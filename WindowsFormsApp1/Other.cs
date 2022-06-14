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
    public partial class Other : Form
    {
        public Other(string name)
        {
            this.name = name;
            InitializeComponent();
        }

        private string name;
        private int col = 0;
        private bool flag = true;

        private Dictionary<string, List<(string, string, string)>> o4 =
            new Dictionary<string, List<(string, string, string)>>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (name_4.Text == "")
            {
                MessageBox.Show("Введите название информации");
                return;
            }

            if (flag)
            {
                flag = false;
                col = (int) info3.Value;
            }

            List<(string, string, string)> l_4 = new List<(string, string, string)>();

            if (o_4_1.SelectedItem != null && o_4_2.SelectedItem != null)
            {
                (string, string, string) a_1 = (o_4_1.SelectedItem.ToString(),
                    o_4_2.SelectedItem.ToString(), o_4_3.SelectedItem.ToString());
                l_4.Add(a_1);
            }

            if (o_4_2_1.SelectedItem != null && o_4_2_2.SelectedItem != null)
            {
                (string, string, string) a_2 = (o_4_2_1.SelectedItem.ToString(),
                    o_4_2_2.SelectedItem.ToString(), o_4_2_3.SelectedItem.ToString());
                l_4.Add(a_2);
            }

            if (o_4_3_1.SelectedItem != null && o_4_3_2.SelectedItem != null)
            {
                (string, string, string) a_3 = (o_4_3_1.SelectedItem.ToString(),
                    o_4_3_2.SelectedItem.ToString(), o_4_3_3.SelectedItem.ToString());
                l_4.Add(a_3);
            }

            int low = 0;
            int average = 0;
            int high = 0;
            foreach (var el in l_4)
            {
                if (el.Item3 == "низкая")
                {
                    low++;
                }
                else if (el.Item3 == "средняя")
                {
                    average++;
                }
                else if (el.Item3 == "высокая")
                {
                    high++;
                }
            }

            string high_1 = "низкий";
            if (high > 0)
            {
                high_1 = "высокий";
            }
            else if (average > 0)
            {
                high_1 = "средний";
            }

            if (l_4.Count >= 1)
            {
                l_4.Add(("", "", high_1));
                o4[name_4.Text] = l_4;
                col--;
                if (col == 0)
                {
                    button1.Enabled = false;
                    button_o_5.Enabled = true;
                }

                name_4.Text = "";
                o_4_1.SelectedItem = null;
                o_4_2.SelectedItem = null;
                o_4_3.SelectedItem = null;

                o_4_2_1.SelectedItem = null;
                o_4_2_2.SelectedItem = null;
                o_4_2_3.SelectedItem = null;

                o_4_3_1.SelectedItem = null;
                o_4_3_2.SelectedItem = null;
                o_4_3_3.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Выберите хотя бы одно свойство");
            }
        }

        private void o_4_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (o_4_2.SelectedItem != null)
            {
                string a = o_4_2.SelectedItem.ToString();

                if (a == "локального характера" || a == "муниципального характера")
                {
                    o_4_3.SelectedItem = "низкая";
                }
                else if (a == "межмуниципального характера" || a == "регионального характера")
                {
                    o_4_3.SelectedItem = "средняя";
                }
                else
                {
                    o_4_3.SelectedItem = "высокая";
                }
            }

        }

        private void o_4_2_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (o_4_2_2.SelectedItem != null)
            {
                string a = o_4_2_2.SelectedItem.ToString();

                if (a == "локального характера" || a == "муниципального характера")
                {
                    o_4_2_3.SelectedItem = "низкая";
                }
                else if (a == "межмуниципального характера" || a == "регионального характера")
                {
                    o_4_2_3.SelectedItem = "средняя";
                }
                else
                {
                    o_4_2_3.SelectedItem = "высокая";
                }
            }
        }

        private void o_4_3_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (o_4_3_2.SelectedItem != null)
            {
                string a = o_4_3_2.SelectedItem.ToString();

                if (a == "локального характера" || a == "муниципального характера")
                {
                    o_4_3_3.SelectedItem = "низкая";
                }
                else if (a == "межмуниципального характера" || a == "регионального характера")
                {
                    o_4_3_3.SelectedItem = "средняя";
                }
                else
                {
                    o_4_3_3.SelectedItem = "высокая";
                }
            }
        }

        private void button_o_5_Click(object sender, EventArgs e)
        {
            int low = 0;
            int high = 0;
            int average = 0;
            foreach (var el in o4)
            {
                if (el.Value.Last().Item3 == "низкий")
                {
                    low++;
                }
                else if (el.Value.Last().Item3 == "средний")
                {
                    average++;
                }
                else
                {
                    high++;
                }

            }

            if (high > 0)
            {
                o_5.Text = "1 класс";
                o_8_high.Visible = true;
            }
            else if (average > 0)
            {
                o_5.Text = "2 класс";
                o_8_average.Visible = true;
            }
            else
            {
                o_5.Text = "3 класс";
                o_8_low.Visible = true;
            }
        }

        private void button_o_9_Click(object sender, EventArgs e)
        {
            o_9_1.Text = name;
            o_9_3.Text = o_5.Text;
            o_9_4.Items.Clear();
            if ((o_6_1.CheckedItems.Count + o_6_2.CheckedItems.Count) != 0)
            {
                if (o_6_1.CheckedItems.Count != 0)
                {
                    foreach (var el in o_6_1.CheckedItems)
                    {
                        o_9_4.Items.Add(el);
                    }
                }

                if (o_6_2.CheckedItems.Count != 0)
                {
                    foreach (var el in o_6_2.CheckedItems)
                    {
                        o_9_4.Items.Add(el);
                    }
                }
            }
            else
            {
                o_9_4.Items.Add("Не были выбраны потенциальные нарушители");
            }

            if (o_5.Text == "1 класс")
            {
                if (o_8_high.CheckedItems.Count != 0)
                {
                    foreach (var el in o_7.CheckedItems)
                    {
                        o_9_5.Items.Add(el);
                    }
                }

                for (int i = 0; i < o_8_high.Items.Count; i++)
                {
                    if (!o_8_high.GetItemChecked(i))
                    {
                        o_9_6.Items.Add(o_8_high.Items[i], CheckState.Indeterminate);
                    }
                }
            }
            else if(o_5.Text == "2 класс")
            {
                o_9_5.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                o_9_6.Visible = false;
            }
            else
            {
                if (o_8_low.CheckedItems.Count != 0)
                {
                    foreach (var el in o_7.CheckedItems)
                    {
                        o_9_5.Items.Add(el);
                    }
                    for (int i = 0; i < o_8_low.Items.Count; i++)
                    {
                        if (!o_8_low.GetItemChecked(i))
                        {
                            o_9_6.Items.Add(o_8_low.Items[i], CheckState.Indeterminate);
                        }
                    }
                }
            }

        }
        
        

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gainsboro;
            button2.ForeColor = Color.Black;
        }
        Point lastPoint;
        private void Other_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void Other_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
