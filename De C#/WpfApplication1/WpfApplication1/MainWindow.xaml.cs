﻿using System;
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
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brick _brick;
        int _forward = 100;
        int _backward = -100;
        uint _time = 300;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _brick = new Brick(new BluetoothCommunication("COM8"));
            _brick.BrickChanged += _brick_BrickChanged;
            await _brick.ConnectAsync();
            await _brick.DirectCommand.PlayToneAsync(15, 1000, 300);
            await _brick.DirectCommand.SetMotorPolarity(OutputPort.B | OutputPort.C, Polarity.Backward);
            await _brick.DirectCommand.StopMotorAsync(OutputPort.All, false);
        }

        private void _brick_BrickChanged(object sender, BrickChangedEventArgs e)
   
        {
            
        }

        private async void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            await _brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.A |OutputPort.B | OutputPort.C, _forward, _time, false);

        }

        private async void BackwardsButton_Click(object sender, RoutedEventArgs e)
        {
            await _brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.A | OutputPort.B | OutputPort.C, _backward, _time, false);

        }

        private async void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            _brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, _backward, _time, false);
            _brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, _forward, _time, false);
            _brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.A, _forward, _time, false);
            await _brick.BatchCommand.SendCommandAsync();
        }

        private async void RightButton_Click(object sender, RoutedEventArgs e)
        {
            _brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, _backward, _time, false);
            _brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, _forward, _time, false);
            _brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.A, _forward, _time, false);
            await _brick.BatchCommand.SendCommandAsync();
        }


    }
}
