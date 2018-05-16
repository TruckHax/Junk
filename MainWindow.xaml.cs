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

namespace Metronome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool bStop = true;
        int nSleep = 600;
        System.Threading.Timer Timer;
        System.Media.SoundPlayer player;

        public MainWindow()
        {
            InitializeComponent();

            player = new System.Media.SoundPlayer(@"c:\WINDOWS\Media\notify.wav");

            Timer = new System.Threading.Timer(TimerCallback, null, 1, nSleep);
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            nSleep = int.Parse(txtMilliseconds.Text);

            Timer.Change(1, nSleep);
        }
      
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            bStop = false;
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            bStop = true;
        }

        private void TimerCallback(object state)
        {
            if (bStop == true)
            {
                player.Stop();
            }
            else
            {
                player.Play();
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ScrollBar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
