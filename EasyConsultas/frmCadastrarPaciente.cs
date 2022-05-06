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
    public partial class frmCadastrarPaciente : Form
    {
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;

        string data_source = @"datasource=localhost;username=root;password=1234567;database=db_easyconsultas";

        public frmCadastrarPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string cpf = textBoxCpf.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string phone = "";

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(email))
            {
                try
                {
                    // criar conexao com o MySQL
                    mySqlConnection = new MySqlConnection(data_source);
                    mySqlConnection.Open(); // abre conexao

                    mySqlCommand = new MySqlCommand();

                    // executar o comando insert
                    mySqlCommand.Connection = mySqlConnection;
                    mySqlCommand.CommandText = "INSERT INTO pacientes (nome, cpf, email, telefone) VALUES (@nome, @cpf, @email, @phone) ";
                    mySqlCommand.Parameters.AddWithValue("@nome", name);
                    mySqlCommand.Parameters.AddWithValue("@cpf", cpf);
                    mySqlCommand.Parameters.AddWithValue("@email", email);
                    mySqlCommand.Parameters.AddWithValue("@phone", phone);
                    mySqlCommand.Prepare();
                    mySqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Paciente cadastrado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxName.Text = textBoxEmail.Text = textBoxCpf.Text = String.Empty;

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
            } else
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
