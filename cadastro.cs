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


namespace livraria
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string autor = textBox2.Text;
            string genero = textBox3.Text;
            string editora = textBox4.Text;
            string ano = textBox5.Text;


            MySqlConnection conexao = new MySqlConnection();

            conexao.ConnectionString = ("SERVER=127.0.0.1; DATABASE=cadastro_livro; UID=root; PASSWORD=;");
            conexao.Open();

            string inserir = "INSERT INTO cadastros (nome, autor, genero, editora, ano ) VALUES ('" + nome + "', '" + autor + "', '" + genero + "', '" + editora + "', '" + ano + "')";

            MySqlCommand comandos = new MySqlCommand(inserir, conexao);

            comandos.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Dados cadastrados com sucesso!!!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


            conexao.Close();
        }
    }
}
