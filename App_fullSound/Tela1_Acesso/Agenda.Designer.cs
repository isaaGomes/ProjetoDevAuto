namespace FullSoundApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            btnTabCliente = new Button();
            btnTabAgenda = new Button();
            btnTabOrcamentos = new Button();
            tabIndicator = new Panel();
            lblData = new Label();
            lblHora = new Label();
            lblPesquisar = new Label();
            dtpData = new DateTimePicker();
            mtxHora = new MaskedTextBox();
            txtPesquisar = new TextBox();
            panelFiltro = new Panel();
            lblTipoServico = new Label();
            comboTipoServico = new ComboBox();
            btnEmitirComprovante = new Button();
            toolTip1 = new ToolTip(components);
            bntTabHome = new Button();
            dgvAgendamentos = new DataGridView();
            panelLista = new Panel();
            label1 = new Label();
            panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).BeginInit();
            panelLista.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Orange;
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(210, 58);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Full";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnTabCliente
            // 
            btnTabCliente.FlatAppearance.BorderSize = 0;
            btnTabCliente.FlatStyle = FlatStyle.Flat;
            btnTabCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTabCliente.Location = new Point(39, 132);
            btnTabCliente.Name = "btnTabCliente";
            btnTabCliente.Size = new Size(100, 28);
            btnTabCliente.TabIndex = 1;
            btnTabCliente.Text = "Cliente";
            // 
            // btnTabAgenda
            // 
            btnTabAgenda.FlatAppearance.BorderSize = 0;
            btnTabAgenda.FlatStyle = FlatStyle.Flat;
            btnTabAgenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTabAgenda.Location = new Point(39, 166);
            btnTabAgenda.Name = "btnTabAgenda";
            btnTabAgenda.Size = new Size(100, 28);
            btnTabAgenda.TabIndex = 2;
            btnTabAgenda.Text = "Agenda";
            btnTabAgenda.Click += btnTabAgenda_Click;
            // 
            // btnTabOrcamentos
            // 
            btnTabOrcamentos.FlatAppearance.BorderSize = 0;
            btnTabOrcamentos.FlatStyle = FlatStyle.Flat;
            btnTabOrcamentos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTabOrcamentos.Location = new Point(39, 205);
            btnTabOrcamentos.Name = "btnTabOrcamentos";
            btnTabOrcamentos.Size = new Size(120, 28);
            btnTabOrcamentos.TabIndex = 3;
            btnTabOrcamentos.Text = "Orçamentos";
            // 
            // tabIndicator
            // 
            tabIndicator.BackColor = Color.Orange;
            tabIndicator.Location = new Point(39, 196);
            tabIndicator.Name = "tabIndicator";
            tabIndicator.Size = new Size(100, 3);
            tabIndicator.TabIndex = 4;
            tabIndicator.Visible = false;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblData.ForeColor = Color.White;
            lblData.Location = new Point(247, 68);
            lblData.Name = "lblData";
            lblData.Size = new Size(33, 15);
            lblData.TabIndex = 5;
            lblData.Text = "Data";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(246, 170);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(34, 15);
            lblHora.TabIndex = 7;
            lblHora.Text = "Hora";
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPesquisar.ForeColor = Color.White;
            lblPesquisar.Location = new Point(246, 119);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(59, 15);
            lblPesquisar.TabIndex = 9;
            lblPesquisar.Text = "Pesquisar";
            // 
            // dtpData
            // 
            dtpData.CalendarForeColor = Color.Black;
            dtpData.CalendarMonthBackground = Color.White;
            dtpData.Font = new Font("Segoe UI", 9F);
            dtpData.Location = new Point(247, 86);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(160, 23);
            dtpData.TabIndex = 6;
            // 
            // mtxHora
            // 
            mtxHora.AsciiOnly = true;
            mtxHora.BackColor = Color.White;
            mtxHora.BorderStyle = BorderStyle.FixedSingle;
            mtxHora.Font = new Font("Segoe UI", 9F);
            mtxHora.ForeColor = Color.Black;
            mtxHora.Location = new Point(249, 188);
            mtxHora.Mask = "00:00";
            mtxHora.Name = "mtxHora";
            mtxHora.Size = new Size(60, 23);
            mtxHora.TabIndex = 8;
            mtxHora.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = Color.White;
            txtPesquisar.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisar.Font = new Font("Segoe UI", 9F);
            txtPesquisar.ForeColor = Color.Black;
            txtPesquisar.Location = new Point(249, 137);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(170, 23);
            txtPesquisar.TabIndex = 10;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // panelFiltro
            // 
            panelFiltro.BackColor = Color.FromArgb(240, 240, 240);
            panelFiltro.BorderStyle = BorderStyle.FixedSingle;
            panelFiltro.Controls.Add(lblTipoServico);
            panelFiltro.Controls.Add(comboTipoServico);
            panelFiltro.Controls.Add(btnEmitirComprovante);
            panelFiltro.Location = new Point(544, 68);
            panelFiltro.Name = "panelFiltro";
            panelFiltro.Padding = new Padding(16);
            panelFiltro.Size = new Size(424, 106);
            panelFiltro.TabIndex = 11;
            // 
            // lblTipoServico
            // 
            lblTipoServico.AutoSize = true;
            lblTipoServico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipoServico.ForeColor = Color.Black;
            lblTipoServico.Location = new Point(22, 18);
            lblTipoServico.Name = "lblTipoServico";
            lblTipoServico.Size = new Size(94, 15);
            lblTipoServico.TabIndex = 0;
            lblTipoServico.Text = "Tipo de serviço:";
            // 
            // comboTipoServico
            // 
            comboTipoServico.BackColor = Color.White;
            comboTipoServico.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoServico.Font = new Font("Segoe UI", 9F);
            comboTipoServico.ForeColor = Color.Black;
            comboTipoServico.IntegralHeight = false;
            comboTipoServico.ItemHeight = 15;
            comboTipoServico.Location = new Point(25, 42);
            comboTipoServico.MaxDropDownItems = 6;
            comboTipoServico.Name = "comboTipoServico";
            comboTipoServico.Size = new Size(220, 23);
            comboTipoServico.TabIndex = 1;
            // 
            // btnEmitirComprovante
            // 
            btnEmitirComprovante.BackColor = Color.Gainsboro;
            btnEmitirComprovante.FlatAppearance.BorderSize = 0;
            btnEmitirComprovante.FlatStyle = FlatStyle.Flat;
            btnEmitirComprovante.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmitirComprovante.ForeColor = Color.Black;
            btnEmitirComprovante.Location = new Point(265, 41);
            btnEmitirComprovante.Name = "btnEmitirComprovante";
            btnEmitirComprovante.Size = new Size(138, 32);
            btnEmitirComprovante.TabIndex = 3;
            btnEmitirComprovante.Text = "Emitir Comprovante";
            btnEmitirComprovante.UseVisualStyleBackColor = false;
            btnEmitirComprovante.Click += btnEmitirComprovante_Click;
            // 
            // bntTabHome
            // 
            bntTabHome.FlatAppearance.BorderSize = 0;
            bntTabHome.FlatStyle = FlatStyle.Flat;
            bntTabHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bntTabHome.Location = new Point(39, 93);
            bntTabHome.Name = "bntTabHome";
            bntTabHome.Size = new Size(100, 28);
            bntTabHome.TabIndex = 13;
            bntTabHome.Text = "Home";
            // 
            // dgvAgendamentos
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAgendamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvAgendamentos.DefaultCellStyle = dataGridViewCellStyle4;
            dgvAgendamentos.Location = new Point(0, 0);
            dgvAgendamentos.Name = "dgvAgendamentos";
            dgvAgendamentos.Size = new Size(724, 300);
            dgvAgendamentos.TabIndex = 13;
            dgvAgendamentos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelLista
            // 
            panelLista.BackColor = Color.DarkOrange;
            panelLista.Controls.Add(dgvAgendamentos);
            panelLista.Location = new Point(244, 248);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(724, 300);
            panelLista.TabIndex = 12;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 20);
            label1.Name = "label1";
            label1.Size = new Size(141, 58);
            label1.TabIndex = 14;
            label1.Text = "Sound";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(980, 560);
            Controls.Add(label1);
            Controls.Add(bntTabHome);
            Controls.Add(lblTitulo);
            Controls.Add(btnTabCliente);
            Controls.Add(btnTabAgenda);
            Controls.Add(btnTabOrcamentos);
            Controls.Add(tabIndicator);
            Controls.Add(lblData);
            Controls.Add(dtpData);
            Controls.Add(lblHora);
            Controls.Add(mtxHora);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(panelFiltro);
            Controls.Add(panelLista);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            MinimumSize = new Size(880, 480);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Full Sound - Agenda";
            panelFiltro.ResumeLayout(false);
            panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).EndInit();
            panelLista.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnTabCliente;
        private System.Windows.Forms.Button btnTabAgenda;
        private System.Windows.Forms.Button btnTabOrcamentos;
        private System.Windows.Forms.Panel tabIndicator;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.MaskedTextBox mtxHora;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel panelFiltro;
        private System.Windows.Forms.Label lblTipoServico;
        private System.Windows.Forms.ComboBox comboTipoServico;
        private System.Windows.Forms.Button btnEmitirComprovante;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bntTabHome;
        private System.Windows.Forms.DataGridView dgvAgendamentos;
        private System.Windows.Forms.Panel panelLista;
        private Label label1;
    }
}
