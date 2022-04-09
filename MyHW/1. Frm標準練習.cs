using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmHomeWork : Form
    {
        public FrmHomeWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 66;
            int c = 77;

            int big=Math.Max(a, b);
            int max = Math.Max(big, c);
            lblResult.Text = Convert.ToString(max);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] nums = { 33, 4, 5, 11, 222, 34 };
            int odd = 0;
            int even = 0;
            foreach(int item in nums)
            {
                if (item % 2 == 0)
                    even += 1;
                if (item % 2 == 1)
                    odd += 1;
            }
            lblResult.Text = "奇數有" + odd + "個，偶數有" + even + "個";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string[] names = { "aaa", "ksdkfjsdk"};
            int max = 0;
            string longest = "";
            foreach(string name in names)
            {
                if (name.Length > max)
                {
                    max = name.Length;
                    longest = name;
                }
            }
            lblResult.Text = longest;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool isNum = int.TryParse(txtNum.Text,out int num);
            if (isNum == false)
                MessageBox.Show("請輸入數字");
            else if (num % 2 == 0)
                lblResult.Text="Even";
            else
                lblResult.Text="Odd";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] scores = { 2, 3, 46, 33, 22, 100,150, 33,55};
            int max =  scores.Max();
            int min=MyMinScore(scores);
            lblResult.Text = "Max()=" + max+"\nMin(int[])="+min;
            //MessageBox.Show("Max = " + max);

            //Array.Sort(scores);
            //MessageBox.Show("Max =" + scores[scores.Length - 1]);

            //================================

            //Point[] points = new Point[3];
            //points[0].X = 3;
            //points[0].Y = 4;
            ////System.InvalidOperationException: '無法比較陣列中的兩個元素。'

            //Array.Sort(points);

            //=================================

            //MessageBox.Show("Max = " + ClsUtility.MyMax(scores));
        }
        int MyMinScore(int[] nums)
        {
            return(nums.Min());
            //return 10;
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            bool from = int.TryParse(txtFrom.Text, out int a);
            bool to = int.TryParse(txtTo.Text, out int b);
            bool step = int.TryParse(txtStep.Text, out int c);
            if (from == false || to == false || step == false)
                MessageBox.Show("請輸入數字");
            else
            {
                int f = int.Parse(txtFrom.Text);
                int t = int.Parse(txtTo.Text);
                int s = int.Parse(txtStep.Text);
                int sum = 0;
                for (int i = f; i <= t; i = i + s)
                {
                    sum += i;
                }
                lblResult.Text = Convert.ToString(sum);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            bool from = int.TryParse(txtFrom.Text, out int a);
            bool to = int.TryParse(txtTo.Text, out int b);
            bool step = int.TryParse(txtStep.Text, out int c);
            if (from == false || to == false || step == false)
                MessageBox.Show("請輸入數字");
            else
            {
                int f = int.Parse(txtFrom.Text);
                int t = int.Parse(txtTo.Text);
                int s = int.Parse(txtStep.Text);
                int sum = 0;
                while (f <= t)
                {
                    sum += f;
                    f = f + s;
                }
                lblResult.Text = Convert.ToString(sum);
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            bool from = int.TryParse(txtFrom.Text, out int a);
            bool to = int.TryParse(txtTo.Text, out int b);
            bool step = int.TryParse(txtStep.Text, out int c);
            if (from == false || to == false || step == false)
                MessageBox.Show("請輸入數字");
            else
            {
                int f = int.Parse(txtFrom.Text);
                int t = int.Parse(txtTo.Text);
                int s = int.Parse(txtStep.Text);
                int sum = 0;
                do
                {
                    sum += f;
                    f = f + s;
                } while (f <= t);
                lblResult.Text = Convert.ToString(sum);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] names = { "aaa", "ksdkfjsdk" };
            string C = "C";
            string c = "c";
            int count = 0;
            foreach(string name in names)
            {
                if (name.Contains(C)||name.Contains(c))
                    count += 1;
            }
            lblResult.Text = count + "個";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] scores = { 60, 70, 80, 90, 100 };
            int max=MaxScore(scores);
            lblResult.Text = Convert.ToString(max);
        }
        int MaxScore(int[] num)
        {
            int max = num.Max();
            return max;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int[] randomArr = new int[6];
            Random num = new Random();
            for(int i = 0; i < 6; i++)
            {
                randomArr[i] = num.Next(1, 50); //產生第一個數
                for(int j = 0; j < i; j++)
                {
                    while (randomArr[j]==randomArr[i])
                    {
                        j = 0;
                        randomArr[i] = num.Next(1, 50);
                    }
                }
            }
            lblResult.Text = randomArr[0].ToString() + "  " + randomArr[1].ToString() + "  " +
                 randomArr[2].ToString() + "  " + randomArr[3].ToString() + "  " + randomArr[4].ToString() + "  "
                 + randomArr[5].ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 1; i <= 9; i++)
            {
                string p = "";
                for (int j = 2; j <= 9; j++)
                {
                    p = Convert.ToString(i * j);
                    p = p.PadLeft(2,'0');
                    result+= j + "x" + i + "=" +p+"  ";
                }
                result+="\n";
            }
            lblResult.Text = result;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(100, 2); //轉二進位
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblResult.Text = "結果";
        }
    }
}

