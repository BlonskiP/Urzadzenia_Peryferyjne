using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA; 

namespace Skaner225959
{
    public partial class Form1 : Form
    {
        String path;
        ScannerController sc;
        public Form1()
        {
            InitializeComponent();
            sc= new ScannerController();
        }

        private void scannersBtn_Click(object sender, EventArgs e)
        {
            scannersList.Items.Clear();
            sc.getScanners();
            for (int i=0; i<sc.scanners.Count; i++)
            {
                scannersList.Items.Add(sc.scanners.ToArray()[i].Properties["Name"].get_Value());
            }
        }

        private void scannersList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            if (path == null) openFolderDialog();
            if (sc.scanners.Count == 0)
            {
                sc.getScanners();
                
            }
            if (sc.scanners.Count > 0)
            {
                if(scannersList.SelectedIndex!=-1)
                sc.chosenDevice = sc.scanners[scannersList.SelectedIndex];
                sc.scan(FormatID.wiaFormatJPEG);
                showImg();
            }
        }

        private void folderBtn_Click(object sender, EventArgs e)
        {
            openFolderDialog();
        }

        private void imgShow_Click(object sender, EventArgs e)
        {
            showImg();

        }

        

        private void dialogBtn_Click(object sender, EventArgs e)
        {
            sc.scanTest();
        }

        private void openFolderDialog()
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                path = folder.SelectedPath;
                Console.WriteLine(path);
                sc.filePath = path;
            }
        }
        private void showImg()
        {

            pictureBox1.ImageLocation = sc.filePath;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        

       
    }
}