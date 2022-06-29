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
    public partial class alterarLivro : Form
    {
        public int ID;
        public alterarLivro(int code)
        {
            InitializeComponent();

            ID = Convert.ToInt32(code);

            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=cadastro_livro; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand Consulta = new MySqlCommand();

            Consulta.Connection = conectar;

            Consulta.CommandText = "SELECT * FROM cadastros WHERE codigo = " + ID;


            MySqlDataReader Resultado = Consulta.ExecuteReader();

            if (Resultado.Read())
            {
                textBox6.Text = Convert.ToString(Resultado["codigo"]);
                textBox1.Text = Convert.ToString(Resultado["nome"]);
                textBox2.Text = Convert.ToString(Resultado["autor"]);
                textBox3.Text = Convert.ToString(Resultado["genero"]);
                textBox4.Text = Convert.ToString(Resultado["editora"]);
                textBox5.Text = Convert.ToString(Resultado["ano"]);

            }
            else
            {
                MessageBox.Show("Nenhum Registro Foi encontrado");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nome = Convert.ToString(textBox1.Text);
            string autor = Convert.ToString(textBox2.Text);
            string genero = Convert.ToString(textBox3.Text);
            string editora = Convert.ToString(textBox4.Text);
            string ano = Convert.ToString(textBox5.Text);
            string codigo = Convert.ToString(textBox6.Text);



            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=cadastro_livro; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand alterar = new MySqlCommand();

            alterar.Connection = conectar;

            string inserir = "UPDATE `cadastros` SET `nome`= '" + nome + "',`autor`= '" + autor + "',`genero`= '" + genero + "',`editora`= '" + editora + "',`ano`= '" + ano + "' WHERE codigo = '" + codigo + "'";

            MySqlCommand comandos = new MySqlCommand(inserir, conectar);
            comandos.ExecuteNonQuery();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            MessageBox.Show("Dados Alterados com Sucesso!!!");
            conectar.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar alterar = new editar();
            alterar.Show();
        }
    }
}
