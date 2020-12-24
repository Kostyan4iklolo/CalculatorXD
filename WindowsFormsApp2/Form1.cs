using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Calculator : Form
    {
  
        public Calculator()
        {
            InitializeComponent();

            n_box.Text = "Enter N";
            dataBox.Text = File.ReadAllText(data_path);
            File.WriteAllText(history_path,"");
            File.WriteAllText(result_path,"");
            
        }
        public string data_path = @"C:\Users\User\source\repos\WindowsFormsApp2\WindowsFormsApp2\data.txt";
        public string mem = null;
        public string history_path = @"C:\Users\User\source\repos\WindowsFormsApp2\WindowsFormsApp2\history.txt";
        public string result_path = @"C:\Users\User\source\repos\WindowsFormsApp2\WindowsFormsApp2\result.txt";
        


        private void SuperCal_Load(object sender, EventArgs e)
        {
            
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
            textBox3.Text = File.ReadAllText(history_path);
        }
        private void fact_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = fakt(arr[j]);
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = fact_Click;
        }
        private void plus_toall_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();

            string a = n_box.Text;
            double n = Convert.ToDouble(a);
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = arr[j] + n;
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = plus_toall_Click;
        }
        private void minus_toall_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
            dataBox.Text = "Enter N:";
            string a = n_box.Text;
            double n = Convert.ToDouble(a);
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = arr[j] - n;
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = minus_toall_Click;
        }
        private void div_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
            dataBox.Text = "Enter N:";
            string a = n_box.Text;
            double n = Convert.ToDouble(a);
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = arr[j] / n;
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = div_Click;
        }
        private void multi_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
            dataBox.Text = "Enter N:";
            string a = n_box.Text;
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
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = Math.Sqrt(arr[j]);
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = sqrt_Click;
        }
        private void standard_deviation_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
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
            for (int j = 0; j < arr.Length; j++)
            {
                temp += arr[j];
            }
            temp = temp / (arr.Length - 1);
            temp = Math.Sqrt(temp);

            string result = temp.ToString();
            n_box.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = standard_deviation_Click;
        }
        private void root_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
            dataBox.Text = "Enter N:";
            string a = n_box.Text;
            double n = Convert.ToDouble(a);
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = Math.Pow(arr[j], 1 / n);
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = root_Click;
        }
        private void log_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
            dataBox.Text = "Enter N:";
            string a = n_box.Text;
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
        }
        private void pow_2_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = arr[j] * arr[j];
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = pow_2_Click;
        }
        private void power_n_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
            dataBox.Text = "Enter N:";
            string a = n_box.Text;
            double n = Convert.ToDouble(a);
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = Math.Pow(arr[j], n);
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            mem = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = power_n_Click;
        }
        private void median_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            double[] arr = data.Split(' ').Select(s => Convert.ToDouble(s)).ToArray();
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
            n_box.Text = result;
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);
            obj = median_Click;
        }
      
        private static double fakt(double x)
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
            n_box.Text = "";
            File.WriteAllText(history_path, "");
            textBox3.Text = "";
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
            var lines = System.IO.File.ReadAllLines(history_path);
            if (lines.Length - 1 != 0)
            {
                File.WriteAllLines(history_path, lines.Take(lines.Length - 1).ToArray());
                string s = File.ReadAllLines(history_path).Last();
                dataBox.Text = s;
            }
            else
                dataBox.Text = File.ReadAllText(data_path);
        }
        private void save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(result_path, dataBox.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void nBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void historyBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
