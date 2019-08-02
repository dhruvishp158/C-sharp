using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
   
    public partial class calculator : Form
    {





        public calculator()
        {
            InitializeComponent();
        }

        double FirstNumber;
        string Operation;
        double SecondNumber;
        double Result;
        

        //class calc
        //{

        //    //int num;

        //    //public int Num { get => num; set => num = value; }

        //    public int getNumber(int num)
        //    {
        //        //Num = num;
        //        return num;
        //    }


        //}

        private void calcExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //calc c = new calc();
        private void button17_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }


        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";

        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";

        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsub_Click(object sender, EventArgs e)
        {

            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void btneql_Click(object sender, EventArgs e)
        {
            string dir = @"..\..\..\Project\";
            string filePath = @"..\..\..\Project\Calculator.txt";
            double wr = 0 ;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                wr = FirstNumber;
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                wr = FirstNumber;
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                wr = FirstNumber;
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    wr = FirstNumber;
                    FirstNumber = Result;
                }
            }

            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            FileStream file = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(file);

            textOut.WriteLine(wr.ToString() + " " + Operation + " " + SecondNumber + " = " + Result.ToString());
            textOut.Close();

        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            int len = str.Length - 1;
            

            textBox1.Text = str.Remove(len);
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }
}
