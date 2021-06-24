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
    public partial class funcionario : Form
    {
        public funcionario()
        {
            InitializeComponent();
        }
        //Criar função/método
        public void listarclientes()
        {
            try
            {
                //conexão com banco de dados
                MySqlConnection con = new MySqlConnection(conexao);

                //2 passo: montar e executar o comenado SQL 
                string sql_select_funcionarios = "select * from tb_funcionarios";

                //3 - montar e organizar o comando sql - executa o comando MySQL
                MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select_funcionarios, con);

                con.Open();
                executacmdMySql_select.ExecuteNonQuery();

                //4 - criar um Data Table - local onde fica os dados
                DataTable tabela_funcionarios = new DataTable();

                //5 passo - criar o  MySqlDataAdapter - que preenche um dataTable com os dados do banco

                MySqlDataAdapter da_fornecedores = new MySqlDataAdapter(executacmdMySql_select);

                da_fornecedores.Fill(tabela_funcionarios);

                // 6 passo -  exibir o data table no datagridview
                dataGridView1.DataSource = tabela_funcionarios;

                con.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Deu o erro: " + erro);
            }

        }


        //Dados da conexao
        string conexao = ConfigurationManager.ConnectionStrings["bd_loja"].ConnectionString;

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Conexão com banco de dados
                MySqlConnection con = new MySqlConnection(conexao);

                //segundo passo- pegar os dados da tela
                string codigo, rg, nome, cpf, email, senha, cargo, nivel, telefone, celular, endereco, cep, cidade, bairro, complemento, estado;
                int numero;
                codigo = txtcodigo.Text;
                rg = txtrg.Text;
                nome = txtnome.Text;
                cpf = txtcpf.Text;
                email = txtemail.Text;
                senha = txtsenha.Text;
                cargo = txtcargo.Text;
                nivel = txtnivel.Text;
                telefone = txttelefone.Text;
                celular = txtcelular.Text;
                endereco = txtendereco.Text;
                cep = txtcep.Text;
                cidade = txtcidade.Text;
                bairro = txtbairro.Text;
                complemento = txtcomplemento.Text;
                estado = txtestado.Text;
                numero = int.Parse(txtnumero.Text);

                //terceiro passo: montar e executar o comenado SQL (Insert into)
                string sql_insert = @"insert into tb_funcionarios(
                                        tb_funcionarios_nome,
                                        tb_funcionarios_rg,
                                        tb_funcionarios_cpf,
                                        tb_funcionarios_email,
                                        tb_funcionarios_senha,
                                        tb_funcionarios_cargo,
                                        tb_funcionarios_nivel_acesso,
                                        tb_funcionarios_telefone,
                                        tb_funcionarios_celular,
                                        tb_funcionarios_cep,
                                        tb_funcionarios_endereco,
                                        tb_funcionarios_numero,
                                        tb_funcionarios_complemento,
                                        tb_funcionarios_bairro,
                                        tb_funcionarios_cidade,
                                        tb_funcionarios_estado)
                                            values(@fornecedores_nome,
                                                    @fornecedores_rg,
                                                    @fornecedores_cpf,
                                                    @fornecedores_email,
                                                    @fornecedores_senha,
                                                    @fornecedores_cargo,
                                                    @fornecedores_nivel_acesso,
                                                    @fornecedores_telefone,
                                                    @fornecedores_celular,
                                                    @fornecedores_cep,
                                                    @fornecedores_endereco,
                                                    @fornecedores_numero,
                                                    @fornecedores_complemento,
                                                    @fornecedores_bairro,
                                                    @fornecedores_cidade,
                                                    @fornecedores_estado)";

                //montar e organizar o comando
                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_rg", rg);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_cpf", cpf);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_email", email);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_senha", senha);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_cargo", cargo);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_nivel_acesso", nivel);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_telefone", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_celular", celular);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_cep", cep);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_endereco", endereco);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_numero", numero);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_complemento", complemento);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_bairro", bairro);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_cidade", cidade);
                executacmdMySql_insert.Parameters.AddWithValue("@fornecedores_estado", estado);

                //abrir conexão
                con.Open();

                //executa o comando sql
                executacmdMySql_insert.ExecuteNonQuery();

                //Fechar conexão
                con.Close();
                MessageBox.Show("Cliente cadastrado com sucesso!");

                listarclientes();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Deu o erro: " + erro);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listarclientes();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                //botão alterar
                //conexão cm banco
                MySqlConnection con = new MySqlConnection(conexao);

                //dados da tela
                string codigo, rg, nome, cpf, email, senha, cargo, nivel, telefone, celular, endereco, cep, cidade, bairro, complemento, estado;
                int numero, id;
                codigo = txtcodigo.Text;
                rg = txtrg.Text;
                nome = txtnome.Text;
                cpf = txtcpf.Text;
                email = txtemail.Text;
                senha = txtsenha.Text;
                cargo = txtcargo.Text;
                nivel = txtnivel.Text;
                telefone = txttelefone.Text;
                celular = txtcelular.Text;
                endereco = txtendereco.Text;
                cep = txtcep.Text;
                cidade = txtcidade.Text;
                bairro = txtbairro.Text;
                complemento = txtcomplemento.Text;
                estado = txtestado.Text;
                numero = int.Parse(txtnumero.Text);
                id = int.Parse(txtcodigo.Text);

                //terceiro passo: montar e executar o comenado SQL (update into)
                string sql_update_funcionarios = @"update tb_funcionarios
                                                    set                                        
                                        tb_funcionarios_nome =  @fornecedores_nome,
                                        tb_funcionarios_rg = @fornecedores_rg,
                                        tb_funcionarios_cpf = @fornecedores_cpf,
                                        tb_funcionarios_email = @fornecedores_email,
                                        tb_funcionarios_senha = @fornecedores_senha,
                                        tb_funcionarios_cargo = @fornecedores_cargo,
                                        tb_funcionarios_nivel_acesso = @fornecedores_nivel_acesso,
                                        tb_funcionarios_telefone = @fornecedores_telefone,
                                        tb_funcionarios_celular = @fornecedores_celular,
                                        tb_funcionarios_cep = @fornecedores_cep,
                                        tb_funcionarios_endereco = @fornecedores_endereco,
                                        tb_funcionarios_numero = @fornecedores_numero,
                                        tb_funcionarios_complemento = @fornecedores_complemento,
                                        tb_funcionarios_bairro = @fornecedores_bairro,
                                        tb_funcionarios_cidade = @fornecedores_cidade,
                                        tb_funcionarios_estado = @fornecedores_estado

                                                    where tb_funcionarios_id = @fornecedores_id";

                //montar e organizar o comando
                MySqlCommand executacmdMySql_update = new MySqlCommand(sql_update_funcionarios, con);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_nome", nome);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_rg", rg);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_cpf", cpf);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_email", email);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_senha", senha);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_cargo", cargo);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_nivel_acesso", nivel);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_telefone", telefone);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_celular", celular);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_cep", cep);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_endereco", endereco);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_numero", numero);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_complemento", complemento);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_bairro", bairro);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_cidade", cidade);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_estado", estado);
                executacmdMySql_update.Parameters.AddWithValue("@fornecedores_id", id);

                //abrir a conexão
                con.Open();

                //executa o comando SQL
                executacmdMySql_update.ExecuteNonQuery();

                //Fechar a conexão
                con.Close();
                MessageBox.Show("Dados do cliente alterado com sucesso");

                listarclientes();



            }
            catch (Exception erro)
            {

                MessageBox.Show("Deu o erro: " + erro);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados de uma linha selecionada no datagridview
            txtcodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtcargo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtnivel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtestado.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //botão excluir
            DialogResult dr = MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(conexao);

                    int id = int.Parse(txtcodigo.Text);

                    string sql_delete_funcionario = @"delete from tb_funcionarios where tb_funcionarios_id = @id";

                    MySqlCommand executacmdMy_Sql_delete = new MySqlCommand(sql_delete_funcionario, con);
                    executacmdMy_Sql_delete.Parameters.AddWithValue("@id", id);


                    con.Open();


                    executacmdMy_Sql_delete.ExecuteNonQuery();


                    con.Close();

                    MessageBox.Show("Cliente excluído");


                    listarclientes();
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
    }
}
