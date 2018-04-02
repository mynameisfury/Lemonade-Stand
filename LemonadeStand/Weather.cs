using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        private bool IsRaining;
        private bool IsHumid;
        private enum SkyStates
        {
            CLOUDY,
            SUNNY,
            PARTLYCLOUDY
            
        }

        public Weather()
        {
                
        }

        public void DetermineRain(Random rng)
        {
            if (rng.Next(0, 1) == 1)
            {
                bool IsRaining = true;
                User_Interface.MenuMessage = "It is raining";
                User_Interface.DisplayMessage();
            }
            else
            {
                bool IsRaining = false;
                User_Interface.MenuMessage = "It's clear";
                User_Interface.DisplayMessage();
            }

        }
        public void DetermineHumid(Random rng)
        {

        
            if (rng.Next(0, 1) == 1)
            {
                bool IsHumid = true;
                User_Interface.MenuMessage = "It is humid";
                User_Interface.DisplayMessage();
            }
            else
            {
                bool IsHumid = false;
                User_Interface.MenuMessage = "It's not humid";
                User_Interface.DisplayMessage();
            }


        }
        public int DetermineTemperature(Random rng)
        {

            int result = rng.Next(60, 100);
            User_Interface.MenuMessage = result.ToString() + " Degrees";
            User_Interface.DisplayMessage();
            return result;

        }

    }
}
