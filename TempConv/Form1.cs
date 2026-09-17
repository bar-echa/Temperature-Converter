using System.Globalization;
using System.Drawing;

namespace TempConv
{
    public partial class Form1 : Form
    {
        private enum Unit { Celsius, Fahrenheit, Kelvin }
        private Unit CurrentUnit = Unit.Celsius;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUnit.Items.Add("Celsius");
            cmbUnit.Items.Add("Fahrenheit");
            cmbUnit.Items.Add("Kelvin");

            cmbUnit.SelectedIndex = 0;

            SetUnit(CurrentUnit);
            ConvertTemperature();
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentUnit = cmbUnit.SelectedItem.ToString() switch
            {
                "Celsius" => Unit.Celsius,
                "Fahrenheit" => Unit.Fahrenheit,
                "Kelvin" => Unit.Kelvin,
                _ => Unit.Celsius
            };

            SetUnit(CurrentUnit);
            ConvertTemperature();
        }

        private void AppendDigit(string digit)
        {
            if (lblTempreture.Text == "0")
                lblTempreture.Text = digit;
            else
                lblTempreture.Text += digit;

            ConvertTemperature();
        }

        private void AppendDecimal()
        {
            if (!lblTempreture.Text.Contains("."))
                lblTempreture.Text += ".";

            ConvertTemperature();
        }

        private void btnCle_Click(object sender, EventArgs e)
        {
            lblTempreture.Text = "0";
            lblDiffer.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lblTempreture.Text.Length > 1)
                lblTempreture.Text = lblTempreture.Text[..^1];
            else
                lblTempreture.Text = "0";

            ConvertTemperature();
        }

        private void btn1_Click(object sender, EventArgs e) => AppendDigit("1");
        private void btn2_Click(object sender, EventArgs e) => AppendDigit("2");
        private void btn3_Click(object sender, EventArgs e) => AppendDigit("3");
        private void btn4_Click(object sender, EventArgs e) => AppendDigit("4");
        private void btn5_Click(object sender, EventArgs e) => AppendDigit("5");
        private void btn6_Click(object sender, EventArgs e) => AppendDigit("6");
        private void btn7_Click(object sender, EventArgs e) => AppendDigit("7");
        private void btn8_Click(object sender, EventArgs e) => AppendDigit("8");
        private void btn9_Click(object sender, EventArgs e) => AppendDigit("9");
        private void btn0_Click(object sender, EventArgs e) => AppendDigit("0");
        private void btnpoint_Click(object sender, EventArgs e) => AppendDecimal();

        private void SetUnit(Unit u)
        {
            switch (u)
            {
               
            }
        }

        private void ConvertTemperature()
        {
            string text = lblTempreture.Text;

            if (!double.TryParse(text, NumberStyles.Float | NumberStyles.AllowThousands,
                CultureInfo.InvariantCulture, out double inputTemp))
            {
                if (!double.TryParse(text, out inputTemp))
                {
                    lblDiffer.Text = "Invalid input";
                    return;
                }
            }

            switch (CurrentUnit)
            {
                case Unit.Celsius:
                    double fahrenheit = (inputTemp * 9.0 / 5.0) + 32.0;
                    double kelvin = inputTemp + 273.15;
                    lblDiffer.Text = $"Fahrenheit: {fahrenheit:F2}\nKelvin: {kelvin:F2}";
                    break;

                case Unit.Fahrenheit:
                    double celsius = (inputTemp - 32.0) * 5.0 / 9.0;
                    double kelvinF = celsius + 273.15;
                    lblDiffer.Text = $"Celsius: {celsius:F2}\nKelvin: {kelvinF:F2}";
                    break;

                case Unit.Kelvin:
                    double celsiusK = inputTemp - 273.15;
                    double fahrenheitK = (celsiusK * 9.0 / 5.0) + 32.0;
                    lblDiffer.Text = $"Celsius: {celsiusK:F2}\nFahrenheit: {fahrenheitK:F2}";
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDiffer_Click(object sender, EventArgs e)
        {

        }

        private void lblTempreture_Click(object sender, EventArgs e)
        {

        }
    }
}
