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
            dgvOrcamento = new DataGridView();
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
            pictureBox3 = new PictureBox();
            ptbClientes = new PictureBox();
            label13 = new Label();
            btnEmitirComprovante = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrcamento).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbOrçamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAgenda).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClientes).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(492, 51);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 49;
            label2.Text = "Orçamento";
            // 
            // dgvOrcamento
            // 
            dgvOrcamento.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvOrcamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrcamento.Location = new Point(431, 287);
            dgvOrcamento.Name = "dgvOrcamento";
            dgvOrcamento.Size = new Size(929, 325);
            dgvOrcamento.TabIndex = 66;
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
            panel1.Location = new Point(431, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 99);
            panel1.TabIndex = 73;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MediumSeaGreen;
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
            label6.Location = new Point(319, 49);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 3;
            label6.Text = "Saldo: R$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(219, 49);
            label5.Name = "label5";
            label5.Size = new Size(29, 21);
            label5.TabIndex = 2;
            label5.Text = "R$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(113, 48);
            label4.Name = "label4";
            label4.Size = new Size(29, 21);
            label4.TabIndex = 1;
            label4.Text = "R$";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(10, 16);
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
            label9.Location = new Point(431, 241);
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
            LbOrçamentos.Location = new Point(93, 375);
            LbOrçamentos.Name = "LbOrçamentos";
            LbOrçamentos.Size = new Size(92, 21);
            LbOrçamentos.TabIndex = 100;
            LbOrçamentos.Text = "Orçamento";
            // 
            // lbAgenda
            // 
            lbAgenda.AutoSize = true;
            lbAgenda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAgenda.ForeColor = SystemColors.ButtonFace;
            lbAgenda.Location = new Point(88, 286);
            lbAgenda.Name = "lbAgenda";
            lbAgenda.Size = new Size(67, 21);
            lbAgenda.TabIndex = 103;
            lbAgenda.Text = "Agenda";
            // 
            // ptbOrçamentos
            // 
            ptbOrçamentos.ErrorImage = null;
            ptbOrçamentos.Image = (Image)resources.GetObject("ptbOrçamentos.Image");
            ptbOrçamentos.Location = new Point(28, 351);
            ptbOrçamentos.Name = "ptbOrçamentos";
            ptbOrçamentos.Size = new Size(63, 57);
            ptbOrçamentos.SizeMode = PictureBoxSizeMode.Zoom;
            ptbOrçamentos.TabIndex = 104;
            ptbOrçamentos.TabStop = false;
            // 
            // ptbAgenda
            // 
            ptbAgenda.ErrorImage = null;
            ptbAgenda.Image = (Image)resources.GetObject("ptbAgenda.Image");
            ptbAgenda.Location = new Point(23, 259);
            ptbAgenda.Name = "ptbAgenda";
            ptbAgenda.Size = new Size(72, 66);
            ptbAgenda.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAgenda.TabIndex = 106;
            ptbAgenda.TabStop = false;
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
            pictureBox7.Location = new Point(28, 111);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(63, 56);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 99;
            pictureBox7.TabStop = false;
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
            lbClientes.Location = new Point(88, 208);
            lbClientes.Name = "lbClientes";
            lbClientes.Size = new Size(61, 21);
            lbClientes.TabIndex = 87;
            lbClientes.Text = "Cliente";
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
            ptbClientes.ErrorImage = null;
            ptbClientes.Image = (Image)resources.GetObject("ptbClientes.Image");
            ptbClientes.Location = new Point(28, 190);
            ptbClientes.Name = "ptbClientes";
            ptbClientes.Size = new Size(63, 46);
            ptbClientes.SizeMode = PictureBoxSizeMode.Zoom;
            ptbClientes.TabIndex = 90;
            ptbClientes.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.SeaShell;
            label13.Location = new Point(88, 138);
            label13.Name = "label13";
            label13.Size = new Size(55, 21);
            label13.TabIndex = 86;
            label13.Text = "Home";
            // 
            // btnEmitirComprovante
            // 
            btnEmitirComprovante.BackColor = Color.DarkOrange;
            btnEmitirComprovante.FlatStyle = FlatStyle.Flat;
            btnEmitirComprovante.Font = new Font("Segoe UI", 10F);
            btnEmitirComprovante.ForeColor = Color.Black;
            btnEmitirComprovante.Location = new Point(1175, 241);
            btnEmitirComprovante.Name = "btnEmitirComprovante";
            btnEmitirComprovante.Size = new Size(185, 40);
            btnEmitirComprovante.TabIndex = 111;
            btnEmitirComprovante.Text = "Emitir Comprovante";
            btnEmitirComprovante.TextAlign = ContentAlignment.MiddleRight;
            btnEmitirComprovante.UseVisualStyleBackColor = false;
            // 
            // Orçamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1419, 624);
            Controls.Add(panel3);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(dgvOrcamento);
            Controls.Add(label2);
            Controls.Add(btnEmitirComprovante);
            Name = "Orçamentos";
            Text = "Orçamentos";
            Load += Orçamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrcamento).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbOrçamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAgenda).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbClientes).EndInit();
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
        private DataGridView dgvOrcamento;
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
    }
}