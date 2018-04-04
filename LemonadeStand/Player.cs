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
                    BuyItems();
                    break;
                case "cups":
                    User_Interface.MenuMessage = "How many would you like to buy? 4 cents each.";
                    User_Interface.DisplayMessage();                    
                    inventory.AddCups(Convert.ToInt32(Console.ReadLine()));
                    money -= (Cup.price * inventory.numberOfCups.Count);
                    BuyItems();
                    break;
                case "ice":
                    User_Interface.MenuMessage = "How many would you like to buy? 1 cent each.";
                    User_Interface.DisplayMessage();
                    inventory.AddIce(Convert.ToInt32(Console.ReadLine()));
                    money -= (Ice.price * inventory.numberOfIceCubes.Count);
                    BuyItems();
                    break;
                case "sugar":
                    User_Interface.MenuMessage = "How many would you like to buy? 10 cents each.";
                    User_Interface.DisplayMessage();
                    inventory.AddSugar(Convert.ToInt32(Console.ReadLine()));
                    money -= (Sugar.price * inventory.numberOfSugar.Count);
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
            SetLemons();
            SetIce();
            SetSugar();
        }
        //Lemonade lemonade = new Lemonade();
        //public void DisplayQuality()
        //{
        //    Console.WriteLine(lemonade.quality);
        //}

        public static int SetLemons()
        {
            User_Interface.MenuMessage = "How many lemons in a pitcher?";
            User_Interface.DisplayMessage();
            return Convert.ToInt32(Console.ReadLine());

        }

        public static int SetSugar()
        {
            User_Interface.MenuMessage = "How many cups of sugar in a pitcher?";
            User_Interface.DisplayMessage();
            return Convert.ToInt32(Console.ReadLine());

        }
        public static int SetIce()
        {
            User_Interface.MenuMessage = "How many ice cubes in a cup?";
            User_Interface.DisplayMessage();
            return Convert.ToInt32(Console.ReadLine());

        }



    }
}
