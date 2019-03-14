using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Ivan Rivas
//This is my own work
namespace InClassAssignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double fatToCalories(double fatGrams)
        {
            return fatGrams * 9;
        }

        private double carbsToCalories(double carbsGrams)
        {
            return carbsGrams * 4;
        }

        private void button2_calculate_Click(object sender, EventArgs e)
        {

            double fatGrams, carbsGrams, fatCaloriesOutput, carbCaloriesOutput;
            if (double.TryParse(textBox1_caloriesFromFat.Text, out fatGrams) &&
                double.TryParse(textBox2_caloriesFromCarbs.Text, out carbsGrams))
            {
                fatCaloriesOutput = fatToCalories(fatGrams);
                carbCaloriesOutput = carbsToCalories(carbsGrams);

                label5_displayCaloriesFromFat.Text = fatCaloriesOutput.ToString();
                label6_displayCaloriesFromCarbs.Text = carbCaloriesOutput.ToString();

            }
        }

        private void button1_clear_Click(object sender, EventArgs e)
        {
            textBox1_caloriesFromFat.Text = "";
            textBox2_caloriesFromCarbs.Text = "";
            label5_displayCaloriesFromFat.Text = "";
            label6_displayCaloriesFromCarbs.Text = "";
        }

        private void button3_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
