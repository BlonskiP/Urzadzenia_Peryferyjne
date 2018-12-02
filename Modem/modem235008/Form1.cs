using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modem235008
{
    public partial class Form1 : Form
    {
        bool enter = false;
        string filePath;
        SerialPortManager _portManager;
       
        public Form1()
        {
            _portManager = new SerialPortManager();
            InitializeComponent();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if(COMBox.SelectedItem!=null)
           _portManager.Connect(COMBox.SelectedItem.ToString());
         
        }

        private void PortsBtn_Click(object sender, EventArgs e)
        {
            List<String> ComList =_portManager.GetCOM();
            COMBox.Items.Clear();
            COMBox.Items.AddRange(ComList.ToArray());
        }

        private void COMBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void SendBtn_Click(object sender, EventArgs e)
        {   string message;
        message = messageBox.Text;
        if (enter = true)
            message = message + Environment.NewLine;
        Console.WriteLine("MESSAGE TO SEND: " + message);
        _portManager.SendMessage(message);
        }

        private void EnterCB_CheckedChanged(object sender, EventArgs e)
        {
            if (EnterCB.Checked) enter = true;
            else enter = false;
            Console.WriteLine(EnterCB.Checked);
        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFolderDialog();
            _portManager.SendFile(filePath);
        }
        private void OpenFolderDialog()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                
                Console.WriteLine("File:" + filePath + " is ready to load");

            }
        }
        
    }
}
