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
    public partial class RelatorioTodosCliente : Form
    {
        MySqlConnection conexao;

        public RelatorioTodosCliente()
        {
            InitializeComponent();
            conexao = new MySqlConnection("Server = localhost; port = 3306; database = dbbank; user = root; password = ''");
        }

        private void BTN_RelatorioGeralLimpar_Click(object sender, EventArgs e)
        {
            DialogResult opcao = MessageBox.Show("Deseja Realmente Limpar os Campos?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //usei a condicional para verificar a resposta do usuário
            if (opcao == DialogResult.Yes)
            {
                TXTBOX_RelatorioGeralDisplay.Text = "";
            }
        }

        private void BTN_RelatorioGeralCancelar_Click(object sender, EventArgs e)
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

        private void BTN_RelatorioGeralListar_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader = null;

            try
            {
                conexao.Open();         
                sql = "SELECT * FROM clientes";
                MySqlCommand query = new MySqlCommand(sql, conexao);

                reader = query.ExecuteReader();
                int contador = 1;

                if (reader.Read())
                {
                    
                   

                    TXTBOX_RelatorioGeralDisplay.Text = "\r\n";
                    do
                    {
                        TXTBOX_RelatorioGeralDisplay.Text += "\r\n";                       
                        TXTBOX_RelatorioGeralDisplay.Text +="   " + Convert.ToString(reader[0]) + "             "
                            + Convert.ToString(reader[1])+ "          " + Convert.ToString(reader[2]) + "                "
                            + Convert.ToString(reader[3])+ "                         " + Convert.ToString(reader[4]) + "                                      " +
                            Convert.ToString(reader[5])+ "       ";
                        contador++;
                    } while (reader.Read());


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
