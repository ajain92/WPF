using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  bool chequ = false;
        public  bool saving = false;
        public  bool deposit = false;
        public  bool widhtDraw = false;
        public static double chequAmt = 100.00;
        public static double savingAmt = 100.00;
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender,  RoutedEventArgs e)
        {
               
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {


            if (chequ && widhtDraw)
            {               
                MessageBoxResult result = MessageBox.Show("Do you really want to widthdraw $"+textBox1.Text+" form chequing account", "Withdraw", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                { chequAmt -= Convert.ToDouble(textBox1.Text);  }
                textBox2.Text = Convert.ToString(chequAmt);    
                
            }
            else
            {
                if (chequ && deposit)
                {
                    MessageBoxResult result = MessageBox.Show("Do you really want to QUIT", "QUIT", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                     chequAmt += Convert.ToDouble(textBox1.Text); 
                    textBox2.Text = Convert.ToString(chequAmt);
                }
                
            }
            
              
             if (saving && widhtDraw)
               {
                   MessageBoxResult result = MessageBox.Show("Do you really want to widthdraw $" + textBox1.Text + " form saving account", "Withdraw", MessageBoxButton.YesNo);
                   if (result == MessageBoxResult.Yes)     
                     savingAmt -= Convert.ToDouble(textBox1.Text);
                   textBox2.Text = Convert.ToString(savingAmt); 
             }
                    else
             {
                 if (saving && deposit)
                 {
                     MessageBoxResult result = MessageBox.Show("Do you really want to deposit $" + textBox1.Text + " to saving account", "Deposit", MessageBoxButton.YesNo);
                     if (result == MessageBoxResult.Yes)
                         savingAmt += Convert.ToDouble(textBox1.Text);
                     textBox2.Text = Convert.ToString(savingAmt); 
                 }
                 
             }                        
                 
        }
        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        { 
            chequ = true;
            saving = false;
        }

        private void radioButton4_Checked(object sender, RoutedEventArgs e)
        {
            widhtDraw = true;
            deposit = false;
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            saving = true;
            chequ = false;
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            deposit = true;
            widhtDraw = false;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
