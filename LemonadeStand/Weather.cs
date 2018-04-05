using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public bool IsRaining;
        public bool IsHumid;
        
        private enum SkyStates
        {
            CLOUDY,
            SUNNY,
            PARTLYCLOUDY
            
        }

        

        public bool DetermineRain(Random rng)
        {
            if (rng.Next(0, 1) == 1)
            {
                bool IsRaining = true;
                return true;
                User_Interface.MenuMessage = "It is raining";
                User_Interface.DisplayMessage();
            }
            else
            {
                bool IsRaining = false;
                return false;
                User_Interface.MenuMessage = "It's clear";
                User_Interface.DisplayMessage();
            }

        }
        public bool DetermineHumid(Random rng)
        {

        
            if (rng.Next(0, 1) == 1)
            {
                bool IsHumid = true;
                return true;
                User_Interface.MenuMessage = "It is humid";
                User_Interface.DisplayMessage();
            }
            else
            {
                bool IsHumid = false;
                return false;
                User_Interface.MenuMessage = "It's not humid";
                User_Interface.DisplayMessage();
            }


        }
        public int DetermineTemperature(Random rng)
        {

            int result = rng.Next(60, 100);
            
            return result;

        }

    }
}
