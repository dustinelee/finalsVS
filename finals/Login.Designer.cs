namespace finals
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(61, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 557);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 21F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(273, 75);
            label1.Name = "label1";
            label1.Size = new Size(256, 50);
            label1.TabIndex = 0;
            label1.Text = "WELCOME!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 21F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(347, 136);
            label2.Name = "label2";
            label2.Size = new Size(192, 50);
            label2.TabIndex = 1;
            label2.Text = "FITNESS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 21F, FontStyle.Bold);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(545, 140);
            label3.Name = "label3";
            label3.Size = new Size(134, 46);
            label3.TabIndex = 2;
            label3.Text = "GOAL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(217, 251);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(180, 324);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 5;
            label5.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(314, 324);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(319, 31);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(525, 405);
            button1.Name = "button1";
            button1.Size = new Size(139, 42);
            button1.TabIndex = 8;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(347, 405);
            button2.Name = "button2";
            button2.Size = new Size(139, 42);
            button2.TabIndex = 9;
            button2.Text = "LOG IN";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(435, 472);
            button3.Name = "button3";
            button3.Size = new Size(139, 42);
            button3.TabIndex = 10;
            button3.Text = "QUIT";
            button3.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1052, 688);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Button button3;
    }
}