using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_tb_funcionarios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes clientes = new clientes();
            clientes.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fornecedor fornecedor = new fornecedor();
            fornecedor.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcionario funcionario = new funcionario();
            funcionario.ShowDialog();
        }
    }
}
