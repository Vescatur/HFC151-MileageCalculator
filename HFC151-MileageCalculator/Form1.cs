using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFC151_MileageCalculator
{
    public partial class Form1 : Form
    {
        decimal startingMileage;
        decimal endingMileage;
        double mileasTraveled;
        double reimburseRate = 0.39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = numericUpDown1.Value;
            endingMileage = numericUpDown2.Value;

            if (startingMileage>endingMileage)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage.","Cannot Calculate Mileage");
                return;
            }

            mileasTraveled = (double)(endingMileage - startingMileage);
            amountOwed = mileasTraveled * reimburseRate;
            label2.Text = "$" + amountOwed;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(mileasTraveled + "miles", "Miles Traveled");
        }
    }
}
