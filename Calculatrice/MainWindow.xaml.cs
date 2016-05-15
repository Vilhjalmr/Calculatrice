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
        String Memory = "0";
        Boolean Started = false;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateDisplay(Button btn)
        {
            Display.Text += (String)btn.Content;
            Started = true;
        }

        private void CheckInput(Button btn)
        {
            if ((String)btn.Content == "0" && !Started)
            {
                // Don't do anything
            }
            else if ((String)btn.Content == "+" || 
                     (String)btn.Content == "-" || 
                     (String)btn.Content == "*" || 
                     (String)btn.Content == "/" || 
                     (String)btn.Content == "=" )
            {
                if (!Started)
                {
                    // Don't do anything
                }
                else
                {
                    UpdateDisplay(btn);
                }
            }
            else
            {
                if ((String)Display.Text == "0")
                {
                    Display.Clear();
                }
                UpdateDisplay(btn);
            }
            
            //if (Started)
            //{
            //    Display.Text = "0";
            //    Started = false;
            //}
            //if (Display.Text == "0")
            //{
            //    Display.Text = "0";
            //}
            //Display.Text += (String)btn.Content;


            //Display.Focus();
            //Display.CaretIndex = Display.Text.Length;
            //Display.ScrollToEnd();
        }

        private void DisplayResult()
        {
            // TODO: boolean indique qu'on est passé. Si on tape qqch est que ce bool est vrai, on remet à zéro
            string math = Display.Text;
            string value = new DataTable().Compute(math, null).ToString();
            Display.Text = value;
            Started = true;
        }

        /*
         * Following methods implement behaviour of the 
         * calculator's buttons when pressed
         */

        // NUMBERS
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btn0);
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btn1);
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btn2);
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btn3);
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btn4);
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btn5);
        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btn6);
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btn7);
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btn8);
        }
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btn9);
        }

        // OPERATORS
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btnPlus);
        }
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btnMinus);
        }
        private void btnTime_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btnTime);
        }
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btnDivide);
        }
        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            DisplayResult();
        }


        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            CheckInput(btnComma);
        }

        private void btnMc_Click(object sender, RoutedEventArgs e)
        {
            Memory = "0";
        }

        private void btnMplus_Click(object sender, RoutedEventArgs e)
        {
            if (Memory == "0")
            {
                Memory = Display.Text;
                Started = true;
            }
            else
            {
                Display.Text = Display.Text + "+" + Memory;
                DisplayResult();
            }

        }

        private void btnMminus_Click(object sender, RoutedEventArgs e)
        {
            if (Memory != "0")
            {
                Display.Text = Display.Text + "-" + Memory;
                DisplayResult();
            }
        }

        private void btnMr_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = Memory;
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
                btn0_Click(sender, e);
            }
            if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                btn1_Click(sender, e);
            }
            if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                btn2_Click(sender, e);
            }
            if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                btn3_Click(sender, e);
            }
            if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                btn4_Click(sender, e);
            }
            if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                btn5_Click(sender, e);
            }
            if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                btn6_Click(sender, e);
            }
            if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                btn7_Click(sender, e);
            }
            if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                btn8_Click(sender, e);
            }
            if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                btn9_Click(sender, e);
            }

            // OPERATORS
            if (e.Key == Key.Add || e.Key == Key.OemPlus)
            {
                btnPlus_Click(sender, e);
            }
            if (e.Key == Key.Subtract || e.Key == Key.OemMinus)
            {
                btnMinus_Click(sender, e);
            }
            if (e.Key == Key.Multiply)
            {
                CheckInput(btnTime);
            }
            if (e.Key == Key.Divide)
            {
                CheckInput(btnDivide);
            }

            if (e.Key == Key.Enter)
            {
                DisplayResult();
            }

            if (e.Key == Key.C || e.Key == Key.Delete)
            {
                btnC_Click(sender, e);
            }

            if (e.Key == Key.Back)
            {
                try
                {
                    Display.Text = Display.Text.Remove(Display.Text.Length - 1, 1);
                    // Other possibility
                    // Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
                }
                catch
                {
                    // Doesn't do anything. Avoids errors when trying to remove
                    // last letter of an empty chain
                }
            }
        }
    }
}
