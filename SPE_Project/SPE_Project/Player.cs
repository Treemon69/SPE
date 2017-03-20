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
        MediaPlayer MediaP = new MediaPlayer();
        OpenFileDialog OFD=new OpenFileDialog();
        private string lied = "C:\\Users\\krzes\\Music\\5 Seconds of Summer - She Looks So Perfect";
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
        void randomPlanets() { }

    


    }
}
