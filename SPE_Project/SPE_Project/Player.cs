using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Microsoft.Win32;
using  System.IO;
using System.Windows.Threading;

namespace SPE_Project
{
    class Player
    {

        // StreamWriter SW=new StreamWriter("Places.txt");
        // StreamReader SR=new StreamReader("Places.txt");
        DispatcherTimer timer = new DispatcherTimer();
        


        Random r = new Random();
        private MediaPlayer MediaP = new MediaPlayer();
        private OpenFileDialog OFD=new OpenFileDialog();
        private string[] songs;
        public string lblStatus;

        //Standard (noWork)
        public void selectLied()
        {
            
            OFD.Filter = "MP3  (.mp3)|*.mp3";
            if (OFD.ShowDialog() == true)
                MediaP.Open(new Uri(OFD.FileName));
         
        }

        public void startLied()
        {
            MediaP.Volume = 100;
            
            MediaP.Play();
            lblStatus = Convert.ToString(MediaP.NaturalDuration);
            System.Diagnostics.Debug.WriteLine(MediaP.NaturalDuration);

        }

        

        public void pauseLied()
        {
            
            MediaP.Pause();
            

        }

        public void nextLied()
        {
            
            MediaP.Stop();
            GetLieder();
            MediaP.Play();

        }

        //Unusual

        void GetLieder() { }

        /// <summary>
        /// Spielt ein zufälliges Lied ab
        /// </summary>
        /// <param name="a">Anzahl der Lieder</param>
        void randomSong(int a)
        {           
            MediaP.Open((new Uri(songs[r.Next(0, a)])));
            MediaP.Play();
        }



    


    }
}
