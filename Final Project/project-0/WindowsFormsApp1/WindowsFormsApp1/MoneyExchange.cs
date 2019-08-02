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
    public partial class MoneyExchange : Form
    {
        public MoneyExchange()
        {
            InitializeComponent();
        }



        private void moneyExit_Click(object sender, EventArgs e)
        {
            string str = "";
            str = MessageBox.Show("Do You Want To Quit The Money Exchange Application?", "Exit?", MessageBoxButtons.YesNo).ToString();

            if(str=="Yes")
            {
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        moneyConvert con = new moneyConvert();
        double n = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToDouble(from.Text);
              
                con = new moneyConvert(n);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n please enter new numeric value");
               
                from.Focus();
                from.Clear();
               
            }

            if(cad.Checked==true)
            {
                if(cad2.Checked==true)
                {
                    to.Text = con.cadToCad().ToString();
                }
                else if(usd2.Checked == true)
                {
                    to.Text = con.cadToUsd().ToString();
                }
                else if (eur2.Checked == true)
                {
                    to.Text = con.cadToEur().ToString();
                }
                else if (gbp2.Checked == true)
                {
                    to.Text = con.cadToGbp().ToString();
                }
                else if (inr2.Checked == true)
                {
                    to.Text = con.cadToInd().ToString();
                }
            }

            else if (usd.Checked == true)
            {
                if (cad2.Checked == true)
                {
                    to.Text = con.usdToCad().ToString();
                }
                else if (usd2.Checked == true)
                {
                    to.Text = con.usdTousd().ToString();
                }
                else if (eur2.Checked == true)
                {
                    to.Text = con.usdToEur().ToString();
                }
                else if (gbp2.Checked == true)
                {
                    to.Text = con.usdToGdp().ToString();
                }
                else if (inr2.Checked == true)
                {
                    to.Text = con.usdToInr().ToString();
                }
            }

            else if (eur.Checked == true)
            {
                if (cad2.Checked == true)
                {
                    to.Text = con.eurToCad().ToString();
                }
                else if (usd2.Checked == true)
                {
                    to.Text = con.eurToUsd().ToString();
                }
                else if (eur2.Checked == true)
                {
                    to.Text = con.eurToEur().ToString();
                }
                else if (gbp2.Checked == true)
                {
                    to.Text = con.eurToGbp().ToString();
                }
                else if (inr2.Checked == true)
                {
                    to.Text = con.usdToInr().ToString();
                }
            }

            else if (gbp.Checked == true)
            {
                if (cad2.Checked == true)
                {
                    to.Text = con.gbpTocad().ToString();
                }
                else if (usd2.Checked == true)
                {
                    to.Text = con.gbpToUsd().ToString();
                }
                else if (eur2.Checked == true)
                {
                    to.Text = con.gbpToEur().ToString();
                }
                else if (gbp2.Checked == true)
                {
                    to.Text = con.gbpTogbp().ToString();
                }
                else if (inr2.Checked == true)
                {
                    to.Text = con.gbpToInr().ToString();
                }
            }

            else if (inr.Checked == true)
            {
                if (cad2.Checked == true)
                {
                    to.Text = con.indToCad().ToString();
                }
                else if (usd2.Checked == true)
                {
                    to.Text = con.indToUsd().ToString();
                }
                else if (eur2.Checked == true)
                {
                    to.Text = con.indToEur().ToString();
                }
                else if (gbp2.Checked == true)
                {
                    to.Text = con.indToGbp().ToString();
                }
                else if (inr2.Checked == true)
                {
                    to.Text = con.indToInd().ToString();
                }
            }

            File.AppendAllText("MoneyConversions.txt","Read " + " " + con.Number + " = " + to.Text + "     "+ DateTime.Now.ToString() + Environment.NewLine);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("MoneyConversions.txt"), "Read File", MessageBoxButtons.OK);

        }

        private void MoneyExchange_Load(object sender, EventArgs e)
        {

        }
    }

    public class moneyConvert
    {
        double number;

        public double Number { get => number; set => number = value; }

        public moneyConvert() { }

        public moneyConvert(double n)
        {
            Number = n;

        }

        public double cadToUsd()
        {
            return number * 0.76;
        }
        public double cadToCad()
        {
            return number;
        }
        public double cadToEur()
        {
            return number*0.68;
        }
        public double cadToGbp()
        {
            return number*0.61;
        }
        public double cadToInd()
        {
            return number*52.58;
        }


        public double usdToCad()
        {
            return number * 1.31;
        }
      
        public double usdTousd()
        {
            return number;
        }
        public double usdToEur()
        {
            return number*0.49;
        }
        public double usdToGdp()
        {
            return number*0.80;
        }
        public double usdToInr()
        {
            return number*68.81;
        }


        public double eurToGbp()
        {
            return number*0.90;
        }

        public double eurToEur()
        {
            return number;
        }
        public double eurToCad()
        {
            return number*1.47;
        }
        public double eurToUsd()
        {
            return number*1.12;
        }
        public double eurToInr()
        {
            return number*77.24;
        }


        public double gbpToEur()
        {
            return number*1.11;
        }
       
        public double gbpTogbp()
        {
            return number;
        }
        public double gbpTocad()
        {
            return number*1.64;
        }
        public double gbpToUsd()
        {
            return number*1.25;
        }
        public double gbpToInr()
        {
            return number*86.12;
        }


        public double indToCad()
        {
           
            return number*0.019;
        }
        public double indToUsd()
        {

            return number * 0.015;
        }
        public double indToEur()
        {

            return number * 0.013;
        }
        public double indToGbp()
        {

            return number * 0.012;
        }
        public double indToInd()
        {

            return number;
        }

    }
}
