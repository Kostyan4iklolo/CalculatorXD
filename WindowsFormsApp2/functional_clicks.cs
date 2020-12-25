using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Calculator : Form
    {
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
