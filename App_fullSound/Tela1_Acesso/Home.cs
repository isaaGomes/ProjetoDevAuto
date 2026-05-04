using FullSoundApp;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TelaCliente cliente = new TelaCliente();
            cliente.Show();
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            TelaCliente cliente = new TelaCliente();
            cliente.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TelaCliente cliente = new TelaCliente();
            cliente.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Agenda Agenda1 = new Agenda();
            Agenda1.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Agenda Agenda1 = new Agenda();
            Agenda1.Show();
        }

        private void lblAgenda_Click(object sender, EventArgs e)
        {
            Agenda Agenda1 = new Agenda();
            Agenda1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Orçamentos orçamentos1 = new Orçamentos();
            orçamentos1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Orçamentos orçamentos1 = new Orçamentos();
            orçamentos1.Show();
        }

        private void lblOrcamentos_Click(object sender, EventArgs e)
        {
            Orçamentos orçamentos1 = new Orçamentos();
            orçamentos1.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Agenda Agenda1 = new Agenda();
            Agenda1.Show();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Orçamentos orçamentos1 = new Orçamentos();
            orçamentos1.Show();

        }
    }
}
