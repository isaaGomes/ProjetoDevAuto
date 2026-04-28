namespace Tela1_Acesso
{
    partial class TelaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCliente));
            LbNome = new Label();
            LbCelular2 = new Label();
            LbTipoDeServiço = new Label();
            LbStatusDoCliente = new Label();
            LbTipoDePagamento = new Label();
            txtNome = new TextBox();
            txtCelular = new TextBox();
            txtTipoDeServiço = new TextBox();
            txtStatusDoCliente = new TextBox();
            LbOrçamentos = new Label();
            lbHome = new Label();
            lbClientes = new Label();
            lbAgenda = new Label();
            ptbOrçamentos = new PictureBox();
            ptbClientes = new PictureBox();
            ptbAgenda = new PictureBox();
            ptbHome = new PictureBox();
            dgvClientes = new DataGridView();
            gbTipodePagamento = new GroupBox();
            rbDébito = new RadioButton();
            btnAdicionarCliente = new Button();
            rbCrédito = new RadioButton();
            rbPix = new RadioButton();
            lbClientes2 = new Label();
            ptbClientes2 = new PictureBox();
            ptbFullSound = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbOrçamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbTipodePagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClientes2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbFullSound).BeginInit();
            SuspendLayout();
            // 
            // LbNome
            // 
            LbNome.AutoSize = true;
            LbNome.ForeColor = Color.White;
            LbNome.Location = new Point(227, 82);
            LbNome.Name = "LbNome";
            LbNome.Size = new Size(43, 15);
            LbNome.TabIndex = 9;
            LbNome.Text = "Nome:";
            LbNome.Click += LbNomeCliente_Click;
            // 
            // LbCelular2
            // 
            LbCelular2.AutoSize = true;
            LbCelular2.ForeColor = Color.White;
            LbCelular2.Location = new Point(555, 82);
            LbCelular2.Name = "LbCelular2";
            LbCelular2.Size = new Size(47, 15);
            LbCelular2.TabIndex = 10;
            LbCelular2.Text = "Celular:";
            LbCelular2.Click += label10_Click;
            // 
            // LbTipoDeServiço
            // 
            LbTipoDeServiço.AutoSize = true;
            LbTipoDeServiço.ForeColor = Color.White;
            LbTipoDeServiço.Location = new Point(226, 141);
            LbTipoDeServiço.Name = "LbTipoDeServiço";
            LbTipoDeServiço.Size = new Size(91, 15);
            LbTipoDeServiço.TabIndex = 11;
            LbTipoDeServiço.Text = "Tipo de Serviço:";
            // 
            // LbStatusDoCliente
            // 
            LbStatusDoCliente.AutoSize = true;
            LbStatusDoCliente.ForeColor = Color.White;
            LbStatusDoCliente.Location = new Point(228, 196);
            LbStatusDoCliente.Name = "LbStatusDoCliente";
            LbStatusDoCliente.Size = new Size(99, 15);
            LbStatusDoCliente.TabIndex = 12;
            LbStatusDoCliente.Text = "Status do Cliente:";
            LbStatusDoCliente.Click += label12_Click;
            // 
            // LbTipoDePagamento
            // 
            LbTipoDePagamento.AutoSize = true;
            LbTipoDePagamento.ForeColor = Color.White;
            LbTipoDePagamento.Location = new Point(736, 82);
            LbTipoDePagamento.Name = "LbTipoDePagamento";
            LbTipoDePagamento.Size = new Size(114, 15);
            LbTipoDePagamento.TabIndex = 13;
            LbTipoDePagamento.Text = "Tipo de pagamento:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(227, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(310, 23);
            txtNome.TabIndex = 14;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(555, 100);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(126, 23);
            txtCelular.TabIndex = 15;
            // 
            // txtTipoDeServiço
            // 
            txtTipoDeServiço.Location = new Point(228, 163);
            txtTipoDeServiço.Name = "txtTipoDeServiço";
            txtTipoDeServiço.Size = new Size(406, 23);
            txtTipoDeServiço.TabIndex = 16;
            // 
            // txtStatusDoCliente
            // 
            txtStatusDoCliente.Location = new Point(228, 214);
            txtStatusDoCliente.Name = "txtStatusDoCliente";
            txtStatusDoCliente.Size = new Size(128, 23);
            txtStatusDoCliente.TabIndex = 17;
            // 
            // LbOrçamentos
            // 
            LbOrçamentos.AutoSize = true;
            LbOrçamentos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbOrçamentos.Location = new Point(55, 225);
            LbOrçamentos.Name = "LbOrçamentos";
            LbOrçamentos.Size = new Size(99, 21);
            LbOrçamentos.TabIndex = 30;
            LbOrçamentos.Text = "Orçamentos";
            // 
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHome.Location = new Point(55, 118);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(55, 21);
            lbHome.TabIndex = 31;
            lbHome.Text = "Home";
            // 
            // lbClientes
            // 
            lbClientes.AutoSize = true;
            lbClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClientes.Location = new Point(55, 157);
            lbClientes.Name = "lbClientes";
            lbClientes.Size = new Size(68, 21);
            lbClientes.TabIndex = 32;
            lbClientes.Text = "Clientes";
            lbClientes.Click += lbCliente_Click;
            // 
            // lbAgenda
            // 
            lbAgenda.AutoSize = true;
            lbAgenda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAgenda.Location = new Point(55, 191);
            lbAgenda.Name = "lbAgenda";
            lbAgenda.Size = new Size(67, 21);
            lbAgenda.TabIndex = 33;
            lbAgenda.Text = "Agenda";
            // 
            // ptbOrçamentos
            // 
            ptbOrçamentos.ErrorImage = null;
            ptbOrçamentos.Image = Properties.Resources.UI_Frame_FullSound__8_;
            ptbOrçamentos.Location = new Point(27, 225);
            ptbOrçamentos.Name = "ptbOrçamentos";
            ptbOrçamentos.Size = new Size(22, 21);
            ptbOrçamentos.TabIndex = 34;
            ptbOrçamentos.TabStop = false;
            // 
            // ptbClientes
            // 
            ptbClientes.ErrorImage = null;
            ptbClientes.Image = Properties.Resources.UI_Frame_FullSound__6_;
            ptbClientes.Location = new Point(27, 155);
            ptbClientes.Name = "ptbClientes";
            ptbClientes.Size = new Size(22, 21);
            ptbClientes.TabIndex = 35;
            ptbClientes.TabStop = false;
            // 
            // ptbAgenda
            // 
            ptbAgenda.ErrorImage = null;
            ptbAgenda.Image = Properties.Resources.UI_Frame_FullSound__7_;
            ptbAgenda.Location = new Point(28, 191);
            ptbAgenda.Name = "ptbAgenda";
            ptbAgenda.Size = new Size(21, 21);
            ptbAgenda.TabIndex = 36;
            ptbAgenda.TabStop = false;
            // 
            // ptbHome
            // 
            ptbHome.AccessibleRole = AccessibleRole.OutlineButton;
            ptbHome.ErrorImage = null;
            ptbHome.Image = Properties.Resources.UI_Frame_FullSound__5_;
            ptbHome.Location = new Point(27, 118);
            ptbHome.Name = "ptbHome";
            ptbHome.Size = new Size(26, 21);
            ptbHome.TabIndex = 37;
            ptbHome.TabStop = false;
            ptbHome.Click += pictureBox4_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(27, 341);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(909, 287);
            dgvClientes.TabIndex = 39;
            // 
            // gbTipodePagamento
            // 
            gbTipodePagamento.Controls.Add(rbPix);
            gbTipodePagamento.Controls.Add(rbCrédito);
            gbTipodePagamento.Controls.Add(rbDébito);
            gbTipodePagamento.Location = new Point(736, 111);
            gbTipodePagamento.Name = "gbTipodePagamento";
            gbTipodePagamento.Size = new Size(200, 154);
            gbTipodePagamento.TabIndex = 41;
            gbTipodePagamento.TabStop = false;
            gbTipodePagamento.Text = "groupBox1";
            // 
            // rbDébito
            // 
            rbDébito.AutoSize = true;
            rbDébito.Location = new Point(6, 30);
            rbDébito.Name = "rbDébito";
            rbDébito.Size = new Size(60, 19);
            rbDébito.TabIndex = 0;
            rbDébito.TabStop = true;
            rbDébito.Text = "Débito";
            rbDébito.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.BackColor = Color.FromArgb(255, 128, 0);
            btnAdicionarCliente.BackgroundImageLayout = ImageLayout.None;
            btnAdicionarCliente.FlatStyle = FlatStyle.Flat;
            btnAdicionarCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarCliente.ForeColor = Color.Black;
            btnAdicionarCliente.Location = new Point(407, 267);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(130, 38);
            btnAdicionarCliente.TabIndex = 42;
            btnAdicionarCliente.Text = "Adicionar Cliente";
            btnAdicionarCliente.UseVisualStyleBackColor = false;
            // 
            // rbCrédito
            // 
            rbCrédito.AutoSize = true;
            rbCrédito.Location = new Point(6, 55);
            rbCrédito.Name = "rbCrédito";
            rbCrédito.Size = new Size(67, 19);
            rbCrédito.TabIndex = 1;
            rbCrédito.TabStop = true;
            rbCrédito.Text = "Crédito ";
            rbCrédito.UseVisualStyleBackColor = true;
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.Location = new Point(6, 82);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(40, 19);
            rbPix.TabIndex = 2;
            rbPix.TabStop = true;
            rbPix.Text = "Pix";
            rbPix.UseVisualStyleBackColor = true;
            // 
            // lbClientes2
            // 
            lbClientes2.AutoSize = true;
            lbClientes2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClientes2.ForeColor = Color.White;
            lbClientes2.Location = new Point(373, 36);
            lbClientes2.Name = "lbClientes2";
            lbClientes2.Size = new Size(87, 30);
            lbClientes2.TabIndex = 43;
            lbClientes2.Text = "Clientes";
            lbClientes2.Click += label3_Click;
            // 
            // ptbClientes2
            // 
            ptbClientes2.Image = (Image)resources.GetObject("ptbClientes2.Image");
            ptbClientes2.Location = new Point(341, 27);
            ptbClientes2.Name = "ptbClientes2";
            ptbClientes2.Size = new Size(35, 39);
            ptbClientes2.TabIndex = 44;
            ptbClientes2.TabStop = false;
            // 
            // ptbFullSound
            // 
            ptbFullSound.Image = (Image)resources.GetObject("ptbFullSound.Image");
            ptbFullSound.Location = new Point(12, 27);
            ptbFullSound.Name = "ptbFullSound";
            ptbFullSound.Size = new Size(221, 50);
            ptbFullSound.TabIndex = 45;
            ptbFullSound.TabStop = false;
            // 
            // TelaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(975, 662);
            Controls.Add(ptbFullSound);
            Controls.Add(ptbClientes2);
            Controls.Add(lbClientes2);
            Controls.Add(btnAdicionarCliente);
            Controls.Add(gbTipodePagamento);
            Controls.Add(dgvClientes);
            Controls.Add(ptbHome);
            Controls.Add(ptbAgenda);
            Controls.Add(ptbClientes);
            Controls.Add(ptbOrçamentos);
            Controls.Add(lbAgenda);
            Controls.Add(lbClientes);
            Controls.Add(lbHome);
            Controls.Add(LbOrçamentos);
            Controls.Add(txtStatusDoCliente);
            Controls.Add(txtTipoDeServiço);
            Controls.Add(txtCelular);
            Controls.Add(txtNome);
            Controls.Add(LbTipoDePagamento);
            Controls.Add(LbStatusDoCliente);
            Controls.Add(LbTipoDeServiço);
            Controls.Add(LbCelular2);
            Controls.Add(LbNome);
            ForeColor = Color.White;
            Name = "TelaCliente";
            Text = "TelaCliente";
            ((System.ComponentModel.ISupportInitialize)ptbOrçamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbTipodePagamento.ResumeLayout(false);
            gbTipodePagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClientes2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbFullSound).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LbNome;
        private Label LbCelular2;
        private Label LbTipoDeServiço;
        private Label LbStatusDoCliente;
        private Label LbTipoDePagamento;
        private TextBox txtNome;
        private TextBox txtCelular;
        private TextBox txtTipoDeServiço;
        private TextBox txtStatusDoCliente;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lbClientes2;
        private Label LbOrçamentos;
        private Label lbHome;
        private Label lbClientes;
        private Label lbAgenda;
        private PictureBox ptbOrçamentos;
        private PictureBox ptbClientes;
        private PictureBox ptbAgenda;
        private PictureBox ptbHome;
        private DataGridView dgvClientes;
        private GroupBox gbTipodePagamento;
        private RadioButton rbDébito;
        private Button btnAdicionarCliente;
        private RadioButton rbPix;
        private RadioButton rbCrédito;
        private PictureBox ptbClientes2;
        private PictureBox ptbFullSound;
    }
}