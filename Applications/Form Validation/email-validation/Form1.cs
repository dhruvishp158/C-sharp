using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace email_validation
{
    //Dhruvish Patel (1911261);




    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = "";
            str = MessageBox.Show("Do You Want to Exit?", "Exit Window", MessageBoxButtons.YesNo).ToString();

            if(str=="Yes")
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

                


                if (!reg.IsMatch(textBox1.Text))
                {
                    MessageBox.Show("email-id is not valid");
                    
                   
                }
                else
                {
                    MessageBox.Show("email-id  valid");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            name = name.Trim();

            //@"^(\s+)$" this is a regular expression for removing all spaces

            if (!string.IsNullOrWhiteSpace(name))
            {
                name = name.Replace(" ", "");

            }
            MessageBox.Show("string after remove all spaces: " + name);

         

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           
                Regex reg = new Regex(@"^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$");

            if(!reg.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Not valid");
            }
            else
            {
                MessageBox.Show("Valid");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            name = name.Trim();

            Regex reg = new Regex(@"[abcdABCD]+");

            if (reg.IsMatch(name))
            {
                string a = reg.ToString();
                MessageBox.Show("string after remove all spaces: " + reg.Replace(name,""));
            }
            else
            {
                MessageBox.Show("invalid string! \n please enter another string");
            }
            //name = name.Replace("a", "");
            //name = name.Replace("b", "");
            //name = name.Replace("c", "");
            //name = name.Replace("d", "");
            //if (!string.IsNullOrWhiteSpace(name))
            //{
            //    name = name.Replace(" ", "");

            //}






        }

        private void button5_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"\s+");
            string name = "";
            textBox1.Text = textBox1.Text.Trim();
            if (reg.IsMatch(textBox1.Text))
            {

                textBox1.Text = textBox1.Text.Replace(" ", " ");
                string[] word;
                word = reg.Split(textBox1.Text);

                foreach(string txt in word)
                {
                    name = name + txt+"\n";

                }
                MessageBox.Show("array of words: \n\n" + name);

            }
        }
    }
}
