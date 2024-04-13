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
        public Form1()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                if (int.TryParse(textBox1.Text, out int N) && N > 1 && int.TryParse(textBox2.Text, out int A) && int.TryParse(textBox3.Text, out int D))
                {
                    listBox1.Items.Clear();

                    int[] progression = Solution.GenerateArithmeticProgression(N, A, D);

                    foreach (int item in progression)
                    {
                        listBox1.Items.Add($"Результат равен {item}");
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
    }
}
