namespace Login_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public class Log    
        {
            public string nev;
            public string email;
            public string passw;

            public Log(string sor)
            {
                string[] r = sor.Split(';');
                this.nev = r[0];
                this.email = r[1];
                this.passw = r[2];
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regisztr�ci� regisztr�ci� = new regisztr�ci�();
            regisztr�ci�.Show();
            Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Log> login = new List<Log>();
            StreamReader sr = new StreamReader("E:\\Reg.txt");
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Log log = new Log(sor);
                login.Add(log);
            }
            sr.Close();

            for (int i = 0; i < login.Count(); i++)
            {
                if (login[i].email == textBox1.Text && login[i].passw == textBox2.Text)
                {
                    MessageBox.Show($"Sikeres bejelentkez�s \n �dv�z�llek {login[i].nev}");
                    F�oldal f�oldal = new F�oldal();
                    f�oldal.Show();
                    Visible = true;
                }
               
            }
        }
    }
}
