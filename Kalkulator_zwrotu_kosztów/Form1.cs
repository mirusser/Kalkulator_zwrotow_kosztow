using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_zwrotu_kosztów
{
    public partial class Form1 : Form
    {
        public int startingMileage, endingMileage;
        public double milesTraveled, amountOwed;
        public double reimburseRate = 0.39;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value)
            {
                MessageBox.Show("Początkowy stan licznika musi być mniejszy niż końcowy",
                    "Nie mogę obliczyć odległości");
            }
            else
            {
                startingMileage = (int)numericUpDown1.Value;
                endingMileage = (int)numericUpDown2.Value;
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = amountOwed.ToString() + " zł";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            milesTraveled = (double)numericUpDown2.Value - (double)numericUpDown1.Value;
            if(milesTraveled>=0)
            {
                MessageBox.Show(milesTraveled + " kilometrów", "Przebyta odległość");
            }
            else
            {
                MessageBox.Show("Początkowy stan licznika musi być mniejszy niż końcowy",
                   "Nie mogę obliczyć odległości");
            }
            
        }
    }
}
