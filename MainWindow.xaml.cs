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

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         private int lives = 10;
        private int randomNumber = 0;

        public MainWindow()
        {
             InitializeComponent();
            Random rnd = new Random();
            randomNumber = rnd.Next() % 100;
        }


         private void TextBoxinput_KeyDown(object sender, KeyEventArgs e)
        {
            if(lives == 0)
            {
                lblFrom.Content = "Du";
                lblTo.Content = "Förlora";
                return;
            }
            if(e.Key == Key.Enter) 
            {
               
                lives --;
                int userGuessed = Int32.Parse(TextBoxinput.Text);
                TextBoxinput.Text = "";
            
                if (userGuessed == randomNumber)
                {
                    lblFrom.Content = "Du";
                    lblTo.Content = "Vann";
                    return;
                }
                if(userGuessed < randomNumber )
                {
                    lblFrom.Content = userGuessed;
                }
               else
               {
                    lblTo.Content = userGuessed;
               }
                lblLives.Content = "Remaining lives: " + lives;
                if(lives <= 3)
                {
                    lblLives.Foreground = new SolidColorBrush(Colors.Red);
                }
            }
        }

      

        private void TextBoxinput_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxinput.Text = "";
        }
    }
    
}
