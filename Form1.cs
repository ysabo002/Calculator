using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        private long result;

        public Form1()
        {
            InitializeComponent();
            result = 0;
        }


        private void btn_Click(object sender, EventArgs e)
        {
            //if (txtOutput.Text== "0")
            //    txtOutput.Text = ((Button)sender).Text;
            //else
            txtOutput.Text += ((Button)sender).Text;
        }

        private void btn_OperatorClick(object sender, EventArgs e)
        {
            //if (txtOutput.Text.Length == 0)
            //    txtOutput.Text = ((Button)sender).Text;
            if (txtOutput.Text[txtOutput.Text.Length-1] == '+')
            {

                txtOutput.Text.Remove(txtOutput.Text.Length - 2);
                txtOutput.Text += ((Button)sender).Text;
            }
            else
                txtOutput.Text += ((Button)sender).Text;

            
        }
        private void form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double click on " + sender.ToString() + "??! Calm down!");
        }



        private void btnEqual_Click(object sender, EventArgs e)
        {
            var res = cal(txtOutput.Text);
           txtOutput.Text += " = " + res.ToString();
        }

        private object cal(string text)
        {
            DataTable dt = new DataTable();
            var v = new object();
            try
            {
                v = dt.Compute(text, "");
            }
            catch (Exception e)
            {
                v = "NaN";
            }

            return v;
        }

   
        private void btnErase_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length >= 1)
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.Length - 1, 1);
            else
                txtOutput.Text = txtOutput.Text;

        }

              

        private void btnGoToCero_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPowOf2_Click(object sender, EventArgs e)
        {
            var res = cal(txtOutput.Text);
            double res1 = Math.Pow((double)res, 2);


            txtOutput.Text += " = " + res.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
