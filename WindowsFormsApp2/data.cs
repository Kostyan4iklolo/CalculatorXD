using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Calculator : Form
    {
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
    }
}
