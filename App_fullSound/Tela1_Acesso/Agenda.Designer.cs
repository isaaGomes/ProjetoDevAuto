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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitulo = new Label();
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            dgvAgendamentos = new DataGridView();
            panelLista = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            button1 = new Button();
            panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).BeginInit();
            panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
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
            // 
            // btnTabAgenda
            // 
            btnTabAgenda.FlatAppearance.BorderSize = 0;
            btnTabAgenda.FlatStyle = FlatStyle.Flat;
            btnTabAgenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTabAgenda.Location = new Point(39, 185);
            btnTabAgenda.Name = "btnTabAgenda";
            btnTabAgenda.Size = new Size(100, 28);
            btnTabAgenda.TabIndex = 2;
            btnTabAgenda.Text = "Agenda";
            // 
            // btnTabOrcamentos
            // 
            btnTabOrcamentos.FlatAppearance.BorderSize = 0;
            btnTabOrcamentos.FlatStyle = FlatStyle.Flat;
            btnTabOrcamentos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTabOrcamentos.Location = new Point(39, 235);
            btnTabOrcamentos.Name = "btnTabOrcamentos";
            btnTabOrcamentos.Size = new Size(120, 28);
            btnTabOrcamentos.TabIndex = 3;
            btnTabOrcamentos.Text = "Orçamentos";
            // 
            // tabIndicator
            // 
            tabIndicator.BackColor = Color.Orange;
            tabIndicator.Location = new Point(30, 215);
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
            lblData.Location = new Point(242, 160);
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
            lblHora.Location = new Point(241, 262);
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
            lblPesquisar.Location = new Point(241, 211);
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
            dtpData.Location = new Point(244, 178);
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
            mtxHora.Location = new Point(244, 280);
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
            txtPesquisar.Location = new Point(244, 229);
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
            panelFiltro.Location = new Point(620, 178);
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
            bntTabHome.Location = new Point(39, 100);
            bntTabHome.Name = "bntTabHome";
            bntTabHome.Size = new Size(100, 28);
            bntTabHome.TabIndex = 13;
            bntTabHome.Text = "Home";
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
            // pictureBox1
            // 
            pictureBox1.Image = Tela1_Acesso.Properties.Resources.UI_Frame_FullSound__5_;
            pictureBox1.Location = new Point(39, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(39, 189);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 23);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(39, 240);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 23);
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // dgvAgendamentos
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAgendamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAgendamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvAgendamentos.DefaultCellStyle = dataGridViewCellStyle5;
            dgvAgendamentos.Location = new Point(-1, 0);
            dgvAgendamentos.Name = "dgvAgendamentos";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvAgendamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvAgendamentos.Size = new Size(801, 420);
            dgvAgendamentos.TabIndex = 13;
            // 
            // panelLista
            // 
            panelLista.BackColor = Color.DarkOrange;
            panelLista.Controls.Add(dgvAgendamentos);
            panelLista.Location = new Point(244, 345);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(800, 251);
            panelLista.TabIndex = 12;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(355, 60);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 47);
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(847, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 46);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(345, 113);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(65, 10);
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(603, 61);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(45, 46);
            pictureBox8.TabIndex = 23;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(39, 144);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(22, 23);
            pictureBox7.TabIndex = 24;
            pictureBox7.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(39, 143);
            button1.Name = "button1";
            button1.Size = new Size(100, 28);
            button1.TabIndex = 25;
            button1.Text = "Cliente";
            // 
            // Agenda
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(1126, 620);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(bntTabHome);
            Controls.Add(lblTitulo);
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
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            MinimumSize = new Size(880, 480);
            Name = "Agenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Full Sound - Agenda";
            Load += Form1_Load;
            panelFiltro.ResumeLayout(false);
            panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAgendamentos).EndInit();
            panelLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
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
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private DataGridView dgvAgendamentos;
        private Panel panelLista;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Button button1;
    }
}
