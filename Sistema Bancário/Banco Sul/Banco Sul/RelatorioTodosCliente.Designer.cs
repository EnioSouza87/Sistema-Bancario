namespace Banco_Sul
{
    partial class RelatorioTodosCliente
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
            this.LBL_RelatorioGeralTitulo = new System.Windows.Forms.Label();
            this.TXTBOX_RelatorioGeralDisplay = new System.Windows.Forms.TextBox();
            this.BTN_RelatorioGeralLimpar = new System.Windows.Forms.Button();
            this.BTN_RelatorioGeralCancelar = new System.Windows.Forms.Button();
            this.LBL_RelatorioGeralId = new System.Windows.Forms.Label();
            this.LBL_RelatorioGeralNome = new System.Windows.Forms.Label();
            this.LBL_RelatorioGeralDataNasc = new System.Windows.Forms.Label();
            this.LBL_RelatorioGeralCPF = new System.Windows.Forms.Label();
            this.LBL_RelatorioGeralEndereco = new System.Windows.Forms.Label();
            this.LBL_RelatorioGeralSaldo = new System.Windows.Forms.Label();
            this.LBL_RelatorioGeralListar = new System.Windows.Forms.Label();
            this.LBL_RelatorioGeralLimpar = new System.Windows.Forms.Label();
            this.LBL_RelatorioGeralCancelar = new System.Windows.Forms.Label();
            this.BTN_RelatorioGeralListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_RelatorioGeralTitulo
            // 
            this.LBL_RelatorioGeralTitulo.AutoSize = true;
            this.LBL_RelatorioGeralTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RelatorioGeralTitulo.Location = new System.Drawing.Point(24, 42);
            this.LBL_RelatorioGeralTitulo.Name = "LBL_RelatorioGeralTitulo";
            this.LBL_RelatorioGeralTitulo.Size = new System.Drawing.Size(202, 17);
            this.LBL_RelatorioGeralTitulo.TabIndex = 0;
            this.LBL_RelatorioGeralTitulo.Text = "RELATÓRIO DE CLIENTES";
            // 
            // TXTBOX_RelatorioGeralDisplay
            // 
            this.TXTBOX_RelatorioGeralDisplay.Location = new System.Drawing.Point(27, 86);
            this.TXTBOX_RelatorioGeralDisplay.Multiline = true;
            this.TXTBOX_RelatorioGeralDisplay.Name = "TXTBOX_RelatorioGeralDisplay";
            this.TXTBOX_RelatorioGeralDisplay.Size = new System.Drawing.Size(745, 330);
            this.TXTBOX_RelatorioGeralDisplay.TabIndex = 2;
            // 
            // BTN_RelatorioGeralLimpar
            // 
            this.BTN_RelatorioGeralLimpar.Image = global::Banco_Sul.Properties.Resources.borracha__1_;
            this.BTN_RelatorioGeralLimpar.Location = new System.Drawing.Point(454, 13);
            this.BTN_RelatorioGeralLimpar.Name = "BTN_RelatorioGeralLimpar";
            this.BTN_RelatorioGeralLimpar.Size = new System.Drawing.Size(63, 55);
            this.BTN_RelatorioGeralLimpar.TabIndex = 3;
            this.BTN_RelatorioGeralLimpar.UseVisualStyleBackColor = true;
            this.BTN_RelatorioGeralLimpar.Click += new System.EventHandler(this.BTN_RelatorioGeralLimpar_Click);
            // 
            // BTN_RelatorioGeralCancelar
            // 
            this.BTN_RelatorioGeralCancelar.Image = global::Banco_Sul.Properties.Resources.cancelar__2_;
            this.BTN_RelatorioGeralCancelar.Location = new System.Drawing.Point(541, 14);
            this.BTN_RelatorioGeralCancelar.Name = "BTN_RelatorioGeralCancelar";
            this.BTN_RelatorioGeralCancelar.Size = new System.Drawing.Size(60, 54);
            this.BTN_RelatorioGeralCancelar.TabIndex = 4;
            this.BTN_RelatorioGeralCancelar.UseVisualStyleBackColor = true;
            this.BTN_RelatorioGeralCancelar.Click += new System.EventHandler(this.BTN_RelatorioGeralCancelar_Click);
            // 
            // LBL_RelatorioGeralId
            // 
            this.LBL_RelatorioGeralId.AutoSize = true;
            this.LBL_RelatorioGeralId.Location = new System.Drawing.Point(36, 91);
            this.LBL_RelatorioGeralId.Name = "LBL_RelatorioGeralId";
            this.LBL_RelatorioGeralId.Size = new System.Drawing.Size(18, 13);
            this.LBL_RelatorioGeralId.TabIndex = 5;
            this.LBL_RelatorioGeralId.Text = "ID";
            // 
            // LBL_RelatorioGeralNome
            // 
            this.LBL_RelatorioGeralNome.AutoSize = true;
            this.LBL_RelatorioGeralNome.Location = new System.Drawing.Point(96, 91);
            this.LBL_RelatorioGeralNome.Name = "LBL_RelatorioGeralNome";
            this.LBL_RelatorioGeralNome.Size = new System.Drawing.Size(53, 13);
            this.LBL_RelatorioGeralNome.TabIndex = 6;
            this.LBL_RelatorioGeralNome.Text = "TITULAR";
            // 
            // LBL_RelatorioGeralDataNasc
            // 
            this.LBL_RelatorioGeralDataNasc.AutoSize = true;
            this.LBL_RelatorioGeralDataNasc.Location = new System.Drawing.Point(202, 91);
            this.LBL_RelatorioGeralDataNasc.Name = "LBL_RelatorioGeralDataNasc";
            this.LBL_RelatorioGeralDataNasc.Size = new System.Drawing.Size(65, 13);
            this.LBL_RelatorioGeralDataNasc.TabIndex = 7;
            this.LBL_RelatorioGeralDataNasc.Text = "DATANASC";
            // 
            // LBL_RelatorioGeralCPF
            // 
            this.LBL_RelatorioGeralCPF.AutoSize = true;
            this.LBL_RelatorioGeralCPF.Location = new System.Drawing.Point(332, 91);
            this.LBL_RelatorioGeralCPF.Name = "LBL_RelatorioGeralCPF";
            this.LBL_RelatorioGeralCPF.Size = new System.Drawing.Size(27, 13);
            this.LBL_RelatorioGeralCPF.TabIndex = 8;
            this.LBL_RelatorioGeralCPF.Text = "CPF";
            // 
            // LBL_RelatorioGeralEndereco
            // 
            this.LBL_RelatorioGeralEndereco.AutoSize = true;
            this.LBL_RelatorioGeralEndereco.Location = new System.Drawing.Point(451, 89);
            this.LBL_RelatorioGeralEndereco.Name = "LBL_RelatorioGeralEndereco";
            this.LBL_RelatorioGeralEndereco.Size = new System.Drawing.Size(53, 13);
            this.LBL_RelatorioGeralEndereco.TabIndex = 9;
            this.LBL_RelatorioGeralEndereco.Text = "Endereço";
            // 
            // LBL_RelatorioGeralSaldo
            // 
            this.LBL_RelatorioGeralSaldo.AutoSize = true;
            this.LBL_RelatorioGeralSaldo.Location = new System.Drawing.Point(629, 91);
            this.LBL_RelatorioGeralSaldo.Name = "LBL_RelatorioGeralSaldo";
            this.LBL_RelatorioGeralSaldo.Size = new System.Drawing.Size(43, 13);
            this.LBL_RelatorioGeralSaldo.TabIndex = 10;
            this.LBL_RelatorioGeralSaldo.Text = "SALDO";
            // 
            // LBL_RelatorioGeralListar
            // 
            this.LBL_RelatorioGeralListar.AutoSize = true;
            this.LBL_RelatorioGeralListar.Location = new System.Drawing.Point(374, 68);
            this.LBL_RelatorioGeralListar.Name = "LBL_RelatorioGeralListar";
            this.LBL_RelatorioGeralListar.Size = new System.Drawing.Size(32, 13);
            this.LBL_RelatorioGeralListar.TabIndex = 11;
            this.LBL_RelatorioGeralListar.Text = "Listar";
            // 
            // LBL_RelatorioGeralLimpar
            // 
            this.LBL_RelatorioGeralLimpar.AutoSize = true;
            this.LBL_RelatorioGeralLimpar.Location = new System.Drawing.Point(467, 68);
            this.LBL_RelatorioGeralLimpar.Name = "LBL_RelatorioGeralLimpar";
            this.LBL_RelatorioGeralLimpar.Size = new System.Drawing.Size(38, 13);
            this.LBL_RelatorioGeralLimpar.TabIndex = 12;
            this.LBL_RelatorioGeralLimpar.Text = "Limpar";
            // 
            // LBL_RelatorioGeralCancelar
            // 
            this.LBL_RelatorioGeralCancelar.AutoSize = true;
            this.LBL_RelatorioGeralCancelar.Location = new System.Drawing.Point(548, 68);
            this.LBL_RelatorioGeralCancelar.Name = "LBL_RelatorioGeralCancelar";
            this.LBL_RelatorioGeralCancelar.Size = new System.Drawing.Size(49, 13);
            this.LBL_RelatorioGeralCancelar.TabIndex = 13;
            this.LBL_RelatorioGeralCancelar.Text = "Cancelar";
            // 
            // BTN_RelatorioGeralListar
            // 
            this.BTN_RelatorioGeralListar.Image = global::Banco_Sul.Properties.Resources.buscar__1_;
            this.BTN_RelatorioGeralListar.Location = new System.Drawing.Point(363, 12);
            this.BTN_RelatorioGeralListar.Name = "BTN_RelatorioGeralListar";
            this.BTN_RelatorioGeralListar.Size = new System.Drawing.Size(57, 55);
            this.BTN_RelatorioGeralListar.TabIndex = 2;
            this.BTN_RelatorioGeralListar.UseVisualStyleBackColor = true;
            this.BTN_RelatorioGeralListar.Click += new System.EventHandler(this.BTN_RelatorioGeralListar_Click);
            // 
            // RelatorioTodosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.LBL_RelatorioGeralCancelar);
            this.Controls.Add(this.LBL_RelatorioGeralLimpar);
            this.Controls.Add(this.LBL_RelatorioGeralListar);
            this.Controls.Add(this.LBL_RelatorioGeralSaldo);
            this.Controls.Add(this.LBL_RelatorioGeralEndereco);
            this.Controls.Add(this.LBL_RelatorioGeralCPF);
            this.Controls.Add(this.LBL_RelatorioGeralDataNasc);
            this.Controls.Add(this.LBL_RelatorioGeralNome);
            this.Controls.Add(this.LBL_RelatorioGeralId);
            this.Controls.Add(this.BTN_RelatorioGeralCancelar);
            this.Controls.Add(this.BTN_RelatorioGeralLimpar);
            this.Controls.Add(this.BTN_RelatorioGeralListar);
            this.Controls.Add(this.TXTBOX_RelatorioGeralDisplay);
            this.Controls.Add(this.LBL_RelatorioGeralTitulo);
            this.Name = "RelatorioTodosCliente";
            this.Text = "RelatorioTodosCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_RelatorioGeralTitulo;
        private System.Windows.Forms.TextBox TXTBOX_RelatorioGeralDisplay;
        private System.Windows.Forms.Button BTN_RelatorioGeralListar;
        private System.Windows.Forms.Button BTN_RelatorioGeralLimpar;
        private System.Windows.Forms.Button BTN_RelatorioGeralCancelar;
        private System.Windows.Forms.Label LBL_RelatorioGeralId;
        private System.Windows.Forms.Label LBL_RelatorioGeralNome;
        private System.Windows.Forms.Label LBL_RelatorioGeralDataNasc;
        private System.Windows.Forms.Label LBL_RelatorioGeralCPF;
        private System.Windows.Forms.Label LBL_RelatorioGeralEndereco;
        private System.Windows.Forms.Label LBL_RelatorioGeralSaldo;
        private System.Windows.Forms.Label LBL_RelatorioGeralListar;
        private System.Windows.Forms.Label LBL_RelatorioGeralLimpar;
        private System.Windows.Forms.Label LBL_RelatorioGeralCancelar;
    }
}