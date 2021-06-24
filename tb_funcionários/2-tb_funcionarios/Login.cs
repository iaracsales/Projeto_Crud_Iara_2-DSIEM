using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_tb_funcionarios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Dados da conexao
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;
        private void btnentrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Conexão com banco de dados
                MySqlConnection con = new MySqlConnection(conexao);

                //2 passo, pega os dados da tela
                string email, senha;

                email = txtemail.Text;
                senha = txtsenha.Text;

                //executar comando SQL
                string sql = @"select * from tb_usuarios where email = @email and senha = @senha";

                //montar e organizar  o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, con);

                executacmd.Parameters.AddWithValue("@email", email);
                executacmd.Parameters.AddWithValue("@senha", senha);

                //abrir a conexao
                con.Open();

                //criar um mysqldatareader
                MySqlDataReader dr = executacmd.ExecuteReader();

                //verificar se tem dados dentro do MySqlDataReader
                if (dr.Read())
                {
                    //Logou no sistema
                    MessageBox.Show("Bem vindo ao Sistema!");

                    //ir para tela MENU
                    Menu menu = new Menu();
                    menu.ShowDialog();

                }
                else
                {
                    //senha ou email incorretos
                    MessageBox.Show("Dados incorretos, tente novamente");
                }
                //Fechar a conexao
                con.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Deu o erro: " + erro);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
