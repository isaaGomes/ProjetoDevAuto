namespace Tela1_Acesso
{
    partial class Orçamentos
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
            lblX = new Label();
            lblEmissao = new Label();
            lblFluxo = new Label();
            lblEmitir = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            ColEntrada = new DataGridViewTextBoxColumn();
            ColSaidas = new DataGridViewTextBoxColumn();
            ColSaldo = new DataGridViewTextBoxColumn();
            ColLista = new DataGridViewTextBoxColumn();
            lblHome = new Label();
            lblCliente = new Label();
            lblOrcamentos = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.BackColor = Color.White;
            lblX.Cursor = Cursors.Hand;
            lblX.Location = new Point(8, 6);
            lblX.Name = "lblX";
            lblX.Size = new Size(14, 15);
            lblX.TabIndex = 0;
            lblX.Text = "X";
            // 
            // lblEmissao
            // 
            lblEmissao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmissao.ForeColor = SystemColors.ButtonHighlight;
            lblEmissao.Location = new Point(6, 15);
            lblEmissao.Name = "lblEmissao";
            lblEmissao.Size = new Size(252, 23);
            lblEmissao.TabIndex = 0;
            lblEmissao.Text = "Emissão de comprovante";
            // 
            // lblFluxo
            // 
            lblFluxo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFluxo.ForeColor = SystemColors.ButtonHighlight;
            lblFluxo.Location = new Point(4, 12);
            lblFluxo.Name = "lblFluxo";
            lblFluxo.Size = new Size(287, 23);
            lblFluxo.TabIndex = 0;
            lblFluxo.Text = "Entrada de fluxo de caixa";
            // 
            // lblEmitir
            // 
            lblEmitir.AutoSize = true;
            lblEmitir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmitir.ForeColor = SystemColors.ButtonHighlight;
            lblEmitir.Location = new Point(6, 13);
            lblEmitir.Name = "lblEmitir";
            lblEmitir.Size = new Size(150, 21);
            lblEmitir.TabIndex = 11;
            lblEmitir.Text = "Emitir Comprovante";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 106, 0);
            panel1.Controls.Add(lblEmissao);
            panel1.Location = new Point(8, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 53);
            panel1.TabIndex = 12;
            panel1.MouseClick += panel1_MouseClick;
            panel1.MouseEnter += panel1_MouseEnter;
            panel1.MouseLeave += panel1_MouseLeave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 106, 0);
            panel3.Controls.Add(lblFluxo);
            panel3.Location = new Point(8, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(718, 51);
            panel3.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 106, 0);
            panel5.Controls.Add(lblEmitir);
            panel5.Location = new Point(8, 432);
            panel5.Name = "panel5";
            panel5.Size = new Size(718, 45);
            panel5.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(62, 62, 62);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColEntrada, ColSaidas, ColSaldo, ColLista });
            dataGridView1.Location = new Point(8, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(718, 255);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColEntrada
            // 
            ColEntrada.HeaderText = "Entradas";
            ColEntrada.Name = "ColEntrada";
            // 
            // ColSaidas
            // 
            ColSaidas.HeaderText = "Saídas";
            ColSaidas.Name = "ColSaidas";
            // 
            // ColSaldo
            // 
            ColSaldo.HeaderText = "Saldo do dia/mês";
            ColSaldo.Name = "ColSaldo";
            // 
            // ColLista
            // 
            ColLista.HeaderText = "Lista de movimentações";
            ColLista.Name = "ColLista";
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.BackColor = Color.Black;
            lblHome.Cursor = Cursors.Hand;
            lblHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHome.ForeColor = SystemColors.ButtonHighlight;
            lblHome.Location = new Point(40, 9);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(52, 21);
            lblHome.TabIndex = 41;
            lblHome.Text = "Home";
            lblHome.Click += lblHome_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Black;
            lblCliente.Cursor = Cursors.Hand;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.ButtonHighlight;
            lblCliente.Location = new Point(106, 9);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 21);
            lblCliente.TabIndex = 42;
            lblCliente.Text = "Cliente";
            lblCliente.Click += lblCliente_Click;
            // 
            // lblOrcamentos
            // 
            lblOrcamentos.AutoSize = true;
            lblOrcamentos.BackColor = Color.Black;
            lblOrcamentos.Cursor = Cursors.Hand;
            lblOrcamentos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrcamentos.ForeColor = SystemColors.ButtonHighlight;
            lblOrcamentos.Location = new Point(248, 9);
            lblOrcamentos.Name = "lblOrcamentos";
            lblOrcamentos.Size = new Size(95, 21);
            lblOrcamentos.TabIndex = 44;
            lblOrcamentos.Text = "Orçamentos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(176, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 45;
            label1.Text = "Agenda";
            label1.Click += label1_Click_1;
            label1.MouseClick += label1_MouseClick;
            label1.MouseEnter += label1_MouseEnter;
            // 
            // Orçamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(738, 494);
            Controls.Add(label1);
            Controls.Add(lblOrcamentos);
            Controls.Add(lblCliente);
            Controls.Add(lblHome);
            Controls.Add(dataGridView1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lblX);
            Name = "Orçamentos";
            Text = "Orçamentos";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblX;
        private Label lblEmissao;
        private Label lblFluxo;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lblEmitir;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColEntrada;
        private DataGridViewTextBoxColumn ColSaidas;
        private DataGridViewTextBoxColumn ColSaldo;
        private DataGridViewTextBoxColumn ColLista;
        private Label lblHome;
        private Label lblCliente;
        private Label lblAgenda;
        private Label lblOrcamentos;
        private Label label1;
    }
}