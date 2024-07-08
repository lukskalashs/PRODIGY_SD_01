using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tempreture_Conversion_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Methods for Conversion
        public double CelsiusToFahrenheit(double Celsius)
        {
            return (Celsius * 9 / 5) + 32;
        }
        public double FahrenheitToCelsius(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9;
        }
        public double CelsiusToKelvin(double Celsius)
        {
            return Celsius + 273.15;
        }
        public double KelvinToCelsius(double Kelvin)
        {
            return Kelvin - 273.15;
        }
        public double FahrenheitToKelvin(double Fahrenheit)
        {
            return (Fahrenheit - 32) * 5 / 9 + 273.15;
        }
        public double KelvinToFahrenheit(double Kelvin)
        {
            return (Kelvin - 273.15) * 9 / 5 + 32;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblResults_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblLabel_Click(object sender, EventArgs e)
        {
            
            

        }

        private void cmbBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cmbBoxType.SelectedItem.ToString();
            if (selectedItem == "Celsius - Fahrenheit" || selectedItem == "Fahrenheit - Celsius" || selectedItem == "Celsius - Kelvin" || selectedItem == "Fahrenheit - Kelvin")
            {
                lblLabel.Text = "Degrees";
            }
            else if (selectedItem == "Kelvin - Celsius" || selectedItem == "Kelvin - Fahrenheit")
            {
                lblLabel.Text = "Kelvin";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbBoxType.SelectedItem != null)
            {
                try
                {
                    string SelectedItem = cmbBoxType.SelectedItem.ToString();
                    double TempToChange = double.Parse(textBox1.Text.ToString());
                    if (SelectedItem == "Celsius - Fahrenheit")
                    {
                        double Fahrenheit = CelsiusToFahrenheit(TempToChange);

                        lblResults.Text = Fahrenheit.ToString().PadLeft(18);
                    }
                    if (SelectedItem == "Fahrenheit - Celsius")
                    {
                        double Celsius = FahrenheitToCelsius(TempToChange);
                        lblResults.Text = Celsius.ToString().PadLeft(18);
                    }
                    if (SelectedItem == "Kelvin - Celsius")
                    {
                        double Kelvin = KelvinToCelsius(TempToChange);
                        lblResults.Text = Kelvin.ToString().PadLeft(18);
                    }
                    if (SelectedItem == "Celsius - Kelvin")
                    {
                        double Celsius = CelsiusToKelvin(TempToChange);
                        lblResults.Text = Celsius.ToString().PadLeft(18);
                    }
                    if (SelectedItem == "Fahrenheit- Kelvin")
                    {
                        double Fahrenheit = FahrenheitToKelvin(TempToChange);
                        lblResults.Text = Fahrenheit.ToString().PadLeft(18);
                    }
                    else if (SelectedItem == "Kelvin - Fahrenheit")
                    {
                        double Kelvin = KelvinToFahrenheit(TempToChange);
                        lblResults.Text = Kelvin.ToString().PadLeft(18);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Select a Conversion from the drop down");
            }
            
        }
    }
}


//Celsius - Fahrenheit
//Fahrenheit - Celsius
//Kelvin - Celsius
//Celsius - Kelvin
//Fahrenheit - Kelvin
//Kelvin - Fahrenheit 