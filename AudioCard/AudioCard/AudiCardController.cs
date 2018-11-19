using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AxWMPLib;

namespace AudioCard
{
    class AudiCardController
    {   
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command,
            StringBuilder retstring, int ReturnLength, IntPtr callback);

        public AxWindowsMediaPlayer mediaPlayer;
        private SoundPlayer player;
        public AudiCardController()
        {
            
          
        }

        public void PlaySound(string fileName) //gets .wav file and plays it.
        {
            if (fileName != null)
            {
                player = new SoundPlayer(fileName);
                player.Play();
            }
            else
            {
                MessageBox.Show("Choose .wav file first");
            }

        }
        public void StopSound()
        {
            player?.Stop(); // same as if(player!=null);
        }

        public void PlayMediaPlayer(string fileName)
        {
            if (fileName != null)
            {
                mediaPlayer.URL = fileName;
                mediaPlayer.Ctlcontrols.play();

            }
        }

        public void MicroPhoneOn()
        {
            mciSendString("open new type waveaudio alias wavfile", null, 0, IntPtr.Zero);
            mciSendString("record wavfile", null, 0, IntPtr.Zero);

        }

        public void SaveMicro()
        {
            mciSendString("save wavfile test.wav", null, 0, IntPtr.Zero);
            mciSendString("close wavfile", null, 0, IntPtr.Zero);
            
        }
        public void msiPlay(string fileName)
        {
            string command = "Open wavefile " + fileName + " alias MediaFile";
            Console.WriteLine(command);
            mciSendString(command,null,0,IntPtr.Zero);
            command = "Play "+fileName +" from 5";
           
            mciSendString(command,null,0,IntPtr.Zero);
        }

        public void mciPause(string filename)
        {
            string command= "pause "+filename;
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void mciResume(string filename)
        {
            string command = "resume " + filename;
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void mciStop(string filename)
        {
            string command = "stop " + filename;
            mciSendString(command, null, 0, IntPtr.Zero);
            command = "close " + filename;
            mciSendString(command, null, 0, IntPtr.Zero);

        }
    }
}
