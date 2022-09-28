using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RGR_2
{
    public partial class Form1 : Form
    {
        int Row, Col;
        double[,] two_array;
        Random rnd = new Random();
        bool is_exist_array = false;
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private int Data = 0;
        private double[,] Mass = new double[100,100];

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_rows.Text.Length > 0 && tb_cols.Text.Length > 0)
            {
                //Проверка(строк) на соответствие форматов 
                try
                {
                    Row = int.Parse(tb_rows.Text);
                    
                    
                }
                catch (FormatException)
                {
                    tb_rows.Text = "ERROR";
                    MessageBox.Show("Ошибка!\n Неверный формат!");
                    
                    tb_rows.Clear();

                }
                //Проверка(столбцов) на соответствие форматов
                try
                {
                    Col = int.Parse(tb_cols.Text);

                }
                catch (FormatException)
                {
                    tb_cols.Text = "ERROR";
                    MessageBox.Show("Ошибка!\n Неверный формат!");
                    
                    tb_cols.Clear();
                }
                
                two_array = new double[Row, Col];
                dgv1.Rows.Clear();
                dgv1.Columns.Clear();
                dgv1.RowHeadersVisible = false;
                dgv1.ColumnHeadersVisible = false;
                dgv1.ColumnCount = Col;
                dgv1.RowCount = Row;
                int number_start = 0;
                int number_end = 0;
                int number_between = 0;
                
                for (int i = 0; i < Col; i++)//Задаем ширину столбцов
                {
                    dgv1.Columns[i].Width = 50;
                }
                //Проверка(интервал 1) на соответствие форматов
                try
                {
                    number_start = int.Parse(tb_rnd_start.Text);

                }
                catch (FormatException)
                {
                    tb_rnd_start.Text = "ERROR";
                    MessageBox.Show("Ошибка!\n Неверный формат!");

                    tb_rnd_start.Clear();
                }
                //Проверка(интервал 2) на соответствие форматов
                try
                {
                    number_end = int.Parse(tb_rnd_end.Text);
                    number_between = number_end - number_start;
                    tb_output.Clear();
                    //tb_output.Text += string.Format($"number_start = {0}" + Environment.NewLine, number_start);
                    //tb_output.Text += string.Format($"number_end = {0}" + Environment.NewLine, number_end);
                    //tb_output.Text += string.Format($"number_between = {0}" + Environment.NewLine, number_between);
                    
                    //Заполнение массива рандомными числами
                    for (int i = 0; i < Row; i++)
                    {
                        for (int j = 0; j < Col; j++)
                        {
                            two_array[i, j] = number_start + rnd.NextDouble() * number_between;
                            dgv1.Rows[i].Cells[j].Value = String.Format("{0:0.00}", two_array[i, j]);
                            Mass[i, j] = two_array[i, j];

                        }
                    }
                }
                catch (FormatException)
                {
                    tb_rnd_end.Text = "ERROR";
                    MessageBox.Show("Ошибка!\n Неверный формат!");

                    tb_rnd_end.Clear();
                }
               
               
                is_exist_array = true;
                

            }
            else
            {
                MessageBox.Show("Вы не ввели количество строк и/или столбцов!, Внимание!" +
                    $"{MessageBoxButtons.OK}" +
                    $"{MessageBoxIcon.Asterisk}" +
                    $"{MessageBoxDefaultButton.Button2}");
            }

        }
        //Метод чтения файла из папки 
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Текстовый файл|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    StreamReader sr = new StreamReader(filePath);
                    if (int.Parse(sr.ReadLine()).ToString() != "0")
                    {
                        Row = int.Parse(sr.ReadLine());
                        tb_rows.Text = Row.ToString();
                        Col = int.Parse(sr.ReadLine());
                        tb_cols.Text = Col.ToString();
                        two_array = new double[Row, Col];
                        dgv1.Rows.Clear();
                        dgv1.Columns.Clear();
                        dgv1.RowHeadersVisible = false;
                        dgv1.ColumnHeadersVisible = false;
                        dgv1.ColumnCount = Col;
                        dgv1.RowCount = Row;
                        for (int i = 0; i < Col; i++)
                        {
                            dgv1.Columns[i].Width = 50;
                        }
                        for (int i = 0; i < Row; i++)
                        {
                            string[] str_array = sr.ReadLine().Split('\t');
                            for (int j = 0; j < Col; j++)
                            {
                                two_array[i, j] = double.Parse(str_array[j]);
                            }
                        }
                        for (int i = 0; i < Row; i++)
                        {
                            for (int j = 0; j < Col; j++)
                            {
                                dgv1.Rows[i].Cells[j].Value = string.Format("{0:0.00}", two_array[i, j]);
                            }
                        }
                    }
                    else MessageBox.Show("Ошибка!");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Ошибка!");

            }

        }
        //Метод сохранения файла в папку
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                saveFileDialog1.Filter = "Текстовый файл|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(filePath, false);
                    sw.WriteLine(Row);
                    sw.WriteLine(Col);
                    for (int i = 0; i < Row; i++)
                    {
                        for (int j = 0; j < Col; j++)
                        {
                            sw.Write(two_array[i, j] + "\t");
                        }
                        sw.WriteLine();
                    }
                    sw.Close();
                }
            }
            catch (FieldAccessException)
            {

                MessageBox.Show("Ошибка!");
            }
           

        }
        //Кнопка "Задание 1"
        private void Tb_runClick_CheckedChanged(object sender, EventArgs e)
        {
            Data = 1;
            tb_output.Text = "Сгенерировать матрицу и заполнить вещественными числами (положительнымии отрицательными). Определить номер столбца с минимальной и максимальной суммойэлементов.Вывести номер столбца с минимальной и максимальной суммой, а также двазначения суммы элементов.";
        }
        //Кнопка "Задание 5"
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Data = 5;
            tb_output.Text = "Сгенерировать матрицу  и заполнить вещественными числами(положительными и отрицательными).Реализовать алгоритм транспонирования матрицы ивывести транспонированную матрицу.";
        }
        //Кнопка "Задание 2"
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Data = 2;
            tb_output.Text = "Сгенерировать матрицу и заполнить вещественными числами (положительнымии отрицательными). Определить отношение максимального элемента всех четных строк кминимальному элементы нечетных столбцов. Разделить элементы четных столбцов наполученное отношение.)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Выполнение 1 задания
            if (Data == 1)
            {
                tb_output.Clear();
                double MinValue1 = 1000.00;
                double MinValue2 = 0;
                double MaxValue1 = 0;
                double MaxValue2 = 0;
                int MinValueStolb = 0;
                int MaxValueStolb = 0;

                for (int i = 0; i < two_array.GetLength(0); i++)
                {
                    int y = 0;
                    
                    for (int j = 0; j < two_array.GetLength(1); j++)
                    {
                        MinValue2 += two_array[j, i];
                        y = i;
                    }
                    if (MinValue1 > MinValue2)
                    {
                        MinValue1 = MinValue2;
                        MinValueStolb = y;
                        MinValue2 = 0;
                    }
                    MinValue2 = 0;

                }
                for (int i = 0; i < two_array.GetLength(0); i++)
                {
                    int y = 0;
                    
                    for (int j = 0; j < two_array.GetLength(1); j++)
                    {
                        MaxValue2 += two_array[j, i];
                        y = i;
                    }
                    if (MaxValue2 > MaxValue1)
                    {
                        MaxValue1 = MaxValue2;
                        MaxValueStolb = y;
                        MaxValue2 = 0;
                    }
                    MaxValue2 = 0;
                }
                MinValueStolb = MinValueStolb + 1;
                MaxValueStolb = MaxValueStolb + 1;
                tb_output.Text = $"Номер с минимальной суммой столбца:{MinValueStolb}  Сумма:{MinValue1}\t Номер с максимальной суммой столбца:{MaxValueStolb}  Сумма:{MaxValue1}";
            }
            //Выполнение 2 задания
            if (Data == 2 )
            {
                tb_output.Clear();
                double MinValue1 = 1000.00;
                double MinValue2 = 0;
                double MaxValue1 = 0;
                double MaxValue2 = 0;
                double relationship = 0;
                for (int i = 0; i < two_array.GetLength(0); i++)
                {
                    for (int j = 0; j < two_array.GetLength(1); j++)
                    {
                        if(i % 2 == 0 && MaxValue1 < two_array[i,j])
                        {
                            MaxValue1 = two_array[i, j];

                        }
                        if(i % 2 != 0 && MinValue1 > two_array[j,i])
                        {
                            MinValue1 = two_array[j, i];
                        }
                    }
                }
                relationship = MaxValue1 / MinValue1;
                tb_output.Text = $"Отношение: {relationship}";
                for (int i = 0; i < two_array.GetLength(0); i++)
                {
                    for (int j = 0; j < two_array.GetLength(1); j++)
                    {
                        if (i % 2 == 0)
                        {
                            double g = two_array[j, i] / relationship;

                            dgv1.Rows[j].Cells[i].Value = String.Format("{0:0.00}", g);

                        }
                        
                    }
                }


            }
            //Выполнение 3 задания
            if (Data == 3)
            {
                tb_output.Clear();
                double start = Convert.ToDouble(tb_rnd_start.Text);
                double end = Convert.ToDouble(tb_rnd_end.Text);
                if (Col >= 10 && Row >= 10 && start >= -2 && end <= 2)
                {
                    double[] b = new double[two_array.GetLength(1)];
                    for (int i = 0; i < b.Length; i++)
                    {
                        b[i] = 1;
                    }
                    string s = "";
                    dgv1.Rows.Add();
                    for (int i = 0; i < two_array.GetLength(1); i++)
                    {
                        b[i] = 0;
                    }

                    for (int q = 0; q < two_array.GetLength(1); q++)
                    {
                        for (int w = 0; w < two_array.GetLength(0); w++)
                        {
                            dgv1.Rows[Row - 1].Cells[q].Value = String.Format("{0:0.00}", two_array[w, q]);
                            if (two_array[w, q] == 0)
                            {
                                b[q] = b[q] + 1;
                            }
                            dgv1.Rows[Row].Cells[q].Value = String.Format("{0:0.00}", b[q]);
                        }
                        s = s + 1 + b[q].ToString("0.00") + "  ";
                    }
                    tb_output.Text = (s);
                }
            }
            //Выполнение 4 задания
            if (Data == 4)
            {
                tb_output.Clear();
                tb_output.Clear();
                double MinValue1 = 1000.00;
                int StrokaMin = 0;
                int StolbMin = 0;
                int StrokaMax = 0;
                int StolbMax = 0;
                double MaxValue1 = 0;
                for (int i = 0; i < two_array.GetLength(0); i++)
                {
                    for (int j = 0; j < two_array.GetLength(1); j++)
                    {
                        if (MinValue1 > two_array[i, j])
                        {
                            MinValue1 = two_array[i, j];
                            StrokaMin = i;
                            StolbMin = j;
                        }
                        if (MaxValue1 < two_array[i, j] && i + j == two_array.GetLength(0) - 1)
                        {
                            MaxValue1 = two_array[i, j];
                            StolbMax = j;
                            StrokaMax = i;

                        }

                    }
                }
                dgv1.Rows[StrokaMin].Cells[StolbMin].Value = String.Format("{0:0.00}", MaxValue1);
                dgv1.Rows[StrokaMax].Cells[StolbMax].Value = String.Format("{0:0.00}", MinValue1);
            }
            //Выполнение 5 задания
            if (Data == 5)
            {
                tb_output.Clear();
                for (int i = 0; i < two_array.GetLength(0); i++)
                {
                    for (int j = 0; j < two_array.GetLength(1); j++)
                    {
                        dgv1.Rows[i].Cells[j].Value = String.Format("{0:0.00}", two_array[j,i]);
                    }
                }
            }
        }
        //Метод возвращения первоначального массива
        private void button5_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < two_array.GetLength(0); i++)
            {
                for (int r = 0; r < two_array.GetLength(1); r++)
                {
                    dgv1.Rows[i].Cells[r].Value = String.Format("{0:0.00}", Mass[i, r]);
                }
            }
        }
        //Кнопка "Задание 3"
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Data = 3;
            tb_output.Text = "Сгенерировать матрицу (N>10, M>10) и заполнить целыми положительнымичислами в диапазоне от -2 до 2.В каждой строке найти количество нулевых значений и изних сформировать дополнительный столбец матрицы.";
        }
        //Кнопка "Задание 4"
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Data = 4;
            tb_output.Text = "Сгенерировать квадратную матрицу и заполнить вещественными числами(положительными и отрицательными).Найти минимальный элемент всей матрицы ипоменять местами с максимальным элементом на побочной диагонали.";
        }

        private void tb_rows_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv1_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void tb_output_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_rnd_start_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
