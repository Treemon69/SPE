using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Microsoft.Win32;

namespace SPE_Project
{
    class Player
    {
        Random r = new Random();
        MediaPlayer MediaP = new MediaPlayer();
        OpenFileDialog OFD=new OpenFileDialog();
        private string lied;
        private string[] songs;
        //Standard (noWork)
        public void SelectPlanet()
        {
          //  OFD.OpenFile();
            // OFD.Filter = "MP3  (.mp3)|*.mp3";
            MediaP.Open(new Uri(lied)); 
        }

        public void StartPlanet()
        {
            MediaP.Volume = 50;
            MediaP.Play();
        }

        public void PausePlanet()
        {
            
            MediaP.Pause();
            

        }

        public void nextPlanet()
        {
            
            MediaP.Stop();
            nextBigBang();
            MediaP.Play();

        }

        //Unusual

        void nextBigBang() { }

        /// <summary>
        /// Spielt ein zufälliges Lied ab
        /// </summary>
        /// <param name="a">Anzahl der Lieder</param>
        void randomPlanets(int a)
        {           
            MediaP.Open((new Uri(songs[r.Next(0, a)])));
            MediaP.Play();
        }



    


    }
}
