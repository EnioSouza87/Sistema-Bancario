namespace Banco_Sul
{
    partial class RelatorioCliente
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
            this.GROUPBOX_RelatorioCliente = new System.Windows.Forms.GroupBox();
            this.LBL_RelatorioCliente_Cdcliente = new System.Windows.Forms.Label();
            this.NUMBOX_RelatorioCliente = new System.Windows.Forms.NumericUpDown();
            this.BTN_RelatorioClienteBuscar = new System.Windows.Forms.Button();
            this.LBL_RelatorioClienteBuscar = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioNome = new System.Windows.Forms.TextBox();
            this.LBL_RelatorioClienteNome = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioclienteDataNasc = new System.Windows.Forms.TextBox();
            this.LBL_RelatorioClienteDataNasc = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioClienteCpf = new System.Windows.Forms.TextBox();
            this.LBL_RelatorioClienteCpf = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioClienteEndereco = new System.Windows.Forms.TextBox();
            this.LBL_RelatorioClienteEndereco = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioClienteSaldo = new System.Windows.Forms.TextBox();
            this.LBL_RelatorioClienteSaldo = new System.Windows.Forms.Label();
            this.BTN_RelatorioClienteLimpar = new System.Windows.Forms.Button();
            this.LBL_RelatorioClienteLimpar = new System.Windows.Forms.Label();
            this.BTN_RelatorioClienteCancelar = new System.Windows.Forms.Button();
            this.LBL_RelatorioClienteCancelar = new System.Windows.Forms.Label();
            this.GROUPBOX_RelatorioCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_RelatorioCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GROUPBOX_RelatorioCliente
            // 
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.LBL_RelatorioClienteCancelar);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.BTN_RelatorioClienteCancelar);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.LBL_RelatorioClienteLimpar);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.BTN_RelatorioClienteLimpar);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.LBL_RelatorioClienteSaldo);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.TXTBOX_RelatorioClienteSaldo);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.LBL_RelatorioClienteEndereco);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.TXTBOX_RelatorioClienteEndereco);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.LBL_RelatorioClienteCpf);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.TXTBOX_RelatorioClienteCpf);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.LBL_RelatorioClienteDataNasc);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.TXTBOX_RelatorioclienteDataNasc);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.LBL_RelatorioClienteNome);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.TXTBOX_RelatorioNome);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.LBL_RelatorioClienteBuscar);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.BTN_RelatorioClienteBuscar);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.NUMBOX_RelatorioCliente);
            this.GROUPBOX_RelatorioCliente.Controls.Add(this.LBL_RelatorioCliente_Cdcliente);
            this.GROUPBOX_RelatorioCliente.Location = new System.Drawing.Point(12, 12);
            this.GROUPBOX_RelatorioCliente.Name = "GROUPBOX_RelatorioCliente";
            this.GROUPBOX_RelatorioCliente.Size = new System.Drawing.Size(408, 504);
            this.GROUPBOX_RelatorioCliente.TabIndex = 0;
            this.GROUPBOX_RelatorioCliente.TabStop = false;
            this.GROUPBOX_RelatorioCliente.Text = "Relatório por cliente";
            // 
            // LBL_RelatorioCliente_Cdcliente
            // 
            this.LBL_RelatorioCliente_Cdcliente.AutoSize = true;
            this.LBL_RelatorioCliente_Cdcliente.Location = new System.Drawing.Point(15, 49);
            this.LBL_RelatorioCliente_Cdcliente.Name = "LBL_RelatorioCliente_Cdcliente";
            this.LBL_RelatorioCliente_Cdcliente.Size = new System.Drawing.Size(90, 13);
            this.LBL_RelatorioCliente_Cdcliente.TabIndex = 0;
            this.LBL_RelatorioCliente_Cdcliente.Text = "Código do Cliente";
            // 
            // NUMBOX_RelatorioCliente
            // 
            this.NUMBOX_RelatorioCliente.Location = new System.Drawing.Point(111, 47);
            this.NUMBOX_RelatorioCliente.Name = "NUMBOX_RelatorioCliente";
            this.NUMBOX_RelatorioCliente.Size = new System.Drawing.Size(73, 20);
            this.NUMBOX_RelatorioCliente.TabIndex = 1;
            // 
            // BTN_RelatorioClienteBuscar
            // 
            this.BTN_RelatorioClienteBuscar.Image = global::Banco_Sul.Properties.Resources.buscar__1_;
            this.BTN_RelatorioClienteBuscar.Location = new System.Drawing.Point(190, 41);
            this.BTN_RelatorioClienteBuscar.Name = "BTN_RelatorioClienteBuscar";
            this.BTN_RelatorioClienteBuscar.Size = new System.Drawing.Size(35, 28);
            this.BTN_RelatorioClienteBuscar.TabIndex = 2;
            this.BTN_RelatorioClienteBuscar.UseVisualStyleBackColor = true;
            this.BTN_RelatorioClienteBuscar.Click += new System.EventHandler(this.BTN_RelatorioClienteBuscar_Click);
            // 
            // LBL_RelatorioClienteBuscar
            // 
            this.LBL_RelatorioClienteBuscar.AutoSize = true;
            this.LBL_RelatorioClienteBuscar.Location = new System.Drawing.Point(188, 70);
            this.LBL_RelatorioClienteBuscar.Name = "LBL_RelatorioClienteBuscar";
            this.LBL_RelatorioClienteBuscar.Size = new System.Drawing.Size(40, 13);
            this.LBL_RelatorioClienteBuscar.TabIndex = 3;
            this.LBL_RelatorioClienteBuscar.Text = "Buscar";
            // 
            // TXTBOX_RelatorioNome
            // 
            this.TXTBOX_RelatorioNome.Location = new System.Drawing.Point(18, 145);
            this.TXTBOX_RelatorioNome.Name = "TXTBOX_RelatorioNome";
            this.TXTBOX_RelatorioNome.ReadOnly = true;
            this.TXTBOX_RelatorioNome.Size = new System.Drawing.Size(306, 20);
            this.TXTBOX_RelatorioNome.TabIndex = 4;
            // 
            // LBL_RelatorioClienteNome
            // 
            this.LBL_RelatorioClienteNome.AutoSize = true;
            this.LBL_RelatorioClienteNome.Location = new System.Drawing.Point(17, 130);
            this.LBL_RelatorioClienteNome.Name = "LBL_RelatorioClienteNome";
            this.LBL_RelatorioClienteNome.Size = new System.Drawing.Size(82, 13);
            this.LBL_RelatorioClienteNome.TabIndex = 5;
            this.LBL_RelatorioClienteNome.Text = "Nome do Titular";
            // 
            // TXTBOX_RelatorioclienteDataNasc
            // 
            this.TXTBOX_RelatorioclienteDataNasc.Location = new System.Drawing.Point(17, 202);
            this.TXTBOX_RelatorioclienteDataNasc.Name = "TXTBOX_RelatorioclienteDataNasc";
            this.TXTBOX_RelatorioclienteDataNasc.ReadOnly = true;
            this.TXTBOX_RelatorioclienteDataNasc.Size = new System.Drawing.Size(129, 20);
            this.TXTBOX_RelatorioclienteDataNasc.TabIndex = 6;
            // 
            // LBL_RelatorioClienteDataNasc
            // 
            this.LBL_RelatorioClienteDataNasc.AutoSize = true;
            this.LBL_RelatorioClienteDataNasc.Location = new System.Drawing.Point(16, 187);
            this.LBL_RelatorioClienteDataNasc.Name = "LBL_RelatorioClienteDataNasc";
            this.LBL_RelatorioClienteDataNasc.Size = new System.Drawing.Size(104, 13);
            this.LBL_RelatorioClienteDataNasc.TabIndex = 7;
            this.LBL_RelatorioClienteDataNasc.Text = "Data de Nascimento";
            // 
            // TXTBOX_RelatorioClienteCpf
            // 
            this.TXTBOX_RelatorioClienteCpf.Location = new System.Drawing.Point(18, 252);
            this.TXTBOX_RelatorioClienteCpf.Name = "TXTBOX_RelatorioClienteCpf";
            this.TXTBOX_RelatorioClienteCpf.ReadOnly = true;
            this.TXTBOX_RelatorioClienteCpf.Size = new System.Drawing.Size(166, 20);
            this.TXTBOX_RelatorioClienteCpf.TabIndex = 8;
            // 
            // LBL_RelatorioClienteCpf
            // 
            this.LBL_RelatorioClienteCpf.AutoSize = true;
            this.LBL_RelatorioClienteCpf.Location = new System.Drawing.Point(18, 237);
            this.LBL_RelatorioClienteCpf.Name = "LBL_RelatorioClienteCpf";
            this.LBL_RelatorioClienteCpf.Size = new System.Drawing.Size(27, 13);
            this.LBL_RelatorioClienteCpf.TabIndex = 9;
            this.LBL_RelatorioClienteCpf.Text = "CPF";
            // 
            // TXTBOX_RelatorioClienteEndereco
            // 
            this.TXTBOX_RelatorioClienteEndereco.Location = new System.Drawing.Point(17, 309);
            this.TXTBOX_RelatorioClienteEndereco.Name = "TXTBOX_RelatorioClienteEndereco";
            this.TXTBOX_RelatorioClienteEndereco.ReadOnly = true;
            this.TXTBOX_RelatorioClienteEndereco.Size = new System.Drawing.Size(381, 20);
            this.TXTBOX_RelatorioClienteEndereco.TabIndex = 10;
            // 
            // LBL_RelatorioClienteEndereco
            // 
            this.LBL_RelatorioClienteEndereco.AutoSize = true;
            this.LBL_RelatorioClienteEndereco.Location = new System.Drawing.Point(14, 294);
            this.LBL_RelatorioClienteEndereco.Name = "LBL_RelatorioClienteEndereco";
            this.LBL_RelatorioClienteEndereco.Size = new System.Drawing.Size(53, 13);
            this.LBL_RelatorioClienteEndereco.TabIndex = 11;
            this.LBL_RelatorioClienteEndereco.Text = "Endereço";
            // 
            // TXTBOX_RelatorioClienteSaldo
            // 
            this.TXTBOX_RelatorioClienteSaldo.Location = new System.Drawing.Point(17, 365);
            this.TXTBOX_RelatorioClienteSaldo.Name = "TXTBOX_RelatorioClienteSaldo";
            this.TXTBOX_RelatorioClienteSaldo.ReadOnly = true;
            this.TXTBOX_RelatorioClienteSaldo.Size = new System.Drawing.Size(129, 20);
            this.TXTBOX_RelatorioClienteSaldo.TabIndex = 12;
            // 
            // LBL_RelatorioClienteSaldo
            // 
            this.LBL_RelatorioClienteSaldo.AutoSize = true;
            this.LBL_RelatorioClienteSaldo.Location = new System.Drawing.Point(15, 350);
            this.LBL_RelatorioClienteSaldo.Name = "LBL_RelatorioClienteSaldo";
            this.LBL_RelatorioClienteSaldo.Size = new System.Drawing.Size(82, 13);
            this.LBL_RelatorioClienteSaldo.TabIndex = 13;
            this.LBL_RelatorioClienteSaldo.Text = "Saldo em Conta";
            // 
            // BTN_RelatorioClienteLimpar
            // 
            this.BTN_RelatorioClienteLimpar.Image = global::Banco_Sul.Properties.Resources.borracha__1_;
            this.BTN_RelatorioClienteLimpar.Location = new System.Drawing.Point(88, 406);
            this.BTN_RelatorioClienteLimpar.Name = "BTN_RelatorioClienteLimpar";
            this.BTN_RelatorioClienteLimpar.Size = new System.Drawing.Size(67, 62);
            this.BTN_RelatorioClienteLimpar.TabIndex = 14;
            this.BTN_RelatorioClienteLimpar.UseVisualStyleBackColor = true;
            this.BTN_RelatorioClienteLimpar.Click += new System.EventHandler(this.BTN_RelatorioClienteLimpar_Click);
            // 
            // LBL_RelatorioClienteLimpar
            // 
            this.LBL_RelatorioClienteLimpar.AutoSize = true;
            this.LBL_RelatorioClienteLimpar.Location = new System.Drawing.Point(103, 469);
            this.LBL_RelatorioClienteLimpar.Name = "LBL_RelatorioClienteLimpar";
            this.LBL_RelatorioClienteLimpar.Size = new System.Drawing.Size(38, 13);
            this.LBL_RelatorioClienteLimpar.TabIndex = 15;
            this.LBL_RelatorioClienteLimpar.Text = "Limpar";
            // 
            // BTN_RelatorioClienteCancelar
            // 
            this.BTN_RelatorioClienteCancelar.Image = global::Banco_Sul.Properties.Resources.cancelar__2_;
            this.BTN_RelatorioClienteCancelar.Location = new System.Drawing.Point(247, 408);
            this.BTN_RelatorioClienteCancelar.Name = "BTN_RelatorioClienteCancelar";
            this.BTN_RelatorioClienteCancelar.Size = new System.Drawing.Size(68, 62);
            this.BTN_RelatorioClienteCancelar.TabIndex = 16;
            this.BTN_RelatorioClienteCancelar.UseVisualStyleBackColor = true;
            this.BTN_RelatorioClienteCancelar.Click += new System.EventHandler(this.BTN_RelatorioClienteCancelar_Click);
            // 
            // LBL_RelatorioClienteCancelar
            // 
            this.LBL_RelatorioClienteCancelar.AutoSize = true;
            this.LBL_RelatorioClienteCancelar.Location = new System.Drawing.Point(258, 471);
            this.LBL_RelatorioClienteCancelar.Name = "LBL_RelatorioClienteCancelar";
            this.LBL_RelatorioClienteCancelar.Size = new System.Drawing.Size(49, 13);
            this.LBL_RelatorioClienteCancelar.TabIndex = 17;
            this.LBL_RelatorioClienteCancelar.Text = "Cancelar";
            // 
            // RelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 524);
            this.Controls.Add(this.GROUPBOX_RelatorioCliente);
            this.Name = "RelatorioCliente";
            this.Text = "RelatorioCliente";
            this.GROUPBOX_RelatorioCliente.ResumeLayout(false);
            this.GROUPBOX_RelatorioCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_RelatorioCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GROUPBOX_RelatorioCliente;
        private System.Windows.Forms.Button BTN_RelatorioClienteBuscar;
        private System.Windows.Forms.NumericUpDown NUMBOX_RelatorioCliente;
        private System.Windows.Forms.Label LBL_RelatorioCliente_Cdcliente;
        private System.Windows.Forms.Label LBL_RelatorioClienteSaldo;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioClienteSaldo;
        private System.Windows.Forms.Label LBL_RelatorioClienteEndereco;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioClienteEndereco;
        private System.Windows.Forms.Label LBL_RelatorioClienteCpf;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioClienteCpf;
        private System.Windows.Forms.Label LBL_RelatorioClienteDataNasc;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioclienteDataNasc;
        private System.Windows.Forms.Label LBL_RelatorioClienteNome;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioNome;
        private System.Windows.Forms.Label LBL_RelatorioClienteBuscar;
        private System.Windows.Forms.Label LBL_RelatorioClienteCancelar;
        private System.Windows.Forms.Button BTN_RelatorioClienteCancelar;
        private System.Windows.Forms.Label LBL_RelatorioClienteLimpar;
        private System.Windows.Forms.Button BTN_RelatorioClienteLimpar;
    }
}