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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ipConvert : Form
    {
        public ipConvert()
        {
            InitializeComponent();
        }

        private void ipExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text.Trim();
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                Regex reg = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");




                if (reg.IsMatch(textBox1.Text))
                {
                    MessageBox.Show(textBox1.Text + "\nThe IP is correct");


                }
                else
                {
                    MessageBox.Show("The IP must have 4 bytes\ninteger number between 0 to 255\nseperated by a dot(255.255.255.255)");

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void ipConvert_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime.TryParse(label3.Text, out currentDate);

            label3.Text = DateTime.Now.ToString("MMMM-dd-yyyy");
        }
    }
}
