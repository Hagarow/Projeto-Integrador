
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_Integrador
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();

            tbcodigo.Enabled = true;
            tbtelefone.Enabled = true;
            tbcelular.Enabled = true;
            tbnome.Enabled = true;
            tbemail.Enabled = true;
            tbsenha.Enabled = true;
            tbpesquisarnome.Enabled = true;
        }

        private MySqlConnectionStringBuilder ConexaoBanco()
        {
            MySqlBaseConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "locadora";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = MySqlSslMode.None;
            return (MySqlConnectionStringBuilder)conexaoBD;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = ConexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                //INSERT INTO usuarios (codUsuario,telefoneUsuario,celularUsuario,nomeUsuario,emailUsuario,senhaUsuario)
                //VALUES('" + tbcodigo.Text + "', '" + tbtelefone.Text + "', '" + tbcelular.Text + "', '" + tbnome.Text + "', '" + tbemail.Text + "', '" + tbsenha.Text + "')

                comandoMySql.CommandText = "INSERT INTO usuarios (codUsuario,telefoneUsuario,celularUsuario,nomeUsuario,emailUsuario,senhaUsuario)" +
                    "VALUES('" + tbcodigo.Text + "', '" + tbtelefone.Text + "', '" + tbcelular.Text + "', '" + tbnome.Text + "', '" + tbemail.Text + "', '" + tbsenha.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("iTEM INSERIDO COM SUCESSO!");
                // AtualizaGrid();
                LimparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void usuarios_Load(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            tbcodigo.Clear();
            tbtelefone.Clear();
            tbcelular.Clear();
            tbnome.Clear();
            tbemail.Clear();
            tbsenha.Clear();
        }
    }
}