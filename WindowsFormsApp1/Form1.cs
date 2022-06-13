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
            string a = o_5_2.SelectedItem.ToString(); 

            if (a == "локального характера" || a == "муниципального характера")
            {
                o_5_4.SelectedItem = "низкая";
                o_5_5.SelectedItem = "низкий";
            }
            else if (a == "межмуниципального характера" || a == "регионального характера ")
            {
                o_5_4.SelectedItem = "средняя";
                o_5_5.SelectedItem = "средний";
            }
            else
            {
                o_5_4.SelectedItem = "высокая";
                o_5_5.SelectedItem = "высокий";
            }
        }

        private void button_o_7_Click(object sender, EventArgs e)
        {
            int low = 0;
            int average = 0;
            int high = 0;
            if(lah(o_5_1.Text) == 0)
            {
                low++;
            }
            else if(lah(o_5_1.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }

            if (lah(o_5_2.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_2.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }
            if (lah(o_5_3.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_3.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }
            if (lah(o_5_4.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_4.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }
            if (lah(o_5_5.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_5.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }
            if (lah(o_5_6.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_6.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }

            if (lah(o_5_12.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_12.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }

            if (lah(o_5_8.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_8.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }
            if (lah(o_5_16.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_16.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }
            if (lah(o_5_10.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_10.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }
            if (lah(o_5_7.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_7.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }
            if (lah(o_5_11.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_11.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }
            if (lah(o_5_9.Text) == 0)
            {
                low++;
            }
            else if (lah(o_5_9.Text) == 1)
            {
                average++;
            }
            else
            {
                high++;
            }

            if (high > 0)
            {
                textBox13.Text = "высокий";
                o_8_high.Visible = true;
            }
            else if (average > 0)
            {
                textBox13.Text = "средний";
                o_8_average.Visible = true;
            }
            else
            {
                textBox13.Text = "низкий";
                o_8_low.Visible = true;
            }
        }

        private int lah(string a)
        {
            if (a == "низкий")
            {
                return 0;
            }
            else if (a == "средний")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            o_9_1.Text = name.Text;

            o_9_2.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            //o_9_3.Text = 
            o_9_3_1.Text = textBox13.Text;
            foreach (var el in o_6_1.CheckedItems)
            {
                o_9_4.Items.Add(el);
            }
            foreach (var el in o_6_2.CheckedItems)
            {
                o_9_4.Items.Add(el);
            }

            foreach (var el in o_7.CheckedItems)
            {
                o_9_5.Items.Add(el);
            }

            foreach (var el in o_8_high.CheckedItems)
            {
                o_9_6.Items.Add(el);
            }
            foreach (var el in o_8_average.CheckedItems)
            {
                o_9_6.Items.Add(el);
            }
            foreach (var el in o_8_low.CheckedItems)
            {
                o_9_6.Items.Add(el);
            }
            button1.Enabled = false;
        }
    }
}
