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
        public Calculator()
        {
            InitializeComponent();
            xddata();
            nBox.Text = "Enter N";

            this.Disposed += this.END;
            File.WriteAllText(history_path, "");
            File.WriteAllText(result_path, "");
            using (StreamWriter stream = new StreamWriter(history_path, true))
                stream.WriteLine(dataBox.Text);
            nBox.Click += nBox_Click;
        }
        delegate void Operation(object sender, EventArgs e);
        private Operation obj;
    }
}
