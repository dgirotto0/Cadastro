using System.Drawing;
using System.Windows.Forms;

namespace Cadastro
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.cbxCadastrado = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
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
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.lblUltimaTroca = new System.Windows.Forms.Label();
            this.mtxData = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcbItaoleo = new System.Windows.Forms.PictureBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.lblItaoleo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlCadastro.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItaoleo)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.Color.Gray;
            this.pnlCadastro.Controls.Add(this.cbxCadastrado);
            this.pnlCadastro.Controls.Add(this.btnCadastrar);
            this.pnlCadastro.Controls.Add(this.groupBox3);
            this.pnlCadastro.Controls.Add(this.groupBox2);
            this.pnlCadastro.Controls.Add(this.gbxCliente);
            this.pnlCadastro.Controls.Add(this.lblCadastro);
            this.pnlCadastro.Location = new System.Drawing.Point(279, 124);
            this.pnlCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(651, 571);
            this.pnlCadastro.TabIndex = 1;
            this.pnlCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbxCadastrado
            // 
            this.cbxCadastrado.AutoSize = true;
            this.cbxCadastrado.BackColor = System.Drawing.Color.Transparent;
            this.cbxCadastrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCadastrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCadastrado.ForeColor = System.Drawing.Color.Black;
            this.cbxCadastrado.Location = new System.Drawing.Point(26, 33);
            this.cbxCadastrado.Name = "cbxCadastrado";
            this.cbxCadastrado.Size = new System.Drawing.Size(121, 22);
            this.cbxCadastrado.TabIndex = 25;
            this.cbxCadastrado.Text = "Já cadastrado";
            this.cbxCadastrado.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCadastrar.Location = new System.Drawing.Point(256, 517);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 40);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.groupBox3.Location = new System.Drawing.Point(347, 58);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(283, 147);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carro";
            // 
            // mtxAno
            // 
            this.mtxAno.BackColor = System.Drawing.Color.White;
            this.mtxAno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxAno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxAno.ForeColor = System.Drawing.Color.Black;
            this.mtxAno.Location = new System.Drawing.Point(165, 43);
            this.mtxAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxAno.Mask = "9999";
            this.mtxAno.Name = "mtxAno";
            this.mtxAno.Size = new System.Drawing.Size(102, 27);
            this.mtxAno.TabIndex = 12;
            // 
            // txtMontadora
            // 
            this.txtMontadora.BackColor = System.Drawing.Color.White;
            this.txtMontadora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMontadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontadora.ForeColor = System.Drawing.Color.Black;
            this.txtMontadora.Location = new System.Drawing.Point(165, 99);
            this.txtMontadora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontadora.Name = "txtMontadora";
            this.txtMontadora.Size = new System.Drawing.Size(102, 24);
            this.txtMontadora.TabIndex = 5;
            // 
            // lblMontadora
            // 
            this.lblMontadora.AutoSize = true;
            this.lblMontadora.BackColor = System.Drawing.Color.Transparent;
            this.lblMontadora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblMontadora.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblMontadora.ForeColor = System.Drawing.Color.Black;
            this.lblMontadora.Location = new System.Drawing.Point(161, 72);
            this.lblMontadora.Name = "lblMontadora";
            this.lblMontadora.Size = new System.Drawing.Size(101, 25);
            this.lblMontadora.TabIndex = 11;
            this.lblMontadora.Text = "Montadora";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlaca.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblPlaca.ForeColor = System.Drawing.Color.Black;
            this.lblPlaca.Location = new System.Drawing.Point(3, 16);
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
            this.mtxPlaca.BackColor = System.Drawing.Color.White;
            this.mtxPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxPlaca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxPlaca.ForeColor = System.Drawing.Color.Black;
            this.mtxPlaca.Location = new System.Drawing.Point(6, 43);
            this.mtxPlaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxPlaca.Mask = "AAA-9999";
            this.mtxPlaca.Name = "mtxPlaca";
            this.mtxPlaca.Size = new System.Drawing.Size(139, 27);
            this.mtxPlaca.TabIndex = 2;
            // 
            // txtNomeCarro
            // 
            this.txtNomeCarro.BackColor = System.Drawing.Color.White;
            this.txtNomeCarro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCarro.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCarro.Location = new System.Drawing.Point(6, 99);
            this.txtNomeCarro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCarro.Name = "txtNomeCarro";
            this.txtNomeCarro.Size = new System.Drawing.Size(138, 24);
            this.txtNomeCarro.TabIndex = 4;
            // 
            // lblCarro
            // 
            this.lblCarro.AutoSize = true;
            this.lblCarro.BackColor = System.Drawing.Color.Transparent;
            this.lblCarro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCarro.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblCarro.ForeColor = System.Drawing.Color.Black;
            this.lblCarro.Location = new System.Drawing.Point(3, 72);
            this.lblCarro.Name = "lblCarro";
            this.lblCarro.Size = new System.Drawing.Size(61, 25);
            this.lblCarro.TabIndex = 7;
            this.lblCarro.Text = "Nome";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.Transparent;
            this.lblAno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblAno.ForeColor = System.Drawing.Color.Black;
            this.lblAno.Location = new System.Drawing.Point(162, 16);
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
            this.groupBox2.Location = new System.Drawing.Point(27, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(603, 287);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Troca";
            // 
            // lblFluidoCambio
            // 
            this.lblFluidoCambio.AutoSize = true;
            this.lblFluidoCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblFluidoCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFluidoCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblFluidoCambio.ForeColor = System.Drawing.Color.Black;
            this.lblFluidoCambio.Location = new System.Drawing.Point(322, 227);
            this.lblFluidoCambio.Name = "lblFluidoCambio";
            this.lblFluidoCambio.Size = new System.Drawing.Size(144, 23);
            this.lblFluidoCambio.TabIndex = 31;
            this.lblFluidoCambio.Text = "Fluído de Câmbio";
            // 
            // txtFluidoCambio
            // 
            this.txtFluidoCambio.BackColor = System.Drawing.Color.White;
            this.txtFluidoCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFluidoCambio.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtFluidoCambio.ForeColor = System.Drawing.Color.Black;
            this.txtFluidoCambio.Location = new System.Drawing.Point(325, 253);
            this.txtFluidoCambio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFluidoCambio.Name = "txtFluidoCambio";
            this.txtFluidoCambio.Size = new System.Drawing.Size(260, 25);
            this.txtFluidoCambio.TabIndex = 15;
            // 
            // lblOleoCambio
            // 
            this.lblOleoCambio.AutoSize = true;
            this.lblOleoCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblOleoCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOleoCambio.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblOleoCambio.ForeColor = System.Drawing.Color.Black;
            this.lblOleoCambio.Location = new System.Drawing.Point(321, 173);
            this.lblOleoCambio.Name = "lblOleoCambio";
            this.lblOleoCambio.Size = new System.Drawing.Size(134, 23);
            this.lblOleoCambio.TabIndex = 29;
            this.lblOleoCambio.Text = "Óleo de Câmbio";
            // 
            // txtOleoCambio
            // 
            this.txtOleoCambio.BackColor = System.Drawing.Color.White;
            this.txtOleoCambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOleoCambio.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtOleoCambio.ForeColor = System.Drawing.Color.Black;
            this.txtOleoCambio.Location = new System.Drawing.Point(325, 198);
            this.txtOleoCambio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOleoCambio.Name = "txtOleoCambio";
            this.txtOleoCambio.Size = new System.Drawing.Size(260, 25);
            this.txtOleoCambio.TabIndex = 14;
            // 
            // lblPalheta
            // 
            this.lblPalheta.AutoSize = true;
            this.lblPalheta.BackColor = System.Drawing.Color.Transparent;
            this.lblPalheta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPalheta.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblPalheta.ForeColor = System.Drawing.Color.Black;
            this.lblPalheta.Location = new System.Drawing.Point(324, 120);
            this.lblPalheta.Name = "lblPalheta";
            this.lblPalheta.Size = new System.Drawing.Size(66, 23);
            this.lblPalheta.TabIndex = 28;
            this.lblPalheta.Text = "Palheta";
            // 
            // txtPaleta
            // 
            this.txtPaleta.BackColor = System.Drawing.Color.White;
            this.txtPaleta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaleta.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtPaleta.ForeColor = System.Drawing.Color.Black;
            this.txtPaleta.Location = new System.Drawing.Point(326, 145);
            this.txtPaleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaleta.Name = "txtPaleta";
            this.txtPaleta.Size = new System.Drawing.Size(260, 25);
            this.txtPaleta.TabIndex = 13;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblQuantidade.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidade.Location = new System.Drawing.Point(6, 68);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(100, 23);
            this.lblQuantidade.TabIndex = 25;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.Location = new System.Drawing.Point(6, 93);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(255, 25);
            this.txtQuantidade.TabIndex = 7;
            // 
            // lblOleoOriginal
            // 
            this.lblOleoOriginal.AutoSize = true;
            this.lblOleoOriginal.BackColor = System.Drawing.Color.Transparent;
            this.lblOleoOriginal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOleoOriginal.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblOleoOriginal.ForeColor = System.Drawing.Color.Black;
            this.lblOleoOriginal.Location = new System.Drawing.Point(6, 16);
            this.lblOleoOriginal.Name = "lblOleoOriginal";
            this.lblOleoOriginal.Size = new System.Drawing.Size(111, 23);
            this.lblOleoOriginal.TabIndex = 23;
            this.lblOleoOriginal.Text = "Óleo Original";
            // 
            // txtOleoOriginal
            // 
            this.txtOleoOriginal.BackColor = System.Drawing.Color.White;
            this.txtOleoOriginal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOleoOriginal.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtOleoOriginal.ForeColor = System.Drawing.Color.Black;
            this.txtOleoOriginal.Location = new System.Drawing.Point(6, 41);
            this.txtOleoOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOleoOriginal.Name = "txtOleoOriginal";
            this.txtOleoOriginal.Size = new System.Drawing.Size(255, 25);
            this.txtOleoOriginal.TabIndex = 6;
            // 
            // lblBujao
            // 
            this.lblBujao.AutoSize = true;
            this.lblBujao.BackColor = System.Drawing.Color.Transparent;
            this.lblBujao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBujao.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblBujao.ForeColor = System.Drawing.Color.Black;
            this.lblBujao.Location = new System.Drawing.Point(323, 68);
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
            this.txtBujao.BackColor = System.Drawing.Color.White;
            this.txtBujao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBujao.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtBujao.ForeColor = System.Drawing.Color.Black;
            this.txtBujao.Location = new System.Drawing.Point(326, 93);
            this.txtBujao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBujao.Name = "txtBujao";
            this.txtBujao.Size = new System.Drawing.Size(260, 25);
            this.txtBujao.TabIndex = 12;
            // 
            // lblFiltroCombustivel
            // 
            this.lblFiltroCombustivel.AutoSize = true;
            this.lblFiltroCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroCombustivel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFiltroCombustivel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblFiltroCombustivel.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroCombustivel.Location = new System.Drawing.Point(6, 227);
            this.lblFiltroCombustivel.Name = "lblFiltroCombustivel";
            this.lblFiltroCombustivel.Size = new System.Drawing.Size(171, 23);
            this.lblFiltroCombustivel.TabIndex = 17;
            this.lblFiltroCombustivel.Text = "Filtro de Combustível";
            // 
            // txtFiltroComb
            // 
            this.txtFiltroComb.BackColor = System.Drawing.Color.White;
            this.txtFiltroComb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroComb.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtFiltroComb.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroComb.Location = new System.Drawing.Point(7, 253);
            this.txtFiltroComb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroComb.Name = "txtFiltroComb";
            this.txtFiltroComb.Size = new System.Drawing.Size(254, 25);
            this.txtFiltroComb.TabIndex = 10;
            // 
            // lblFiltroAr
            // 
            this.lblFiltroAr.AutoSize = true;
            this.lblFiltroAr.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroAr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFiltroAr.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblFiltroAr.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroAr.Location = new System.Drawing.Point(6, 173);
            this.lblFiltroAr.Name = "lblFiltroAr";
            this.lblFiltroAr.Size = new System.Drawing.Size(94, 23);
            this.lblFiltroAr.TabIndex = 15;
            this.lblFiltroAr.Text = "Filtro de Ar";
            // 
            // txtFiltroAr
            // 
            this.txtFiltroAr.BackColor = System.Drawing.Color.White;
            this.txtFiltroAr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroAr.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtFiltroAr.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroAr.Location = new System.Drawing.Point(6, 198);
            this.txtFiltroAr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroAr.Name = "txtFiltroAr";
            this.txtFiltroAr.Size = new System.Drawing.Size(255, 25);
            this.txtFiltroAr.TabIndex = 9;
            // 
            // lblFiltroOleo
            // 
            this.lblFiltroOleo.AutoSize = true;
            this.lblFiltroOleo.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroOleo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblFiltroOleo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblFiltroOleo.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroOleo.Location = new System.Drawing.Point(6, 120);
            this.lblFiltroOleo.Name = "lblFiltroOleo";
            this.lblFiltroOleo.Size = new System.Drawing.Size(113, 23);
            this.lblFiltroOleo.TabIndex = 13;
            this.lblFiltroOleo.Text = "Filtro de Óleo";
            // 
            // txtFiltroDeOleo
            // 
            this.txtFiltroDeOleo.BackColor = System.Drawing.Color.White;
            this.txtFiltroDeOleo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroDeOleo.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtFiltroDeOleo.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroDeOleo.Location = new System.Drawing.Point(6, 145);
            this.txtFiltroDeOleo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroDeOleo.Name = "txtFiltroDeOleo";
            this.txtFiltroDeOleo.Size = new System.Drawing.Size(255, 25);
            this.txtFiltroDeOleo.TabIndex = 8;
            // 
            // lblOleo
            // 
            this.lblOleo.AutoSize = true;
            this.lblOleo.BackColor = System.Drawing.Color.Transparent;
            this.lblOleo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOleo.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblOleo.ForeColor = System.Drawing.Color.Black;
            this.lblOleo.Location = new System.Drawing.Point(322, 15);
            this.lblOleo.Name = "lblOleo";
            this.lblOleo.Size = new System.Drawing.Size(97, 23);
            this.lblOleo.TabIndex = 11;
            this.lblOleo.Text = "Óleo usado";
            // 
            // txtOleoUsado
            // 
            this.txtOleoUsado.BackColor = System.Drawing.Color.White;
            this.txtOleoUsado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOleoUsado.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtOleoUsado.ForeColor = System.Drawing.Color.Black;
            this.txtOleoUsado.Location = new System.Drawing.Point(326, 41);
            this.txtOleoUsado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOleoUsado.Name = "txtOleoUsado";
            this.txtOleoUsado.Size = new System.Drawing.Size(260, 25);
            this.txtOleoUsado.TabIndex = 11;
            // 
            // gbxCliente
            // 
            this.gbxCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbxCliente.Controls.Add(this.lblUltimaTroca);
            this.gbxCliente.Controls.Add(this.mtxData);
            this.gbxCliente.Controls.Add(this.lblNome);
            this.gbxCliente.Controls.Add(this.txtNomeCliente);
            this.gbxCliente.Controls.Add(this.mtxTelefone);
            this.gbxCliente.Controls.Add(this.lblTelefone);
            this.gbxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxCliente.ForeColor = System.Drawing.Color.Black;
            this.gbxCliente.Location = new System.Drawing.Point(27, 58);
            this.gbxCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCliente.Size = new System.Drawing.Size(286, 147);
            this.gbxCliente.TabIndex = 7;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // lblUltimaTroca
            // 
            this.lblUltimaTroca.AutoSize = true;
            this.lblUltimaTroca.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimaTroca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblUltimaTroca.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblUltimaTroca.ForeColor = System.Drawing.Color.Black;
            this.lblUltimaTroca.Location = new System.Drawing.Point(142, 71);
            this.lblUltimaTroca.Name = "lblUltimaTroca";
            this.lblUltimaTroca.Size = new System.Drawing.Size(49, 25);
            this.lblUltimaTroca.TabIndex = 8;
            this.lblUltimaTroca.Text = "Data";
            // 
            // mtxData
            // 
            this.mtxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxData.BackColor = System.Drawing.Color.White;
            this.mtxData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxData.ForeColor = System.Drawing.Color.Black;
            this.mtxData.Location = new System.Drawing.Point(147, 98);
            this.mtxData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxData.Mask = "99/99/9999";
            this.mtxData.Name = "mtxData";
            this.mtxData.Size = new System.Drawing.Size(133, 27);
            this.mtxData.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(3, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 25);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BackColor = System.Drawing.Color.White;
            this.txtNomeCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCliente.Location = new System.Drawing.Point(6, 43);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(274, 27);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.BackColor = System.Drawing.Color.White;
            this.mtxTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtxTelefone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxTelefone.ForeColor = System.Drawing.Color.Black;
            this.mtxTelefone.Location = new System.Drawing.Point(6, 98);
            this.mtxTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxTelefone.Mask = "(99) 00000-0000";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(135, 27);
            this.mtxTelefone.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblTelefone.ForeColor = System.Drawing.Color.Black;
            this.lblTelefone.Location = new System.Drawing.Point(2, 71);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(77, 25);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCadastro.ForeColor = System.Drawing.Color.Black;
            this.lblCadastro.Location = new System.Drawing.Point(279, 23);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(92, 28);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblItaoleo);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 42);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pcbItaoleo);
            this.panel3.Controls.Add(this.btnConsulta);
            this.panel3.Controls.Add(this.btnCadastro);
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1209, 78);
            this.panel3.TabIndex = 4;
            // 
            // pcbItaoleo
            // 
            this.pcbItaoleo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcbItaoleo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbItaoleo.Location = new System.Drawing.Point(469, 6);
            this.pcbItaoleo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbItaoleo.Name = "pcbItaoleo";
            this.pcbItaoleo.Size = new System.Drawing.Size(271, 78);
            this.pcbItaoleo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbItaoleo.TabIndex = 2;
            this.pcbItaoleo.TabStop = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConsulta.Location = new System.Drawing.Point(814, 18);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(219, 47);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCadastro.Location = new System.Drawing.Point(171, 18);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(219, 47);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = false;
            // 
            // lblItaoleo
            // 
            this.lblItaoleo.AutoSize = true;
            this.lblItaoleo.BackColor = System.Drawing.Color.Black;
            this.lblItaoleo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblItaoleo.ForeColor = System.Drawing.Color.White;
            this.lblItaoleo.Location = new System.Drawing.Point(568, 3);
            this.lblItaoleo.Name = "lblItaoleo";
            this.lblItaoleo.Size = new System.Drawing.Size(74, 28);
            this.lblItaoleo.TabIndex = 1;
            this.lblItaoleo.Text = "Itaoleo";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFechar.Location = new System.Drawing.Point(1162, -5);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(54, 43);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(3, 35);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1209, 78);
            this.panel4.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.Location = new System.Drawing.Point(493, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Consulta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1209, 716);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbItaoleo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlCadastro;
        private Label lblCadastro;
        private Label lblNome;
        private Label lblTelefone;
        private MaskedTextBox mtxTelefone;
        private Label lblPlaca;
        private MaskedTextBox mtxPlaca;
        private GroupBox gbxCliente;
        private TextBox txtNomeCliente;
        private GroupBox groupBox2;
        private Label lblCarro;
        private TextBox txtNomeCarro;
        private Label lblAno;
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
        private GroupBox groupBox3;
        private Label lblBujao;
        private TextBox textBox4;
        private MaskedTextBox maskedTextBox2;
        private Panel panel1;
        private Label lblItaoleo;
        private Button btnFechar;
        private Panel panel3;
        private PictureBox pcbItaoleo;
        private Button btnConsulta;
        private Button btnCadastro;
        private Panel panel4;
        private Button button2;
        private Label lblOleoOriginal;
        private TextBox txtOleoOriginal;
        private Label lblQuantidade;
        private TextBox txtQuantidade;
        private Label lblFluidoCambio;
        private TextBox txtFluidoCambio;
        private Label lblOleoCambio;
        private TextBox txtOleoCambio;
        private Label lblPalheta;
        private TextBox txtPaleta;
        private TextBox txtMontadora;
        private Label lblMontadora;
        private MaskedTextBox mtxData;
        private Label lblUltimaTroca;
        private Button btnCadastrar;
        private CheckBox cbxCadastrado;
        private MaskedTextBox mtxAno;
    }
}

