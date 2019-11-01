using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Banco_Sul
{
    public partial class RelatorioCliente : Form
    {
        MySqlConnection conexao;
        Cliente cliente;
        public RelatorioCliente()
        {
            InitializeComponent();
            conexao = new MySqlConnection("Server = localhost; port = 3306; database = dbbank; user = root; password = ''");
            cliente = new Cliente();
        }

        private void BTN_RelatorioClienteCancelar_Click(object sender, EventArgs e)
        {
            //indiquei para o botão cancelar realizar sempre uma confirmação se realmente o usuário quer cancelar
            DialogResult opcao = MessageBox.Show("Deseja Realmente cancelar a ação?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //usei a condicional para verificar a resposta do usuário
            if (opcao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BTN_RelatorioClienteLimpar_Click(object sender, EventArgs e)
        {
            DialogResult opcao = MessageBox.Show("Deseja Realmente Limpar os Campos?", "Confirmação",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //usei a condicional para verificar a resposta do usuário
            if (opcao == DialogResult.Yes)
            {
                TXTBOX_RelatorioClienteNome.Text = "";
                TXTBOX_RelatorioClienteDataNasc.Text = "";
                TXTBOX_RelatorioClienteCPF.Text = "";
                TXTBOX_RelatorioClienteEndereco.Text = "";
                TXTBOX_RelatorioClienteSaldo.Text = "";
            }
        }

        private void BTN_relatorioClienteBuscar_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader = null;

            try
            {
                conexao.Open();
                cliente.IdCliente = Convert.ToInt32(NUMBOX_RelatorioClientecdCliente.Value);
                sql = "SELECT * FROM clientes WHERE id_cliente = " + cliente.IdCliente + ";";
                MySqlCommand query = new MySqlCommand(sql, conexao);

                reader = query.ExecuteReader();
                if (reader.Read())
                {
                    TXTBOX_RelatorioClienteNome.Text = Convert.ToString(reader[1]);
                    TXTBOX_RelatorioClienteDataNasc.Text = Convert.ToString(reader[2]);
                    TXTBOX_RelatorioClienteCPF.Text = Convert.ToString(reader[3]);
                    TXTBOX_RelatorioClienteEndereco.Text = Convert.ToString(reader[4]);
                    TXTBOX_RelatorioClienteSaldo.Text = Convert.ToString(reader[5]);

                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!!!");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO!(" + ex.Number + "): " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
