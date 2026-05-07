using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using FullSoundApp;

namespace Tela1_Acesso
{
    public partial class Orçamentos : Form
    {
        public Orçamentos()
        {
            InitializeComponent();
        }



        private void lblCliente_Click(object sender, EventArgs e)
        {

            TelaCliente cliente = new TelaCliente();
            cliente.Show();
            this.Hide();

        }





        private void ArredondarPanel(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(panel.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, panel.Height - raio, raio, raio, 90, 90);

            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void Orçamentos_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn col in dgvServicos.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Padding = new Padding(0);
            }
            dgvServicos.RowHeadersVisible = false;
            dgvServicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


            dgvServicos.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;

            dgvServicos.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;


            dgvServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvServicos.RowHeadersVisible = false;
            dgvServicos.AllowUserToAddRows = false;

            dgvServicos.BorderStyle = BorderStyle.None;
            dgvServicos.GridColor = Color.FromArgb(45, 45, 45);

            dgvServicos.EnableHeadersVisualStyles = false;
            dgvServicos.SelectionMode = DataGridViewSelectionMode.CellSelect;

            ArredondarPanel(panel1, 20);

            dgvServicos.DefaultCellStyle.SelectionForeColor =
            dgvServicos.DefaultCellStyle.ForeColor;
            dgvServicos.EnableHeadersVisualStyles = false;
            dgvServicos.BackgroundColor = Color.FromArgb(32, 32, 32);
            dgvServicos.BorderStyle = BorderStyle.None;
            dgvServicos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvServicos.GridColor = Color.FromArgb(45, 45, 45);

            dgvServicos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            dgvServicos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Orange;
            dgvServicos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            dgvServicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvServicos.DefaultCellStyle.BackColor = Color.FromArgb(38, 38, 38);
            dgvServicos.DefaultCellStyle.ForeColor = Color.White;
            dgvServicos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 55, 55);
            dgvServicos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvServicos.ColumnHeadersDefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;
            dgvServicos.RowTemplate.Height = 38;

            dgvServicos.Rows.Add(
                "Pedro",
                "5852563698",
                "Carro",
                "21/03/2026",
                "10:00",
                "Elétrico",
                "950",
                "Pago"
);

            dgvServicos.Rows.Add(
                "Maria",
                "9656963658",
                "Moto",
                "25/03/2026",
                "14:00",
                "Suspensão",
                "1000",
                "Pendente"
            );

            dgvServicos.Rows.Add(
                "João",
                "1158236932",
                "Carro",
                "06/03/2026",
                "09:30",
                "Elétrico",
                "500",
                "Cancelado"
            );

            // Remove qualquer destaque visual de seleção
            dgvServicos.DefaultCellStyle.SelectionBackColor =
                dgvServicos.DefaultCellStyle.BackColor;

            dgvServicos.DefaultCellStyle.SelectionForeColor =
                dgvServicos.DefaultCellStyle.ForeColor;

            // Evita destaque de linha inteira
            dgvServicos.SelectionMode = DataGridViewSelectionMode.CellSelect;

            // Remove célula atual visualmente
            dgvServicos.ClearSelection();

            dgvServicos.RowHeadersVisible = false;
            dgvServicos.AllowUserToResizeRows = false;
            dgvServicos.AllowUserToResizeColumns = false;





            foreach (DataGridViewRow row in dgvServicos.Rows)
            {
                row.Height = 44;
            }


            dgvServicos.CellPainting += dgvServicos_CellPainting;

            dgvServicos.ClearSelection();
            dgvServicos.Invalidate();
            dgvServicos.Refresh();

            foreach (DataGridViewColumn col in dgvServicos.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvServicos.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }


        private void dgvServicos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            {
                if (e.RowIndex < 0) return;

                if (dgvServicos.Columns[e.ColumnIndex].Name == "Status")
                {
                    e.Handled = true;

                    e.PaintBackground(e.CellBounds, true);

                    string status = e.FormattedValue?.ToString();
                    Color cor = Color.Gray;

                    if (status == "Pago")
                        cor = Color.FromArgb(0, 180, 150);

                    else if (status == "Pendente")
                        cor = Color.FromArgb(240, 190, 90);

                    else if (status == "Cancelado")
                        cor = Color.FromArgb(220, 60, 60);

                    using (Brush brush = new SolidBrush(cor))
                    {
                        int paddingHorizontal = 20;
                        int paddingVertical = 8;

                        Rectangle rect = new Rectangle(
                            e.CellBounds.X + paddingHorizontal,
                            e.CellBounds.Y + paddingVertical,
                            e.CellBounds.Width - (paddingHorizontal * 2),
                            e.CellBounds.Height - (paddingVertical * 2)
                        );

                        // borda arredondada
                        System.Drawing.Drawing2D.GraphicsPath path =
                            new System.Drawing.Drawing2D.GraphicsPath();

                        int radius = 25;

                        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                        path.CloseFigure();

                        e.Graphics.FillPath(brush, path);

                        // texto centralizado
                        TextRenderer.DrawText(
                            e.Graphics,
                            status,
                            new Font("Segoe UI", 9, FontStyle.Bold),
                            rect,
                            status == "Pendente" ? Color.Black : Color.White,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                        );
                        dgvServicos.RowTemplate.Height = 50;
                    }
                }

            }
        }











        private void dgvServicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ptbOrçamentos_Click(object sender, EventArgs e)
        {
            Orçamentos orçamentos1 = new Orçamentos();
            orçamentos1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Home Home1 = new Home();
            Home1.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Home Home1 = new Home();
            Home1.Show();
        }

        private void ptbClientes_Click(object sender, EventArgs e)
        {
            TelaCliente telaCliente1 = new TelaCliente();
            telaCliente1.Show();
        }

        private void lbClientes_Click(object sender, EventArgs e)
        {
            TelaCliente telaCliente1 = new TelaCliente();
            telaCliente1.Show();
        }

        private void ptbAgenda_Click(object sender, EventArgs e)
        {
            Agenda agenda1 = new Agenda();
            agenda1.Show();
        }

        private void lbAgenda_Click(object sender, EventArgs e)
        {
            Agenda agenda2 = new Agenda();
            agenda2.Show();
        }

        private void LbOrçamentos_Click(object sender, EventArgs e)
        {
            Orçamentos orçamentos2 = new Orçamentos();
            orçamentos2.Show();
        }
    }
}

