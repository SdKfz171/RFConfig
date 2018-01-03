using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace RFConfig.Views
{
    /// <summary>
    /// SettingPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SettingPage : Page
    {
        private SerialPort serial;

        public string _PortName { get; set; }
        public int _BaudRate { get; set; }
        public int _DataBits { get; set; }
        public Parity _Parity { get; set; }
        public StopBits _StopBits { get; set; }


        public SettingPage()
        {
            InitializeComponent();

            serial = new SerialPort();
        }

        private void SerialInit()
        {
            // string[] AvailablePorts = SerialPort.GetPortNames();
            try
            {
                serial.PortName = _PortName;
                serial.BaudRate = _BaudRate;
                serial.DataBits = _DataBits;
                serial.Parity = _Parity;
                serial.StopBits = _StopBits;
            }
            catch
            {

            }
            
            serial.DataReceived += Serial_DataReceived;
            
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
        }

        private void PortCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BaudRateCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _BaudRate = int.Parse(((ComboBoxItem)BaudRateCombo.SelectedValue).Content.ToString());
        }

        private void DataBitsCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _DataBits = int.Parse(((ComboBoxItem)DataBitsCombo.SelectedValue).Content.ToString());
        }

        private void ParityCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ParityCombo.SelectedIndex)
            {
                case 0:
                    _Parity = Parity.None;
                    break;

                case 1:
                    _Parity = Parity.Odd;
                    break;

                case 2:
                    _Parity = Parity.Even;
                    break;
            }
        }

        private void StopBitsCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FlowCtrlCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PortCombo_DropDownOpened(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked");
        }

        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
