namespace Tela1_Acesso
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(267, 136);
            button2.Name = "button2";
            button2.Size = new Size(243, 125);
            button2.TabIndex = 2;
            button2.Text = "Cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(516, 136);
            button3.Name = "button3";
            button3.Size = new Size(212, 125);
            button3.TabIndex = 2;
            button3.Text = "Agenda";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(757, 143);
            button4.Name = "button4";
            button4.Size = new Size(217, 110);
            button4.TabIndex = 2;
            button4.Text = "button2";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.CausesValidation = false;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 3;
            label1.Text = " Full Sound";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 450);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = Color.White;
            button6.Location = new Point(36, 247);
            button6.Name = "button6";
            button6.Size = new Size(125, 31);
            button6.TabIndex = 5;
            button6.Text = "Orçamento";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.White;
            button5.Location = new Point(36, 165);
            button5.Name = "button5";
            button5.Size = new Size(125, 34);
            button5.TabIndex = 5;
            button5.Text = "Agenda";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(11, 80);
            button1.Name = "button1";
            button1.Size = new Size(150, 44);
            button1.TabIndex = 5;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1099, 450);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button1;
    }
}
