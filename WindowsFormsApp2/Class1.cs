using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Calculator : Form
    {
        private void plus_toall_Click(object sender, EventArgs e)
        {
            double[] arr = data();
            double n = N();
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = arr[j] + n;
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
    }
}
