namespace Calculo_Salario_Liquido
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblNSS = new System.Windows.Forms.Label();
            this.lblIRRF = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(141, 109);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 42);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(117, 56);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.PlaceholderText = "Digite o Salário Bruto";
            this.txtSalario.Size = new System.Drawing.Size(124, 23);
            this.txtSalario.TabIndex = 1;
            // 
            // lblNSS
            // 
            this.lblNSS.AutoSize = true;
            this.lblNSS.Location = new System.Drawing.Point(23, 219);
            this.lblNSS.Name = "lblNSS";
            this.lblNSS.Size = new System.Drawing.Size(77, 15);
            this.lblNSS.TabIndex = 2;
            this.lblNSS.Text = "Valor do INSS";
            // 
            // lblIRRF
            // 
            this.lblIRRF.AutoSize = true;
            this.lblIRRF.Location = new System.Drawing.Point(23, 247);
            this.lblIRRF.Name = "lblIRRF";
            this.lblIRRF.Size = new System.Drawing.Size(76, 15);
            this.lblIRRF.TabIndex = 3;
            this.lblIRRF.Text = "Valor do IRRF";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(23, 275);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(82, 15);
            this.lblSalarioLiquido.TabIndex = 4;
            this.lblSalarioLiquido.Text = "Salário líquido";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(23, 192);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 15);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 309);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblIRRF);
            this.Controls.Add(this.lblNSS);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Calculo Salario Liquido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private TextBox txtSalario;
        private Label lblNSS;
        private Label lblIRRF;
        private Label lblSalarioLiquido;
        private Label lblSalario;
    }
}