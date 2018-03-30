using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Item item = new Item();
        Random rng = new Random();
        Day day = new Day();

        public void RunGame()
        {
            User_Interface.MenuMessage = "";
            User_Interface.DisplayMessage();
            day.weather.DetermineRain(rng);
            day.weather.DetermineTemperature(rng);
            Console.ReadKey();
        }
    }
}
