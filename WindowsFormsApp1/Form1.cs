using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Other Form = new Other(name.Text);
            Form.Show();
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = listBox1.SelectedItem.ToString(); 

            if (a == "локального характера" || a == "муниципального характера")
            {
                listBox3.SelectedItem = "низкая";
                listBox4.SelectedItem = "низкий";
            }
            else if (a == "межмуниципального характера" || a == "регионального характера ")
            {
                listBox3.SelectedItem = "средняя";
                listBox4.SelectedItem = "средний";
            }
            else
            {
                listBox3.SelectedItem = "высокая";
                listBox4.SelectedItem = "высокий";
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
