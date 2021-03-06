﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public string data_path = @"C:\Users\User\source\repos\Calculator\WindowsFormsApp2\data.txt";
        public string history_path = @"C:\Users\User\source\repos\Calculator\WindowsFormsApp2\history.txt";
        public string result_path = @"C:\Users\User\source\repos\Calculator\WindowsFormsApp2\result.txt";
        public string fullhistory_path = @"C:\Users\User\source\repos\Calculator\WindowsFormsApp2\historyFULL.txt";
        public void END(object sender, EventArgs e)
        {
            new FileInfo(data_path).Delete();
            new FileInfo(history_path).Delete();
            new FileInfo(fullhistory_path).Delete();

        }
        public void FillInData()
        {
            using (StreamWriter stream = new StreamWriter(data_path, false))
            {
                for (int i = 0; i < 10000; i++)
                    stream.Write(i + " ");
            }
        }
        public void SaveRESULT(string result)
        {
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(result);

            comboBox1.Items.Add(result);
            using (StreamWriter stream = new StreamWriter(fullhistory_path, true))
            {
                stream.WriteLine(result);
                stream.WriteLine("");
            }
               
        }
    }
}
