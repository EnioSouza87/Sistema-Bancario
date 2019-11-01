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
    public partial class RelatorioTodosClientes : Form
    {
        MySqlConnection conexao;
        public RelatorioTodosClientes()
        {
            InitializeComponent();
            conexao = new MySqlConnection("Server = localhost; port = 3306; database = dbbank; user = root; password = ''");
        }

        private void BTN_RelatorioGeralBuscar_Click(object sender, EventArgs e)
        {
            string sql = "";
            MySqlDataReader reader = null;

            try
            {                             
                    conexao.Open();

                    sql = "SELECT * FROM clientes";
                    MySqlCommand query = new MySqlCommand(sql, conexao);

                    reader = query.ExecuteReader();

                    if (reader.Read())
                    {
                        while (reader.Read())
                        {
                            TXTBOX_RelatorioCLientesDisplay.Text += "-------------------------------------------------------------------------------------------" +
                                "-------------------------------------------------------------------------------------------------------------------------------------------------------------";
                            TXTBOX_RelatorioCLientesDisplay.Text = "\r\n ";
                            TXTBOX_RelatorioCLientesDisplay.Text += "       " + reader[0] + "    " + "        " + reader[1] + "              "
                               + reader[2] + "                " + reader[3] + "                " + reader[4] + "                     " + reader[5];
                        }
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
