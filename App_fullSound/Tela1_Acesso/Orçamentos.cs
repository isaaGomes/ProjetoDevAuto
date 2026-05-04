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

            dgvServicos.Columns["Data"].DefaultCellStyle.Alignment =
             DataGridViewContentAlignment.MiddleCenter;

            dgvServicos.Columns["Servico"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvServicos.Columns["Valor"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvServicos.Columns["Valor"].DefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvServicos.Columns["Status"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Remove qualquer destaque visual de seleção
            dgvServicos.DefaultCellStyle.SelectionBackColor =
                dgvServicos.DefaultCellStyle.BackColor;

            dgvServicos.DefaultCellStyle.SelectionForeColor =
                dgvServicos.DefaultCellStyle.ForeColor;

            // Evita destaque de linha inteira
            dgvServicos.SelectionMode = DataGridViewSelectionMode.CellSelect;

            // Remove célula atual visualmente
            dgvServicos.ClearSelection();

            dgvServicos.Enabled = false;
            dgvServicos.Enabled = true;

            dgvServicos.Rows.Add("21/03/2026", "Elétrico", "200", "Pago");
            dgvServicos.Rows.Add("25/03/2026", "Suspensão", "200", "Pendente");
            dgvServicos.Rows.Add("06/03/2026", "Elétrico", "200", "Cancelado");


            foreach (DataGridViewRow row in dgvServicos.Rows)
            {
                row.Height = 44;
            }
        }

        private void dgvServicos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0) return;

            // ===== COLUNA STATUS =====
            if (dgvServicos.Columns[e.ColumnIndex].Name == "Status")
            {
                e.Handled = true;
                e.PaintBackground(e.CellBounds, true);

                string text = e.FormattedValue?.ToString();

                Color backColor = Color.Gray;

                if (text == "Pago")
                    backColor = Color.FromArgb(0, 184, 148);
                else if (text == "Pendente")
                    backColor = Color.FromArgb(253, 203, 110);
                else if (text == "Cancelado")
                    backColor = Color.FromArgb(214, 48, 49);

                Rectangle rect = new Rectangle(
                    e.CellBounds.X + 10,
                    e.CellBounds.Y + 8,
                    e.CellBounds.Width - 20,
                    e.CellBounds.Height - 16
                );

                using (System.Drawing.Drawing2D.GraphicsPath path =
                       new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = rect.Height;

                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    using (SolidBrush brush = new SolidBrush(backColor))
                        e.Graphics.FillPath(brush, path);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    text,
                    e.CellStyle.Font,
                    rect,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                return;
            }

            // ===== OUTRAS COLUNAS (linha embaixo) =====


            e.Paint(e.ClipBounds, DataGridViewPaintParts.All);

            // Desenha a linha apenas UMA vez por linha (na primeira coluna)
            if (e.ColumnIndex == 0)
            {
                Rectangle rowRect =
                    dgvServicos.GetRowDisplayRectangle(e.RowIndex, true);

                using (Pen pen = new Pen(Color.FromArgb(80, 80, 80), 1))
                {
                    int y = rowRect.Bottom - 5;

                    e.Graphics.DrawLine(
                        pen,
                        rowRect.Left + 20,
                        y,
                        rowRect.Right - 20,
                        y
                    );
                }
            }
            e.Handled = true;

        }

    }


}

