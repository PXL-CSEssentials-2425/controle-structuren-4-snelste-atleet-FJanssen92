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

namespace SnelsteAtleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int fastestTime = 0; 
        string fastestAthlete;
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            
            int currentTime = int.Parse(secondsTextBox.Text);

            if (fastestTime == 0 || currentTime < fastestTime)
            {
                fastestTime = currentTime;
                fastestAthlete = nameTextBox.Text;
            }

            nameTextBox.Clear();
            secondsTextBox.Clear();


        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Clear();
            secondsTextBox.Clear();
            resultTextBox.Clear();
            
            nameTextBox.Focus();
        }

        private void fastestButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = $"De snelste atleet is {fastestAthlete} met een tijd van {fastestTime} seconden.\n" +
                $"\n" +
                $"Aantal uren: {fastestTime / 3600}\n" +
                $"Aantal minuten: {(fastestTime % 3600) / 60}\n" +
                $"Aantal seconden: {(fastestTime % 3600) % 60}";
        }
    }

    }
