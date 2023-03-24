using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Belousov_Bubble;
using Belousov_Viborka;
using Belousov_Vstavka;
using Belousov_Perestanov;
namespace ArraySorter
{
    public partial class Form1 : Form
    {
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string myArr = textBox4.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            string texter = string.Join("",BubbleSort.SortArray(result));
            textBox3.Text = texter;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            try
            {
                n = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show(
        "Неверный тип данных",
        "Ошибка",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1);
            }
         
            int[] x = new int[n]; 
            for (int i = 0; i < x.Length; i++)
            {
               textBox4.Text = textBox4.Text + x[i];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myArr = textBox4.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            string texter = string.Join("", ViborkaSorter.ViborkaSort(result));
            textBox3.Text = texter;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int[] x = new int[n];
            if (x.Length > textBox4.TextLength)
            {
                int a = x.Length - textBox4.TextLength;
                while (a > 0)
                {
                    a--;
                    textBox4.Text = textBox4.Text + 0;
                }
            }
            else
            if (x.Length < textBox4.TextLength)
            {
                int a = textBox4.TextLength - x.Length;

                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - a);
                a = 0;

            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string myArr = textBox4.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int resl = result.Length; 
            string texter = string.Join("", VstavkaSorter.SortArray(result));
            textBox3.Text = texter;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string myArr = textBox4.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int resl = result.Length;
            string texter = string.Join("", PerestanovSorter.PerestanovSort(result));
            textBox3.Text = texter;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
