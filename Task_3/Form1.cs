using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private readonly int[,] matrix = new int[5, 5];
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            GenerateMatrix();
            DisplayMatrix();
            CalculateColumnSums();
        }

        private void GenerateMatrix()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-19, 50); // Generate random numbers from -19 to 49
                }
            }
        }

        private void DisplayMatrix()
        {
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 5;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
        }

        private void CalculateColumnSums()
        {
            List<int> columnSums = new List<int>();

            for (int j = 0; j < 5; j++)
            {
                int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] % 2 == 0) // Check if the number is even
                    {
                        sum += matrix[i, j];
                    }
                }
                columnSums.Add(sum);
            }

            listBox1.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add($"Sum of even numbers in column {i + 1}: {columnSums[i]}");
            }
        }
    }
}
