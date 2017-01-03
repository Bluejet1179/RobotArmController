using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotArmControllerV1
{
    public partial class Form1 : Form
    {
        int timeleft = 180;//seconds
        Boolean timerState;
        Boolean timerEnd = false;
        Arduino mega = new Arduino();

        public Form1()
        {
            InitializeComponent();
            mega._SerialPort = SerialPort1;



            SerialPort1.DataReceived += SerialPort1_DataReceived;
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string[] potData = mega.getPotData();
            pot1.Invoke((MethodInvoker)(() =>
            {
                pot1.Text = potData[0];
            }));
            pot2.Invoke((MethodInvoker)(() =>
            {
                pot2.Text = potData[1];
            }));
            pot3.Invoke((MethodInvoker)(() =>
            {
                pot3.Text = potData[2];
            }));
            pot4.Invoke((MethodInvoker)(() =>
            {
                pot4.Text = potData[3];
            }));
            pot5.Invoke((MethodInvoker)(() =>
            {
                pot5.Text = potData[4];
            }));
            pot6.Invoke((MethodInvoker)(() =>
            {
                pot6.Text = potData[5];
            }));

            //MessageBox.Show(SerialPort1.ReadTo("n").ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string AvailableSerialPorts in System.IO.Ports.SerialPort.GetPortNames())
            {

                portComboBox.Items.Add(AvailableSerialPorts);
                SerialPort1.ReadTimeout = 2000;

                buttonConnect.Visible = true;
                buttonDisconnect.Visible = false;
            }
            baudRateComboBox.Items.Add(9600);
            baudRateComboBox.Items.Add(14400);
            baudRateComboBox.Items.Add(19200);
            baudRateComboBox.Items.Add(28800);
            baudRateComboBox.Items.Add(38400);
            baudRateComboBox.Items.Add(57600);
            baudRateComboBox.Items.Add(115200);
            portComboBox.SelectedItem = "COM3";
            baudRateComboBox.SelectedItem = 9600;




        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (portComboBox.SelectedItem != null && baudRateComboBox.SelectedItem != null)
            {
                SerialPort1.BaudRate = Convert.ToInt32(baudRateComboBox.SelectedItem);
                SerialPort1.PortName = portComboBox.SelectedItem.ToString();
                SerialPort1.Open();
                buttonConnect.Visible = false;
                buttonDisconnect.Visible = true;
                MessageBox.Show("Connected to " + portComboBox.SelectedItem.ToString() + " at " + baudRateComboBox.SelectedItem.ToString());
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            SerialPort1.Close();
            buttonConnect.Visible = true;
            buttonDisconnect.Visible = false;
            MessageBox.Show("Disconnected from " + portComboBox.SelectedItem.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pot1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void portComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

        }

        private void baudRateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool[] switches = { true, false, false, true };
            mega.sendData(switches);
            if(timeleft == 0 && timerEnd == false)
            {
                timerEnd = true;
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Time is up.");
            }
            if (timerState && timeleft > 0)
            {
                timeleft -= 1;
            }
            if (timeleft == 180)
            {
                timerTextBox.Text = "3:00";
            }
            else if(timeleft % 60 <= 9)
            {
                timerTextBox.Text = (timeleft / 60).ToString() + ":" + "0" + (timeleft % 60).ToString();
            }
            else
            {
                timerTextBox.Text = (timeleft / 60).ToString() + ":" + (timeleft % 60).ToString();
            }
        }

        private void timerTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void startTimerButton_Click(object sender, EventArgs e)
        {
            timerState = true;
            timerEnd = false;
        }

        private void stopTimerButton_Click(object sender, EventArgs e)
        {
            timerState = false;
            timerEnd = true;
        }

        private void resetTimerButton_Click(object sender, EventArgs e)
        {
            timeleft = 180;
            timerState = false;
            timerEnd = false;
        }
    }
}
