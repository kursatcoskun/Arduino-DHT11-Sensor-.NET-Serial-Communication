using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace DHT11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
            {
                comboBox1.Items.Add(System.IO.Ports.SerialPort.GetPortNames()[i]);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            string veriAl = serialPort1.ReadLine().ToString();
            string[] isinem = veriAl.Split(',');
            //double nemdeger = Convert.ToDouble(isinem[0]);
            string degernem = isinem[0];
            string degerisi = isinem[1];

           label2.Text = degerisi+ " C";
            label3.Text = degernem + " %";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
           serialPort1.Open();
           timer1.Enabled = true;
            label1.Text = "Bağlanıldı...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer1.Stop();
            this.Close();
            Application.Exit();
        }
    }
}
