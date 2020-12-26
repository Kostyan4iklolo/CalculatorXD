using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
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
    }
}
