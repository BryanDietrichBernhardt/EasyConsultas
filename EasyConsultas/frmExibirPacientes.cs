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

namespace EasyConsultas
{
    public partial class frmExibirPacientes : Form
    {
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;

        string data_source = @"datasource=localhost;username=root;password=1234567;database=db_easyconsultas";

        public frmExibirPacientes()
        {
            InitializeComponent();

            listViewPacientes.View = View.Details;
            listViewPacientes.LabelEdit = true;
            listViewPacientes.AllowColumnReorder = true;
            listViewPacientes.FullRowSelect = true;
            listViewPacientes.GridLines = true;

            listViewPacientes.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listViewPacientes.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listViewPacientes.Columns.Add("CPF", 90, HorizontalAlignment.Left);
            listViewPacientes.Columns.Add("E-mail", 250, HorizontalAlignment.Left);

            searchPacientes();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            searchPacientes();

        }

        private void searchPacientes()
        {
            string searchText = textBoxPacientes.Text.Trim();

            try
            {
                // criar conexao com o MySQL
                mySqlConnection = new MySqlConnection(data_source);
                mySqlConnection.Open(); // abre conexao

                mySqlCommand = new MySqlCommand();

                mySqlCommand.Connection = mySqlConnection;

                mySqlCommand.CommandText = "SELECT * FROM pacientes WHERE nome LIKE @busca OR cpf LIKE @busca OR email LIKE @busca ORDER BY ID DESC";
                mySqlCommand.Parameters.AddWithValue("@busca", "%" + textBoxPacientes.Text + "%");
                mySqlCommand.Prepare();

                
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                listViewPacientes.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    };
                    listViewPacientes.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro! " + ex.Number + " ocorreu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! ocorreu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // fecha conexao
                mySqlConnection.Close();
            }
        }

        private void textBoxPacientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchPacientes();
        }
    }
}
