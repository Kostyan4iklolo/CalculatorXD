using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Calculator : Form
    {
        public string data_path = @"C:\Users\User\source\repos\WindowsFormsApp2\WindowsFormsApp2\data.txt";
        public string history_path = @"C:\Users\User\source\repos\WindowsFormsApp2\WindowsFormsApp2\history.txt";
        public string result_path = @"C:\Users\User\source\repos\WindowsFormsApp2\WindowsFormsApp2\result.txt";
        public string fullhistory_path = @"C:\Users\User\source\repos\WindowsFormsApp2\WindowsFormsApp2\historyFULL.txt";
        public Calculator()
        {
            InitializeComponent();
            xddata();
            nBox.Text = "Enter N";


            File.WriteAllText(history_path, "");
            File.WriteAllText(result_path, "");
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(dataBox.Text);
            nBox.Click += nBox_Click;

        }
        public void xddata()
        {
            using (StreamWriter stream = new StreamWriter(data_path, false))
            {
                for (int i = 0; i < 100; i++)
                    stream.Write(1 +" ");
            }
        }
        public void PATH(string result)
        {
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);

            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }

        private double[] data()
        {
            char ch = ' ';
            string data1 = dataBox.Text;
            var data2 = Regex.Replace(data1, " {1,}", " ").TrimEnd(ch).TrimStart(ch);
            return data2.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
        }
        private double N()
        {
            string a = nBox.Text;
            return Convert.ToDouble(a);
        }
        
        private void press_0_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = "0";
            else
                dataBox.Text += 0;
        }
        private void press_1_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = "1";
            else
                dataBox.Text += 1;
        }

        private void press_2_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = "2";
            else
                dataBox.Text += 2;
        }
        private void press_3_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = "3";
            else
                dataBox.Text += 3;
        }
        private void press_4_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = "4";
            else
                dataBox.Text += 4;
        }

        private void press_5_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = "5";
            else
                dataBox.Text += 5;
        }

        private void press_6_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = "6";
            else
                dataBox.Text += 6;
        }

        private void press_7_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = "7";
            else
                dataBox.Text += 7;
        }

        private void press_8_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = "8";
            else
                dataBox.Text += 8;
        }

        private void press_9_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = "9";
            else
                dataBox.Text += 9;
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            {
                if (dataBox.Text == "0")
                    dataBox.Text = "0,";
                else
                    dataBox.Text += ",";
            }
        }
        private void Next_Element_Click(object sender, EventArgs e)
        {
            if (dataBox.Text == "0")
                dataBox.Text = " ";
            else
                dataBox.Text += " ";
        }

        private void history_Click(object sender, EventArgs e)
        {
            historyBox.Text = File.ReadAllText(fullhistory_path);
        }
        private void fact_Click(object sender, EventArgs e)
        {
            double[] arr = data();
            int[] arr1 = arr.Select(x => Convert.ToInt32(x)).ToArray();
            for (int j = 0; j < arr1.Length; j++)
            {
                arr[j] = fakt(arr1[j]);
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = fact_Click;
            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }
       
        private void minus_toall_Click(object sender, EventArgs e)
        {
            double[] arr = data();
            double n = N();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = arr[j] - n;
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = minus_toall_Click;
            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }
        private void div_Click(object sender, EventArgs e)
        {
            double[] arr = data();
            double n = N();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = arr[j] / n;
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = div_Click;
            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }
        private void multi_Click(object sender, EventArgs e)
        {
            double[] arr = data();

            string a = nBox.Text;
            double n = Convert.ToDouble(a);
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = arr[j] * n;
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = multi_Click;
            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            double[] arr = data();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = Math.Sqrt(arr[j]);
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = sqrt_Click;
            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }
        private void standard_deviation_Click(object sender, EventArgs e)
        {
            double[] arr = data();
            double temp = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                temp += arr[j];
            }
            temp = temp / arr.Length;
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] -= temp;
                arr[j] = arr[j] * arr[j];
            }
            temp = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                temp += arr[j];
            }
            temp = temp / (arr.Length - 1);
            temp = Math.Sqrt(temp);

            string result = temp.ToString();
            nBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = standard_deviation_Click;
            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }
        private void root_Click(object sender, EventArgs e)
        {
            double[] arr = data();

            string a = nBox.Text;
            double n = Convert.ToDouble(a);
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] < 0 && n % 2 == 1)
                {
                    arr[j] = -(Math.Pow(Math.Abs(arr[j]), 1 / n));
                }
                else
                    arr[j] = Math.Pow(arr[j], 1 / n);
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = root_Click;
            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }
        private void log_Click(object sender, EventArgs e)
        {
            double[] arr = data();

            string a = nBox.Text;
            double n = Convert.ToDouble(a);
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = Math.Log(arr[j]) / Math.Log(n);
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = log_Click;
            comboBox1.Items.Add(result);
        }
        private void pow_2_Click(object sender, EventArgs e)
        {
            double[] arr = data();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = arr[j] * arr[j];
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = pow_2_Click;
            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }
        private void power_n_Click(object sender, EventArgs e)
        {
            double[] arr = data();

            string a = nBox.Text;
            double n = Convert.ToDouble(a);
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = Math.Pow(arr[j], n);
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;

            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = power_n_Click;
            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }
        private void median_Click(object sender, EventArgs e)
        {
            double[] arr = data();
            double temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            if (arr.Length % 2 == 1)
                temp = arr[arr.Length / 2];
            else
                temp = (arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2;
            string result = temp.ToString();
            nBox.Text = result;
            obj = median_Click;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            
            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
                stream.WriteLine(result);
        }

        private static double fakt(int x)
        {
            if (x < 0)
                return 0;
            if (x == 0)
                return 1;
            else
                return x * fakt(x - 1);

        }

        private void clean_element_Click(object sender, EventArgs e)
        {
            if (dataBox.Text.Length != 1)
                dataBox.Text = dataBox.Text.Remove(dataBox.Text.Length - 1);
            else
                dataBox.Text = "0";
        }
        private void clean_all_Click(object sender, EventArgs e)
        {
            dataBox.Text = "";
            nBox.Text = "";
            File.WriteAllText(history_path, "");
            historyBox.Text = "";
        }

        delegate void Operation(object sender, EventArgs e);
        private Operation obj;
        private void repeat_Click(object sender, EventArgs e)
        {
            if (obj != null)
                obj(sender, e);
        }

        private void open_Click(object sender, EventArgs e)
        {
            dataBox.Text = File.ReadAllText(data_path);
        }

        private void undo_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            var lines = System.IO.File.ReadAllLines(history_path);
            if (lines.Length == 1)
                dataBox.Text = data;
            else
            {
                File.WriteAllLines(history_path, lines.Take(lines.Length - 1).ToArray());
                string s = File.ReadAllLines(history_path).Last();
                dataBox.Text = s;
            }

        }
        private void save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(result_path, dataBox.Text);
        }

        private void nBox_Click(object sender, EventArgs e)
        {
            if (nBox.Text == "Enter N")
                nBox.Text = "";
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = comboBox1.SelectedItem.ToString();
            dataBox.Text = c;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(c);
        }


    }
}
