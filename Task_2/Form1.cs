using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private int[] array;

        public Form1()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                if (int.TryParse(textBox1.Text, out int N) && int.TryParse(textBox2.Text, out int K) && int.TryParse(textBox3.Text, out int L))
                {
                    if (N > L && L >= K && K >= 0)
                    {
                        FillArray(N);

                        listBox1.Items.Add($"Текущий массив: {string.Join("; ", array)}");
                        listBox1.Items.Add($"Сумма между K и L: {Solution.GetResult(array, K, L)}");
                    }   
                    else
                    {
                        listBox1.Items.Add("Неверно введены числа.\nУсловие: N > L и L >= K и K >= 0");
                    }
                }
                else
                {
                    listBox1.Items.Add("Неверно введенны значения");
                }
                
            }
            catch(Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void FillArray(int n)
        {
            if (array != null)
            {
                array = null;
            }

            if (n > 0)
            {
                array = new int[n];

                Random random = new Random();

                for (int i = 0; i < n; i++)
                {
                    array[i] = random.Next(-100, 100);
                }
            }
        }
    }
}
