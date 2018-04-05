using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Random rng = new Random();
        public Weather weather = new Weather();
        Lemonade lemonade = new Lemonade();
        Player player = new Player();
        public static int temperature;
        private int ThirstLevel;
        private int numberOfCustomers;
        public Day()
        {
            temperature = weather.DetermineTemperature(rng);
            ThirstLevel = Customer.GetLikelihoodToBuy(rng);
            numberOfCustomers = DetermineNumberOfCustomers();
        }

        private int DetermineNumberOfCustomers()
        {
            int result = rng.Next(80, 121);            
            return result;
        }
        public void RunDays()
        {
            weather.DetermineRain(rng);
            weather.DetermineTemperature(rng);
            DisplayWeather();
            player.BuyItems();
            player.inventory.DisplayItems();
            player.DisplayMoney();
            player.SetRecipe();
            player.GetQuality(Lemonade.numberOfLemons, Lemonade.numberOfSugar);
            //player.DisplayQuality();
            //DetermineNumberOfCustomers();

            for (int i = 0; i < numberOfCustomers; i++)
            {
                if (DeterminePurchase(Lemonade.quality, ThirstLevel, temperature, weather.IsRaining, weather.IsHumid) == true)
                {
                    player.money += Lemonade.price;
                }
            }
            player.DisplayMoney();


            //
            Console.ReadKey();
        }
        



        public void DisplayWeather()
        {
            weather.DetermineRain(rng);
            if (weather.IsRaining == true)
            {
                User_Interface.MenuMessage = "It is raining";
                User_Interface.DisplayMessage();
            }
            else
            {
                User_Interface.MenuMessage = "It's clear";
                User_Interface.DisplayMessage();
            }
            weather.DetermineHumid(rng);
            if (weather.IsHumid == true)
            {
                User_Interface.MenuMessage = "It is humid";
                User_Interface.DisplayMessage();
            }
            else
            {
                User_Interface.MenuMessage = "It's not humid";
                User_Interface.DisplayMessage();
            }
        }

        public void CreateCustomers()
        {
            
        }

        public bool DeterminePurchase(int quality, int LikelihoodToBuy, int temperature, bool isRaining, bool isHumid)
        {
            bool buying;
            int humidity = 0;
            if (weather.IsHumid == true)
            {
                humidity = 15;
            }
            int raining = 0;
            if (weather.IsRaining == true)
            {
                raining = -20;
            }
            int number = Customer.GetLikelihoodToBuy(rng) + temperature + humidity + raining + Lemonade.quality;

            if (number > 100)
            {
                buying = true;
            }
            else
            {
                buying = false;
            }
            return buying;

        }




    }
}
