namespace Login_
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
            button1 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Small", 10.2F);
            button1.Location = new Point(555, 282);
            button1.Name = "button1";
            button1.Size = new Size(153, 34);
            button1.TabIndex = 0;
            button1.Text = "Bejelentkezés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Small", 10.2F);
            textBox1.Location = new Point(249, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 29);
            textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-8, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 136);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(235, 54);
            label3.Name = "label3";
            label3.Size = new Size(364, 52);
            label3.TabIndex = 0;
            label3.Text = "Bejelentkezés";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sitka Small", 10.2F);
            textBox2.Location = new Point(249, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 29);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 10.2F);
            label1.Location = new Point(155, 212);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 3;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 10.2F);
            label2.Location = new Point(122, 287);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Sitka Small", 10.2F);
            linkLabel1.Location = new Point(417, 363);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 25);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Regisztráció";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 10.2F);
            label4.Location = new Point(122, 363);
            label4.Name = "label4";
            label4.Size = new Size(289, 25);
            label4.TabIndex = 6;
            label4.Text = "Ha még nem regisztráltál volna:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox2;
        private Label label3;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}
