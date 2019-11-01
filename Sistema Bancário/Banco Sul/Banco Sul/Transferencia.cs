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
    public partial class Transferencia : Form
    {
        Cliente clienteOrigem;
        Cliente clienteDestino;
        MySqlConnection conexao;
        double valorTransferencia;
        public Transferencia()
        {
            InitializeComponent();
            conexao = new MySqlConnection("Server = localhost; port = 3306; database = dbbank; user = root; password = ''");
          
            clienteOrigem = new Cliente();
            clienteDestino= new Cliente();
            NUMBOX_TransferirValoraTransferir.Enabled = false;
        }

        private void BTN_TransferenciaCancelar_Click(object sender, EventArgs e)
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

        private void BTN_TransferenciaLimpar_Click(object sender, EventArgs e)
        {
            DialogResult opcao = MessageBox.Show("Deseja Realmente Limpar os Campos?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //usei a condicional para verificar a resposta do usuário
            if (opcao == DialogResult.Yes)
            {
                NUMBOX_TransferenciaCodClienteOrigem.Value = 0;
                NUMBOX_TransferirCodClienteDestino.Value = 0;
                NUMBOX_TransferirValoraTransferir.Value = 0;
                TXTBOX_TransferirDisplayClienteOrigem.Text = "";
                TXTBOX_TransferirDisplayClienteDestino.Text = "";
                NUMBOX_TransferirValoraTransferir.Enabled = false;
            }
        }

        private void BTN_TransferenciaBuscarClientOrigem_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader = null;

            try
            {
                conexao.Open();
                clienteOrigem.IdCliente = Convert.ToInt32(NUMBOX_TransferenciaCodClienteOrigem.Value);
                sql = "SELECT * FROM clientes WHERE id_cliente = " + clienteOrigem.IdCliente + ";";
                MySqlCommand query = new MySqlCommand(sql, conexao);

                reader = query.ExecuteReader();

                if (reader.Read())
                {
                    TXTBOX_TransferirDisplayClienteOrigem.Text += "\r\nID: " + reader[0];
                    TXTBOX_TransferirDisplayClienteOrigem.Text += "\r\nNOME: " + reader[1];
                    TXTBOX_TransferirDisplayClienteOrigem.Text += "\r\nCPF: " + reader[3];
                    TXTBOX_TransferirDisplayClienteOrigem.Text += "\r\nSALDO: " + reader[5];
                    clienteOrigem.Nome = Convert.ToString(reader[1]);
                    clienteOrigem.DataNasc = Convert.ToString(reader[2]);
                    clienteOrigem.Cpf = Convert.ToString(reader[3]);
                    clienteOrigem.Endereco = Convert.ToString(reader[4]);
                    clienteOrigem.Saldo = Convert.ToDouble(reader[5]);


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

        private void BTN_TransferirBuscarClienteDestino_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader = null;

            try
            {
                conexao.Open();
                clienteDestino.IdCliente = Convert.ToInt32(NUMBOX_TransferirCodClienteDestino.Value);
                sql = "SELECT * FROM clientes WHERE id_cliente = " + clienteDestino.IdCliente + ";";
                MySqlCommand query = new MySqlCommand(sql, conexao);

                reader = query.ExecuteReader();

                if (reader.Read())
                {
                    TXTBOX_TransferirDisplayClienteDestino.Text += "\r\nID: " + reader[0];
                    TXTBOX_TransferirDisplayClienteDestino.Text += "\r\nTITULAR: " + reader[1];
                    TXTBOX_TransferirDisplayClienteDestino.Text += "\r\nCPF: " + reader[3];
                    TXTBOX_TransferirDisplayClienteDestino.Text += "\r\nSALDO: " + reader[5];
                    clienteDestino.IdCliente = Convert.ToInt32(reader[0]);
                    clienteDestino.Nome = Convert.ToString(reader[1]);
                    clienteDestino.DataNasc = Convert.ToString(reader[2]);
                    clienteDestino.Cpf = Convert.ToString(reader[3]);
                    clienteDestino.Endereco = Convert.ToString(reader[4]);
                    clienteDestino.Saldo = Convert.ToDouble(reader[5]);
                    NUMBOX_TransferirValoraTransferir.Enabled = true;
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

        private void BTN_TransferenciaTransferir_Click(object sender, EventArgs e)
        {
            string sql1 = "";
            string sql2 = "";
            MySqlCommand update;


            try
            {
                //indiquei para o botão cancelar realizar sempre uma confirmação se realmente o usuário quer cancelar
                DialogResult opcao = MessageBox.Show("Deseja Realmente Realizar a Transferência?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao==DialogResult.Yes){

                    conexao.Open();
                    clienteOrigem.IdCliente = Convert.ToInt32(NUMBOX_TransferenciaCodClienteOrigem.Value);
                    
                    valorTransferencia = Convert.ToDouble(NUMBOX_TransferirValoraTransferir.Value);

                    clienteOrigem.Transferir(clienteDestino,valorTransferencia);

                    sql1 = "UPDATE clientes SET saldo_cliente = '" + clienteOrigem.Saldo + "'" +
                        "WHERE id_cliente ='" + clienteOrigem.IdCliente + "'";
                    update = new MySqlCommand(sql1,conexao);
                    update.ExecuteNonQuery();
                    conexao.Close();
                    conexao.Open();
                    
                    clienteDestino.IdCliente = Convert.ToInt32(NUMBOX_TransferirCodClienteDestino.Value);
                    valorTransferencia = Convert.ToDouble(NUMBOX_TransferirValoraTransferir.Value);

                    clienteOrigem.Transferir(clienteDestino, valorTransferencia);
                    sql2 = "UPDATE clientes SET saldo_cliente = '" + clienteDestino.Saldo + "'" +
                        "WHERE id_cliente ='" + clienteDestino.IdCliente + "'";
                    update = new MySqlCommand(sql2, conexao);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Transferência Realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Transferência não realizada!");
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
