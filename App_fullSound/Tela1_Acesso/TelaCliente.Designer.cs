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
            LbTipoDePagamento = new Label();
            txtNome = new TextBox();
            txtCelular = new TextBox();
            dgvClientes = new DataGridView();
            gbTipodePagamento = new GroupBox();
            rbPix = new RadioButton();
            rbCrédito = new RadioButton();
            rbDébito = new RadioButton();
            lbClientes2 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            btnSair = new Button();
            label1 = new Label();
            lblTitulo = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbTipodePagamento.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // LbNome
            // 
            LbNome.AutoSize = true;
            LbNome.ForeColor = Color.White;
            LbNome.Location = new Point(435, 107);
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
            LbCelular2.Location = new Point(780, 107);
            LbCelular2.Name = "LbCelular2";
            LbCelular2.Size = new Size(47, 15);
            LbCelular2.TabIndex = 10;
            LbCelular2.Text = "Celular:";
            LbCelular2.Click += label10_Click;
            // 
            // LbTipoDePagamento
            // 
            LbTipoDePagamento.AutoSize = true;
            LbTipoDePagamento.ForeColor = Color.White;
            LbTipoDePagamento.Location = new Point(950, 106);
            LbTipoDePagamento.Name = "LbTipoDePagamento";
            LbTipoDePagamento.Size = new Size(92, 15);
            LbTipoDePagamento.TabIndex = 13;
            LbTipoDePagamento.Text = "Tipo do veículo:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(435, 125);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(310, 23);
            txtNome.TabIndex = 14;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(780, 125);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(126, 23);
            txtCelular.TabIndex = 15;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(431, 333);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(719, 261);
            dgvClientes.TabIndex = 39;
            // 
            // gbTipodePagamento
            // 
            gbTipodePagamento.Controls.Add(rbPix);
            gbTipodePagamento.Controls.Add(rbCrédito);
            gbTipodePagamento.Controls.Add(rbDébito);
            gbTipodePagamento.Location = new Point(950, 135);
            gbTipodePagamento.Name = "gbTipodePagamento";
            gbTipodePagamento.Size = new Size(200, 147);
            gbTipodePagamento.TabIndex = 41;
            gbTipodePagamento.TabStop = false;
            gbTipodePagamento.Text = "groupBox1";
            // 
            // rbPix
            // 
            rbPix.AutoSize = true;
            rbPix.Location = new Point(6, 82);
            rbPix.Name = "rbPix";
            rbPix.Size = new Size(46, 19);
            rbPix.TabIndex = 2;
            rbPix.TabStop = true;
            rbPix.Text = "SUV";
            rbPix.UseVisualStyleBackColor = true;
            // 
            // rbCrédito
            // 
            rbCrédito.AutoSize = true;
            rbCrédito.Location = new Point(6, 55);
            rbCrédito.Name = "rbCrédito";
            rbCrédito.Size = new Size(57, 19);
            rbCrédito.TabIndex = 1;
            rbCrédito.TabStop = true;
            rbCrédito.Text = "Sedan";
            rbCrédito.UseVisualStyleBackColor = true;
            // 
            // rbDébito
            // 
            rbDébito.AutoSize = true;
            rbDébito.Location = new Point(6, 30);
            rbDébito.Name = "rbDébito";
            rbDébito.Size = new Size(57, 19);
            rbDébito.TabIndex = 0;
            rbDébito.TabStop = true;
            rbDébito.Text = "Hatch";
            rbDébito.UseVisualStyleBackColor = true;
            // 
            // lbClientes2
            // 
            lbClientes2.AutoSize = true;
            lbClientes2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbClientes2.ForeColor = Color.White;
            lbClientes2.Location = new Point(492, 51);
            lbClientes2.Name = "lbClientes2";
            lbClientes2.Size = new Size(200, 30);
            lbClientes2.TabIndex = 43;
            lbClientes2.Text = "Cadastro de Cliente";
            lbClientes2.Click += label3_Click;
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 621);
            panel1.TabIndex = 94;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(88, 374);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 85;
            label2.Text = "Orçamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(88, 284);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 88;
            label4.Text = "Agenda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(88, 208);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 87;
            label5.Text = "Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 89;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SeaShell;
            label6.Location = new Point(88, 133);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 86;
            label6.Text = "Home";
            // 
            // pictureBox4
            // 
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(28, 188);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 90;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(23, 257);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(72, 66);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 91;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(431, 32);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(55, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 95;
            pictureBox6.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(782, 175);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 96;
            button1.Text = "Adicionar Cliente";
            button1.UseVisualStyleBackColor = false;
            // 
            // TelaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1419, 624);
            Controls.Add(button1);
            Controls.Add(pictureBox6);
            Controls.Add(panel1);
            Controls.Add(lbClientes2);
            Controls.Add(gbTipodePagamento);
            Controls.Add(dgvClientes);
            Controls.Add(txtCelular);
            Controls.Add(txtNome);
            Controls.Add(LbTipoDePagamento);
            Controls.Add(LbCelular2);
            Controls.Add(LbNome);
            ForeColor = Color.White;
            Name = "TelaCliente";
            Text = "TelaCliente";
            Load += TelaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbTipodePagamento.ResumeLayout(false);
            gbTipodePagamento.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LbNome;
        private Label LbCelular2;
        private Label LbTipoDePagamento;
        private TextBox txtNome;
        private TextBox txtCelular;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lbClientes2;
        private DataGridView dgvClientes;
        private GroupBox gbTipodePagamento;
        private RadioButton rbDébito;
        private RadioButton rbPix;
        private RadioButton rbCrédito;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnSair;
        private Label label1;
        private Label lblTitulo;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button button1;
    }
}