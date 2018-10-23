using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AudioCard
{
    public partial class Form1 : Form
    {
        private AudiCardController AC;
        private string filepath;
       
        public Form1()
        {
            InitializeComponent();
            AC = new AudiCardController();
            AC.mediaPlayer = mediaPlayer;
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SoundClick_Click(object sender, EventArgs e)
        {
            AC.PlaySound(filepath);
        }

        private void fileDialogBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Audio Files(*.wav)|*.wav"; //filter to be sure that user
            if (fileDialog.ShowDialog() == DialogResult.OK)
                filepath = fileDialog.FileName;
             
            Console.WriteLine(filepath);

        }

        private void StopSound_btn_Click(object sender, EventArgs e)
        {
            AC.StopSound();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            AC.PlayMediaPlayer(filepath);
        }
    }
}
