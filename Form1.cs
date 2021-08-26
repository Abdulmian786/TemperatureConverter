using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FartoCel
{
    public partial class Form1 : Form
    {
        double cel;
        double far;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {

           if(txtDisplay2.Text == "")
            {
                try
                {
                    cel = double.Parse(txtDisplay1.Text);
                    result = (1.8 * cel) + 32;
                    txtDisplay2.Text = result.ToString();
                    
                }
                catch
                {
                    MessageBox.Show("Invaild input");
                }
            }
            else if(txtDisplay1.Text == "")
            {

                try
                {
                    far = double.Parse(txtDisplay2.Text);
                    result = far *(5/9) - 32;
                    txtDisplay1.Text = result.ToString();


                }
                catch
                {
                    MessageBox.Show("Invaild input");

                }
              
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "";
            txtDisplay2.Text = "";
            cel = 0;
            far = 0;
            result = 0;

        }
    }
}
