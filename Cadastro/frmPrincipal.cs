using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace Cadastro
{
    public partial class frmPrincipal : Form
    {        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();            
            this.Hide();
            consulta.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //"Transparente" escuro 
            pnlCadastro.BackColor = Color.FromArgb(85, 0, 0, 0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarPlanilha();            
        }

        private void CadastrarPlanilha()
        {
            Excel.Application excel = new Excel.Application();

            
            string filePath = ("C:\\Users\\daniel.girotto\\OneDrive - INFORDOC SERVICOS DE INFORMATICA LTDA\\Desktop\\Projetos\\Cadastro6.xlsx");

            Workbook wb;
            Worksheet ws1, ws2, ws3;

            try
            {
                wb = excel.Workbooks.Open(filePath);
                ws1 = wb.Worksheets[1];
                ws2 = wb.Worksheets[2];
                ws3 = wb.Worksheets[3];

                string cliente = txtNomeCliente.Text;
                string telefone = mtxTelefone.Text;
                string data = mtxData.Text;

                string placa = mtxPlaca.Text;
                string carro = txtNomeCarro.Text;
                string ano = mtxAno.Text;
                string montadora = txtMontadora.Text;

                string oleoOriginal = txtOleoOriginal.Text;
                string quantidade = txtQuantidade.Text;
                string filtroOleo = txtFiltroDeOleo.Text;
                string filtroAr = txtFiltroAr.Text;
                string filtroComb = txtFiltroComb.Text;
                string oleoUsado = txtOleoUsado.Text;
                string bujao = txtBujao.Text;
                string palheta = txtPaleta.Text;
                string oleoCambio = txtOleoCambio.Text;
                string fluidoCambio = txtFluidoCambio.Text;

                int lastRow1 = GetLastRow(ws1, "A");
                int lastRow2 = GetLastRow(ws2, "A");
                int lastRow3 = GetLastRow(ws3, "A");

                ws1.Range["A" + lastRow1 + ":A" + lastRow1].Value = cliente;
                ws1.Range["B" + lastRow1 + ":B" + lastRow1].Value = telefone;
                ws1.Range["C" + lastRow1 + ":C" + lastRow1].Value = data;

                ws2.Range["A" + lastRow2 + ":A" + lastRow2].Value = carro;
                ws2.Range["B" + lastRow2 + ":B" + lastRow2].Value = placa;
                ws2.Range["C" + lastRow2 + ":C" + lastRow2].Value = ano;
                ws2.Range["D" + lastRow2 + ":D" + lastRow2].Value = montadora;

                ws3.Range["A" + lastRow3 + ":A" + lastRow3].Value = oleoOriginal;
                ws3.Range["B" + lastRow3 + ":B" + lastRow3].Value = quantidade;
                ws3.Range["C" + lastRow3 + ":C" + lastRow3].Value = filtroOleo;
                ws3.Range["D" + lastRow3 + ":D" + lastRow3].Value = filtroAr;
                ws3.Range["E" + lastRow3 + ":E" + lastRow3].Value = filtroComb;
                ws3.Range["F" + lastRow3 + ":F" + lastRow3].Value = oleoUsado;
                ws3.Range["G" + lastRow3 + ":G" + lastRow3].Value = bujao;
                ws3.Range["H" + lastRow3 + ":H" + lastRow3].Value = palheta;
                ws3.Range["I" + lastRow3 + ":I" + lastRow3].Value = oleoCambio;
                ws3.Range["J" + lastRow3 + ":J" + lastRow3].Value = fluidoCambio;
                
               
                wb.Save();
                wb.Close(false);

                // Libera os recursos COM
                Marshal.ReleaseComObject(ws3);
                Marshal.ReleaseComObject(ws2);
                Marshal.ReleaseComObject(ws1);
                Marshal.ReleaseComObject(wb);
                Marshal.ReleaseComObject(excel);

                MessageBox.Show("Cliente cadastrado.");

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " +ex.Message);
            }               
        }
        private void LimparCampos()
        {
            txtNomeCliente.Text = "";
            mtxTelefone.Text = "";
            mtxData.Text = "";
            mtxPlaca.Text = "";
            txtNomeCarro.Text = "";
            mtxAno.Text = "";
            txtMontadora.Text = "";
            txtOleoOriginal.Text = "";
            txtQuantidade.Text = "";
            txtFiltroDeOleo.Text = "";
            txtFiltroAr.Text = "";
            txtFiltroComb.Text = "";
            txtOleoUsado.Text = "";
            txtBujao.Text = "";
            txtPaleta.Text = "";
            txtOleoCambio.Text = "";
            txtFluidoCambio.Text = "";
        }

        private int GetLastRow(Worksheet worksheet, string column)
        {
            int row = 1;

            // Percorre as células da coluna até encontrar a primeira célula vazia
            while (!string.IsNullOrEmpty(worksheet.Range[column + row].Value?.ToString()))
            {
                row++;
            }

            return row;
        }
    }    
}
