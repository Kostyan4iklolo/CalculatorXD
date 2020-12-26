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
            obj = plus_toall_Click;
            SaveRESULT(result);
        }
        private void factorial_Click(object sender, EventArgs e)
        {
            double[] arr = data();
            int[] arr1 = arr.Select(x => Convert.ToInt32(x)).ToArray();
            for (int j = 0; j < arr1.Length; j++)
            {
                arr[j] = Fact(arr1[j]);
            }
            string result = string.Join(" ", arr);
            dataBox.Text = result;
            obj = factorial_Click;
            SaveRESULT(result);
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
            obj = minus_toall_Click;
            SaveRESULT(result);
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
            obj = div_Click;
            SaveRESULT(result);
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
            obj = multi_Click;
            SaveRESULT(result);
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
            obj = sqrt_Click;
            SaveRESULT(result);
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
            obj = standard_deviation_Click;
            SaveRESULT(result);
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
            obj = root_Click;
            SaveRESULT(result);
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
            obj = log_Click;
            SaveRESULT(result);
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
            obj = pow_2_Click;
            SaveRESULT(result);
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
            obj = power_n_Click;
            SaveRESULT(result);
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
            SaveRESULT(result);
        }

        private static double Fact(int x)
        {
            if (x < 0)
                return 0;
            if (x == 0)
                return 1;
            else
                return x * Fact(x - 1);

        }


    }
}
