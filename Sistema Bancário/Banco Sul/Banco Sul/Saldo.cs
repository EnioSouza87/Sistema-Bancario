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
    public partial class Saldo : Form
    {
        MySqlConnection conexao;
        
        Cliente cliente;

        public Saldo()
        {
            InitializeComponent();
            conexao = new MySqlConnection("Server = localhost; port = 3306; database = dbbank; user = root; password = ''");
            
            cliente = new Cliente();
        }

        private void BTN_SaldoBuscar_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader = null;

            try
            {
                conexao.Open();
                cliente.IdCliente = Convert.ToInt32(NUMBOX_SaldoCodCliente.Value);
                sql = "SELECT * FROM clientes WHERE id_cliente = " + cliente.IdCliente + ";";
                MySqlCommand query = new MySqlCommand(sql, conexao);

                reader = query.ExecuteReader();

                if (reader.Read())
                {
                    TXTBOX_SaldoDisplay.Text += "\r\n ID: " + reader[0]; 
                    TXTBOX_SaldoDisplay.Text += "\r\n TITULAR: " + reader[1];
                    TXTBOX_SaldoDisplay.Text += "\r\n SALDO EM CONTA: " + reader[5];
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

        private void BTN_SaldoCancelar_Click(object sender, EventArgs e)
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

        private void BTN_SaldoLimpar_Click(object sender, EventArgs e)
        {
            //indiquei para o botão cancelar realizar sempre uma confirmação se realmente o usuário quer cancelar
            DialogResult opcao = MessageBox.Show("Deseja Realmente Limpar os Campos?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcao == DialogResult.Yes)
            {
                TXTBOX_SaldoDisplay.Text = "";
                NUMBOX_SaldoCodCliente.Value = 0;

            }
        }
    }
}
