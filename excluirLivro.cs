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
    public partial class excluirLivro : Form
    {
        public int ID;
        public excluirLivro(int code)
        {
            InitializeComponent();

            ID = Convert.ToInt32(code);

            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=cadastro_livro; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand Consulta = new MySqlCommand();

            Consulta.Connection = conectar;

            Consulta.CommandText = "SELECT * FROM cadastros WHERE codigo = "+ ID;

            dataGridView1.Rows.Clear();

            MySqlDataReader Resultado = Consulta.ExecuteReader();

            if (Resultado.HasRows)
            {
                while (Resultado.Read())
                {
                    dataGridView1.Rows.Add(
                    Resultado["codigo"].ToString(),
                    Resultado["nome"].ToString(),
                    Resultado["autor"].ToString(),
                    Resultado["genero"].ToString(),
                    Resultado["editora"].ToString(),
                    Resultado["ano"].ToString()
                    );
                }
            }
            else
            {
                MessageBox.Show("Nenhum Registro Foi encontrado");
            }
        }


        
        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=cadastro_livro; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand deletar = new MySqlCommand();

            deletar.Connection = conectar;

            deletar.CommandText = "DELETE FROM cadastros WHERE codigo =  " + ID;

            dataGridView1.Rows.Clear();

            MySqlDataReader Resultado = deletar.ExecuteReader();

            MessageBox.Show("Dados Excluidos com Sucesso!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            excluir excluir = new excluir();
            excluir.Show();
        }
    }
}
