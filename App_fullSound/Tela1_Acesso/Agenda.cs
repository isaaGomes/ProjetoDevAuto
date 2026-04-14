using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Windows.Forms;

namespace FullSoundApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            public class Agendamento
        {
            public DateTime Data { get; set; }
            public string Hora { get; set; }
            public string TipoServico { get; set; }
            public decimal Valor { get; set; }
        }
        List<Agendamento> agendamentos;
        public Agenda()
        {
            InitializeComponent();
            comboTipoServico.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoServico.Items.Clear();
            comboTipoServico.Items.AddRange(new object[]
            {
                "Instalação",
                "Manutenção",
                "Sonorização de evento",
                "Locação de equipamentos",
                "Orçamento rápido"
            });
            comboTipoServico.SelectedIndex = -1;

            agendamentos = new List<Agendamento>
            {
                new Agendamento
                {
                    Data = new DateTime(2026, 3, 21),
                    Hora = "15:00",
                    TipoServico = "Instalação",
                    Valor = 400
                },
                new Agendamento
                {
                    Data = new DateTime(2026, 3, 25),
                    Hora = "10:00",
                    TipoServico = "Manutenção",
                    Valor = 200
                },
                new Agendamento
                {
                    Data = new DateTime(2026, 3, 27),
                    Hora = "13:00",
                    TipoServico = "Instalação",
                    Valor = 400
                }
            };

            dgvAgendamentos.AutoGenerateColumns = true;
            dgvAgendamentos.ReadOnly = true;
            dgvAgendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgendamentos.MultiSelect = false;
            dgvAgendamentos.DataSource = agendamentos;
            InitializeComponent();
            comboTipoServico.Items.AddRange(new object[]
            {
                "Instalação",
                "Manutenção",
                "Sonorização de evento",
                "Locação de equipamentos",
                "Orçamento rápido"
            });
            if (comboTipoServico.Items.Count > 0)
                comboTipoServico.SelectedIndex = 0;
            btnEmitirComprovante.Click += btnPesquisar_Click;
            btnEmitirComprovante.MouseEnter += (s, e) => btnEmitirComprovante.BackColor = Color.Silver;
            btnEmitirComprovante.MouseLeave += (s, e) => btnEmitirComprovante.BackColor = Color.Gainsboro;
            panelFiltro.Paint += panelFiltro_Paint;
            btnTabCliente.Click += (s, e) => SetSelectedTab(btnTabCliente);
            btnTabAgenda.Click += (s, e) => SetSelectedTab(btnTabAgenda);
            btnTabOrcamentos.Click += (s, e) => SetSelectedTab(btnTabOrcamentos);
            SetSelectedTab(btnTabAgenda);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bool tipoSelecionado = comboTipoServico.SelectedItem != null;
            bool horaPreenchida = mtxHora.MaskCompleted;

            string tipo = tipoSelecionado ? comboTipoServico.SelectedItem.ToString() : null;
            DateTime data = dtpData.Value.Date;
            string hora = mtxHora.Text;

            var resultado = agendamentos
                .Where(a =>
                    (!tipoSelecionado || a.TipoServico == tipo) &&
                    a.Data.Date == data &&
                    (!horaPreenchida || a.Hora == hora)
                )
                .ToList();

            if (resultado.Count == 0)
            {
                MessageBox.Show("Nenhum agendamento encontrado.");
                dgvAgendamentos.DataSource = agendamentos;
                return;
            }

            dgvAgendamentos.DataSource = resultado;
        }
        private void panelFiltro_Paint(object sender, PaintEventArgs e)
        {
            var rect = panelFiltro.ClientRectangle;
            rect.Inflate(-1, -1);
            ControlPaint.DrawBorder3D(e.Graphics, rect, Border3DStyle.Raised);
        }
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTabAgenda_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEmitirComprovante_Click(object sender, EventArgs e)
        {
            var agendamento = dgvAgendamentos.CurrentRow?.DataBoundItem as Agendamento;

            if (agendamento == null)
            {
                MessageBox.Show("Selecione um agendamento na lista.");
                return;
            }
            string caminho = $@"C:\Users\Public\comprovante_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            PdfWriter writer = new PdfWriter(caminho);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            PdfFont fonteNegrito =
                PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            document.Add(new Paragraph("FULL SOUND - COMPROVANTE")
                .SetFont(fonteNegrito)
                .SetFontSize(18));
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph($"Data: {agendamento.Data:dd/MM/yyyy}"));
            document.Add(new Paragraph($"Hora: {agendamento.Hora}"));
            document.Add(new Paragraph($"Serviço: {agendamento.TipoServico}"));
            document.Add(new Paragraph($"Valor: R$ {agendamento.Valor:N2}"));
            document.Close();
            MessageBox.Show("Comprovante gerado com sucesso!");
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);
        }
    }
}
