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
            btnFechar = new Button();
            LbNomeDoCliente = new Label();
            LbCelular = new Label();
            LbStatus = new Label();
            LbAddCliente = new Label();
            LbNomeCliente = new Label();
            LbCelular2 = new Label();
            LbTipoDeServiço = new Label();
            LbStatusDoCliente = new Label();
            LbTipoDePagamento = new Label();
            txtNomeDoCliente = new TextBox();
            txtCelular = new TextBox();
            txtTipoDeServiço = new TextBox();
            txtStatusDoCliente = new TextBox();
            txtTipoDePagamento = new TextBox();
            btnAdicionarCliente = new Button();
            btnLinkDeAcessoAoWhatsapp = new Button();
            dgvClientes = new DataGridView();
            LbOrçamentos = new Label();
            lbHome = new Label();
            lbCliente = new Label();
            lbAgenda = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.FromArgb(255, 128, 0);
            btnFechar.Location = new Point(12, 30);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(22, 23);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // LbNomeDoCliente
            // 
            LbNomeDoCliente.AutoSize = true;
            LbNomeDoCliente.ForeColor = Color.FromArgb(255, 128, 0);
            LbNomeDoCliente.Location = new Point(12, 105);
            LbNomeDoCliente.Name = "LbNomeDoCliente";
            LbNomeDoCliente.Size = new Size(100, 15);
            LbNomeDoCliente.TabIndex = 5;
            LbNomeDoCliente.Text = "Nome do Cliente:";
            // 
            // LbCelular
            // 
            LbCelular.AutoSize = true;
            LbCelular.ForeColor = Color.FromArgb(255, 128, 0);
            LbCelular.Location = new Point(274, 105);
            LbCelular.Name = "LbCelular";
            LbCelular.Size = new Size(47, 15);
            LbCelular.TabIndex = 6;
            LbCelular.Text = "Celular:";
            // 
            // LbStatus
            // 
            LbStatus.AutoSize = true;
            LbStatus.ForeColor = Color.FromArgb(255, 128, 0);
            LbStatus.Location = new Point(435, 105);
            LbStatus.Name = "LbStatus";
            LbStatus.Size = new Size(42, 15);
            LbStatus.TabIndex = 7;
            LbStatus.Text = "Status:";
            LbStatus.Click += label7_Click;
            // 
            // LbAddCliente
            // 
            LbAddCliente.AutoSize = true;
            LbAddCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbAddCliente.ForeColor = Color.FromArgb(255, 128, 0);
            LbAddCliente.Location = new Point(12, 313);
            LbAddCliente.Name = "LbAddCliente";
            LbAddCliente.Size = new Size(90, 20);
            LbAddCliente.TabIndex = 8;
            LbAddCliente.Text = "Add Cliente:";
            // 
            // LbNomeCliente
            // 
            LbNomeCliente.AutoSize = true;
            LbNomeCliente.ForeColor = Color.FromArgb(255, 128, 0);
            LbNomeCliente.Location = new Point(12, 351);
            LbNomeCliente.Name = "LbNomeCliente";
            LbNomeCliente.Size = new Size(100, 15);
            LbNomeCliente.TabIndex = 9;
            LbNomeCliente.Text = "Nome do Cliente:";
            // 
            // LbCelular2
            // 
            LbCelular2.AutoSize = true;
            LbCelular2.ForeColor = Color.FromArgb(255, 128, 0);
            LbCelular2.Location = new Point(12, 407);
            LbCelular2.Name = "LbCelular2";
            LbCelular2.Size = new Size(47, 15);
            LbCelular2.TabIndex = 10;
            LbCelular2.Text = "Celular:";
            LbCelular2.Click += label10_Click;
            // 
            // LbTipoDeServiço
            // 
            LbTipoDeServiço.AutoSize = true;
            LbTipoDeServiço.ForeColor = Color.FromArgb(255, 128, 0);
            LbTipoDeServiço.Location = new Point(12, 465);
            LbTipoDeServiço.Name = "LbTipoDeServiço";
            LbTipoDeServiço.Size = new Size(91, 15);
            LbTipoDeServiço.TabIndex = 11;
            LbTipoDeServiço.Text = "Tipo de Serviço:";
            // 
            // LbStatusDoCliente
            // 
            LbStatusDoCliente.AutoSize = true;
            LbStatusDoCliente.ForeColor = Color.FromArgb(255, 128, 0);
            LbStatusDoCliente.Location = new Point(12, 520);
            LbStatusDoCliente.Name = "LbStatusDoCliente";
            LbStatusDoCliente.Size = new Size(99, 15);
            LbStatusDoCliente.TabIndex = 12;
            LbStatusDoCliente.Text = "Status do Cliente:";
            LbStatusDoCliente.Click += label12_Click;
            // 
            // LbTipoDePagamento
            // 
            LbTipoDePagamento.AutoSize = true;
            LbTipoDePagamento.ForeColor = Color.FromArgb(255, 128, 0);
            LbTipoDePagamento.Location = new Point(12, 577);
            LbTipoDePagamento.Name = "LbTipoDePagamento";
            LbTipoDePagamento.Size = new Size(114, 15);
            LbTipoDePagamento.TabIndex = 13;
            LbTipoDePagamento.Text = "Tipo de pagamento:";
            // 
            // txtNomeDoCliente
            // 
            txtNomeDoCliente.Location = new Point(12, 381);
            txtNomeDoCliente.Name = "txtNomeDoCliente";
            txtNomeDoCliente.Size = new Size(228, 23);
            txtNomeDoCliente.TabIndex = 14;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(12, 425);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(228, 23);
            txtCelular.TabIndex = 15;
            // 
            // txtTipoDeServiço
            // 
            txtTipoDeServiço.Location = new Point(12, 483);
            txtTipoDeServiço.Name = "txtTipoDeServiço";
            txtTipoDeServiço.Size = new Size(228, 23);
            txtTipoDeServiço.TabIndex = 16;
            // 
            // txtStatusDoCliente
            // 
            txtStatusDoCliente.Location = new Point(12, 538);
            txtStatusDoCliente.Name = "txtStatusDoCliente";
            txtStatusDoCliente.Size = new Size(228, 23);
            txtStatusDoCliente.TabIndex = 17;
            // 
            // txtTipoDePagamento
            // 
            txtTipoDePagamento.Location = new Point(12, 595);
            txtTipoDePagamento.Name = "txtTipoDePagamento";
            txtTipoDePagamento.Size = new Size(228, 23);
            txtTipoDePagamento.TabIndex = 18;
            // 
            // btnAdicionarCliente
            // 
            btnAdicionarCliente.BackColor = Color.White;
            btnAdicionarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnAdicionarCliente.ForeColor = Color.FromArgb(255, 128, 0);
            btnAdicionarCliente.Location = new Point(301, 369);
            btnAdicionarCliente.Name = "btnAdicionarCliente";
            btnAdicionarCliente.Size = new Size(214, 79);
            btnAdicionarCliente.TabIndex = 20;
            btnAdicionarCliente.Text = "Adicionar Cliente";
            btnAdicionarCliente.UseVisualStyleBackColor = false;
            btnAdicionarCliente.Click += btnAdicionarCliente_Click;
            // 
            // btnLinkDeAcessoAoWhatsapp
            // 
            btnLinkDeAcessoAoWhatsapp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLinkDeAcessoAoWhatsapp.ForeColor = Color.FromArgb(255, 128, 0);
            btnLinkDeAcessoAoWhatsapp.Location = new Point(311, 473);
            btnLinkDeAcessoAoWhatsapp.Name = "btnLinkDeAcessoAoWhatsapp";
            btnLinkDeAcessoAoWhatsapp.Size = new Size(192, 41);
            btnLinkDeAcessoAoWhatsapp.TabIndex = 21;
            btnLinkDeAcessoAoWhatsapp.Text = "Link de acesso ao whatsapp";
            btnLinkDeAcessoAoWhatsapp.UseVisualStyleBackColor = true;
            btnLinkDeAcessoAoWhatsapp.Click += button3_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 123);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(532, 187);
            dgvClientes.TabIndex = 22;
            // 
            // LbOrçamentos
            // 
            LbOrçamentos.AutoSize = true;
            LbOrçamentos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbOrçamentos.Location = new Point(382, 32);
            LbOrçamentos.Name = "LbOrçamentos";
            LbOrçamentos.Size = new Size(95, 21);
            LbOrçamentos.TabIndex = 30;
            LbOrçamentos.Text = "Orçamentos";
            // 
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHome.Location = new Point(65, 32);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(52, 21);
            lbHome.TabIndex = 31;
            lbHome.Text = "Home";
            // 
            // lbCliente
            // 
            lbCliente.AutoSize = true;
            lbCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCliente.Location = new Point(166, 31);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new Size(58, 21);
            lbCliente.TabIndex = 32;
            lbCliente.Text = "Cliente";
            lbCliente.Click += lbCliente_Click;
            // 
            // lbAgenda
            // 
            lbAgenda.AutoSize = true;
            lbAgenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgenda.Location = new Point(274, 32);
            lbAgenda.Name = "lbAgenda";
            lbAgenda.Size = new Size(63, 21);
            lbAgenda.TabIndex = 33;
            lbAgenda.Text = "Agenda";
            // 
            // TelaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(556, 662);
            Controls.Add(lbAgenda);
            Controls.Add(lbCliente);
            Controls.Add(lbHome);
            Controls.Add(LbOrçamentos);
            Controls.Add(dgvClientes);
            Controls.Add(btnLinkDeAcessoAoWhatsapp);
            Controls.Add(btnAdicionarCliente);
            Controls.Add(txtTipoDePagamento);
            Controls.Add(txtStatusDoCliente);
            Controls.Add(txtTipoDeServiço);
            Controls.Add(txtCelular);
            Controls.Add(txtNomeDoCliente);
            Controls.Add(LbTipoDePagamento);
            Controls.Add(LbStatusDoCliente);
            Controls.Add(LbTipoDeServiço);
            Controls.Add(LbCelular2);
            Controls.Add(LbNomeCliente);
            Controls.Add(LbAddCliente);
            Controls.Add(LbStatus);
            Controls.Add(LbCelular);
            Controls.Add(LbNomeDoCliente);
            Controls.Add(btnFechar);
            ForeColor = Color.White;
            Name = "TelaCliente";
            Text = "TelaCliente";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private Label LbNomeDoCliente;
        private Label LbCelular;
        private Label LbStatus;
        private Label LbAddCliente;
        private Label LbNomeCliente;
        private Label LbCelular2;
        private Label LbTipoDeServiço;
        private Label LbStatusDoCliente;
        private Label LbTipoDePagamento;
        private TextBox txtNomeDoCliente;
        private TextBox txtCelular;
        private TextBox txtTipoDeServiço;
        private TextBox txtStatusDoCliente;
        private TextBox txtTipoDePagamento;
        private Button btnAdicionarCliente;
        private Button btnLinkDeAcessoAoWhatsapp;
        private DataGridView dgvClientes;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LbOrçamentos;
        private Label lbHome;
        private Label lbCliente;
        private Label lbAgenda;
    }
}