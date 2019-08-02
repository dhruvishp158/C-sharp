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
    public partial class tempConvert : Form
    {
        public tempConvert()
        {
            InitializeComponent();
        }

        private void tempExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        convertTemp con = new convertTemp();
        double n = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToDouble(from.Text);
                con = new convertTemp(n);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n please enter new numeric value");
               
                from.Focus();
                from.Clear();
                
            }


            if(btn1.Checked==true)
            {
                to.Text = con.cToF().ToString();
                label2.Text = "C";
                label3.Text = "F";
                File.AppendAllText("TempConversions.txt", from.Text + " C " + " = " + to.Text + " F," + DateTime.Now.ToString() + Environment.NewLine);

            }
            else if(btn2.Checked==true)
            {
                to.Text = con.fToC().ToString();
                label2.Text = "F";
                label3.Text = "C";
                File.AppendAllText("TempConversions.txt", from.Text + " F " + " = " + to.Text + "C" + DateTime.Now.ToString() + Environment.NewLine);

            }


        }

        private void tempConvert_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void to_TextChanged(object sender, EventArgs e)
        {
            if(from.Text=="100")
            {
                
               if(btn2.Checked==true)
                {
                    description.Clear();
                }
                else
                {
                    description.Text = "Water Boils";
                }
            }

          else  if (from.Text == "40")
            {

                if (btn2.Checked == true)
                {
                    description.Clear();
                }
                else
                {
                    description.Text = "Hot Bath";
                }
            }

          else  if (from.Text == "37")
            {

                if (btn2.Checked == true)
                {
                    description.Clear();
                }
                else
                {
                    description.Text = "Body Temparature";
                }
            }

           else  if (from.Text == "30")
            {

                if (btn2.Checked == true)
                {
                    description.Clear();
                }
                else
                {
                    description.Text = "Beach Teamparature";
                }
            }

           else if (from.Text == "21")
            {

                if (btn2.Checked == true)
                {
                    description.Clear();
                }
                else
                {
                    description.Text = "Room Temparature";
                }
            }

           else if (from.Text == "10")
            {

                if (btn2.Checked == true)
                {
                    description.Clear();
                }
                else
                {
                    description.Text = "Cool Day";
                }
            }

          else  if (from.Text == "0")
            {

                if (btn2.Checked == true)
                {
                    description.Clear();
                }
                else
                {
                    description.Text = "Freezing Points";
                }
            }

           else if (from.Text == "-18")
            {

                if (btn2.Checked == true)
                {
                    description.Clear();
                }
                else
                {
                    description.Text = "Very Cold Day";
                }
            }

           else if (from.Text == "-40")
            {

                if (btn2.Checked == true)
                {
                    description.Clear();
                }
                else
                {
                    description.Text = "Extremely Cold Day";
                }
            }
            else
            {
                description.Clear();
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("TempConversions.txt"), "File", MessageBoxButtons.OK);

        }
    }

    public class convertTemp
    {
        double number;

        public double Number { get => number; set => number = value; }

        public convertTemp() { }
        public convertTemp(double n)
        {
            Number = n;
        }

        public double cToF()
        {
            return (Number * 1.8) + 32;
        }
        public double fToC()
        {
           
            return (Number - 32) / 1.8;
        }
      
    }



}
