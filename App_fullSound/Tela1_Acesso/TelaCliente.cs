using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela1_Acesso
{
    public partial class TelaCliente : Form
    {
        string conexao = " Source=localhost;User=root;pwd =; Database=telacliente";
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conexao);

            if (txtNomeDoCliente.Text == "" ||
                txtCelular.Text == "" ||
                txtTipoDeServiço.Text == "" ||
                txtTipoDePagamento.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            con.Open();

            string sql = @"INSERT INTO Clientes 
                   (Nome, Celular, Tipodeservico, Status, Tipodepagamento)
                   VALUES 
                   (@nome, @celular, @servico, @status, @pagamento)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", txtNomeDoCliente.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
            cmd.Parameters.AddWithValue("@servico", txtTipoDeServiço.Text);
            cmd.Parameters.AddWithValue("@status", "Ativo");
            cmd.Parameters.AddWithValue("@pagamento", txtTipoDePagamento.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Cliente cadastrado com sucesso!");

            txtNomeDoCliente.Clear();
            txtCelular.Clear();
            txtTipoDeServiço.Clear();
            txtTipoDePagamento.Clear();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbCliente_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
