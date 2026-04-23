using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
namespace FullSoundApp
{
    public partial class Agenda : Form
    {
        private List<Agendamento> agendamentos = new();
        public Agenda()
        {
            InitializeComponent();
            comboTipoServico.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoServico.Items.AddRange(new object[]
            {
                "Instalação",
                "Manutenção",
                "Sonorização de evento",
                "Locação de equipamentos",
                "Orçamento rápido"
            });
            dtpData.Format = DateTimePickerFormat.Short;
            mtxHora.Mask = "00:00";
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
                }
            };
            dgvAgendamentos.AutoGenerateColumns = true;
            dgvAgendamentos.ReadOnly = true;
            dgvAgendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgendamentos.MultiSelect = false;
            dgvAgendamentos.DataSource = agendamentos;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            bool filtrarTipo = comboTipoServico.SelectedItem != null;
            bool filtrarHora = mtxHora.MaskCompleted;
            string? tipo = filtrarTipo
                ? comboTipoServico.SelectedItem?.ToString()
                : null;
            DateTime data = dtpData.Value.Date;
            string hora = mtxHora.Text;
            var resultado = agendamentos.Where(a =>
                a.Data.Date == data &&
                (!filtrarTipo || a.TipoServico == tipo) &&
                (!filtrarHora || a.Hora == hora)
            ).ToList();
            dgvAgendamentos.DataSource =
                resultado.Count == 0 ? agendamentos : resultado;
        }
        private void btnEmitirComprovante_Click(object sender, EventArgs e)
        {
            var agendamento = dgvAgendamentos.CurrentRow?.DataBoundItem as Agendamento;
            if (agendamento == null)
            {
                MessageBox.Show("Selecione um agendamento na lista.");
                return;
            }
            string caminho = @$"C:\Users\Public\comprovante_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            PdfWriter writer = new PdfWriter(caminho);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            PdfFont fonte = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            document.Add(new Paragraph("FULL SOUND - COMPROVANTE")
                .SetFont(fonte)
                .SetFontSize(16));
            document.Add(new Paragraph($"Data: {agendamento.Data:dd/MM/yyyy}"));
            document.Add(new Paragraph($"Hora: {agendamento.Hora}"));
            document.Add(new Paragraph($"Serviço: {agendamento.TipoServico}"));
            document.Add(new Paragraph($"Valor: R$ {agendamento.Valor:N2}"));
            document.Close();
            MessageBox.Show("Comprovante gerado com sucesso!");
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
    public class Agendamento
    {
        public DateTime Data { get; set; }
        public string Hora { get; set; } = "";
        public string TipoServico { get; set; } = "";
        public decimal Valor { get; set; }
    }
}