namespace Tela1_Acesso
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox10 = new PictureBox();
            ptbAgenda = new PictureBox();
            ptbClientes = new PictureBox();
            ptbOrçamentos = new PictureBox();
            lbAgenda = new Label();
            lbClientes = new Label();
            lbHome = new Label();
            LbOrçamentos = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            btnSair = new Button();
            label1 = new Label();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbOrçamentos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(470, 213);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(0, 0);
            pictureBox10.TabIndex = 84;
            pictureBox10.TabStop = false;
            // 
            // ptbAgenda
            // 
            ptbAgenda.ErrorImage = null;
            ptbAgenda.Image = (Image)resources.GetObject("ptbAgenda.Image");
            ptbAgenda.Location = new Point(23, 257);
            ptbAgenda.Name = "ptbAgenda";
            ptbAgenda.Size = new Size(72, 66);
            ptbAgenda.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAgenda.TabIndex = 91;
            ptbAgenda.TabStop = false;
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
            // ptbOrçamentos
            // 
            ptbOrçamentos.ErrorImage = null;
            ptbOrçamentos.Image = (Image)resources.GetObject("ptbOrçamentos.Image");
            ptbOrçamentos.Location = new Point(23, 350);
            ptbOrçamentos.Name = "ptbOrçamentos";
            ptbOrçamentos.Size = new Size(63, 57);
            ptbOrçamentos.SizeMode = PictureBoxSizeMode.Zoom;
            ptbOrçamentos.TabIndex = 89;
            ptbOrçamentos.TabStop = false;
            // 
            // lbAgenda
            // 
            lbAgenda.AutoSize = true;
            lbAgenda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAgenda.ForeColor = SystemColors.ButtonFace;
            lbAgenda.Location = new Point(88, 284);
            lbAgenda.Name = "lbAgenda";
            lbAgenda.Size = new Size(67, 21);
            lbAgenda.TabIndex = 88;
            lbAgenda.Text = "Agenda";
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
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHome.ForeColor = Color.DarkOrange;
            lbHome.Location = new Point(88, 133);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(55, 21);
            lbHome.TabIndex = 86;
            lbHome.Text = "Home";
            // 
            // LbOrçamentos
            // 
            LbOrçamentos.AutoSize = true;
            LbOrçamentos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbOrçamentos.ForeColor = SystemColors.ButtonFace;
            LbOrçamentos.Location = new Point(88, 374);
            LbOrçamentos.Name = "LbOrçamentos";
            LbOrçamentos.Size = new Size(92, 21);
            LbOrçamentos.TabIndex = 85;
            LbOrçamentos.Text = "Orçamento";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(LbOrçamentos);
            panel1.Controls.Add(lbAgenda);
            panel1.Controls.Add(lbClientes);
            panel1.Controls.Add(ptbOrçamentos);
            panel1.Controls.Add(lbHome);
            panel1.Controls.Add(ptbClientes);
            panel1.Controls.Add(ptbAgenda);
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 644);
            panel1.TabIndex = 93;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 106);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 99;
            pictureBox3.TabStop = false;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 527);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 97;
            pictureBox2.TabStop = false;
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
            label1.Click += label1_Click;
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
            lblTitulo.Click += lblTitulo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(281, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1131, 601);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 94;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(1297, 35);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 0;
            label2.Text = "Bem-Vindo!";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1441, 637);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox10);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbOrçamentos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox10;
        private PictureBox ptbAgenda;
        private PictureBox ptbClientes;
        private PictureBox ptbOrçamentos;
        private Label lbAgenda;
        private Label lbClientes;
        private Label lbHome;
        private Label LbOrçamentos;
        private Panel panel1;
        private Label lblTitulo;
        private Label label1;
        private Button btnSair;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
    }
}