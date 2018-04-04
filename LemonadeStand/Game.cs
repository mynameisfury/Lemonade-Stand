using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //Item item = new Item();
        Random rng = new Random();
        Day day = new Day();
        Player player = new Player();

        public void RunGame()
        {
            day.weather.DetermineRain(rng);
            day.weather.DetermineTemperature(rng);
            player.BuyItems();
            player.inventory.DisplayItems();
            Console.WriteLine(player.money + "$");
            player.SetRecipe();
            
            //player.DisplayQuality();
            Console.ReadKey();
        }
    }
}
