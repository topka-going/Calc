using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {

        public string MemoryNumber = "0";

        public string CalculationResult;

        public string Number1;

        public string Number2;

        public string Operation;

        public bool NumberExistence;

        public MainWindow()

        {

            InitializeComponent();

            NumberExistence = false;

            TxtCalculation.Text = "0";

        }

        private void BtnCalculation_Click(object sender, RoutedEventArgs e)

        {
            if (TxtCalculation.Text == "")

            {

                TxtCalculation.Text = "0";

            }

            double result = 0;

            double Number1Double = Convert.ToDouble(Number1);

            double Number2Double = Convert.ToDouble(TxtCalculation.Text);

            switch (Operation)

            {

                case "+":

                    result = Number1Double + (Number2Double);

                    break;

                case "-":

                    result = Number1Double - Number2Double;

                    break;

                case "*":

                    result = Number1Double * Number2Double;

                    break;

                case "/":

                    result = Number1Double / Number2Double;

                    break;

                case "^":

                    result = Math.Pow(Number1Double, Number2Double);

                    break;

                case "%":

                    result = Number1Double * (Number2Double / 100);

                    break;

            }

            Operation = $"{null}";

            NumberExistence = true;

            TxtCalculation.Text = Convert.ToString(result);

        }

        #region buttons number

        private void TxtEngage(string ButtonText)

        {

            if (NumberExistence == true)

            {

                NumberExistence = false;

                TxtCalculation.Text = $"0";

            }

            if (TxtCalculation.Text == "0")

            { TxtCalculation.Text = $"{null}"; }

            TxtCalculation.Text = TxtCalculation.Text + ButtonText;

        }

        private void Btn0_Click(object sender, RoutedEventArgs e)

        {

            TxtEngage("0");

        }

        private void Btn1_Click(object sender, RoutedEventArgs e)

        {

            TxtEngage("1");

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)

        {

            TxtEngage("2");

        }

        private void Btn3_Click(object sender, RoutedEventArgs e)

        {

            TxtEngage("3");

        }

        private void Btn4_Click(object sender, RoutedEventArgs e)

        {

            TxtEngage("4");

        }

        private void Btn5_Click(object sender, RoutedEventArgs e)

        {

            TxtEngage("5");

        }

        private void Btn6_Click(object sender, RoutedEventArgs e)

        {

            TxtEngage("6");

        }

        private void Btn7_Click(object sender, RoutedEventArgs e)

        {

            TxtEngage("7");

        }

        private void Btn8_Click(object sender, RoutedEventArgs e)

        {

            TxtEngage("8");

        }

        private void Btn9_Click(object sender, RoutedEventArgs e)

        {

            TxtEngage("9");

        }

        private void BtnDot_Click(object sender, RoutedEventArgs e)

        {

            if (TxtCalculation.Text.Contains(",") != true)

            {

                TxtCalculation.Text = TxtCalculation.Text + ",";

            }

        }

        #endregion

        #region arithmetic sign

        private void CalculationSign(string sign)

        {

            Operation = sign;

            Number1 = TxtCalculation.Text;

            NumberExistence = true;

        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)

        {

            CalculationSign("+");

        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)

        {

            CalculationSign("-");

        }

        private void BtnMulti_Click(object sender, RoutedEventArgs e)

        {

            CalculationSign("*");

        }

        private void BtnSegment_Click(object sender, RoutedEventArgs e)

        {

            CalculationSign("/");

        }

        private void BtnDegree_Click(object sender, RoutedEventArgs e)

        {

            CalculationSign("^");

        }

        private void BtnRad_Click(object sender, RoutedEventArgs e)

        {

            double rad = Convert.ToDouble(TxtCalculation.Text);

            TxtCalculation.Text = Convert.ToString(Math.Sqrt(rad));

        }

        private void BtnInvert_Click(object sender, RoutedEventArgs e)

        {

            double invert = Convert.ToDouble(TxtCalculation.Text);

            TxtCalculation.Text = Convert.ToString(-invert);

        }

        private void Btn1x_Click(object sender, RoutedEventArgs e)

        {

            double x1 = Convert.ToDouble(TxtCalculation.Text);

            TxtCalculation.Text = Convert.ToString(1 / x1);

        }

        private void BtnPersent_Click(object sender, RoutedEventArgs e)

        {

            CalculationSign("%");

        }

        #endregion

        private void BtnClear_Click(object sender, RoutedEventArgs e)

        {

            TxtCalculation.Text = $"0";

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)

        {

            if (TxtCalculation.Text != "")

            { TxtCalculation.Text = TxtCalculation.Text.Remove(TxtCalculation.Text.Length - 1); }

        }

        private void BtnMemorySaveorDelete_Click(object sender, RoutedEventArgs e)

        {
            if (MemoryNumber != TxtCalculation.Text)

            {

                LblMemory.Visibility = Visibility.Visible;

                MemoryNumber = (TxtCalculation.Text);

            }

            else

            {

                LblMemory.Visibility = Visibility.Hidden;

                MemoryNumber = "0";

            }

        }

        private void BtnMemoryRead_Click(object sender, RoutedEventArgs e)

        {

            TxtCalculation.Text = MemoryNumber;

        }

        private void BtnMemoryPlus_Click(object sender, RoutedEventArgs e)

        {

            TxtCalculation.Text = Convert.ToString(Convert.ToDouble(TxtCalculation.Text) + Convert.ToDouble(MemoryNumber));

        }

        private void BtnMemoryMinus_Click(object sender, RoutedEventArgs e)

        {

            TxtCalculation.Text = Convert.ToString(Convert.ToDouble(TxtCalculation.Text) - Convert.ToDouble(MemoryNumber));

        }

    }

}

