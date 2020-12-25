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

            this.Disposed += this.KONEC;
            File.WriteAllText(history_path, "");
            File.WriteAllText(result_path, "");
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(dataBox.Text);
            nBox.Click += nBox_Click;

        }
        public void KONEC(object sender, EventArgs e)
        {
            new FileInfo(data_path).Delete();
            new FileInfo(history_path).Delete();
            new FileInfo(fullhistory_path).Delete();
      
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
