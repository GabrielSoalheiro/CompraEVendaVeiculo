namespace Compra_e_venda_de_veiculos
{
    partial class ConfirmaExclusão
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
            this.label1 = new System.Windows.Forms.Label();
            this.bntSim = new System.Windows.Forms.Button();
            this.btnNão = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirma Exclusão ?";
            // 
            // bntSim
            // 
            this.bntSim.BackColor = System.Drawing.Color.Red;
            this.bntSim.Location = new System.Drawing.Point(41, 56);
            this.bntSim.Name = "bntSim";
            this.bntSim.Size = new System.Drawing.Size(75, 23);
            this.bntSim.TabIndex = 1;
            this.bntSim.Text = "Sim";
            this.bntSim.UseVisualStyleBackColor = false;
            this.bntSim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNão
            // 
            this.btnNão.BackColor = System.Drawing.Color.Transparent;
            this.btnNão.Location = new System.Drawing.Point(122, 56);
            this.btnNão.Name = "btnNão";
            this.btnNão.Size = new System.Drawing.Size(75, 23);
            this.btnNão.TabIndex = 2;
            this.btnNão.Text = "Não";
            this.btnNão.UseVisualStyleBackColor = false;
            this.btnNão.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConfirmaExclusão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 91);
            this.Controls.Add(this.btnNão);
            this.Controls.Add(this.bntSim);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmaExclusão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntSim;
        private System.Windows.Forms.Button btnNão;
    }
}