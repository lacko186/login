using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_
{
    public partial class regisztráció : Form
    {
        public regisztráció()
        {
            InitializeComponent();
        }

        class Reg
        {
            public string nev;
            public string email;
            public string jelszo;

            public Reg(string sor)
            {
                string[] r = sor.Split(';');
                this.nev = r[0];
                this.email = r[1];
                this.jelszo = r[2];
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Visible = true;
        }

        private void regisztráció_Load_1(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("E:\\Reg.txt", true))
            {
                if (textBox3.Text != "" && textBox1.Text != "" && textBox2.Text != "")
                {
                    // Új felhasználói adatokat hozzáfűz
                    sw.WriteLine($"{textBox3.Text};{textBox1.Text};{textBox2.Text}");
                }
            }
           
        }
    }
}
