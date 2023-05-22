namespace restaurante
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cbopagamento = new System.Windows.Forms.ComboBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbosobremesa = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQtdSobremesa = new System.Windows.Forms.TextBox();
            this.txtTotalSobremesa = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbobebida = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQtdBebida = new System.Windows.Forms.TextBox();
            this.txtTotalBebida = new System.Windows.Forms.TextBox();
            this.gbxAlmoco = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalAlmoco = new System.Windows.Forms.TextBox();
            this.txtQtdAlmoco = new System.Windows.Forms.TextBox();
            this.cboalmoco = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnome_clie = new System.Windows.Forms.TextBox();
            this.txtcod_clie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnapagar_prod = new System.Windows.Forms.Button();
            this.btnnovo_prod = new System.Windows.Forms.Button();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.dgvprodutos = new System.Windows.Forms.DataGridView();
            this.txtpreco_prod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome_prod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcod_prod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxAlmoco.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodutos)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 509);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "VENDAS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gbxAlmoco);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 495);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PEDIDO";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox6.Controls.Add(this.lblTotal);
            this.groupBox6.Controls.Add(this.cbopagamento);
            this.groupBox6.Controls.Add(this.btncalcular);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 318);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(374, 171);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PAGAMENTO";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(195, 69);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 31);
            this.lblTotal.TabIndex = 3;
            // 
            // cbopagamento
            // 
            this.cbopagamento.FormattingEnabled = true;
            this.cbopagamento.Items.AddRange(new object[] {
            "CREDITO",
            "DEBITO",
            "PIX",
            "VALE REFEIÇÃO",
            "VALE ALIMENTAÇÃO",
            "---------------------",
            "MENSALISTA"});
            this.cbopagamento.Location = new System.Drawing.Point(11, 19);
            this.cbopagamento.Name = "cbopagamento";
            this.cbopagamento.Size = new System.Drawing.Size(351, 28);
            this.cbopagamento.TabIndex = 16;
            this.cbopagamento.Text = ">> SELECIONE <<";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(92, 126);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(164, 39);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "TOTAL:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::restaurante.Properties.Resources.logo_restaurante;
            this.pictureBox1.Location = new System.Drawing.Point(386, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox5.Location = new System.Drawing.Point(386, 321);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 168);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.cbosobremesa);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtQtdSobremesa);
            this.groupBox4.Controls.Add(this.txtTotalSobremesa);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 93);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SOBREMESA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(197, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "TOTAL";
            // 
            // cbosobremesa
            // 
            this.cbosobremesa.FormattingEnabled = true;
            this.cbosobremesa.Items.AddRange(new object[] {
            "BOLO DE ABACAXI",
            "BOLO DE AMENDOIN",
            "BOLO DE CENOURA",
            "CUSCUZ"});
            this.cbosobremesa.Location = new System.Drawing.Point(11, 19);
            this.cbosobremesa.Name = "cbosobremesa";
            this.cbosobremesa.Size = new System.Drawing.Size(351, 28);
            this.cbosobremesa.TabIndex = 16;
            this.cbosobremesa.Text = ">> SELECIONE <<";
            this.cbosobremesa.SelectedIndexChanged += new System.EventHandler(this.cbosobremesa_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "QUANTIDADE";
            // 
            // txtQtdSobremesa
            // 
            this.txtQtdSobremesa.Location = new System.Drawing.Point(134, 53);
            this.txtQtdSobremesa.Name = "txtQtdSobremesa";
            this.txtQtdSobremesa.Size = new System.Drawing.Size(42, 26);
            this.txtQtdSobremesa.TabIndex = 17;
            // 
            // txtTotalSobremesa
            // 
            this.txtTotalSobremesa.Location = new System.Drawing.Point(262, 53);
            this.txtTotalSobremesa.Name = "txtTotalSobremesa";
            this.txtTotalSobremesa.Size = new System.Drawing.Size(100, 26);
            this.txtTotalSobremesa.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cbobebida);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtQtdBebida);
            this.groupBox3.Controls.Add(this.txtTotalBebida);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BEBIDA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "TOTAL";
            // 
            // cbobebida
            // 
            this.cbobebida.FormattingEnabled = true;
            this.cbobebida.Items.AddRange(new object[] {
            "COCA COLA 350ML",
            "COCA COLA 600ML",
            "COCA COLA 2L",
            "GUARANÁ ANTARTICA 350ML",
            "GUARANÁ ANTARTICA 600ML",
            "GUARANÁ ANTARTICA 2L",
            "FANTA 350ML",
            "FANTA 600ML",
            "FANTA 2L",
            "DOLLY 2L"});
            this.cbobebida.Location = new System.Drawing.Point(11, 19);
            this.cbobebida.Name = "cbobebida";
            this.cbobebida.Size = new System.Drawing.Size(351, 28);
            this.cbobebida.TabIndex = 11;
            this.cbobebida.Text = ">> SELECIONE <<";
            this.cbobebida.SelectedIndexChanged += new System.EventHandler(this.cbobebida_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "QUANTIDADE";
            // 
            // txtQtdBebida
            // 
            this.txtQtdBebida.Location = new System.Drawing.Point(134, 53);
            this.txtQtdBebida.Name = "txtQtdBebida";
            this.txtQtdBebida.Size = new System.Drawing.Size(42, 26);
            this.txtQtdBebida.TabIndex = 12;
            // 
            // txtTotalBebida
            // 
            this.txtTotalBebida.Location = new System.Drawing.Point(262, 53);
            this.txtTotalBebida.Name = "txtTotalBebida";
            this.txtTotalBebida.Size = new System.Drawing.Size(100, 26);
            this.txtTotalBebida.TabIndex = 13;
            // 
            // gbxAlmoco
            // 
            this.gbxAlmoco.BackColor = System.Drawing.Color.NavajoWhite;
            this.gbxAlmoco.Controls.Add(this.label11);
            this.gbxAlmoco.Controls.Add(this.label10);
            this.gbxAlmoco.Controls.Add(this.txtTotalAlmoco);
            this.gbxAlmoco.Controls.Add(this.txtQtdAlmoco);
            this.gbxAlmoco.Controls.Add(this.cboalmoco);
            this.gbxAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAlmoco.Location = new System.Drawing.Point(6, 21);
            this.gbxAlmoco.Name = "gbxAlmoco";
            this.gbxAlmoco.Size = new System.Drawing.Size(374, 93);
            this.gbxAlmoco.TabIndex = 0;
            this.gbxAlmoco.TabStop = false;
            this.gbxAlmoco.Text = "ALMOÇO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "TOTAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "QUANTIDADE";
            // 
            // txtTotalAlmoco
            // 
            this.txtTotalAlmoco.Location = new System.Drawing.Point(262, 53);
            this.txtTotalAlmoco.Name = "txtTotalAlmoco";
            this.txtTotalAlmoco.Size = new System.Drawing.Size(100, 26);
            this.txtTotalAlmoco.TabIndex = 8;
            // 
            // txtQtdAlmoco
            // 
            this.txtQtdAlmoco.Location = new System.Drawing.Point(134, 53);
            this.txtQtdAlmoco.Name = "txtQtdAlmoco";
            this.txtQtdAlmoco.Size = new System.Drawing.Size(42, 26);
            this.txtQtdAlmoco.TabIndex = 7;
            // 
            // cboalmoco
            // 
            this.cboalmoco.FormattingEnabled = true;
            this.cboalmoco.Items.AddRange(new object[] {
            "FILÉ DE FRANGO GRELHADO",
            "FILÉ DE FRANGO Á MILANESA",
            "FILÉ DE FRANGO Á PARMEGIANA",
            "CONTRA-FILÉ ACEBOLADO",
            "CONTRA-FILÉ À MILANESA",
            "CONTRA-FILÉ À PARMEGIANA",
            "FIGADO ACEBOLADO",
            "FIGADO GRELHADO",
            "BISTECA DE PORCO",
            "CARNE SECA COM BATATA",
            "FEIJOADA",
            "FILÉ DE PEIXE COM MOLHO DE CAMARÃO",
            "FRANGO ENSOPADO"});
            this.cboalmoco.Location = new System.Drawing.Point(11, 19);
            this.cboalmoco.Name = "cboalmoco";
            this.cboalmoco.Size = new System.Drawing.Size(351, 28);
            this.cboalmoco.TabIndex = 6;
            this.cboalmoco.Text = ">> SELECIONE <<";
            this.cboalmoco.SelectedIndexChanged += new System.EventHandler(this.cboalmoco_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtnome_clie);
            this.tabPage2.Controls.Add(this.txtcod_clie);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CLIENTES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Empresa";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefone";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome";
            // 
            // txtnome_clie
            // 
            this.txtnome_clie.Location = new System.Drawing.Point(96, 69);
            this.txtnome_clie.Name = "txtnome_clie";
            this.txtnome_clie.Size = new System.Drawing.Size(100, 22);
            this.txtnome_clie.TabIndex = 3;
            // 
            // txtcod_clie
            // 
            this.txtcod_clie.Location = new System.Drawing.Point(96, 41);
            this.txtcod_clie.Name = "txtcod_clie";
            this.txtcod_clie.ReadOnly = true;
            this.txtcod_clie.Size = new System.Drawing.Size(100, 22);
            this.txtcod_clie.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Codigo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btnapagar_prod);
            this.tabPage3.Controls.Add(this.btnnovo_prod);
            this.tabPage3.Controls.Add(this.btn_carregar);
            this.tabPage3.Controls.Add(this.btn_salvar);
            this.tabPage3.Controls.Add(this.dgvprodutos);
            this.tabPage3.Controls.Add(this.txtpreco_prod);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtnome_prod);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtcod_prod);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(702, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PRODUTOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "ALTERAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnapagar_prod
            // 
            this.btnapagar_prod.Location = new System.Drawing.Point(389, 202);
            this.btnapagar_prod.Name = "btnapagar_prod";
            this.btnapagar_prod.Size = new System.Drawing.Size(98, 23);
            this.btnapagar_prod.TabIndex = 12;
            this.btnapagar_prod.Text = "APAGAR";
            this.btnapagar_prod.UseVisualStyleBackColor = true;
            this.btnapagar_prod.Click += new System.EventHandler(this.btnapagar_prod_Click);
            // 
            // btnnovo_prod
            // 
            this.btnnovo_prod.Location = new System.Drawing.Point(308, 202);
            this.btnnovo_prod.Name = "btnnovo_prod";
            this.btnnovo_prod.Size = new System.Drawing.Size(75, 23);
            this.btnnovo_prod.TabIndex = 11;
            this.btnnovo_prod.Text = "NOVO";
            this.btnnovo_prod.UseVisualStyleBackColor = true;
            this.btnnovo_prod.Click += new System.EventHandler(this.btnnovo_prod_Click);
            // 
            // btn_carregar
            // 
            this.btn_carregar.Location = new System.Drawing.Point(196, 202);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(105, 23);
            this.btn_carregar.TabIndex = 10;
            this.btn_carregar.Text = "CARREGAR";
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(104, 202);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(86, 23);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // dgvprodutos
            // 
            this.dgvprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprodutos.Location = new System.Drawing.Point(8, 231);
            this.dgvprodutos.Name = "dgvprodutos";
            this.dgvprodutos.Size = new System.Drawing.Size(776, 187);
            this.dgvprodutos.TabIndex = 8;
            // 
            // txtpreco_prod
            // 
            this.txtpreco_prod.Location = new System.Drawing.Point(443, 126);
            this.txtpreco_prod.Name = "txtpreco_prod";
            this.txtpreco_prod.Size = new System.Drawing.Size(100, 22);
            this.txtpreco_prod.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço";
            // 
            // txtnome_prod
            // 
            this.txtnome_prod.Location = new System.Drawing.Point(215, 126);
            this.txtnome_prod.Name = "txtnome_prod";
            this.txtnome_prod.Size = new System.Drawing.Size(165, 22);
            this.txtnome_prod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome ";
            // 
            // txtcod_prod
            // 
            this.txtcod_prod.Location = new System.Drawing.Point(88, 126);
            this.txtcod_prod.Name = "txtcod_prod";
            this.txtcod_prod.Size = new System.Drawing.Size(49, 22);
            this.txtcod_prod.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(702, 509);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "MENSALISTAS";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(434, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(710, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "COZINHA RUSTICA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxAlmoco.ResumeLayout(false);
            this.gbxAlmoco.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodutos)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtpreco_prod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome_prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcod_prod;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvprodutos;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btnnovo_prod;
        private System.Windows.Forms.Button btnapagar_prod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnome_clie;
        private System.Windows.Forms.TextBox txtcod_clie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbxAlmoco;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbobebida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQtdBebida;
        private System.Windows.Forms.TextBox txtTotalBebida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalAlmoco;
        private System.Windows.Forms.TextBox txtQtdAlmoco;
        private System.Windows.Forms.ComboBox cboalmoco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbosobremesa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQtdSobremesa;
        private System.Windows.Forms.TextBox txtTotalSobremesa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbopagamento;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

