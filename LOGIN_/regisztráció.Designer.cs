namespace Login_
{
    partial class regisztráció
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
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Sitka Small", 10.2F);
            linkLabel1.Location = new Point(384, 373);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(131, 25);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bejelentkezés";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 10.2F);
            label2.Location = new Point(131, 271);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 12;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 10.2F);
            label1.Location = new Point(164, 222);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 11;
            label1.Text = "Email:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 136);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(235, 54);
            label3.Name = "label3";
            label3.Size = new Size(326, 52);
            label3.TabIndex = 0;
            label3.Text = "Regisztráció";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sitka Small", 10.2F);
            textBox2.Location = new Point(258, 267);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 29);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Small", 10.2F);
            textBox1.Location = new Point(258, 218);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 29);
            textBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Small", 10.2F);
            button1.Location = new Point(298, 317);
            button1.Name = "button1";
            button1.Size = new Size(153, 34);
            button1.TabIndex = 7;
            button1.Text = "Regisztráció";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 10.2F);
            label4.Location = new Point(215, 373);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 14;
            label4.Text = "Van már fiókod?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 10.2F);
            label5.Location = new Point(164, 170);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 16;
            label5.Text = "Name:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Sitka Small", 10.2F);
            textBox3.Location = new Point(258, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 29);
            textBox3.TabIndex = 15;
            // 
            // regisztráció
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Name = "regisztráció";
            Text = "regisztráció";
            Load += regisztráció_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
    }
}