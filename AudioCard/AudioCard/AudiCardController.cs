using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using AxWMPLib;

namespace AudioCard
{
    class AudiCardController
    {
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
                player.
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
        
    }
}
