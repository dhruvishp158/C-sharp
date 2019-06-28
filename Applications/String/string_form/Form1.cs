using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string for_exit = "";
            for_exit = MessageBox.Show("do you want to exit?", "Exit window", MessageBoxButtons.YesNo).ToString();

            if(for_exit=="Yes")
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname="" ;
            string middle_name="";
            string last_name = "";
            string full_name = "";

            full_name = textBox1.Text;
            full_name=full_name.Trim();

            string[] name = full_name.Split(' ');
            firstname = name[0];
           

            if (full_name == "")

            {
                MessageBox.Show("please enter string");
               // MessageBox.Show("First Name:       " + "" + "\n\n" + "Middle Name:   " + middle_name + "\n\n" + "Last Name:        " + last_name, "Parse Name").ToString();
            }
            else if (full_name==name[0])

            {
                firstname = name[0];
                MessageBox.Show("First Name:       " + firstname + "\n\n" + "Middle Name:   " + "" + "\n\n" + "Last Name:        " + "", "Parse Name").ToString();
            }
            else if(full_name==name[0]+" "+name[1])
            {
                firstname = name[0];
                middle_name = name[1];

                MessageBox.Show("First Name:       " + firstname + "\n\n" + "Middle Name:   " + middle_name + "\n\n" + "Last Name:        " + "", "Parse Name").ToString();

            }
            else
            {
                firstname = name[0];
                middle_name = name[1];
                last_name = name[2];

                MessageBox.Show("First Name:       " + firstname + "\n\n" + "Middle Name:   " + middle_name + "\n\n" + "Last Name:        " + last_name, "Parse Name").ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //StringBuilder number =new StringBuilder(10);
            string number = "";
            string digits = "";
            string format = "";

             number = textBox2.Text;
            foreach(char c in number)
            {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                {
                    digits = digits + c;
                }
            }
           format = digits.Insert(3, "-");
             format = format.Insert(7, "-");
           // format = format1 + format2;
            MessageBox.Show("Entered:" + number+ "\n\n" + "Digits Only:" + digits + "\n\n" + "Standard Format:" + format);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
