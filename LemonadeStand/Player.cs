using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public Inventory inventory = new Inventory();
        public double money = 20.00;




        public void BuyItems()
        {
            
            User_Interface.MenuMessage = "What would you like to buy? ('lemons', 'cups', 'ice', 'sugar', or 'finish' to finish)";
            User_Interface.DisplayMessage();
            switch (Console.ReadLine())
            {
                case "lemons":
                    User_Interface.MenuMessage = "How many would you like to buy? 15 cents each.";
                    User_Interface.DisplayMessage();                    
                    inventory.AddLemons(Convert.ToInt32(Console.ReadLine()));
                    money -= (Lemon.price * inventory.numberOfLemons.Count);
                    DisplayMoney();
                    BuyItems();
                    break;
                case "cups":
                    User_Interface.MenuMessage = "How many would you like to buy? 4 cents each.";
                    User_Interface.DisplayMessage();                    
                    inventory.AddCups(Convert.ToInt32(Console.ReadLine()));
                    money -= (Cup.price * inventory.numberOfCups.Count);
                    DisplayMoney();
                    BuyItems();
                    break;
                case "ice":
                    User_Interface.MenuMessage = "How many would you like to buy? 1 cent each.";
                    User_Interface.DisplayMessage();
                    inventory.AddIce(Convert.ToInt32(Console.ReadLine()));
                    money -= (Ice.price * inventory.numberOfIceCubes.Count);
                    DisplayMoney();
                    BuyItems();
                    break;
                case "sugar":
                    User_Interface.MenuMessage = "How many would you like to buy? 10 cents each.";
                    User_Interface.DisplayMessage();
                    inventory.AddSugar(Convert.ToInt32(Console.ReadLine()));
                    money -= (Sugar.price * inventory.numberOfSugar.Count);
                    DisplayMoney();
                    BuyItems();
                    break;
                case "finish":
                    break;
                //case "removesugar":
                //    inventory.RemoveSugar(Convert.ToInt32(Console.ReadLine()));
                //    break;
                default:
                    Console.WriteLine("Invalid Input");
                    BuyItems();
                    break;
            }


        }
        
        public void SetRecipe()
        {
            Lemonade.numberOfLemons = SetLemons();
            Lemonade.numberOfSugar = SetIce();
            Lemonade.numberOfIce = SetSugar();
            Lemonade.price = SetPricePerCup();
        }
        //Lemonade lemonade = new Lemonade();
        public void DisplayQuality()
        {
            Console.WriteLine(Lemonade.quality);
        }

        public static int SetLemons()
        {
            try
            {
                User_Interface.MenuMessage = "How many lemons in a pitcher?";
                User_Interface.DisplayMessage();
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                User_Interface.MenuMessage = "Invalid input.";
                User_Interface.DisplayMessage();
                
                SetLemons();
                return 0;
            }
        }

        public static int SetSugar()
        {
            try
            {
                User_Interface.MenuMessage = "How many cups of sugar in a pitcher?";
                User_Interface.DisplayMessage();
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                User_Interface.MenuMessage = "Invalid input.";
                User_Interface.DisplayMessage();

                SetSugar();
                return 0;

            }
        }
        public static int SetIce()
        {
            try
            {
                User_Interface.MenuMessage = "How many ice cubes in a cup?";
                User_Interface.DisplayMessage();
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                User_Interface.MenuMessage = "Invalid input.";
                User_Interface.DisplayMessage();

                SetIce();
                return 0;

            }
        }
        public void DisplayMoney()
        {
            Console.WriteLine("You have $" + Math.Round(money,2));
        }
        public static double SetPricePerCup()
        {
            User_Interface.MenuMessage = "In cents, how much per cup will you charge?";
            User_Interface.DisplayMessage();
            return Convert.ToDouble(Console.ReadLine())/100;
        }

        public int GetQuality(int numberOfLemons, int numberOfSugar)
        {
            Lemonade.quality = Lemonade.numberOfLemons * Lemonade.numberOfSugar;
            return Lemonade.quality;
        }
    }
}
