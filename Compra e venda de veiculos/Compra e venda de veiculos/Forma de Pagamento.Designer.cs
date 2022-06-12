namespace Compra_e_venda_de_veiculos
{
    partial class Forma_de_Pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_de_Pagamento));
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCPFouCNPJ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxEntrada = new System.Windows.Forms.TextBox();
            this.ComboBoxFormaEntrada = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxRestante = new System.Windows.Forms.TextBox();
            this.comboBoxFinanciamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxFormaRestante = new System.Windows.Forms.ComboBox();
            this.comboBoxCrédito = new System.Windows.Forms.ComboBox();
            this.txtBoxValorVeiculo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxValorParcela = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIMGVEIC = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMGVEIC)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(16, 53);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCliente.TabIndex = 0;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // txtBoxCPFouCNPJ
            // 
            this.txtBoxCPFouCNPJ.Location = new System.Drawing.Point(161, 53);
            this.txtBoxCPFouCNPJ.Name = "txtBoxCPFouCNPJ";
            this.txtBoxCPFouCNPJ.ReadOnly = true;
            this.txtBoxCPFouCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCPFouCNPJ.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF / CPNJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor de Entrada";
            // 
            // txtboxEntrada
            // 
            this.txtboxEntrada.Location = new System.Drawing.Point(6, 40);
            this.txtboxEntrada.Name = "txtboxEntrada";
            this.txtboxEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtboxEntrada.TabIndex = 7;
            this.txtboxEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtboxEntrada_KeyPress);
            // 
            // ComboBoxFormaEntrada
            // 
            this.ComboBoxFormaEntrada.FormattingEnabled = true;
            this.ComboBoxFormaEntrada.Items.AddRange(new object[] {
            "Débito",
            "Dinheiro"});
            this.ComboBoxFormaEntrada.Location = new System.Drawing.Point(130, 39);
            this.ComboBoxFormaEntrada.Name = "ComboBoxFormaEntrada";
            this.ComboBoxFormaEntrada.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxFormaEntrada.TabIndex = 9;
            this.ComboBoxFormaEntrada.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Forma de Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Forma de Pagamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Restante a Pagar";
            // 
            // txtBoxRestante
            // 
            this.txtBoxRestante.Location = new System.Drawing.Point(6, 97);
            this.txtBoxRestante.Name = "txtBoxRestante";
            this.txtBoxRestante.ReadOnly = true;
            this.txtBoxRestante.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRestante.TabIndex = 11;
            // 
            // comboBoxFinanciamento
            // 
            this.comboBoxFinanciamento.FormattingEnabled = true;
            this.comboBoxFinanciamento.Items.AddRange(new object[] {
            "6",
            "12",
            "18",
            "24",
            "30",
            "36",
            "42",
            "48",
            "54",
            "60",
            "66",
            "72"});
            this.comboBoxFinanciamento.Location = new System.Drawing.Point(271, 96);
            this.comboBoxFinanciamento.Name = "comboBoxFinanciamento";
            this.comboBoxFinanciamento.Size = new System.Drawing.Size(60, 21);
            this.comboBoxFinanciamento.TabIndex = 15;
            this.comboBoxFinanciamento.Visible = false;
            this.comboBoxFinanciamento.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nº Parcelas";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "-";
            // 
            // comboBoxFormaRestante
            // 
            this.comboBoxFormaRestante.FormattingEnabled = true;
            this.comboBoxFormaRestante.Items.AddRange(new object[] {
            "Crédito",
            "Débito",
            "Dinheiro",
            "Financiamento"});
            this.comboBoxFormaRestante.Location = new System.Drawing.Point(130, 96);
            this.comboBoxFormaRestante.Name = "comboBoxFormaRestante";
            this.comboBoxFormaRestante.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFormaRestante.TabIndex = 21;
            this.comboBoxFormaRestante.SelectedIndexChanged += new System.EventHandler(this.ComboBox4_SelectedIndexChanged_1);
            // 
            // comboBoxCrédito
            // 
            this.comboBoxCrédito.FormattingEnabled = true;
            this.comboBoxCrédito.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxCrédito.Location = new System.Drawing.Point(271, 96);
            this.comboBoxCrédito.Name = "comboBoxCrédito";
            this.comboBoxCrédito.Size = new System.Drawing.Size(60, 21);
            this.comboBoxCrédito.TabIndex = 22;
            this.comboBoxCrédito.Visible = false;
            this.comboBoxCrédito.SelectedIndexChanged += new System.EventHandler(this.ComboBox5_SelectedIndexChanged);
            // 
            // txtBoxValorVeiculo
            // 
            this.txtBoxValorVeiculo.Location = new System.Drawing.Point(16, 100);
            this.txtBoxValorVeiculo.Name = "txtBoxValorVeiculo";
            this.txtBoxValorVeiculo.ReadOnly = true;
            this.txtBoxValorVeiculo.Size = new System.Drawing.Size(110, 20);
            this.txtBoxValorVeiculo.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBoxValorParcela);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtboxEntrada);
            this.groupBox1.Controls.Add(this.comboBoxCrédito);
            this.groupBox1.Controls.Add(this.ComboBoxFormaEntrada);
            this.groupBox1.Controls.Add(this.comboBoxFormaRestante);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtBoxRestante);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxFinanciamento);
            this.groupBox1.Location = new System.Drawing.Point(276, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 198);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Valor Parcela";
            this.label12.Visible = false;
            // 
            // txtBoxValorParcela
            // 
            this.txtBoxValorParcela.Location = new System.Drawing.Point(339, 97);
            this.txtBoxValorParcela.Name = "txtBoxValorParcela";
            this.txtBoxValorParcela.ReadOnly = true;
            this.txtBoxValorParcela.Size = new System.Drawing.Size(98, 20);
            this.txtBoxValorParcela.TabIndex = 27;
            this.txtBoxValorParcela.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Valor Total do Veículo";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(99, 377);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(73, 25);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxIMGVEIC
            // 
            this.pictureBoxIMGVEIC.Location = new System.Drawing.Point(276, 217);
            this.pictureBoxIMGVEIC.Name = "pictureBoxIMGVEIC";
            this.pictureBoxIMGVEIC.Size = new System.Drawing.Size(447, 217);
            this.pictureBoxIMGVEIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIMGVEIC.TabIndex = 27;
            this.pictureBoxIMGVEIC.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 140);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Transação";
            // 
            // Forma_de_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 446);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxIMGVEIC);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxValorVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxCPFouCNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.groupBox2);
            this.Name = "Forma_de_Pagamento";
            this.Text = "Pagamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMGVEIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboBoxCliente;
        public System.Windows.Forms.TextBox txtBoxCPFouCNPJ;
        public System.Windows.Forms.TextBox txtboxEntrada;
        public System.Windows.Forms.ComboBox ComboBoxFormaEntrada;
        public System.Windows.Forms.TextBox txtBoxRestante;
        public System.Windows.Forms.ComboBox comboBoxFormaRestante;
        public System.Windows.Forms.ComboBox comboBoxCrédito;
        public System.Windows.Forms.TextBox txtBoxValorVeiculo;
        public System.Windows.Forms.TextBox txtBoxValorParcela;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.PictureBox pictureBoxIMGVEIC;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboBoxFinanciamento;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}