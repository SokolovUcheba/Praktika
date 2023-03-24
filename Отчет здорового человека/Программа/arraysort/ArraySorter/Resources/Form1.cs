using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Sokolov_CoctailSort;
using Sokolov_CombSort;
using Sokolov_InsertionSort;
using Sokolov_QuickSort;
namespace ArraySorter
{
    public partial class Form1 : Form
    {
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            string myArr = textBox4.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            string texter = string.Join("",CoctailSorter.SortArray(result));
            textBox3.Text = texter;
            sw.Stop();
            textBox7.Text = sw.Elapsed.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            try
            {
                n = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "";
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
            var sw = new Stopwatch();
            sw.Start();
            string myArr = textBox4.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            string texter = string.Join("", CombSorter.SortArray(result));
            textBox3.Text = texter;
            sw.Stop();
            textBox6.Text = sw.Elapsed.ToString();
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
            var sw = new Stopwatch();
            sw.Start();
            string myArr = textBox4.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int resl = result.Length; 
            string texter = string.Join("", InsertionSorter.SortArray(result));
            sw.Stop();
            textBox5.Text = sw.Elapsed.ToString();
            textBox3.Text = texter;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            string myArr = textBox4.Text;
            int[] result = myArr.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int resl = result.Length;
            string texter = string.Join("", QuickSortet.SortArray(result));
            sw.Stop();
            textBox2.Text = sw.Elapsed.ToString();
            textBox3.Text = texter;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
