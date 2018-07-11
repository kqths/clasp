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

namespace CLASP
{
    public partial class frmSMS : MetroFramework.Forms.MetroForm
    {
        public frmSMS()
        {
            InitializeComponent();
            LoadPorts();
        }

        private void frmSMS_Load(object sender, EventArgs e)
        {
            txtMsg.WaterMark = "Message Here";
        }
        public void LoadPorts()
        {
            string[] Ports = SerialPort.GetPortNames();
            foreach(string port in Ports)
            {
                
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSuccess = false;
                SmsClass sm = new SmsClass(cboPorts.Text);
                sm.Opens();

                bSuccess = sm.sendSms(txtMobileNum.Text, txtMsg.Text);
                sm.Closes();
                if (bSuccess == true)
                {
                    MessageBox.Show("Message Sent!");
                }
                else
                {
                    MessageBox.Show("Message Sending Failed!");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
