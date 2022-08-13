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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first, second;
        char sign;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
            second = Int32.Parse(Display.Text);
        }

        private void Button_Div_Click(object sender, RoutedEventArgs e)
        {
            first = int.Parse(Display.Text);
            sign = '/';

            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();

        }

        private void Button_Mul_Click(object sender, RoutedEventArgs e)
        {
            first = int.Parse(Display.Text);
            sign = '*';
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            first = int.Parse(Display.Text);
            sign = '+';

            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
        }

        private void Button_Sub_Click(object sender, RoutedEventArgs e)
        {
            first = int.Parse(Display.Text);
            sign = '-';

            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
        }

        private void Button_Equal_Click(object sender, RoutedEventArgs e)
        {
            int s = Display.Text.IndexOf(sign);
            second = Convert.ToInt32(Display.Text.Substring(s + 1));
            double result = 0;
            switch (sign)
            {
                case '+':
                    result = first + second;
                    break;
                case '-':
                    result = first - second;
                    break;
                case '*':
                    result = first * second;
                    break;
                case '/':
                    try
                    {
                        result = (double)first / second;
                        break;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    break;
            }

            if (Display.Text == "0")
            {
                Display.Clear();
            }
            Display.Text = result.ToString();
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
            int s = Display.Text.IndexOf(sign);
            second = Int32.Parse(Display.Text.Substring(s + 1));
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
            int s = Display.Text.IndexOf(sign);
            second = Int32.Parse(Display.Text.Substring(s + 1));
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
            int s = Display.Text.IndexOf(sign);
            second = Int32.Parse(Display.Text.Substring(s + 1));
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
            int s = Display.Text.IndexOf(sign);
            second = Int32.Parse(Display.Text.Substring(s + 1));
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
            int s = Display.Text.IndexOf(sign);
            second = Int32.Parse(Display.Text.Substring(s + 1));
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
            int s = Display.Text.IndexOf(sign);
            second = Int32.Parse(Display.Text.Substring(s + 1));
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
            int s = Display.Text.IndexOf(sign);
            second = Int32.Parse(Display.Text.Substring(s + 1));
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
            int s = Display.Text.IndexOf(sign);
            second = Int32.Parse(Display.Text.Substring(s + 1));
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
            int s = Display.Text.IndexOf(sign);
            second = Int32.Parse(Display.Text.Substring(s + 1));
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Clear();
        }
    }
}
