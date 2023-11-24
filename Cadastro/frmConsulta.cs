using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cadastro
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();      
            
            pnlDadosTroca.Enabled = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBuscar_Paint(object sender, PaintEventArgs e)
        {
            pnlBuscar.BackColor = Color.FromArgb(85, 0, 0, 0);
        }

        private void pnlDadosTroca_Paint(object sender, PaintEventArgs e)
        {
            pnlDadosTroca.BackColor = Color.FromArgb(85, 0, 0, 0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDados();            
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();            
            this.Hide();
            principal.Show();
        }

        private void BuscarDados()
        {
            Excel.Application excel = new Excel.Application();


            string filePath = ("C:\\Users\\daniel.girotto\\OneDrive - INFORDOC SERVICOS DE INFORMATICA LTDA\\Desktop\\Projetos\\Cadastro6.xlsx");

            Workbook wb;
            Worksheet ws1, ws2, ws3;

            wb = excel.Workbooks.Open(filePath);
            ws1 = wb.Worksheets[1];
            ws2 = wb.Worksheets[2];
            ws3 = wb.Worksheets[3];

            string placa = mtxBuscarPlaca.Text;
            try
            {
                for (int i = 1; i <= ws2.Rows.Count; i++)
                {
                    string valorPlaca = ws2.Cells[i, 2].Value.ToString();

                    if (valorPlaca == placa)
                    {
                        pnlDadosTroca.Enabled = true;

                        txtNomeCliente.Text = ws1.Cells[i, 1].Value;
                        mtxTelefone.Text = ws1.Cells[i, 2].Value.ToString();
                        mtxData.Text = ws1.Cells[i, 3].Value.ToString();

                        txtNomeCarro.Text = ws2.Cells[i, 1].Value;
                        mtxPlaca.Text = ws2.Cells[i, 2].Value.ToString();
                        mtxAno.Text = ws2.Cells[i, 3].Value.ToString();
                        txtMontadora.Text = ws2.Cells[i, 4].Value;

                        txtOleoOriginal.Text = ws3.Cells[i, 1].Value;
                        txtQuantidade.Text = ws3.Cells[i, 2].Value.ToString();
                        txtFiltroDeOleo.Text = ws3.Cells[i, 3].Value; 
                        txtFiltroComb.Text = ws3.Cells[i, 4].Value;
                        txtOleoUsado.Text = ws3.Cells[i, 5].Value;
                        txtBujao.Text = ws3.Cells[i, 6].Value;
                        txtPaleta.Text = ws3.Cells[i, 7].Value;
                        txtOleoCambio.Text = ws3.Cells[i, 8].Value;
                        txtFluidoCambio.Text = ws3.Cells[i, 9].Value;                        

                        break;
                    }
                }
            }  
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
