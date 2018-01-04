using RFConfig.Views;
using System;
using System.Collections.Generic;
using System.IO.Ports;
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
using System.Windows.Threading;

namespace RFConfig
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public SerialPort _Serial;

        public static bool flag;

        public MainWindow()
        {
            InitializeComponent();

            _Serial = new SerialPort();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                //_Serial.RE
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SettingPage(_Serial));
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
