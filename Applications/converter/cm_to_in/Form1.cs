using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cm_to_in
{
    public partial class frmAreaConvert : Form
    {
        //Dhruvish Patel
        //1911261


        public class convertarea
        {


            private double num1, num2;

           // create an object of the globle varible


            public double Num1
            {
                get { return num1; }
                set { num1 = value; }
            }
            public double Num2 { get => num2; set => num2 = value; }

            public convertarea()
            {
                //default constructor
            }

            public convertarea(double num1)
            {
                this.Num1 = num1;
            }
            public double cmToin()
            {
                return Num1 * 0.1550;
            }
            public double mToyard()
            {
                return Num1 * 1.1960;
            }
            public double hectorToacres()
            {
                return Num1 * 2.4711;
            }
            public double kmTomiles()
            {
                return Num1 * 0.3861;
            }
        }


        public frmAreaConvert()
        {
            InitializeComponent();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void frmAreaConvert_Load(object sender, EventArgs e)
        {

        }



        convertarea obj1;
        private void button1_Click(object sender, EventArgs e)
        {


             double num1 = 0;

            try
            {
                obj1 = new convertarea();
                num1 = Convert.ToDouble(textBox1.Text);
                obj1 = new convertarea(num1);
              

                textBox1.ReadOnly = true;


             
            }
             catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message+"this is an invalid number");
                textBox1.Text = "0";
                textBox1.Focus();
                textBox1.ReadOnly = false;
                    

            }
            finally
            {
                
                textBox2.Text = obj1.cmToin().ToString();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = 0;

            try
            {
                obj1 = new convertarea();
                
                num1 = Convert.ToDouble(textBox4.Text);
                obj1 = new convertarea(num1);
                textBox4.ReadOnly = true;
              
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message + "this is an invalid number");
                textBox4.Text = "0";
                textBox4.Focus();
                textBox4.ReadOnly = false;


            }
            finally
            {
                textBox3.Text = obj1.mToyard().ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = 0;

            try
            {
                obj1 = new convertarea();
                num1 = Convert.ToDouble(textBox6.Text);
                obj1 = new convertarea(num1);
                
                textBox6.ReadOnly = true;

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message + "this is an invalid number");
                textBox6.Text = "0";
                textBox6.Focus();
                textBox6.ReadOnly = false;


            }
            finally
            {
                textBox5.Text = obj1.hectorToacres().ToString();
            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = 0;

            try
            {
                obj1 = new convertarea();
                num1 = Convert.ToDouble(textBox8.Text);
                obj1 = new convertarea(num1);
                textBox8.ReadOnly = true;        

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message + "this is an invalid number");
                textBox8.Text = "0";
                textBox8.Focus();
                textBox8.ReadOnly = false;


            }
            finally
            {
                textBox7.Text = obj1.kmTomiles().ToString();
            }

            //try
            //{
            //    textBox7.Text = (Convert.ToDouble(textBox8.Text) * 0.3861).ToString();
            //}
            //catch (Exception ex1)
            //{
            //    MessageBox.Show(ex1.Message);
            //    textBox8.Text = "0";
            //    textBox8.Focus();

            //}
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            string btnexit = "";

            btnexit = MessageBox.Show("do you want to exit?", "Exit window", MessageBoxButtons.YesNo).ToString();

            if(btnexit=="Yes")
            {
                this.Close();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "a,b,c,d";
            textBox10.Text = "a,b,c,d";
            textBox11.Text = "a,b,c,d";
            textBox12.Text = "a,b,c,d";
            textBox13.Text = "a,b,c,d";


        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            textBox9.Text = "a";
            textBox10.Text = "a,b,d";
            textBox11.Text = "a,b";
            textBox12.Text = "b,c";
            textBox13.Text = "c";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
