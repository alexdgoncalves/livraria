using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livraria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            cadastro cadastrar = new cadastro();
            cadastrar.Show();
        }

        private void Pesquisa_Click(object sender, EventArgs e)
        {
            pesquisa pesquisar = new pesquisa();
            pesquisar.Show();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            excluir excluir = new excluir();
            excluir.Show();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            editar editar = new editar();
            editar.Show();
        }
    }
}
