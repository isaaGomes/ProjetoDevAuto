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

            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            dgvServicos = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Servico = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1 = new Panel();
            label11 = new Label();
            label7 = new Label();
            label3 = new Label();

            lbl = new Label();
            label6 = new Label();
            label4 = new Label();
            lblFluxo = new Label();
            pictureBox7 = new PictureBox();
            label9 = new Label();
            pictureBox8 = new PictureBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();

            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // lblHome
            // 
            // 

            // label2
            // 
            // 
            // dgvOrcamento
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(13, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 26);
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 155);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 28);
            pictureBox4.TabIndex = 52;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(44, 44, 43);
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 193);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 23);
            pictureBox5.TabIndex = 53;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // dgvServicos
            // 
            dgvServicos.AllowUserToAddRows = false;
            dgvServicos.AllowUserToDeleteRows = false;
            dgvServicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicos.BackgroundColor = Color.FromArgb(46, 46, 46);
            dgvServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicos.Columns.AddRange(new DataGridViewColumn[] { Data, Servico, Valor, Status });
            dgvServicos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvServicos.Location = new Point(234, 237);
            dgvServicos.MultiSelect = false;
            dgvServicos.Name = "dgvServicos";
            dgvServicos.RowHeadersVisible = false;
            dgvServicos.Size = new Size(835, 331);
            dgvServicos.TabIndex = 66;
            dgvServicos.CellContentClick += dgvServiços_CellContentClick;
            dgvServicos.CellPainting += dgvServicos_CellPainting;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Servico
            // 
            Servico.HeaderText = "Serviço";
            Servico.Name = "Servico";
            // 
            // Valor
            // 
            Valor.HeaderText = "R$ Valor";
            Valor.Name = "Valor";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.Transparent;
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(233, 25);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(26, 30);
            pictureBox15.TabIndex = 69;
            pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.Location = new Point(-4, 190);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(166, 28);
            pictureBox16.TabIndex = 70;
            pictureBox16.TabStop = false;
            pictureBox16.Click += pictureBox16_Click;
            // 
            // pictureBox17
            // 
            pictureBox17.BackgroundImage = (Image)resources.GetObject("pictureBox17.BackgroundImage");
            pictureBox17.Image = (Image)resources.GetObject("pictureBox17.Image");
            pictureBox17.Location = new Point(1, 190);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(10, 27);
            pictureBox17.TabIndex = 71;
            pictureBox17.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(851, 581);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(223, 45);
            pictureBox6.TabIndex = 72;
            pictureBox6.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 44, 43);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbl);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblFluxo);
            panel1.Location = new Point(234, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 115);
            panel1.TabIndex = 73;
            panel1.Paint += panel1_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkOrange;
            label11.Location = new Point(642, 53);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 8;
            label11.Text = "Saldo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(352, 54);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 6;
            label7.Text = "Saídas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(11, 54);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Entradas:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.ForeColor = Color.MediumSeaGreen;
            lbl.Image = (Image)resources.GetObject("lbl.Image");
            lbl.Location = new Point(10, 75);
            lbl.Name = "lbl";
            lbl.Size = new Size(38, 25);
            lbl.TabIndex = 4;
            lbl.Text = "R$ ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(642, 75);
            label6.Name = "label6";
            label6.Size = new Size(33, 25);
            label6.TabIndex = 3;
            label6.Text = "R$";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Firebrick;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(352, 75);
            label4.Name = "label4";
            label4.Size = new Size(33, 25);
            label4.TabIndex = 1;
            label4.Text = "R$";
            label4.Click += label4_Click_1;
            // 
            // lblFluxo
            // 
            lblFluxo.AutoSize = true;
            lblFluxo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFluxo.ForeColor = SystemColors.ButtonHighlight;
            lblFluxo.Image = (Image)resources.GetObject("lblFluxo.Image");
            lblFluxo.Location = new Point(10, 16);
            lblFluxo.Name = "lblFluxo";
            lblFluxo.Size = new Size(134, 25);
            lblFluxo.TabIndex = 0;
            lblFluxo.Text = "Fluxo de Caixa";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(44, 44, 43);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(861, 586);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 32);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 74;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // label8
            // 
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(231, 209);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 76;
            label9.Text = "Listas de Serviços";
            label9.Click += label9_Click_1;
            // 
            // LbOrçamentos
            // 
            pictureBox8.BackColor = Color.FromArgb(216, 141, 41);
            pictureBox8.BackgroundImageLayout = ImageLayout.None;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(864, 589);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 77;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // lbAgenda
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkOrange;
            label12.Image = (Image)resources.GetObject("label12.Image");
            label12.Location = new Point(915, 593);
            label12.Name = "label12";
            label12.Size = new Size(142, 20);
            label12.TabIndex = 78;
            label12.Text = "Emitir Comprovante";
            // 
            // 
            // ptbOrçamentos
            // 

            // 
            // ptbAgenda
            // 
            // 
            // panel3
            // 
            // label1
            // 
            // pictureBox1
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
            // btnSair
            // 
            // label10
            // 
            // lblTitulo
            // 
            // 
            // lbClientes
            // 
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(431, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 89;
            pictureBox3.TabStop = false;
            // 
            // ptbClientes
            // 
            // 
            // label13
            // 

            // 
            // btnEmitirComprovante
            // 
            // Orçamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;

            ClientSize = new Size(1099, 642);
            Controls.Add(pictureBox8);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(panel1);

            Controls.Add(pictureBox6);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox15);
            Controls.Add(dgvServicos);
            Controls.Add(pictureBox4);
            Load += Orçamentos_Load_1;

            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;

        private Label label11;



        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private DataGridView dgvServicos;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox6;
        private Panel panel1;
        private PictureBox pictureBox7;
        private Label lbl;
        private Label label6;
        private Label label4;
        private Label lblFluxo;
        private PictureBox pictureBox8;
        private Label label12;
        private Label label7;
        private Label label3;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Servico;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Status;
    }
}