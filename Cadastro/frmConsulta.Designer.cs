using System.Drawing;
using System.Windows.Forms;
using System;

namespace Cadastro
{
    partial class frmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.lblItaoleo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDadosTroca = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtxAno = new System.Windows.Forms.MaskedTextBox();
            this.txtMontadora = new System.Windows.Forms.TextBox();
            this.lblMontadora = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCarro = new System.Windows.Forms.TextBox();
            this.lblCarro = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFluidoCambio = new System.Windows.Forms.Label();
            this.txtFluidoCambio = new System.Windows.Forms.TextBox();
            this.lblOleoCambio = new System.Windows.Forms.Label();
            this.txtOleoCambio = new System.Windows.Forms.TextBox();
            this.lblPalheta = new System.Windows.Forms.Label();
            this.txtPaleta = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblOleoOriginal = new System.Windows.Forms.Label();
            this.txtOleoOriginal = new System.Windows.Forms.TextBox();
            this.lblBujao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBujao = new System.Windows.Forms.TextBox();
            this.lblFiltroCombustivel = new System.Windows.Forms.Label();
            this.txtFiltroComb = new System.Windows.Forms.TextBox();
            this.lblFiltroAr = new System.Windows.Forms.Label();
            this.txtFiltroAr = new System.Windows.Forms.TextBox();
            this.lblFiltroOleo = new System.Windows.Forms.Label();
            this.txtFiltroDeOleo = new System.Windows.Forms.TextBox();
            this.lblOleo = new System.Windows.Forms.Label();
            this.txtOleoUsado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.mtxData = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.mtxBuscarPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblBuscaPlaca = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlCabecalho.SuspendLayout();
            this.pnlDadosTroca.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCabecalho.Controls.Add(this.btnVoltar2);
            this.pnlCabecalho.Controls.Add(this.lblItaoleo);
            this.pnlCabecalho.Controls.Add(this.button1);
            this.pnlCabecalho.Location = new System.Drawing.Point(-1, 0);
            this.pnlCabecalho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(1211, 40);
            this.pnlCabecalho.TabIndex = 4;
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.BackColor = System.Drawing.Color.Black;
            this.btnVoltar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar2.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar2.Image")));
            this.btnVoltar2.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(42, 41);
            this.btnVoltar2.TabIndex = 2;
            this.btnVoltar2.UseVisualStyleBackColor = false;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // lblItaoleo
            // 
            this.lblItaoleo.AutoSize = true;
            this.lblItaoleo.BackColor = System.Drawing.Color.Black;
            this.lblItaoleo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblItaoleo.ForeColor = System.Drawing.Color.White;
            this.lblItaoleo.Location = new System.Drawing.Point(568, 4);
            this.lblItaoleo.Name = "lblItaoleo";
            this.lblItaoleo.Size = new System.Drawing.Size(74, 28);
            this.lblItaoleo.TabIndex = 1;
            this.lblItaoleo.Text = "Itaoleo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1162, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 43);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlDadosTroca
            // 
            this.pnlDadosTroca.BackColor = System.Drawing.Color.Gray;
            this.pnlDadosTroca.Controls.Add(this.groupBox3);
            this.pnlDadosTroca.Controls.Add(this.groupBox2);
            this.pnlDadosTroca.Controls.Add(this.groupBox1);
            this.pnlDadosTroca.Controls.Add(this.lblCadastro);
            this.pnlDadosTroca.Location = new System.Drawing.Point(484, 62);
            this.pnlDadosTroca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDadosTroca.Name = "pnlDadosTroca";
            this.pnlDadosTroca.Size = new System.Drawing.Size(651, 604);
            this.pnlDadosTroca.TabIndex = 5;
            this.pnlDadosTroca.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDadosTroca_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.mtxAno);
            this.groupBox3.Controls.Add(this.txtMontadora);
            this.groupBox3.Controls.Add(this.lblMontadora);
            this.groupBox3.Controls.Add(this.lblPlaca);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.maskedTextBox2);
            this.groupBox3.Controls.Add(this.mtxPlaca);
            this.groupBox3.Controls.Add(this.txtNomeCarro);
            this.groupBox3.Controls.Add(this.lblCarro);
            this.groupBox3.Controls.Add(this.lblAno);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(325, 58);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(305, 164);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carro";
            // 
            // mtxAno
            // 
            this.mtxAno.BackColor = System.Drawing.Color.White;
            this.mtxAno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxAno.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxAno.ForeColor = System.Drawing.Color.Black;
            this.mtxAno.Location = new System.Drawing.Point(187, 45);
            this.mtxAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxAno.Mask = "9999";
            this.mtxAno.Name = "mtxAno";
            this.mtxAno.Size = new System.Drawing.Size(102, 30);
            this.mtxAno.TabIndex = 13;
            // 
            // txtMontadora
            // 
            this.txtMontadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontadora.BackColor = System.Drawing.Color.White;
            this.txtMontadora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontadora.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtMontadora.ForeColor = System.Drawing.Color.Black;
            this.txtMontadora.Location = new System.Drawing.Point(187, 114);
            this.txtMontadora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontadora.Name = "txtMontadora";
            this.txtMontadora.Size = new System.Drawing.Size(102, 30);
            this.txtMontadora.TabIndex = 5;
            // 
            // lblMontadora
            // 
            this.lblMontadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontadora.AutoSize = true;
            this.lblMontadora.BackColor = System.Drawing.Color.Transparent;
            this.lblMontadora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblMontadora.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblMontadora.ForeColor = System.Drawing.Color.Black;
            this.lblMontadora.Location = new System.Drawing.Point(184, 87);
            this.lblMontadora.Name = "lblMontadora";
            this.lblMontadora.Size = new System.Drawing.Size(101, 25);
            this.lblMontadora.TabIndex = 11;
            this.lblMontadora.Text = "Montadora";
            // 
            // lblPlaca
            // 
            this.lblPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblPlaca.ForeColor = System.Drawing.Color.Black;
            this.lblPlaca.Location = new System.Drawing.Point(3, 18);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(52, 25);
            this.lblPlaca.TabIndex = 2;
            this.lblPlaca.Text = "Placa";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Orange;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(-314, -18);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(255, 22);
            this.textBox4.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.Orange;
            this.maskedTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskedTextBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.maskedTextBox2.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox2.Location = new System.Drawing.Point(-314, 36);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox2.Mask = " (__) _____-____";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(125, 30);
            this.maskedTextBox2.TabIndex = 1;
            // 
            // mtxPlaca
            // 
            this.mtxPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mtxPlaca.BackColor = System.Drawing.Color.White;
            this.mtxPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxPlaca.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.mtxPlaca.ForeColor = System.Drawing.Color.Black;
            this.mtxPlaca.Location = new System.Drawing.Point(6, 43);
            this.mtxPlaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxPlaca.Mask = "AAA-9999";
            this.mtxPlaca.Name = "mtxPlaca";
            this.mtxPlaca.Size = new System.Drawing.Size(139, 30);
            this.mtxPlaca.TabIndex = 2;
            // 
            // txtNomeCarro
            // 
            this.txtNomeCarro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNomeCarro.BackColor = System.Drawing.Color.White;
            this.txtNomeCarro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCarro.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtNomeCarro.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCarro.Location = new System.Drawing.Point(6, 114);
            this.txtNomeCarro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCarro.Name = "txtNomeCarro";
            this.txtNomeCarro.Size = new System.Drawing.Size(138, 30);
            this.txtNomeCarro.TabIndex = 4;
            // 
            // lblCarro
            // 
            this.lblCarro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCarro.AutoSize = true;
            this.lblCarro.BackColor = System.Drawing.Color.Transparent;
            this.lblCarro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCarro.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblCarro.ForeColor = System.Drawing.Color.Black;
            this.lblCarro.Location = new System.Drawing.Point(3, 87);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(61, 25);
            this.lblCarro.TabIndex = 7;
            this.lblCarro.Text = "Nome";
            // 
            // lblAno
            // 
            this.lblAno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.Transparent;
            this.lblAno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblAno.ForeColor = System.Drawing.Color.Black;
            this.lblAno.Location = new System.Drawing.Point(185, 18);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(45, 25);
            this.lblAno.TabIndex = 9;
            this.lblAno.Text = "Ano";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblFluidoCambio);
            this.groupBox2.Controls.Add(this.txtFluidoCambio);
            this.groupBox2.Controls.Add(this.lblOleoCambio);
            this.groupBox2.Controls.Add(this.txtOleoCambio);
            this.groupBox2.Controls.Add(this.lblPalheta);
            this.groupBox2.Controls.Add(this.txtPaleta);
            this.groupBox2.Controls.Add(this.lblQuantidade);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.lblOleoOriginal);
            this.groupBox2.Controls.Add(this.txtOleoOriginal);
            this.groupBox2.Controls.Add(this.lblBujao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBujao);
            this.groupBox2.Controls.Add(this.lblFiltroCombustivel);
            this.groupBox2.Controls.Add(this.txtFiltroComb);
            this.groupBox2.Controls.Add(this.lblFiltroAr);
            this.groupBox2.Controls.Add(this.txtFiltroAr);
            this.groupBox2.Controls.Add(this.lblFiltroOleo);
            this.groupBox2.Controls.Add(this.txtFiltroDeOleo);
            this.groupBox2.Controls.Add(this.lblOleo);
            this.groupBox2.Controls.Add(this.txtOleoUsado);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(27, 226);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(603, 344);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Troca";
            // 
            // lblFluidoCambio
            // 
            this.lblFluidoCambio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFluidoCambio.AutoSize = true;
            this.lblFluidoCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblFluidoCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFluidoCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblFluidoCambio.ForeColor = System.Drawing.Color.Black;
            this.lblFluidoCambio.Location = new System.Drawing.Point(300, 254);
            this.lblFluidoCambio.Name = "lblFluidoCambio";
            this.lblFluidoCambio.Size = new System.Drawing.Size(144, 23);
            this.lblFluidoCambio.TabIndex = 31;
            this.lblFluidoCambio.Text = "Fluído de Câmbio";
            // 
            // txtFluidoCambio
            // 
            this.txtFluidoCambio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFluidoCambio.BackColor = System.Drawing.Color.White;
            this.txtFluidoCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFluidoCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFluidoCambio.ForeColor = System.Drawing.Color.Black;
            this.txtFluidoCambio.Location = new System.Drawing.Point(303, 279);
            this.txtFluidoCambio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFluidoCambio.Name = "txtFluidoCambio";
            this.txtFluidoCambio.Size = new System.Drawing.Size(278, 30);
            this.txtFluidoCambio.TabIndex = 15;
            // 
            // lblOleoCambio
            // 
            this.lblOleoCambio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOleoCambio.AutoSize = true;
            this.lblOleoCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblOleoCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOleoCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblOleoCambio.ForeColor = System.Drawing.Color.Black;
            this.lblOleoCambio.Location = new System.Drawing.Point(301, 195);
            this.lblOleoCambio.Name = "lblOleoCambio";
            this.lblOleoCambio.Size = new System.Drawing.Size(134, 23);
            this.lblOleoCambio.TabIndex = 29;
            this.lblOleoCambio.Text = "Óleo de Câmbio";
            // 
            // txtOleoCambio
            // 
            this.txtOleoCambio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOleoCambio.BackColor = System.Drawing.Color.White;
            this.txtOleoCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOleoCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOleoCambio.ForeColor = System.Drawing.Color.Black;
            this.txtOleoCambio.Location = new System.Drawing.Point(304, 220);
            this.txtOleoCambio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOleoCambio.Name = "txtOleoCambio";
            this.txtOleoCambio.Size = new System.Drawing.Size(278, 30);
            this.txtOleoCambio.TabIndex = 14;
            // 
            // lblPalheta
            // 
            this.lblPalheta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalheta.AutoSize = true;
            this.lblPalheta.BackColor = System.Drawing.Color.Transparent;
            this.lblPalheta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPalheta.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblPalheta.ForeColor = System.Drawing.Color.Black;
            this.lblPalheta.Location = new System.Drawing.Point(302, 133);
            this.lblPalheta.Name = "lblPalheta";
            this.lblPalheta.Size = new System.Drawing.Size(66, 23);
            this.lblPalheta.TabIndex = 28;
            this.lblPalheta.Text = "Palheta";
            // 
            // txtPaleta
            // 
            this.txtPaleta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaleta.BackColor = System.Drawing.Color.White;
            this.txtPaleta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaleta.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaleta.ForeColor = System.Drawing.Color.Black;
            this.txtPaleta.Location = new System.Drawing.Point(305, 162);
            this.txtPaleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaleta.Name = "txtPaleta";
            this.txtPaleta.Size = new System.Drawing.Size(278, 30);
            this.txtPaleta.TabIndex = 13;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblQuantidade.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidade.Location = new System.Drawing.Point(8, 79);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(100, 23);
            this.lblQuantidade.TabIndex = 25;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.Location = new System.Drawing.Point(12, 104);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(253, 30);
            this.txtQuantidade.TabIndex = 7;
            // 
            // lblOleoOriginal
            // 
            this.lblOleoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOleoOriginal.AutoSize = true;
            this.lblOleoOriginal.BackColor = System.Drawing.Color.Transparent;
            this.lblOleoOriginal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOleoOriginal.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblOleoOriginal.ForeColor = System.Drawing.Color.Black;
            this.lblOleoOriginal.Location = new System.Drawing.Point(8, 22);
            this.lblOleoOriginal.Name = "lblOleoOriginal";
            this.lblOleoOriginal.Size = new System.Drawing.Size(111, 23);
            this.lblOleoOriginal.TabIndex = 23;
            this.lblOleoOriginal.Text = "Óleo Original";
            // 
            // txtOleoOriginal
            // 
            this.txtOleoOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOleoOriginal.BackColor = System.Drawing.Color.White;
            this.txtOleoOriginal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOleoOriginal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOleoOriginal.ForeColor = System.Drawing.Color.Black;
            this.txtOleoOriginal.Location = new System.Drawing.Point(11, 47);
            this.txtOleoOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOleoOriginal.Name = "txtOleoOriginal";
            this.txtOleoOriginal.Size = new System.Drawing.Size(253, 30);
            this.txtOleoOriginal.TabIndex = 6;
            // 
            // lblBujao
            // 
            this.lblBujao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBujao.AutoSize = true;
            this.lblBujao.BackColor = System.Drawing.Color.Transparent;
            this.lblBujao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBujao.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblBujao.ForeColor = System.Drawing.Color.Black;
            this.lblBujao.Location = new System.Drawing.Point(302, 78);
            this.lblBujao.Name = "lblBujao";
            this.lblBujao.Size = new System.Drawing.Size(53, 23);
            this.lblBujao.TabIndex = 21;
            this.lblBujao.Text = "Bujão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-19, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 19;
            // 
            // txtBujao
            // 
            this.txtBujao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBujao.BackColor = System.Drawing.Color.White;
            this.txtBujao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBujao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBujao.ForeColor = System.Drawing.Color.Black;
            this.txtBujao.Location = new System.Drawing.Point(305, 104);
            this.txtBujao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBujao.Name = "txtBujao";
            this.txtBujao.Size = new System.Drawing.Size(278, 30);
            this.txtBujao.TabIndex = 12;
            // 
            // lblFiltroCombustivel
            // 
            this.lblFiltroCombustivel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFiltroCombustivel.AutoSize = true;
            this.lblFiltroCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroCombustivel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFiltroCombustivel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblFiltroCombustivel.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroCombustivel.Location = new System.Drawing.Point(10, 254);
            this.lblFiltroCombustivel.Name = "lblFiltroCombustivel";
            this.lblFiltroCombustivel.Size = new System.Drawing.Size(171, 23);
            this.lblFiltroCombustivel.TabIndex = 17;
            this.lblFiltroCombustivel.Text = "Filtro de Combustível";
            // 
            // txtFiltroComb
            // 
            this.txtFiltroComb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltroComb.BackColor = System.Drawing.Color.White;
            this.txtFiltroComb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroComb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroComb.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroComb.Location = new System.Drawing.Point(12, 279);
            this.txtFiltroComb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroComb.Name = "txtFiltroComb";
            this.txtFiltroComb.Size = new System.Drawing.Size(255, 30);
            this.txtFiltroComb.TabIndex = 10;
            // 
            // lblFiltroAr
            // 
            this.lblFiltroAr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFiltroAr.AutoSize = true;
            this.lblFiltroAr.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroAr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFiltroAr.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblFiltroAr.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroAr.Location = new System.Drawing.Point(10, 195);
            this.lblFiltroAr.Name = "lblFiltroAr";
            this.lblFiltroAr.Size = new System.Drawing.Size(94, 23);
            this.lblFiltroAr.TabIndex = 15;
            this.lblFiltroAr.Text = "Filtro de Ar";
            // 
            // txtFiltroAr
            // 
            this.txtFiltroAr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltroAr.BackColor = System.Drawing.Color.White;
            this.txtFiltroAr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroAr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAr.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroAr.Location = new System.Drawing.Point(14, 222);
            this.txtFiltroAr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroAr.Name = "txtFiltroAr";
            this.txtFiltroAr.Size = new System.Drawing.Size(253, 30);
            this.txtFiltroAr.TabIndex = 9;
            // 
            // lblFiltroOleo
            // 
            this.lblFiltroOleo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFiltroOleo.AutoSize = true;
            this.lblFiltroOleo.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroOleo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFiltroOleo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblFiltroOleo.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroOleo.Location = new System.Drawing.Point(7, 137);
            this.lblFiltroOleo.Name = "lblFiltroOleo";
            this.lblFiltroOleo.Size = new System.Drawing.Size(113, 23);
            this.lblFiltroOleo.TabIndex = 13;
            this.lblFiltroOleo.Text = "Filtro de Óleo";
            // 
            // txtFiltroDeOleo
            // 
            this.txtFiltroDeOleo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltroDeOleo.BackColor = System.Drawing.Color.White;
            this.txtFiltroDeOleo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroDeOleo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroDeOleo.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroDeOleo.Location = new System.Drawing.Point(12, 162);
            this.txtFiltroDeOleo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroDeOleo.Name = "txtFiltroDeOleo";
            this.txtFiltroDeOleo.Size = new System.Drawing.Size(253, 30);
            this.txtFiltroDeOleo.TabIndex = 8;
            // 
            // lblOleo
            // 
            this.lblOleo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOleo.AutoSize = true;
            this.lblOleo.BackColor = System.Drawing.Color.Transparent;
            this.lblOleo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOleo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblOleo.ForeColor = System.Drawing.Color.Black;
            this.lblOleo.Location = new System.Drawing.Point(302, 21);
            this.lblOleo.Name = "lblOleo";
            this.lblOleo.Size = new System.Drawing.Size(97, 23);
            this.lblOleo.TabIndex = 11;
            this.lblOleo.Text = "Óleo usado";
            // 
            // txtOleoUsado
            // 
            this.txtOleoUsado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOleoUsado.BackColor = System.Drawing.Color.White;
            this.txtOleoUsado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOleoUsado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOleoUsado.ForeColor = System.Drawing.Color.Black;
            this.txtOleoUsado.Location = new System.Drawing.Point(305, 46);
            this.txtOleoUsado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOleoUsado.Name = "txtOleoUsado";
            this.txtOleoUsado.Size = new System.Drawing.Size(278, 30);
            this.txtOleoUsado.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.mtxData);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.mtxTelefone);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(27, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(292, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(165, 89);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(106, 23);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Última Troca";
            // 
            // mtxData
            // 
            this.mtxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxData.BackColor = System.Drawing.Color.White;
            this.mtxData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxData.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.mtxData.ForeColor = System.Drawing.Color.Black;
            this.mtxData.Location = new System.Drawing.Point(169, 114);
            this.mtxData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxData.Mask = "99/99/9999";
            this.mtxData.Name = "mtxData";
            this.mtxData.Size = new System.Drawing.Size(117, 30);
            this.mtxData.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(6, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 25);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeCliente.BackColor = System.Drawing.Color.White;
            this.txtNomeCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCliente.Location = new System.Drawing.Point(9, 43);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(277, 30);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mtxTelefone.BackColor = System.Drawing.Color.White;
            this.mtxTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxTelefone.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.mtxTelefone.ForeColor = System.Drawing.Color.Black;
            this.mtxTelefone.Location = new System.Drawing.Point(11, 114);
            this.mtxTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxTelefone.Mask = "(99) 00000-0000";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(152, 30);
            this.mtxTelefone.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblTelefone.ForeColor = System.Drawing.Color.Black;
            this.lblTelefone.Location = new System.Drawing.Point(6, 87);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(77, 25);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCadastro
            // 
            this.lblCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCadastro.ForeColor = System.Drawing.Color.Black;
            this.lblCadastro.Location = new System.Drawing.Point(297, 19);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(68, 28);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Dados";
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.Color.Gray;
            this.pnlBuscar.Controls.Add(this.mtxBuscarPlaca);
            this.pnlBuscar.Controls.Add(this.lblBuscaPlaca);
            this.pnlBuscar.Controls.Add(this.btnBuscar);
            this.pnlBuscar.Location = new System.Drawing.Point(34, 310);
            this.pnlBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(366, 128);
            this.pnlBuscar.TabIndex = 6;
            this.pnlBuscar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBuscar_Paint);
            // 
            // mtxBuscarPlaca
            // 
            this.mtxBuscarPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mtxBuscarPlaca.BackColor = System.Drawing.Color.White;
            this.mtxBuscarPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxBuscarPlaca.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxBuscarPlaca.ForeColor = System.Drawing.Color.Black;
            this.mtxBuscarPlaca.Location = new System.Drawing.Point(28, 72);
            this.mtxBuscarPlaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxBuscarPlaca.Mask = "AAA-9999";
            this.mtxBuscarPlaca.Name = "mtxBuscarPlaca";
            this.mtxBuscarPlaca.Size = new System.Drawing.Size(180, 31);
            this.mtxBuscarPlaca.TabIndex = 25;
            // 
            // lblBuscaPlaca
            // 
            this.lblBuscaPlaca.AutoSize = true;
            this.lblBuscaPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscaPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBuscaPlaca.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaPlaca.ForeColor = System.Drawing.Color.Black;
            this.lblBuscaPlaca.Location = new System.Drawing.Point(105, 17);
            this.lblBuscaPlaca.Name = "lblBuscaPlaca";
            this.lblBuscaPlaca.Size = new System.Drawing.Size(169, 28);
            this.lblBuscaPlaca.TabIndex = 24;
            this.lblBuscaPlaca.Text = "Buscar pela Placa";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnBuscar.Location = new System.Drawing.Point(243, 70);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 36);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1209, 716);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.pnlDadosTroca);
            this.Controls.Add(this.pnlCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.pnlDadosTroca.ResumeLayout(false);
            this.pnlDadosTroca.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblItaoleo;
        private Button button1;
        private Panel pnlDadosTroca;
        private GroupBox groupBox3;
        private TextBox txtMontadora;
        private Label lblMontadora;
        private Label lblPlaca;
        private TextBox textBox4;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox mtxPlaca;
        private TextBox txtNomeCarro;
        private Label lblCarro;
        private Label lblAno;
        private GroupBox groupBox2;
        private Label lblFluidoCambio;
        private TextBox txtFluidoCambio;
        private Label lblOleoCambio;
        private TextBox txtOleoCambio;
        private Label lblPalheta;
        private TextBox txtPaleta;
        private Label lblQuantidade;
        private TextBox txtQuantidade;
        private Label lblOleoOriginal;
        private TextBox txtOleoOriginal;
        private Label lblBujao;
        private Label label2;
        private TextBox txtBujao;
        private Label lblFiltroCombustivel;
        private TextBox txtFiltroComb;
        private Label lblFiltroAr;
        private TextBox txtFiltroAr;
        private Label lblFiltroOleo;
        private TextBox txtFiltroDeOleo;
        private Label lblOleo;
        private TextBox txtOleoUsado;
        private GroupBox groupBox1;
        private TextBox txtNomeCliente;
        private MaskedTextBox mtxTelefone;
        private Label lblTelefone;
        private Label lblCadastro;
        private Label lblData;
        private MaskedTextBox mtxData;
        private Panel pnlBuscar;
        private Label lblNome;
        private Button btnBuscar;
        private Label lblBuscaPlaca;
        private Button btnVoltar2;
        private MaskedTextBox mtxBuscarPlaca;
        private MaskedTextBox mtxAno;
    }
}