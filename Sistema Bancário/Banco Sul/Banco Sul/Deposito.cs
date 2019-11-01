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
    public partial class Deposito : Form
    {
        Cliente cliente;
        MySqlConnection conexao;
        double valorDeposito;
        public Deposito()
        {
            InitializeComponent();
            cliente = new Cliente();
            conexao = new MySqlConnection("Server = localhost; port = 3306; database = dbbank; user = root; password = ''");
        }

        private void BTN_DepositoLimpar_Click(object sender, EventArgs e)
        {
            DialogResult opcao = MessageBox.Show("Deseja Realmente Limpar os Campos?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //usei a condicional para verificar a resposta do usuário
            if (opcao == DialogResult.Yes)
            {
                NUMBOX_DepositoCodCliente.Value = 0;
                TXTBOX_depositoDisplay.Text = "";
                NUMBOX_DepositoValor.Value = 0;
            }
        }

        private void BTN_DepositoCancelar_Click(object sender, EventArgs e)
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

        private void BTN_DepositoDepositar_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlCommand update;

                try
                {
                    //indiquei para o botão cancelar realizar sempre uma confirmação se realmente o usuário quer cancelar
                    DialogResult opcao = MessageBox.Show("Deseja Realmente Realizar o Deposito?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opcao == DialogResult.Yes)
                    {
                        conexao.Open();
                        cliente.IdCliente = Convert.ToInt32(NUMBOX_DepositoCodCliente.Value);
                        valorDeposito = Convert.ToDouble(NUMBOX_DepositoValor.Value);
                    cliente.Deposito(valorDeposito);
                            sql = "UPDATE clientes SET saldo_cliente = '" + cliente.Saldo + "'" +
                            "WHERE id_cliente ='" + NUMBOX_DepositoCodCliente.Value + "'";
                            update = new MySqlCommand(sql, conexao);
                            update.ExecuteNonQuery();
                        MessageBox.Show("Deposito Efetuado com Sucesso!");
                    }
                        else
                        {
                            MessageBox.Show("VALOR INCORRETO OU SISTEMA FORA DO AR!");
                        }
                 
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERRO!(" + ex.Number + "): " + ex.Message);
                }
                catch (Exception ex )
                {
                    MessageBox.Show("ERRO!" + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
        }

        private void BTN_DepositoBuscar_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader = null;

            try
            {
                conexao.Open();
                cliente.IdCliente = Convert.ToInt32(NUMBOX_DepositoCodCliente.Value);
                sql = "SELECT * FROM clientes WHERE id_cliente = " + cliente.IdCliente + ";";
                MySqlCommand query = new MySqlCommand(sql, conexao);

                reader = query.ExecuteReader();

                if (reader.Read())
                {
                    TXTBOX_depositoDisplay.Text += "\r\nTitular: " + reader[1]+ " Saldo: " + reader[5];
                    cliente.IdCliente = Convert.ToInt32(reader[0]);
                    cliente.Nome = Convert.ToString(reader[1]);
                    cliente.DataNasc = Convert.ToString(reader[2]);
                    cliente.Cpf = Convert.ToString(reader[3]);
                    cliente.Endereco = Convert.ToString(reader[4]);
                    cliente.Saldo = Convert.ToDouble(reader[5]);


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
