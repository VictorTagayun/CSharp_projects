using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Victor_NXP_DashBoard01
{
    public partial class frmVictorNXP : Form
    {
        static SerialPort myserialPort;
        static bool isSerialConnected;
        static bool isThereAlreadyNewSerial;

        //Console.Write("Test");

        public frmVictorNXP()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            foreach (string comm in SerialPort.GetPortNames())
            {
                comboBoxCommPorts.Items.Add(comm);
            }
        }

        private void comboBoxCommPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmVictorNXP_Load(object sender, EventArgs e)
        {
            Console.Write("Test");
            myserialPort = new SerialPort();
        }

        private void btnCloseFrm_Click(object sender, EventArgs e)
        {
            if (myserialPort.IsOpen)
                myserialPort.Close();
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://victortagayun.github.io");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(comboBoxCommPorts.Text == "")
            {
                MessageBox.Show("Please select correct Serial Comm port!", "ERROR");
            }
            else
            {
                if(btnConnect.Text == "Connect") // Connect
                {
                    if (myserialPort.IsOpen)
                    {
                        MessageBox.Show("Serial Comm port already open!", "ERROR");
                    }
                    else
                    {
                        myserialPort.PortName = comboBoxCommPorts.Text;
                        myserialPort.BaudRate = 19200;
                        myserialPort.Parity = Parity.None;
                        myserialPort.DataBits = 8;
                        myserialPort.StopBits = StopBits.One;
                        myserialPort.Handshake =0;

                        try // open port
                        {
                            myserialPort.Open();
                            txtSerialPort.Text = comboBoxCommPorts.Text;
                            btnConnect.Text = "Disconnect";
                        }
                        catch (Exception ex) // handle the exception
                        {
                            MessageBox.Show("Some app is using the PORT! Please Close the connection!", "ERROR");
                        }
                    }
                }
                else // Disconnect
                {
                    txtSerialPort.Text = "";
                    btnConnect.Text = "Connect";
                    myserialPort.Close();
                }


                    
            }
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            if (myserialPort.IsOpen)
                myserialPort.Close();
            txtSerialPort.Text = "";
        }
    }
}
