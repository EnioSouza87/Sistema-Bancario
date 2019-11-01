using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Sul
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoCliente janelaNovoCliente = new NovoCliente();
            janelaNovoCliente.MdiParent = this;
            janelaNovoCliente.Show();
            janelaNovoCliente.Location = new Point(250,0);

        }

        private void AtualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atualizar janelaAtualizar = new Atualizar();
            janelaAtualizar.MdiParent = this;
            janelaAtualizar.Show();
            janelaAtualizar.Location = new Point(0,0);
        }

        private void ExcluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excluir janelaExcluir = new Excluir();
            janelaExcluir.MdiParent = this;
            janelaExcluir.Show();
            janelaExcluir.Location = new Point(0,0);
        }

        private void saldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saldo janelaSaldo = new Saldo();
            janelaSaldo.MdiParent = this;
            janelaSaldo.Show();
            janelaSaldo.Location = new Point(0,0);
        }

        private void transferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transferencia janelaTransferencia = new Transferencia();
            janelaTransferencia.MdiParent = this;
            janelaTransferencia.Show();
            janelaTransferencia.Location = new Point(0,0);
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saque janelaSaque = new Saque();
            janelaSaque.MdiParent = this;
            janelaSaque.Show();
            janelaSaque.Location = new Point(0,0);
        }

        private void DepósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposito janelaDeposito = new Deposito();
            janelaDeposito.MdiParent = this;
            janelaDeposito.Show();
            janelaDeposito.Location = new Point(0,0);

        }

        private void porClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioCliente janelaRelatorioCliente = new RelatorioCliente();
            janelaRelatorioCliente.MdiParent = this;
            janelaRelatorioCliente.Show();
            janelaRelatorioCliente.Location = new Point(0,0);
        }

        private void TodosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioTodosCliente janelaRelatorioTodosCliente = new RelatorioTodosCliente();
            janelaRelatorioTodosCliente.MdiParent = this;
            janelaRelatorioTodosCliente.Show();
            janelaRelatorioTodosCliente.Location = new Point(0,0);
        }
    }
}
