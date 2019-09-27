using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Todo_Application
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }
        Form1 mainForm = new Form1();

        private void Button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            mainForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

          
            if (regLog.Text != "" && regPass.Text != "")
            {
                var user = regLog.Text + " " + regPass.Text;
                var userDoc = regLog.Text + ".txt";
                var userFile = File.Create(userDoc);
                userFile.Close();
                var vUsers = File.Create("vUsers.txt");
                vUsers.Close();
                File.AppendAllText("Users.txt",user + Environment.NewLine);
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Bütün xanalar doldurulmalıdır!");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıxmaq istədiyinizdən əminsiz ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
