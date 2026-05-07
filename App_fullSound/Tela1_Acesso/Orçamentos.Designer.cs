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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orçamentos));
            label2 = new Label();
            dgvServicos = new DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            LbOrçamentos = new Label();
            lbAgenda = new Label();
            ptbOrçamentos = new PictureBox();
            ptbAgenda = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            btnSair = new Button();
            label10 = new Label();
            lblTitulo = new Label();
            lbClientes = new Label();
            ptbClientes = new PictureBox();
            label13 = new Label();
            pictureBox3 = new PictureBox();
            btnEmitirComprovante = new Button();
            pictureBox2 = new PictureBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Serviço = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbOrçamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAgenda).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(397, 66);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 49;
            label2.Text = "Orçamentos";
            label2.Click += label2_Click;
            // 
            // dgvServicos
            // 
            dgvServicos.AllowUserToAddRows = false;
            dgvServicos.AllowUserToDeleteRows = false;
            dgvServicos.BackgroundColor = Color.FromArgb(32, 32, 32);
            dgvServicos.BorderStyle = BorderStyle.None;
            dgvServicos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvServicos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvServicos.ColumnHeadersHeight = 38;
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvServicos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Data, Column4, Serviço, Valor, Status });
            dgvServicos.EnableHeadersVisualStyles = false;
            dgvServicos.GridColor = Color.FromArgb(45, 45, 45);
            dgvServicos.Location = new Point(355, 287);
            dgvServicos.Name = "dgvServicos";
            dgvServicos.RowHeadersVisible = false;
            dgvServicos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvServicos.Size = new Size(981, 325);
            dgvServicos.TabIndex = 66;
            dgvServicos.CellContentClick += dgvServicos_CellContentClick;
            dgvServicos.CellPainting += dgvServicos_CellPainting;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(355, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 94);
            panel1.TabIndex = 73;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.ForestGreen;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(10, 47);
            label7.Name = "label7";
            label7.Size = new Size(33, 21);
            label7.TabIndex = 4;
            label7.Text = "R$ ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(399, 48);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 3;
            label6.Text = "Saldo: R$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.ForestGreen;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(262, 48);
            label5.Name = "label5";
            label5.Size = new Size(29, 21);
            label5.TabIndex = 2;
            label5.Text = "R$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.ForestGreen;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(134, 48);
            label4.Name = "label4";
            label4.Size = new Size(29, 21);
            label4.TabIndex = 1;
            label4.Text = "R$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(10, 15);
            label3.Name = "label3";
            label3.Size = new Size(109, 21);
            label3.TabIndex = 0;
            label3.Text = "Fluxo de Caixa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(355, 241);
            label9.Name = "label9";
            label9.Size = new Size(150, 25);
            label9.TabIndex = 76;
            label9.Text = "Listas de Serviços";
            // 
            // LbOrçamentos
            // 
            LbOrçamentos.AutoSize = true;
            LbOrçamentos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbOrçamentos.ForeColor = Color.DarkOrange;
            LbOrçamentos.Location = new Point(81, 371);
            LbOrçamentos.Name = "LbOrçamentos";
            LbOrçamentos.Size = new Size(99, 21);
            LbOrçamentos.TabIndex = 100;
            LbOrçamentos.Text = "Orçamentos";
            LbOrçamentos.Click += LbOrçamentos_Click;
            // 
            // lbAgenda
            // 
            lbAgenda.AutoSize = true;
            lbAgenda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAgenda.ForeColor = SystemColors.ButtonFace;
            lbAgenda.Location = new Point(83, 288);
            lbAgenda.Name = "lbAgenda";
            lbAgenda.Size = new Size(67, 21);
            lbAgenda.TabIndex = 103;
            lbAgenda.Text = "Agenda";
            lbAgenda.Click += lbAgenda_Click;
            // 
            // ptbOrçamentos
            // 
            ptbOrçamentos.ErrorImage = null;
            ptbOrçamentos.Image = (Image)resources.GetObject("ptbOrçamentos.Image");
            ptbOrçamentos.Location = new Point(18, 333);
            ptbOrçamentos.Name = "ptbOrçamentos";
            ptbOrçamentos.Size = new Size(63, 86);
            ptbOrçamentos.SizeMode = PictureBoxSizeMode.Zoom;
            ptbOrçamentos.TabIndex = 104;
            ptbOrçamentos.TabStop = false;
            ptbOrçamentos.Click += ptbOrçamentos_Click;
            // 
            // ptbAgenda
            // 
            ptbAgenda.ErrorImage = null;
            ptbAgenda.Image = (Image)resources.GetObject("ptbAgenda.Image");
            ptbAgenda.Location = new Point(27, 261);
            ptbAgenda.Name = "ptbAgenda";
            ptbAgenda.Size = new Size(49, 66);
            ptbAgenda.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAgenda.TabIndex = 106;
            ptbAgenda.TabStop = false;
            ptbAgenda.Click += ptbAgenda_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(LbOrçamentos);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(ptbOrçamentos);
            panel3.Controls.Add(lbAgenda);
            panel3.Controls.Add(btnSair);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(ptbAgenda);
            panel3.Controls.Add(lblTitulo);
            panel3.Controls.Add(lbClientes);
            panel3.Controls.Add(ptbClientes);
            panel3.Controls.Add(label13);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 622);
            panel3.TabIndex = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(97, 550);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 98;
            label1.Text = "Sair";
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
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(29, 117);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(49, 56);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 99;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
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
            // label10
            // 
            label10.Font = new Font("Segoe UI", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkOrange;
            label10.Location = new Point(98, 23);
            label10.Name = "label10";
            label10.Size = new Size(141, 58);
            label10.TabIndex = 96;
            label10.Text = "Sound";
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
            // lbClientes
            // 
            lbClientes.AutoSize = true;
            lbClientes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClientes.ForeColor = Color.AliceBlue;
            lbClientes.Location = new Point(84, 214);
            lbClientes.Name = "lbClientes";
            lbClientes.Size = new Size(61, 21);
            lbClientes.TabIndex = 87;
            lbClientes.Text = "Cliente";
            lbClientes.Click += lbClientes_Click;
            // 
            // ptbClientes
            // 
            ptbClientes.ErrorImage = null;
            ptbClientes.Image = (Image)resources.GetObject("ptbClientes.Image");
            ptbClientes.Location = new Point(28, 195);
            ptbClientes.Name = "ptbClientes";
            ptbClientes.Size = new Size(49, 46);
            ptbClientes.SizeMode = PictureBoxSizeMode.Zoom;
            ptbClientes.TabIndex = 90;
            ptbClientes.TabStop = false;
            ptbClientes.Click += ptbClientes_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.SeaShell;
            label13.Location = new Point(83, 141);
            label13.Name = "label13";
            label13.Size = new Size(55, 21);
            label13.TabIndex = 86;
            label13.Text = "Home";
            label13.Click += label13_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(350, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 89;
            pictureBox3.TabStop = false;
            // 
            // btnEmitirComprovante
            // 
            btnEmitirComprovante.BackColor = Color.DarkOrange;
            btnEmitirComprovante.FlatStyle = FlatStyle.Flat;
            btnEmitirComprovante.Font = new Font("Segoe UI", 10F);
            btnEmitirComprovante.ForeColor = Color.Black;
            btnEmitirComprovante.Location = new Point(1151, 233);
            btnEmitirComprovante.Name = "btnEmitirComprovante";
            btnEmitirComprovante.Size = new Size(185, 40);
            btnEmitirComprovante.TabIndex = 111;
            btnEmitirComprovante.Text = "Emitir Comprovante";
            btnEmitirComprovante.TextAlign = ContentAlignment.MiddleRight;
            btnEmitirComprovante.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkOrange;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1163, 239);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 32);
            pictureBox2.TabIndex = 112;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nome";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Celular";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tipo do Veículo";
            Column3.Name = "Column3";
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Column4
            // 
            Column4.HeaderText = "Hora";
            Column4.Name = "Column4";
            // 
            // Serviço
            // 
            Serviço.HeaderText = "Serviço";
            Serviço.Name = "Serviço";
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Orçamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1349, 624);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(dgvServicos);
            Controls.Add(label2);
            Controls.Add(btnEmitirComprovante);
            Name = "Orçamentos";
            Text = "Orçamentos";
            Load += Orçamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbOrçamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAgenda).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Panel panel4;
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
        private Label lblAgenda;
        private Label label2;
        private DataGridView dgvServicos;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label LbOrçamentos;
        private Label lbAgenda;
        private PictureBox ptbOrçamentos;
        private PictureBox ptbAgenda;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private Button btnSair;
        private Label label10;
        private Label lblTitulo;
        private Label lbClientes;
        private PictureBox pictureBox3;
        private PictureBox ptbClientes;
        private Button btnEmitirComprovante;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Serviço;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Status;
    }
}