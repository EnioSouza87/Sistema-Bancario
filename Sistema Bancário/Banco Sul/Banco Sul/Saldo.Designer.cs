namespace Banco_Sul
{
    partial class Saldo
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
            this.GROUPBOX_Saldo = new System.Windows.Forms.GroupBox();
            this.LBL_SaldoLimpar = new System.Windows.Forms.Label();
            this.BTN_SaldoLimpar = new System.Windows.Forms.Button();
            this.LBL_SaldoCancelar = new System.Windows.Forms.Label();
            this.LBL_SaldoBuscar = new System.Windows.Forms.Label();
            this.BTN_SaldoCancelar = new System.Windows.Forms.Button();
            this.TXTBOX_SaldoDisplay = new System.Windows.Forms.TextBox();
            this.BTN_SaldoBuscar = new System.Windows.Forms.Button();
            this.NUMBOX_SaldoCodCliente = new System.Windows.Forms.NumericUpDown();
            this.LBL_SaldoCodCliente = new System.Windows.Forms.Label();
            this.GROUPBOX_Saldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_SaldoCodCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GROUPBOX_Saldo
            // 
            this.GROUPBOX_Saldo.Controls.Add(this.LBL_SaldoLimpar);
            this.GROUPBOX_Saldo.Controls.Add(this.BTN_SaldoLimpar);
            this.GROUPBOX_Saldo.Controls.Add(this.LBL_SaldoCancelar);
            this.GROUPBOX_Saldo.Controls.Add(this.LBL_SaldoBuscar);
            this.GROUPBOX_Saldo.Controls.Add(this.BTN_SaldoCancelar);
            this.GROUPBOX_Saldo.Controls.Add(this.TXTBOX_SaldoDisplay);
            this.GROUPBOX_Saldo.Controls.Add(this.BTN_SaldoBuscar);
            this.GROUPBOX_Saldo.Controls.Add(this.NUMBOX_SaldoCodCliente);
            this.GROUPBOX_Saldo.Controls.Add(this.LBL_SaldoCodCliente);
            this.GROUPBOX_Saldo.Location = new System.Drawing.Point(32, 26);
            this.GROUPBOX_Saldo.Name = "GROUPBOX_Saldo";
            this.GROUPBOX_Saldo.Size = new System.Drawing.Size(313, 243);
            this.GROUPBOX_Saldo.TabIndex = 0;
            this.GROUPBOX_Saldo.TabStop = false;
            this.GROUPBOX_Saldo.Text = "Consultar Saldo";
            // 
            // LBL_SaldoLimpar
            // 
            this.LBL_SaldoLimpar.AutoSize = true;
            this.LBL_SaldoLimpar.Location = new System.Drawing.Point(192, 212);
            this.LBL_SaldoLimpar.Name = "LBL_SaldoLimpar";
            this.LBL_SaldoLimpar.Size = new System.Drawing.Size(38, 13);
            this.LBL_SaldoLimpar.TabIndex = 8;
            this.LBL_SaldoLimpar.Text = "Limpar";
            // 
            // BTN_SaldoLimpar
            // 
            this.BTN_SaldoLimpar.Image = global::Banco_Sul.Properties.Resources.borracha__1_;
            this.BTN_SaldoLimpar.Location = new System.Drawing.Point(186, 171);
            this.BTN_SaldoLimpar.Name = "BTN_SaldoLimpar";
            this.BTN_SaldoLimpar.Size = new System.Drawing.Size(47, 38);
            this.BTN_SaldoLimpar.TabIndex = 7;
            this.BTN_SaldoLimpar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_SaldoLimpar.UseVisualStyleBackColor = true;
            this.BTN_SaldoLimpar.Click += new System.EventHandler(this.BTN_SaldoLimpar_Click);
            // 
            // LBL_SaldoCancelar
            // 
            this.LBL_SaldoCancelar.AutoSize = true;
            this.LBL_SaldoCancelar.Location = new System.Drawing.Point(72, 212);
            this.LBL_SaldoCancelar.Name = "LBL_SaldoCancelar";
            this.LBL_SaldoCancelar.Size = new System.Drawing.Size(49, 13);
            this.LBL_SaldoCancelar.TabIndex = 6;
            this.LBL_SaldoCancelar.Text = "Cancelar";
            // 
            // LBL_SaldoBuscar
            // 
            this.LBL_SaldoBuscar.AutoSize = true;
            this.LBL_SaldoBuscar.Location = new System.Drawing.Point(214, 66);
            this.LBL_SaldoBuscar.Name = "LBL_SaldoBuscar";
            this.LBL_SaldoBuscar.Size = new System.Drawing.Size(40, 13);
            this.LBL_SaldoBuscar.TabIndex = 5;
            this.LBL_SaldoBuscar.Text = "Buscar";
            // 
            // BTN_SaldoCancelar
            // 
            this.BTN_SaldoCancelar.Image = global::Banco_Sul.Properties.Resources.cancelar__2_;
            this.BTN_SaldoCancelar.Location = new System.Drawing.Point(72, 171);
            this.BTN_SaldoCancelar.Name = "BTN_SaldoCancelar";
            this.BTN_SaldoCancelar.Size = new System.Drawing.Size(49, 38);
            this.BTN_SaldoCancelar.TabIndex = 4;
            this.BTN_SaldoCancelar.UseVisualStyleBackColor = true;
            this.BTN_SaldoCancelar.Click += new System.EventHandler(this.BTN_SaldoCancelar_Click);
            // 
            // TXTBOX_SaldoDisplay
            // 
            this.TXTBOX_SaldoDisplay.Location = new System.Drawing.Point(22, 87);
            this.TXTBOX_SaldoDisplay.Multiline = true;
            this.TXTBOX_SaldoDisplay.Name = "TXTBOX_SaldoDisplay";
            this.TXTBOX_SaldoDisplay.ReadOnly = true;
            this.TXTBOX_SaldoDisplay.Size = new System.Drawing.Size(263, 78);
            this.TXTBOX_SaldoDisplay.TabIndex = 3;
            // 
            // BTN_SaldoBuscar
            // 
            this.BTN_SaldoBuscar.Image = global::Banco_Sul.Properties.Resources.buscar__1_;
            this.BTN_SaldoBuscar.Location = new System.Drawing.Point(211, 33);
            this.BTN_SaldoBuscar.Name = "BTN_SaldoBuscar";
            this.BTN_SaldoBuscar.Size = new System.Drawing.Size(45, 34);
            this.BTN_SaldoBuscar.TabIndex = 2;
            this.BTN_SaldoBuscar.UseVisualStyleBackColor = true;
            this.BTN_SaldoBuscar.Click += new System.EventHandler(this.BTN_SaldoBuscar_Click);
            // 
            // NUMBOX_SaldoCodCliente
            // 
            this.NUMBOX_SaldoCodCliente.Location = new System.Drawing.Point(113, 42);
            this.NUMBOX_SaldoCodCliente.Name = "NUMBOX_SaldoCodCliente";
            this.NUMBOX_SaldoCodCliente.Size = new System.Drawing.Size(94, 20);
            this.NUMBOX_SaldoCodCliente.TabIndex = 1;
            // 
            // LBL_SaldoCodCliente
            // 
            this.LBL_SaldoCodCliente.AutoSize = true;
            this.LBL_SaldoCodCliente.Location = new System.Drawing.Point(19, 44);
            this.LBL_SaldoCodCliente.Name = "LBL_SaldoCodCliente";
            this.LBL_SaldoCodCliente.Size = new System.Drawing.Size(90, 13);
            this.LBL_SaldoCodCliente.TabIndex = 0;
            this.LBL_SaldoCodCliente.Text = "Código do Cliente";
            // 
            // Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 297);
            this.Controls.Add(this.GROUPBOX_Saldo);
            this.Name = "Saldo";
            this.Text = "Saldo";
            this.GROUPBOX_Saldo.ResumeLayout(false);
            this.GROUPBOX_Saldo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_SaldoCodCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GROUPBOX_Saldo;
        private System.Windows.Forms.Button BTN_SaldoBuscar;
        private System.Windows.Forms.NumericUpDown NUMBOX_SaldoCodCliente;
        private System.Windows.Forms.Label LBL_SaldoCodCliente;
        private System.Windows.Forms.Label LBL_SaldoLimpar;
        private System.Windows.Forms.Button BTN_SaldoLimpar;
        private System.Windows.Forms.Label LBL_SaldoCancelar;
        private System.Windows.Forms.Label LBL_SaldoBuscar;
        private System.Windows.Forms.Button BTN_SaldoCancelar;
        private System.Windows.Forms.TextBox TXTBOX_SaldoDisplay;
    }
}