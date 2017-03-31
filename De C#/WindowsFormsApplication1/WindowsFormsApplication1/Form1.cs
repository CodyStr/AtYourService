using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Brick brick;
        ColorSensorColor currentcolor;
        int forward = 15;
        int backward = -15;
        uint time = 300;
        ToolTip toolTip1 = new ToolTip();
        public Form1()
        {
            InitializeComponent();
            init();
            brick.Ports[InputPort.Three].SetMode(ColorMode.Color);
        }

        private async void init()
        {
            brick = new Brick(new BluetoothCommunication("COM3"));
            brick.BrickChanged += brickChanged;
            await brick.ConnectAsync();
            await brick.DirectCommand.PlayToneAsync(5, 1000, 300);
            await brick.DirectCommand.SetMotorPolarity(OutputPort.B | OutputPort.C, Polarity.Backward);
            await brick.DirectCommand.StopMotorAsync(OutputPort.All, false);
        }
        private async void brickChanged(object o, BrickChangedEventArgs e)
        {
            txtDistance.Text = e.Ports[InputPort.Four].SIValue.ToString();
            txtTouch.Text = e.Ports[InputPort.One].SIValue.ToString();
            txtColor.Text = ((ColorSensorColor)e.Ports[InputPort.Three].SIValue).ToString();
            this.currentcolor = (ColorSensorColor) e.Ports[InputPort.Three].SIValue;
            if (this.currentcolor == ColorSensorColor.Blue)
            {
                await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.B, 100, 500, false);
                await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.C, -25, 500, false);
            }
        }

        private async void BTNForward_Click(object sender, EventArgs e)
        {
           if (this.currentcolor != ColorSensorColor.Red)
                await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.A | OutputPort.B | OutputPort.C, forward, time, false);
        }

        private async void BTNLeft_Click(object sender, EventArgs e)
        {
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, backward, time, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, forward, time, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.A, forward, time, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        private async void BTNBackwards_Click(object sender, EventArgs e)
        {
            await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.A | OutputPort.B | OutputPort.C, backward, time, false);
        }

        private async void BTNRight_Click(object sender, EventArgs e)
        {
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, forward, time, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, backward, time, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.A, forward, time, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        public async void up()
        {
            if (this.currentcolor != ColorSensorColor.Red)
                await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.A | OutputPort.B | OutputPort.C, forward, time, false);
        }
        public async void left()
        {
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, backward, time, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, forward, time, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.A, forward, time, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        public async void right()
        {
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.C, backward, time, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.B, forward, time, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.A, forward, time, false);
            await brick.BatchCommand.SendCommandAsync();
        }

        public async void down()
        {
            await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(OutputPort.A | OutputPort.B | OutputPort.C, backward, time, false);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            if (keyData == Keys.Up)
            {
                up();
                return true;
            }
            
            if (keyData == Keys.Down)
            {
                down();
                return true;
            }
            
            if (keyData == Keys.Left)
            {
                left();
                return true;
            }
            
            if (keyData == Keys.Right)
            {
                right();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            forward = trackBar1.Value;
            backward = trackBar1.Value - (trackBar1.Value * 2);
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
