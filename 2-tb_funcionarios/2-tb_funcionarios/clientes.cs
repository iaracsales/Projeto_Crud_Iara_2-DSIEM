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
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }
        //Criando um método / função
        public void listarClientes()
        {
            try
            {
                //Conexão com o banco de dados
                MySqlConnection con = new MySqlConnection(conexao);

                //2 passo: montar e executar o comenado SQL (Insert into)
                string sql_select_cliente = "select * from tb_cliente";

                //3 - montar e organizar o comando sql - executa o comando MySQL
                MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select_cliente, con);

                con.Open();
                executacmdMySql_select.ExecuteNonQuery();

                //4 - criar um Data Table - local onde fica os dados
                DataTable tabela_cliente = new DataTable();

                //5 passo - criar o  MySqlDataAdapter - que preenche um dataTable com os dados do banco

                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select);

                da_cliente.Fill(tabela_cliente);

                // 6 passo -  exibir o data table no datagridview
                DgvListaCliente.DataSource = tabela_cliente;

                con.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu o erro: " + erro);

            }
        }

        // Dados de conexão
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;

        private void btncadastrar_Click_1(object sender, EventArgs e)
        {
            //Botão cadastrar
            try
            {
                //Conexão com o banco de dados
                MySqlConnection con = new MySqlConnection(conexao);

                //segundo passo: pega os dados da tela
                string nome, telefone, email;
                nome = txtnome.Text;
                telefone = txttelefone.Text;
                email = txtemail.Text;

                //terceiro passo: montar e executar o comenado SQL (Insert into)
                string sql_insert = @"insert into tb_cliente (tb_cliente_nome, tb_cliente_tel, tb_cliente_email) 
                                                                    values (@cliente_nome, @cliente_tel, @cliente_email)";

                //Montar e organizar o comando
                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_tel", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_email", email);

                //abrir a conexão
                con.Open();

                //executa o comando SQL
                executacmdMySql_insert.ExecuteNonQuery();

                //Fechar a conexão
                con.Close();
                MessageBox.Show("Cliente cadastrado com sucesso");

                listarClientes();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu o erro: " + erro);

            }
        }

        private void btnalt_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Conexão com o banco de dados
                MySqlConnection con = new MySqlConnection(conexao);

                //
                int id;
                string nome, telefone, email;
                id = int.Parse(txtcodigo.Text);
                nome = txtnome.Text;
                telefone = txttelefone.Text;
                email = txtemail.Text;


                //terceiro passo: montar e executar o comenado SQL (update into)
                string sql_update_cliente = @"update tb_cliente 
                                            set tb_cliente_nome = @nome,
                                                 tb_cliente_tel = @tel,
                                                 tb_cliente_email = @email

                                                where tb_cliente_id = @id";

                //Montar e organizar o comando sql
                MySqlCommand executacmdMySql_uptade = new MySqlCommand(sql_update_cliente, con);
                executacmdMySql_uptade.Parameters.AddWithValue("@nome", nome);
                executacmdMySql_uptade.Parameters.AddWithValue("@tel", telefone);
                executacmdMySql_uptade.Parameters.AddWithValue("@email", email);
                executacmdMySql_uptade.Parameters.AddWithValue("@id", id);

                //abrir a conexão
                con.Open();

                //executa o comando SQL
                executacmdMySql_uptade.ExecuteNonQuery();

                //Fechar a conexão
                con.Close();
                MessageBox.Show("Dados do cliente alterado com sucesso");

                listarClientes();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Deu o erro:" + erro);
            }
        }

        private void btnexcluir_Click_1(object sender, EventArgs e)
        {
            //Botão excluir com confirmação
            DialogResult dr = MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (dr == DialogResult.Yes)
            {
                //clicou no sim
                //botão excluir
                try
                {
                    //1 passo - conexao cm banco de dados
                    MySqlConnection con = new MySqlConnection(conexao);


                    //2 passo- receber dados do cliente que vai se excluído
                    int id = int.Parse(txtcodigo.Text);

                    //criar e executar o comendo SQL(delete)
                    string sql_delete_cliente = @"delete from tb_cliente where tb_cliente_id = @id";

                    //Montar e organizar o comando SQL
                    MySqlCommand executacmdMy_Sql_delete = new MySqlCommand(sql_delete_cliente, con);
                    executacmdMy_Sql_delete.Parameters.AddWithValue("@id", id);

                    //Abrir a conexao
                    con.Open();

                    //executa o comendo SQL
                    executacmdMy_Sql_delete.ExecuteNonQuery();

                    //Fechar a conexao
                    con.Close();

                    MessageBox.Show("Cliente excluído");

                    //chamar o metodo listarClientes
                    listarClientes();
                }
                catch (Exception erro)
                {
                    string mensagem = "Aconteceu o erro ao excluir: " + erro;
                    MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("O cliente não foi excluído");
            }
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            listarClientes();
        }

        private void DgvListaCliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados de uma linha selecionada no datagridview
            txtcodigo.Text = DgvListaCliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = DgvListaCliente.CurrentRow.Cells[1].Value.ToString();
            txttelefone.Text = DgvListaCliente.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = DgvListaCliente.CurrentRow.Cells[3].Value.ToString();
        }
    }
}


