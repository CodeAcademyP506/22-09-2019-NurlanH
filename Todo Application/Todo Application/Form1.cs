using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_Application
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Form3 userPanel = new Form3();
       
        private void BtnSingUp(object sender, EventArgs e)
        {
            this.Hide();
            form2 form = new form2();
            form.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıxmaq istədiyinizdən əminsiz ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] oldLines = File.ReadAllLines("Users.txt");
            var word = textBox1.Text + " " + textBox2.Text;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                for (int i = 0; i < oldLines.Length; i++)
                {
                    if (oldLines[i].Contains(word))
                    {
                        MessageBox.Show("sisteme xosh gelmisiniz");
                        this.Hide();
                        userPanel.label1.Text = textBox1.Text;
                        userPanel.Show();
                        userPanel.userTodoLists();
                        return;
                    }
                }
                MessageBox.Show("Sistemdə belə bir adam yoxdur, zəhmət olmasa qeydiyyat keçin");
            }
            else
            {
                MessageBox.Show("Bu xanalar boş ola bilməz!");
            }
           


        }

    }

}
    

