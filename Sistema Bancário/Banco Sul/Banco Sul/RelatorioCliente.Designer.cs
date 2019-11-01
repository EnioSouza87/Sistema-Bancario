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
            this.GROUPBOX_RelatorioCLiente = new System.Windows.Forms.GroupBox();
            this.LBL_RelatorioClienteCdCliente = new System.Windows.Forms.Label();
            this.NUMBOX_RelatorioClientecdCliente = new System.Windows.Forms.NumericUpDown();
            this.BTN_relatorioClienteBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_relatorioClienteNome = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioClienteNome = new System.Windows.Forms.TextBox();
            this.LBL_RelatorioClienteDataNasc = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioClienteDataNasc = new System.Windows.Forms.TextBox();
            this.LBL_relatorioClienteCPF = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioClienteCPF = new System.Windows.Forms.TextBox();
            this.LBL_RelatorioClienteEndereco = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioClienteEndereco = new System.Windows.Forms.TextBox();
            this.LBL_RelatorioClienteSaldo = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioClienteSaldo = new System.Windows.Forms.TextBox();
            this.BTN_RelatorioClienteLimpar = new System.Windows.Forms.Button();
            this.BTN_RelatorioClienteCancelar = new System.Windows.Forms.Button();
            this.LBL_RelatorioClienteLimpar = new System.Windows.Forms.Label();
            this.LBL_RelatorioClienteCancelar = new System.Windows.Forms.Label();
            this.GROUPBOX_RelatorioCLiente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_RelatorioClientecdCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GROUPBOX_RelatorioCLiente
            // 
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.LBL_RelatorioClienteCancelar);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.LBL_RelatorioClienteLimpar);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.BTN_RelatorioClienteCancelar);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.BTN_RelatorioClienteLimpar);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.TXTBOX_RelatorioClienteSaldo);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.LBL_RelatorioClienteSaldo);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.TXTBOX_RelatorioClienteEndereco);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.LBL_RelatorioClienteEndereco);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.TXTBOX_RelatorioClienteCPF);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.LBL_relatorioClienteCPF);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.TXTBOX_RelatorioClienteDataNasc);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.LBL_RelatorioClienteDataNasc);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.TXTBOX_RelatorioClienteNome);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.LBL_relatorioClienteNome);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.label1);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.BTN_relatorioClienteBuscar);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.NUMBOX_RelatorioClientecdCliente);
            this.GROUPBOX_RelatorioCLiente.Controls.Add(this.LBL_RelatorioClienteCdCliente);
            this.GROUPBOX_RelatorioCLiente.Location = new System.Drawing.Point(12, 12);
            this.GROUPBOX_RelatorioCLiente.Name = "GROUPBOX_RelatorioCLiente";
            this.GROUPBOX_RelatorioCLiente.Size = new System.Drawing.Size(379, 428);
            this.GROUPBOX_RelatorioCLiente.TabIndex = 0;
            this.GROUPBOX_RelatorioCLiente.TabStop = false;
            this.GROUPBOX_RelatorioCLiente.Text = "Relatório Por Cliente";
            // 
            // LBL_RelatorioClienteCdCliente
            // 
            this.LBL_RelatorioClienteCdCliente.AutoSize = true;
            this.LBL_RelatorioClienteCdCliente.Location = new System.Drawing.Point(16, 30);
            this.LBL_RelatorioClienteCdCliente.Name = "LBL_RelatorioClienteCdCliente";
            this.LBL_RelatorioClienteCdCliente.Size = new System.Drawing.Size(90, 13);
            this.LBL_RelatorioClienteCdCliente.TabIndex = 0;
            this.LBL_RelatorioClienteCdCliente.Text = "Código do Cliente";
            // 
            // NUMBOX_RelatorioClientecdCliente
            // 
            this.NUMBOX_RelatorioClientecdCliente.Location = new System.Drawing.Point(19, 47);
            this.NUMBOX_RelatorioClientecdCliente.Name = "NUMBOX_RelatorioClientecdCliente";
            this.NUMBOX_RelatorioClientecdCliente.Size = new System.Drawing.Size(87, 20);
            this.NUMBOX_RelatorioClientecdCliente.TabIndex = 1;
            // 
            // BTN_relatorioClienteBuscar
            // 
            this.BTN_relatorioClienteBuscar.Image = global::Banco_Sul.Properties.Resources.buscar__1_;
            this.BTN_relatorioClienteBuscar.Location = new System.Drawing.Point(112, 39);
            this.BTN_relatorioClienteBuscar.Name = "BTN_relatorioClienteBuscar";
            this.BTN_relatorioClienteBuscar.Size = new System.Drawing.Size(35, 32);
            this.BTN_relatorioClienteBuscar.TabIndex = 2;
            this.BTN_relatorioClienteBuscar.UseVisualStyleBackColor = true;
            this.BTN_relatorioClienteBuscar.Click += new System.EventHandler(this.BTN_relatorioClienteBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informações do Titular";
            // 
            // LBL_relatorioClienteNome
            // 
            this.LBL_relatorioClienteNome.AutoSize = true;
            this.LBL_relatorioClienteNome.Location = new System.Drawing.Point(16, 130);
            this.LBL_relatorioClienteNome.Name = "LBL_relatorioClienteNome";
            this.LBL_relatorioClienteNome.Size = new System.Drawing.Size(82, 13);
            this.LBL_relatorioClienteNome.TabIndex = 4;
            this.LBL_relatorioClienteNome.Text = "Nome do Titular";
            // 
            // TXTBOX_RelatorioClienteNome
            // 
            this.TXTBOX_RelatorioClienteNome.Location = new System.Drawing.Point(19, 147);
            this.TXTBOX_RelatorioClienteNome.Name = "TXTBOX_RelatorioClienteNome";
            this.TXTBOX_RelatorioClienteNome.ReadOnly = true;
            this.TXTBOX_RelatorioClienteNome.Size = new System.Drawing.Size(335, 20);
            this.TXTBOX_RelatorioClienteNome.TabIndex = 5;
            // 
            // LBL_RelatorioClienteDataNasc
            // 
            this.LBL_RelatorioClienteDataNasc.AutoSize = true;
            this.LBL_RelatorioClienteDataNasc.Location = new System.Drawing.Point(15, 184);
            this.LBL_RelatorioClienteDataNasc.Name = "LBL_RelatorioClienteDataNasc";
            this.LBL_RelatorioClienteDataNasc.Size = new System.Drawing.Size(104, 13);
            this.LBL_RelatorioClienteDataNasc.TabIndex = 6;
            this.LBL_RelatorioClienteDataNasc.Text = "Data de Nascimento";
            // 
            // TXTBOX_RelatorioClienteDataNasc
            // 
            this.TXTBOX_RelatorioClienteDataNasc.Location = new System.Drawing.Point(19, 200);
            this.TXTBOX_RelatorioClienteDataNasc.Name = "TXTBOX_RelatorioClienteDataNasc";
            this.TXTBOX_RelatorioClienteDataNasc.ReadOnly = true;
            this.TXTBOX_RelatorioClienteDataNasc.Size = new System.Drawing.Size(114, 20);
            this.TXTBOX_RelatorioClienteDataNasc.TabIndex = 7;
            // 
            // LBL_relatorioClienteCPF
            // 
            this.LBL_relatorioClienteCPF.AutoSize = true;
            this.LBL_relatorioClienteCPF.Location = new System.Drawing.Point(209, 184);
            this.LBL_relatorioClienteCPF.Name = "LBL_relatorioClienteCPF";
            this.LBL_relatorioClienteCPF.Size = new System.Drawing.Size(27, 13);
            this.LBL_relatorioClienteCPF.TabIndex = 8;
            this.LBL_relatorioClienteCPF.Text = "CPF";
            // 
            // TXTBOX_RelatorioClienteCPF
            // 
            this.TXTBOX_RelatorioClienteCPF.Location = new System.Drawing.Point(212, 200);
            this.TXTBOX_RelatorioClienteCPF.Name = "TXTBOX_RelatorioClienteCPF";
            this.TXTBOX_RelatorioClienteCPF.ReadOnly = true;
            this.TXTBOX_RelatorioClienteCPF.Size = new System.Drawing.Size(142, 20);
            this.TXTBOX_RelatorioClienteCPF.TabIndex = 9;
            // 
            // LBL_RelatorioClienteEndereco
            // 
            this.LBL_RelatorioClienteEndereco.AutoSize = true;
            this.LBL_RelatorioClienteEndereco.Location = new System.Drawing.Point(19, 240);
            this.LBL_RelatorioClienteEndereco.Name = "LBL_RelatorioClienteEndereco";
            this.LBL_RelatorioClienteEndereco.Size = new System.Drawing.Size(53, 13);
            this.LBL_RelatorioClienteEndereco.TabIndex = 10;
            this.LBL_RelatorioClienteEndereco.Text = "Endereço";
            // 
            // TXTBOX_RelatorioClienteEndereco
            // 
            this.TXTBOX_RelatorioClienteEndereco.Location = new System.Drawing.Point(22, 257);
            this.TXTBOX_RelatorioClienteEndereco.Name = "TXTBOX_RelatorioClienteEndereco";
            this.TXTBOX_RelatorioClienteEndereco.ReadOnly = true;
            this.TXTBOX_RelatorioClienteEndereco.Size = new System.Drawing.Size(332, 20);
            this.TXTBOX_RelatorioClienteEndereco.TabIndex = 11;
            // 
            // LBL_RelatorioClienteSaldo
            // 
            this.LBL_RelatorioClienteSaldo.AutoSize = true;
            this.LBL_RelatorioClienteSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RelatorioClienteSaldo.Location = new System.Drawing.Point(137, 291);
            this.LBL_RelatorioClienteSaldo.Name = "LBL_RelatorioClienteSaldo";
            this.LBL_RelatorioClienteSaldo.Size = new System.Drawing.Size(95, 15);
            this.LBL_RelatorioClienteSaldo.TabIndex = 12;
            this.LBL_RelatorioClienteSaldo.Text = "Saldo em Conta";
            // 
            // TXTBOX_RelatorioClienteSaldo
            // 
            this.TXTBOX_RelatorioClienteSaldo.Location = new System.Drawing.Point(112, 309);
            this.TXTBOX_RelatorioClienteSaldo.Name = "TXTBOX_RelatorioClienteSaldo";
            this.TXTBOX_RelatorioClienteSaldo.ReadOnly = true;
            this.TXTBOX_RelatorioClienteSaldo.Size = new System.Drawing.Size(142, 20);
            this.TXTBOX_RelatorioClienteSaldo.TabIndex = 13;
            // 
            // BTN_RelatorioClienteLimpar
            // 
            this.BTN_RelatorioClienteLimpar.Image = global::Banco_Sul.Properties.Resources.borracha__1_;
            this.BTN_RelatorioClienteLimpar.Location = new System.Drawing.Point(85, 344);
            this.BTN_RelatorioClienteLimpar.Name = "BTN_RelatorioClienteLimpar";
            this.BTN_RelatorioClienteLimpar.Size = new System.Drawing.Size(62, 50);
            this.BTN_RelatorioClienteLimpar.TabIndex = 14;
            this.BTN_RelatorioClienteLimpar.UseVisualStyleBackColor = true;
            this.BTN_RelatorioClienteLimpar.Click += new System.EventHandler(this.BTN_RelatorioClienteLimpar_Click);
            // 
            // BTN_RelatorioClienteCancelar
            // 
            this.BTN_RelatorioClienteCancelar.Image = global::Banco_Sul.Properties.Resources.cancelar__2_;
            this.BTN_RelatorioClienteCancelar.Location = new System.Drawing.Point(231, 344);
            this.BTN_RelatorioClienteCancelar.Name = "BTN_RelatorioClienteCancelar";
            this.BTN_RelatorioClienteCancelar.Size = new System.Drawing.Size(55, 50);
            this.BTN_RelatorioClienteCancelar.TabIndex = 15;
            this.BTN_RelatorioClienteCancelar.UseVisualStyleBackColor = true;
            this.BTN_RelatorioClienteCancelar.Click += new System.EventHandler(this.BTN_RelatorioClienteCancelar_Click);
            // 
            // LBL_RelatorioClienteLimpar
            // 
            this.LBL_RelatorioClienteLimpar.AutoSize = true;
            this.LBL_RelatorioClienteLimpar.Location = new System.Drawing.Point(98, 395);
            this.LBL_RelatorioClienteLimpar.Name = "LBL_RelatorioClienteLimpar";
            this.LBL_RelatorioClienteLimpar.Size = new System.Drawing.Size(38, 13);
            this.LBL_RelatorioClienteLimpar.TabIndex = 16;
            this.LBL_RelatorioClienteLimpar.Text = "Limpar";
            // 
            // LBL_RelatorioClienteCancelar
            // 
            this.LBL_RelatorioClienteCancelar.AutoSize = true;
            this.LBL_RelatorioClienteCancelar.Location = new System.Drawing.Point(235, 395);
            this.LBL_RelatorioClienteCancelar.Name = "LBL_RelatorioClienteCancelar";
            this.LBL_RelatorioClienteCancelar.Size = new System.Drawing.Size(49, 13);
            this.LBL_RelatorioClienteCancelar.TabIndex = 17;
            this.LBL_RelatorioClienteCancelar.Text = "Cancelar";
            // 
            // RelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 488);
            this.Controls.Add(this.GROUPBOX_RelatorioCLiente);
            this.Name = "RelatorioCliente";
            this.Text = "RelatorioCliente";
            this.GROUPBOX_RelatorioCLiente.ResumeLayout(false);
            this.GROUPBOX_RelatorioCLiente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMBOX_RelatorioClientecdCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GROUPBOX_RelatorioCLiente;
        private System.Windows.Forms.Button BTN_relatorioClienteBuscar;
        private System.Windows.Forms.NumericUpDown NUMBOX_RelatorioClientecdCliente;
        private System.Windows.Forms.Label LBL_RelatorioClienteCdCliente;
        private System.Windows.Forms.Label LBL_RelatorioClienteCancelar;
        private System.Windows.Forms.Label LBL_RelatorioClienteLimpar;
        private System.Windows.Forms.Button BTN_RelatorioClienteCancelar;
        private System.Windows.Forms.Button BTN_RelatorioClienteLimpar;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioClienteSaldo;
        private System.Windows.Forms.Label LBL_RelatorioClienteSaldo;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioClienteEndereco;
        private System.Windows.Forms.Label LBL_RelatorioClienteEndereco;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioClienteCPF;
        private System.Windows.Forms.Label LBL_relatorioClienteCPF;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioClienteDataNasc;
        private System.Windows.Forms.Label LBL_RelatorioClienteDataNasc;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioClienteNome;
        private System.Windows.Forms.Label LBL_relatorioClienteNome;
        private System.Windows.Forms.Label label1;
    }
}