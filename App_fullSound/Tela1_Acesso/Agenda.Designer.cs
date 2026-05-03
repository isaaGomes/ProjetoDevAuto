namespace FullSoundApp
{
    partial class Agenda
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
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
            dgvAgendamentos = new DataGridView();
            panelLista = new Panel();
            lbAgenda = new Label();
            ptbAgenda = new PictureBox();
            pictureBox7 = new PictureBox();
            label9 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnSair = new Button();
            label1 = new Label();
            lblTitulo = new Label();
            LbOrçamentos = new Label();
            lbClientes = new Label();
            ptbOrçamentos = new PictureBox();
            ptbClientes = new PictureBox();
            lbClientes2 = new Label();
            pictureBox2 = new PictureBox();
            btnServiço = new Button();
            panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).BeginInit();
            panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbOrçamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblData.ForeColor = Color.White;
            lblData.Location = new Point(418, 138);
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
            lblHora.Location = new Point(417, 240);
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
            lblPesquisar.Location = new Point(417, 189);
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
            dtpData.Location = new Point(420, 156);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(296, 23);
            dtpData.TabIndex = 6;
            // 
            // mtxHora
            // 
            mtxHora.AsciiOnly = true;
            mtxHora.BackColor = Color.White;
            mtxHora.BorderStyle = BorderStyle.FixedSingle;
            mtxHora.Font = new Font("Segoe UI", 9F);
            mtxHora.ForeColor = Color.Black;
            mtxHora.Location = new Point(420, 258);
            mtxHora.Mask = "00:00";
            mtxHora.Name = "mtxHora";
            mtxHora.Size = new Size(67, 23);
            mtxHora.TabIndex = 8;
            mtxHora.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = Color.White;
            txtPesquisar.BorderStyle = BorderStyle.FixedSingle;
            txtPesquisar.Font = new Font("Segoe UI", 9F);
            txtPesquisar.ForeColor = Color.Black;
            txtPesquisar.Location = new Point(420, 207);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(296, 23);
            txtPesquisar.TabIndex = 10;
            // 
            // panelFiltro
            // 
            panelFiltro.BackColor = Color.FromArgb(240, 240, 240);
            panelFiltro.BorderStyle = BorderStyle.FixedSingle;
            panelFiltro.Controls.Add(lblTipoServico);
            panelFiltro.Controls.Add(comboTipoServico);
            panelFiltro.Controls.Add(btnEmitirComprovante);
            panelFiltro.Location = new Point(773, 148);
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
            // dgvAgendamentos
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAgendamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAgendamentos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAgendamentos.Location = new Point(-1, 0);
            dgvAgendamentos.Name = "dgvAgendamentos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAgendamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAgendamentos.Size = new Size(801, 420);
            dgvAgendamentos.TabIndex = 13;
            // 
            // panelLista
            // 
            panelLista.BackColor = Color.DarkOrange;
            panelLista.Controls.Add(dgvAgendamentos);
            panelLista.Location = new Point(415, 342);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(800, 251);
            panelLista.TabIndex = 12;
            // 
            // lbAgenda
            // 
            lbAgenda.AutoSize = true;
            lbAgenda.BackColor = Color.Black;
            lbAgenda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAgenda.ForeColor = Color.DarkOrange;
            lbAgenda.Location = new Point(88, 283);
            lbAgenda.Name = "lbAgenda";
            lbAgenda.Size = new Size(67, 21);
            lbAgenda.TabIndex = 103;
            lbAgenda.Text = "Agenda";
            // 
            // ptbAgenda
            // 
            ptbAgenda.ErrorImage = null;
            ptbAgenda.Image = (Image)resources.GetObject("ptbAgenda.Image");
            ptbAgenda.Location = new Point(28, 259);
            ptbAgenda.Name = "ptbAgenda";
            ptbAgenda.Size = new Size(63, 65);
            ptbAgenda.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAgenda.TabIndex = 106;
            ptbAgenda.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(28, 111);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(63, 56);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 99;
            pictureBox7.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SeaShell;
            label9.Location = new Point(88, 138);
            label9.Name = "label9";
            label9.Size = new Size(55, 21);
            label9.TabIndex = 86;
            label9.Text = "Home";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbAgenda);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ptbAgenda);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(LbOrçamentos);
            panel1.Controls.Add(lbClientes);
            panel1.Controls.Add(ptbOrçamentos);
            panel1.Controls.Add(ptbClientes);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 622);
            panel1.TabIndex = 107;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(97, 550);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 98;
            label3.Text = "Sair";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 527);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.OrangeRed;
            btnSair.ForeColor = SystemColors.Control;
            btnSair.Location = new Point(2347, 603);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 94;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(98, 23);
            label1.Name = "label1";
            label1.Size = new Size(141, 58);
            label1.TabIndex = 96;
            label1.Text = "Sound";
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Window;
            lblTitulo.Location = new Point(23, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(210, 57);
            lblTitulo.TabIndex = 95;
            lblTitulo.Text = "Full";
            // 
            // LbOrçamentos
            // 
            LbOrçamentos.AutoSize = true;
            LbOrçamentos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbOrçamentos.ForeColor = SystemColors.ButtonFace;
            LbOrçamentos.Location = new Point(88, 375);
            LbOrçamentos.Name = "LbOrçamentos";
            LbOrçamentos.Size = new Size(92, 21);
            LbOrçamentos.TabIndex = 85;
            LbOrçamentos.Text = "Orçamento";
            // 
            // lbClientes
            // 
            lbClientes.AutoSize = true;
            lbClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClientes.ForeColor = Color.AliceBlue;
            lbClientes.Location = new Point(88, 208);
            lbClientes.Name = "lbClientes";
            lbClientes.Size = new Size(61, 21);
            lbClientes.TabIndex = 87;
            lbClientes.Text = "Cliente";
            // 
            // ptbOrçamentos
            // 
            ptbOrçamentos.ErrorImage = null;
            ptbOrçamentos.Image = (Image)resources.GetObject("ptbOrçamentos.Image");
            ptbOrçamentos.Location = new Point(28, 351);
            ptbOrçamentos.Name = "ptbOrçamentos";
            ptbOrçamentos.Size = new Size(63, 57);
            ptbOrçamentos.SizeMode = PictureBoxSizeMode.Zoom;
            ptbOrçamentos.TabIndex = 89;
            ptbOrçamentos.TabStop = false;
            // 
            // ptbClientes
            // 
            ptbClientes.ErrorImage = null;
            ptbClientes.Image = (Image)resources.GetObject("ptbClientes.Image");
            ptbClientes.Location = new Point(28, 190);
            ptbClientes.Name = "ptbClientes";
            ptbClientes.Size = new Size(63, 46);
            ptbClientes.SizeMode = PictureBoxSizeMode.Zoom;
            ptbClientes.TabIndex = 90;
            ptbClientes.TabStop = false;
            // 
            // lbClientes2
            // 
            lbClientes2.AutoSize = true;
            lbClientes2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClientes2.ForeColor = Color.White;
            lbClientes2.Location = new Point(492, 46);
            lbClientes2.Name = "lbClientes2";
            lbClientes2.Size = new Size(254, 30);
            lbClientes2.TabIndex = 108;
            lbClientes2.Text = "Agendamento de serviço";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(431, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 109;
            pictureBox2.TabStop = false;
            // 
            // btnServiço
            // 
            btnServiço.BackColor = Color.DarkOrange;
            btnServiço.FlatStyle = FlatStyle.Flat;
            btnServiço.ForeColor = Color.Black;
            btnServiço.Location = new Point(594, 256);
            btnServiço.Name = "btnServiço";
            btnServiço.Size = new Size(122, 23);
            btnServiço.TabIndex = 110;
            btnServiço.Text = "Adicionar Serviço";
            btnServiço.UseVisualStyleBackColor = false;
            // 
            // Agenda
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(1419, 624);
            Controls.Add(btnServiço);
            Controls.Add(pictureBox2);
            Controls.Add(lbClientes2);
            Controls.Add(panel1);
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
            Name = "Agenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Full Sound - Agenda";
            Load += Form1_Load;
            panelFiltro.ResumeLayout(false);
            panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).EndInit();
            panelLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbOrçamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
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
        private DataGridView dgvAgendamentos;
        private Panel panelLista;
        private Label lbAgenda;
        private PictureBox ptbAgenda;
        private PictureBox pictureBox7;
        private Label label9;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnSair;
        private Label label1;
        private Label lblTitulo;
        private Label LbOrçamentos;
        private Label lbClientes;
        private PictureBox ptbOrçamentos;
        private PictureBox ptbClientes;
        private Label lbClientes2;
        private PictureBox pictureBox2;
        private Button btnServiço;
    }
}
