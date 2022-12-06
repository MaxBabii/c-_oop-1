using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int n = ((int)numericUpDown1.Value);
            string interval = comboBox1.Text;

            int first_num = Convert.ToInt32(interval.Substring(0, interval.IndexOf(',')));


            int second_num = Convert.ToInt32(interval.Substring(interval.IndexOf(',') + 1, interval.IndexOf(']') - interval.IndexOf(',') - 1));

            int min=second_num, max=first_num;
            Random random = new Random();
            for(int i = 0; i < n; i++)
            {
                int num = random.Next(first_num, second_num);
                textBox1.Text += num + " ";
                if(min > num)
                {
                    min = num;
                }
                if(max < num)
                {
                    max = num;
                }
            }
            int result_sum = min + max;
            int result_minus = max - min;
            label3.Text = $"sum:{result_sum} minus:{result_minus}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
        }
    }
}
