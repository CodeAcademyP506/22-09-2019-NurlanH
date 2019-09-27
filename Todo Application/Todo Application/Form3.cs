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
    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(listAdder.Text != "")
            {
                lists.Items.Add(listAdder.Text);
                listAdder.Text = "";
            }
            else
            {
                MessageBox.Show("Bu xana boş buraxıla bilməz");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to delete this user", "Danger", MessageBoxButtons.YesNo);
            var selectedDo = lists.SelectedIndex;
           

            var line = lists.Items[selectedDo];

            if (result == DialogResult.Yes)
            {
                lists.Items.RemoveAt(selectedDo);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıxmaq istədiyinizdən əminsiz ?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var userPath = label1.Text + ".txt";
            File.Delete(userPath);
            foreach (var item in lists.Items)
            {
                File.AppendAllText(userPath, item.ToString() + Environment.NewLine);
            }
        }


        public void userTodoLists()
        {
            var userPath = label1.Text + ".txt";
            string[] toDoLists = File.ReadAllLines(userPath);

            for (int i = 0; i < toDoLists.Length; i++)
            {
                if(toDoLists[i] != null)
                {
                    lists.Items.Add(toDoLists[i]);
                }
            }
        }
    }
}
