using System;
using System.Collections.Generic;
using System.Data;
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

namespace Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void UpdateDisplay(Button btn)
        {
            if (Display.Text == "0")
            {
                Display.Clear();
            }
            Display.Text += (String)btn.Content;
        }
        private void DisplayResult()
        {
            // TODO: boolean indique qu'on est passé. Si on tape qqch est que ce bool est vrai, on remet à zéro
            string math = Display.Text;
            string value = new DataTable().Compute(math, null).ToString();
            Display.Text = value;
        }

        /*
         * Following methods implements behaviour of the 
         * calculator's buttons when pressed
         */

        // NUMBERS
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btn0);
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btn1);
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btn2);
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btn3);
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btn4);
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btn5);
        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btn6);
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btn7);
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btn8);
        }
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btn9);
        }

        // OPERATORS
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btnPlus);
        }
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btnMinus);
        }
        private void btnTime_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btnTime);
        }
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btnDivide);
        }
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            DisplayResult();
        }


        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            UpdateDisplay(btnComma);
        }

        private void btnMc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMplus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMminus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
        }

        private void btnNeg_Click(object sender, RoutedEventArgs e)
        {

        }




        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            // NUMBERS
            if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                UpdateDisplay(btn0);
            }
            if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                UpdateDisplay(btn1);
            }
            if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                UpdateDisplay(btn2);
            }
            if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                UpdateDisplay(btn3);
            }
            if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                UpdateDisplay(btn4);
            }
            if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                UpdateDisplay(btn5);
            }
            if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                UpdateDisplay(btn6);
            }
            if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                UpdateDisplay(btn7);
            }
            if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                UpdateDisplay(btn8);
            }
            if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                UpdateDisplay(btn9);
            }

            // OPERATORS
            if (e.Key == Key.Add || e.Key == Key.OemPlus)
            {
                UpdateDisplay(btnPlus);
            }
            if (e.Key == Key.Subtract || e.Key == Key.OemMinus)
            {
                UpdateDisplay(btnMinus);
            }
            if (e.Key == Key.Multiply)
            {
                UpdateDisplay(btnTime);
            }
            if (e.Key == Key.Divide)
            {
                UpdateDisplay(btnDivide);
            }

            if (e.Key == Key.Enter)
            {
                DisplayResult();
            }
        }
    }
}
