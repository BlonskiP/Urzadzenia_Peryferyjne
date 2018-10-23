using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace AudioCard
{
    class AudiCardController
    {
        public AudiCardController()
        {
            
        }

        public void PlaySound(string fileName) //gets .wav file and plays it.
        {
            if (fileName != null)
            {
                SoundPlayer player = new SoundPlayer(fileName);
                player.Play();
            }
            else
            {
                MessageBox.Show("Choose .wav file first");
            }
        }
    }
}
