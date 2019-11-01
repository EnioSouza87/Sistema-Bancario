namespace Banco_Sul
{
    partial class Deposito
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
            this.GROUPBOX_Deposito = new System.Windows.Forms.GroupBox();
            this.LBL_DepositoLimpar = new System.Windows.Forms.Label();
            this.BTN_DepositoLimpar = new System.Windows.Forms.Button();
            this.LBL_DepositoCancelar = new System.Windows.Forms.Label();
            this.BTN_DepositoCancelar = new System.Windows.Forms.Button();
            this.LBL_DepositoDepositar = new System.Windows.Forms.Label();
            this.BTN_DepositoDepositar = new System.Windows.Forms.Button();
            this.LBL_DepositoValor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NUMBOX_DepositoValor = new System.Windows.Forms.NumericUpDown();
            this.LBL_DepositoDisplay = new System.Windows.Forms.Label();
            this.TXTBOX_depositoDisplay = new System.Windows.Forms.TextBox();
            this.LBL_DepositoBuscar = new System.Windows.Forms.Label();
            this.BTN_DepositoBuscar = new System.Windows.Forms.Button();
            this.LBL_DepositoCodCliente = new System.Windows.Forms.Label();
            this.NUMBOX_DepositoCodCliente = new System.Windows.Forms.NumericUpDown();
            this.GROUPBOX_Deposito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_DepositoValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_DepositoCodCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GROUPBOX_Deposito
            // 
            this.GROUPBOX_Deposito.Controls.Add(this.LBL_DepositoLimpar);
            this.GROUPBOX_Deposito.Controls.Add(this.BTN_DepositoLimpar);
            this.GROUPBOX_Deposito.Controls.Add(this.LBL_DepositoCancelar);
            this.GROUPBOX_Deposito.Controls.Add(this.BTN_DepositoCancelar);
            this.GROUPBOX_Deposito.Controls.Add(this.LBL_DepositoDepositar);
            this.GROUPBOX_Deposito.Controls.Add(this.BTN_DepositoDepositar);
            this.GROUPBOX_Deposito.Controls.Add(this.LBL_DepositoValor);
            this.GROUPBOX_Deposito.Controls.Add(this.pictureBox1);
            this.GROUPBOX_Deposito.Controls.Add(this.NUMBOX_DepositoValor);
            this.GROUPBOX_Deposito.Controls.Add(this.LBL_DepositoDisplay);
            this.GROUPBOX_Deposito.Controls.Add(this.TXTBOX_depositoDisplay);
            this.GROUPBOX_Deposito.Controls.Add(this.LBL_DepositoBuscar);
            this.GROUPBOX_Deposito.Controls.Add(this.BTN_DepositoBuscar);
            this.GROUPBOX_Deposito.Controls.Add(this.LBL_DepositoCodCliente);
            this.GROUPBOX_Deposito.Controls.Add(this.NUMBOX_DepositoCodCliente);
            this.GROUPBOX_Deposito.Location = new System.Drawing.Point(12, 12);
            this.GROUPBOX_Deposito.Name = "GROUPBOX_Deposito";
            this.GROUPBOX_Deposito.Size = new System.Drawing.Size(288, 273);
            this.GROUPBOX_Deposito.TabIndex = 0;
            this.GROUPBOX_Deposito.TabStop = false;
            this.GROUPBOX_Deposito.Text = "Depóstito";
            // 
            // LBL_DepositoLimpar
            // 
            this.LBL_DepositoLimpar.AutoSize = true;
            this.LBL_DepositoLimpar.Location = new System.Drawing.Point(226, 249);
            this.LBL_DepositoLimpar.Name = "LBL_DepositoLimpar";
            this.LBL_DepositoLimpar.Size = new System.Drawing.Size(38, 13);
            this.LBL_DepositoLimpar.TabIndex = 14;
            this.LBL_DepositoLimpar.Text = "Limpar";
            // 
            // BTN_DepositoLimpar
            // 
            this.BTN_DepositoLimpar.Image = global::Banco_Sul.Properties.Resources.borracha__1_;
            this.BTN_DepositoLimpar.Location = new System.Drawing.Point(220, 206);
            this.BTN_DepositoLimpar.Name = "BTN_DepositoLimpar";
            this.BTN_DepositoLimpar.Size = new System.Drawing.Size(48, 42);
            this.BTN_DepositoLimpar.TabIndex = 13;
            this.BTN_DepositoLimpar.UseVisualStyleBackColor = true;
            this.BTN_DepositoLimpar.Click += new System.EventHandler(this.BTN_DepositoLimpar_Click);
            // 
            // LBL_DepositoCancelar
            // 
            this.LBL_DepositoCancelar.AutoSize = true;
            this.LBL_DepositoCancelar.Location = new System.Drawing.Point(123, 248);
            this.LBL_DepositoCancelar.Name = "LBL_DepositoCancelar";
            this.LBL_DepositoCancelar.Size = new System.Drawing.Size(49, 13);
            this.LBL_DepositoCancelar.TabIndex = 12;
            this.LBL_DepositoCancelar.Text = "Cancelar";
            // 
            // BTN_DepositoCancelar
            // 
            this.BTN_DepositoCancelar.Image = global::Banco_Sul.Properties.Resources.cancelar__2_;
            this.BTN_DepositoCancelar.Location = new System.Drawing.Point(123, 206);
            this.BTN_DepositoCancelar.Name = "BTN_DepositoCancelar";
            this.BTN_DepositoCancelar.Size = new System.Drawing.Size(49, 42);
            this.BTN_DepositoCancelar.TabIndex = 11;
            this.BTN_DepositoCancelar.UseVisualStyleBackColor = true;
            this.BTN_DepositoCancelar.Click += new System.EventHandler(this.BTN_DepositoCancelar_Click);
            // 
            // LBL_DepositoDepositar
            // 
            this.LBL_DepositoDepositar.AutoSize = true;
            this.LBL_DepositoDepositar.Location = new System.Drawing.Point(25, 249);
            this.LBL_DepositoDepositar.Name = "LBL_DepositoDepositar";
            this.LBL_DepositoDepositar.Size = new System.Drawing.Size(52, 13);
            this.LBL_DepositoDepositar.TabIndex = 10;
            this.LBL_DepositoDepositar.Text = "Depositar";
            // 
            // BTN_DepositoDepositar
            // 
            this.BTN_DepositoDepositar.Image = global::Banco_Sul.Properties.Resources.sacar__1_;
            this.BTN_DepositoDepositar.Location = new System.Drawing.Point(27, 206);
            this.BTN_DepositoDepositar.Name = "BTN_DepositoDepositar";
            this.BTN_DepositoDepositar.Size = new System.Drawing.Size(47, 42);
            this.BTN_DepositoDepositar.TabIndex = 9;
            this.BTN_DepositoDepositar.UseVisualStyleBackColor = true;
            this.BTN_DepositoDepositar.Click += new System.EventHandler(this.BTN_DepositoDepositar_Click);
            // 
            // LBL_DepositoValor
            // 
            this.LBL_DepositoValor.AutoSize = true;
            this.LBL_DepositoValor.Location = new System.Drawing.Point(7, 154);
            this.LBL_DepositoValor.Name = "LBL_DepositoValor";
            this.LBL_DepositoValor.Size = new System.Drawing.Size(91, 13);
            this.LBL_DepositoValor.TabIndex = 8;
            this.LBL_DepositoValor.Text = "Valor do Depósito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Banco_Sul.Properties.Resources.Modern_Real_Estate_Etsy_Shop_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(202, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // NUMBOX_DepositoValor
            // 
            this.NUMBOX_DepositoValor.Location = new System.Drawing.Point(9, 169);
            this.NUMBOX_DepositoValor.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NUMBOX_DepositoValor.Name = "NUMBOX_DepositoValor";
            this.NUMBOX_DepositoValor.Size = new System.Drawing.Size(138, 20);
            this.NUMBOX_DepositoValor.TabIndex = 6;
            // 
            // LBL_DepositoDisplay
            // 
            this.LBL_DepositoDisplay.AutoSize = true;
            this.LBL_DepositoDisplay.Location = new System.Drawing.Point(7, 102);
            this.LBL_DepositoDisplay.Name = "LBL_DepositoDisplay";
            this.LBL_DepositoDisplay.Size = new System.Drawing.Size(115, 13);
            this.LBL_DepositoDisplay.TabIndex = 5;
            this.LBL_DepositoDisplay.Text = "Informações do Cliente";
            // 
            // TXTBOX_depositoDisplay
            // 
            this.TXTBOX_depositoDisplay.Location = new System.Drawing.Point(9, 117);
            this.TXTBOX_depositoDisplay.Name = "TXTBOX_depositoDisplay";
            this.TXTBOX_depositoDisplay.ReadOnly = true;
            this.TXTBOX_depositoDisplay.Size = new System.Drawing.Size(259, 20);
            this.TXTBOX_depositoDisplay.TabIndex = 4;
            // 
            // LBL_DepositoBuscar
            // 
            this.LBL_DepositoBuscar.AutoSize = true;
            this.LBL_DepositoBuscar.Location = new System.Drawing.Point(132, 75);
            this.LBL_DepositoBuscar.Name = "LBL_DepositoBuscar";
            this.LBL_DepositoBuscar.Size = new System.Drawing.Size(40, 13);
            this.LBL_DepositoBuscar.TabIndex = 3;
            this.LBL_DepositoBuscar.Text = "Buscar";
            // 
            // BTN_DepositoBuscar
            // 
            this.BTN_DepositoBuscar.Image = global::Banco_Sul.Properties.Resources.buscar__1_;
            this.BTN_DepositoBuscar.Location = new System.Drawing.Point(135, 47);
            this.BTN_DepositoBuscar.Name = "BTN_DepositoBuscar";
            this.BTN_DepositoBuscar.Size = new System.Drawing.Size(31, 28);
            this.BTN_DepositoBuscar.TabIndex = 2;
            this.BTN_DepositoBuscar.UseVisualStyleBackColor = true;
            this.BTN_DepositoBuscar.Click += new System.EventHandler(this.BTN_DepositoBuscar_Click);
            // 
            // LBL_DepositoCodCliente
            // 
            this.LBL_DepositoCodCliente.AutoSize = true;
            this.LBL_DepositoCodCliente.Location = new System.Drawing.Point(6, 37);
            this.LBL_DepositoCodCliente.Name = "LBL_DepositoCodCliente";
            this.LBL_DepositoCodCliente.Size = new System.Drawing.Size(90, 13);
            this.LBL_DepositoCodCliente.TabIndex = 1;
            this.LBL_DepositoCodCliente.Text = "Código do Cliente";
            // 
            // NUMBOX_DepositoCodCliente
            // 
            this.NUMBOX_DepositoCodCliente.Location = new System.Drawing.Point(9, 53);
            this.NUMBOX_DepositoCodCliente.Name = "NUMBOX_DepositoCodCliente";
            this.NUMBOX_DepositoCodCliente.Size = new System.Drawing.Size(120, 20);
            this.NUMBOX_DepositoCodCliente.TabIndex = 0;
            
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 291);
            this.Controls.Add(this.GROUPBOX_Deposito);
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.GROUPBOX_Deposito.ResumeLayout(false);
            this.GROUPBOX_Deposito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_DepositoValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_DepositoCodCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GROUPBOX_Deposito;
        private System.Windows.Forms.Button BTN_DepositoBuscar;
        private System.Windows.Forms.Label LBL_DepositoCodCliente;
        private System.Windows.Forms.NumericUpDown NUMBOX_DepositoCodCliente;
        private System.Windows.Forms.Label LBL_DepositoLimpar;
        private System.Windows.Forms.Button BTN_DepositoLimpar;
        private System.Windows.Forms.Label LBL_DepositoCancelar;
        private System.Windows.Forms.Button BTN_DepositoCancelar;
        private System.Windows.Forms.Label LBL_DepositoDepositar;
        private System.Windows.Forms.Button BTN_DepositoDepositar;
        private System.Windows.Forms.Label LBL_DepositoValor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown NUMBOX_DepositoValor;
        private System.Windows.Forms.Label LBL_DepositoDisplay;
        private System.Windows.Forms.TextBox TXTBOX_depositoDisplay;
        private System.Windows.Forms.Label LBL_DepositoBuscar;
    }
}