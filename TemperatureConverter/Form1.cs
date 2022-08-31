using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (measureFromCB.SelectedItem != null || measureToCB.SelectedItem != null)
            {
                ConversionDecision();
            }
            else
            {
                errorLabel.Visible = true;
            }
        }

        private void ConversionDecision()
        {
            if (CheckValidEntry())
            {
                if (measureFromCB.SelectedItem.ToString() == "Celsius °C" && measureToCB.SelectedItem.ToString() == "Fahrenheit °F")
                {
                    errorLabel.Visible = false;
                    conversionTextBox.Text = Convert.ToString(CelsiusToFahrenheit());
                }
                else if (measureFromCB.SelectedItem.ToString() == "Celsius °C" && measureToCB.SelectedItem.ToString() == "Kelvin °K")
                {
                    errorLabel.Visible = false;
                    conversionTextBox.Text = Convert.ToString(CelsiusToKelvin());
                }
                else if (measureFromCB.SelectedItem.ToString() == "Fahrenheit °F" && measureToCB.SelectedItem.ToString() == "Celsius °C")
                {
                    errorLabel.Visible = false;
                    conversionTextBox.Text = Convert.ToString(FahrenheitToCelsius());
                }
                else if (measureFromCB.SelectedItem.ToString() == "Fahrenheit °F" && measureToCB.SelectedItem.ToString() == "Kelvin °K")
                {
                    errorLabel.Visible = false;
                    conversionTextBox.Text = Convert.ToString(FahrenheitToKelvin());
                }
                else if (measureFromCB.SelectedItem.ToString() == "Kelvin °K" && measureToCB.SelectedItem.ToString() == "Celsius °C")
                {
                    errorLabel.Visible = false;
                    conversionTextBox.Text = Convert.ToString(KelvinToCelsius());
                }
                else if (measureFromCB.SelectedItem.ToString() == "Kelvin °K" && measureToCB.SelectedItem.ToString() == "Fahrenheit °F")
                {
                    errorLabel.Visible = false;
                    conversionTextBox.Text = Convert.ToString(KelvinToFahrenheit());
                }
                else
                {
                    errorLabel.Visible = true;
                }
            }
            else
            {
                errorLabel.Text = "The value entered is not convertable.  Please try again.";
                errorLabel.Visible = true;
            }
        }

        private bool CheckValidEntry()
        {
            bool isValid = double.TryParse(valueTextBox.Text, out _);
            return isValid;
        }

        private double KelvinToFahrenheit()
        {
            double fahrenheit = (Convert.ToDouble(valueTextBox.Text) * (double)9 / (double)5) - 459.67;
            return fahrenheit;
        }

        private double KelvinToCelsius()
        {
            double celsius = Convert.ToDouble(valueTextBox.Text) - 273.15;
            return celsius;
        }

        private double FahrenheitToKelvin()
        {
            double kelvin = (Convert.ToDouble(valueTextBox.Text) + 459.67) * ((double)5 / (double)9);
            return kelvin;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private double FahrenheitToCelsius()
        {
            double celsius = (Convert.ToDouble(valueTextBox.Text) - 32) * ((double)5 / (double)9);
            return celsius;
        }

        private double CelsiusToKelvin()
        {
            double kelvin = Convert.ToDouble(valueTextBox.Text) + 273.15;
            return kelvin;
        }

        private double CelsiusToFahrenheit()
        {
            double fahrenheit = (Convert.ToInt32(valueTextBox.Text) * ((double)5 / (double)9)) + 32;
            return fahrenheit;
        }

    }
}
