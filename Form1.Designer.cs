namespace AppBancario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxCria = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimeNasc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vlrTransTextBox = new System.Windows.Forms.TextBox();
            this.btoSacar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumCCShow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaldoShow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NomeCabec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxCria.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBoxCria);
            this.panel1.Location = new System.Drawing.Point(618, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 483);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(4, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 30);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.label2.Font = new System.Drawing.Font("BancoDoBrasil Textos", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(28, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "CRIE SUA CONTA BB";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(22, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 75);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxCria
            // 
            this.groupBoxCria.AutoSize = true;
            this.groupBoxCria.BackColor = System.Drawing.Color.White;
            this.groupBoxCria.Controls.Add(this.button1);
            this.groupBoxCria.Controls.Add(this.dateTimeNasc);
            this.groupBoxCria.Controls.Add(this.label1);
            this.groupBoxCria.Controls.Add(this.maskedTextBoxCPF);
            this.groupBoxCria.Controls.Add(this.labelCPF);
            this.groupBoxCria.Controls.Add(this.labelEmail);
            this.groupBoxCria.Controls.Add(this.textBoxEmail);
            this.groupBoxCria.Controls.Add(this.labelNome);
            this.groupBoxCria.Controls.Add(this.textBoxNome);
            this.groupBoxCria.Location = new System.Drawing.Point(22, 6);
            this.groupBoxCria.Name = "groupBoxCria";
            this.groupBoxCria.Size = new System.Drawing.Size(261, 371);
            this.groupBoxCria.TabIndex = 3;
            this.groupBoxCria.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("BancoDoBrasil Textos", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.button1.Location = new System.Drawing.Point(53, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimeNasc
            // 
            this.dateTimeNasc.CalendarFont = new System.Drawing.Font("BancoDoBrasil Textos", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeNasc.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.dateTimeNasc.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dateTimeNasc.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.dateTimeNasc.Checked = false;
            this.dateTimeNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNasc.Location = new System.Drawing.Point(31, 247);
            this.dateTimeNasc.Name = "dateTimeNasc";
            this.dateTimeNasc.Size = new System.Drawing.Size(196, 21);
            this.dateTimeNasc.TabIndex = 4;
            this.dateTimeNasc.Value = new System.DateTime(2022, 12, 23, 0, 0, 0, 0);
            this.dateTimeNasc.ValueChanged += new System.EventHandler(this.dateTimeNasc_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(31, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nascimento:";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.maskedTextBoxCPF.Font = new System.Drawing.Font("BancoDoBrasil Textos", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(31, 130);
            this.maskedTextBoxCPF.Mask = "999.999.999-99";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(132, 23);
            this.maskedTextBoxCPF.TabIndex = 2;
            this.maskedTextBoxCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCPF_MaskInputRejected);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.labelCPF.Location = new System.Drawing.Point(31, 112);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(32, 15);
            this.labelCPF.TabIndex = 4;
            this.labelCPF.Text = "CPF:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.labelEmail.Location = new System.Drawing.Point(31, 168);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 15);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBoxEmail.Font = new System.Drawing.Font("BancoDoBrasil Textos", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
            this.textBoxEmail.Location = new System.Drawing.Point(31, 187);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(196, 23);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.labelNome.Location = new System.Drawing.Point(31, 54);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(44, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBoxNome.Font = new System.Drawing.Font("BancoDoBrasil Textos", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
            this.textBoxNome.Location = new System.Drawing.Point(31, 75);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(196, 23);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 483);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.panel5.Location = new System.Drawing.Point(3, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 8);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.NomeCabec);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(9, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 475);
            this.panel4.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.vlrTransTextBox);
            this.groupBox2.Controls.Add(this.btoSacar);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("BancoDoBrasil Textos", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.groupBox2.Location = new System.Drawing.Point(26, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 371);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transações";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(11, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(59, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 9;
            // 
            // vlrTransTextBox
            // 
            this.vlrTransTextBox.Location = new System.Drawing.Point(8, 65);
            this.vlrTransTextBox.Name = "vlrTransTextBox";
            this.vlrTransTextBox.Size = new System.Drawing.Size(141, 21);
            this.vlrTransTextBox.TabIndex = 8;
            // 
            // btoSacar
            // 
            this.btoSacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.btoSacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btoSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoSacar.Font = new System.Drawing.Font("BancoDoBrasil Textos", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btoSacar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.btoSacar.Location = new System.Drawing.Point(8, 228);
            this.btoSacar.Name = "btoSacar";
            this.btoSacar.Size = new System.Drawing.Size(141, 47);
            this.btoSacar.TabIndex = 3;
            this.btoSacar.Text = "Sacar";
            this.btoSacar.UseVisualStyleBackColor = false;
            this.btoSacar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("BancoDoBrasil Textos", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.button3.Location = new System.Drawing.Point(10, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "Depositar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("BancoDoBrasil Textos", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.button4.Location = new System.Drawing.Point(9, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "Transferir";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumCCShow);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SaldoShow);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("BancoDoBrasil Textos", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.groupBox1.Location = new System.Drawing.Point(331, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(254, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Bancários";
            // 
            // NumCCShow
            // 
            this.NumCCShow.AutoSize = true;
            this.NumCCShow.Font = new System.Drawing.Font("BancoDoBrasil Textos", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumCCShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.NumCCShow.Location = new System.Drawing.Point(148, 74);
            this.NumCCShow.Name = "NumCCShow";
            this.NumCCShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumCCShow.Size = new System.Drawing.Size(20, 18);
            this.NumCCShow.TabIndex = 3;
            this.NumCCShow.Text = "...";
            this.NumCCShow.Click += new System.EventHandler(this.NumCCShow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("BancoDoBrasil Textos", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(9, 72);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(135, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Número da Conta: ";
            // 
            // SaldoShow
            // 
            this.SaldoShow.AutoSize = true;
            this.SaldoShow.Font = new System.Drawing.Font("BancoDoBrasil Textos", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaldoShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(48)))));
            this.SaldoShow.Location = new System.Drawing.Point(102, 34);
            this.SaldoShow.Name = "SaldoShow";
            this.SaldoShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaldoShow.Size = new System.Drawing.Size(118, 21);
            this.SaldoShow.TabIndex = 1;
            this.SaldoShow.Text = "Clique pra ver";
            this.SaldoShow.Click += new System.EventHandler(this.SaldoShow_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BancoDoBrasil Textos", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seu Saldo: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(525, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 51);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // NomeCabec
            // 
            this.NomeCabec.AutoSize = true;
            this.NomeCabec.Font = new System.Drawing.Font("BancoDoBrasil Textos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomeCabec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.NomeCabec.Location = new System.Drawing.Point(65, 20);
            this.NomeCabec.Name = "NomeCabec";
            this.NomeCabec.Size = new System.Drawing.Size(22, 21);
            this.NomeCabec.TabIndex = 1;
            this.NomeCabec.Text = "...";
            this.NomeCabec.Click += new System.EventHandler(this.NomeCabec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BancoDoBrasil Textos", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Olá, ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("BancoDoBrasil Textos", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(913, 545);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(913, 545);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Crie sua conta no Banco do Brasil - #ÉaGenteQueTransforma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxCria.ResumeLayout(false);
            this.groupBoxCria.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBoxCria;
        private Button button1;
        private DateTimePicker dateTimeNasc;
        private Label label1;
        private MaskedTextBox maskedTextBoxCPF;
        private Label labelCPF;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelNome;
        private TextBox textBoxNome;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label NomeCabec;
        private Label label3;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Button button4;
        private Button button3;
        private Button btoSacar;
        private GroupBox groupBox1;
        private Label SaldoShow;
        private Label label4;
        private Label NumCCShow;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox vlrTransTextBox;
        private Label label7;
        private Label label5;
    }
}