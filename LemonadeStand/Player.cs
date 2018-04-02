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
        private int money;
        public void BuyItems()
        {
            
            User_Interface.MenuMessage = "What would you like to buy? ('lemons', 'cups', 'ice', 'sugar', or 'finish' to finish)";
            User_Interface.DisplayMessage();
            switch (Console.ReadLine())
            {
                case "lemons":
                    User_Interface.MenuMessage = "How many would you like to buy?";
                    User_Interface.DisplayMessage();                    
                    inventory.AddLemons(Convert.ToInt32(Console.ReadLine()));
                    BuyItems();
                    break;
                case "cups":
                    User_Interface.MenuMessage = "How many would you like to buy?";
                    User_Interface.DisplayMessage();                    
                    inventory.AddCups(Convert.ToInt32(Console.ReadLine()));
                    BuyItems();
                    break;
                case "ice":
                    User_Interface.MenuMessage = "How many would you like to buy?";
                    User_Interface.DisplayMessage();
                    inventory.AddIce(Convert.ToInt32(Console.ReadLine()));
                    BuyItems();
                    break;
                case "sugar":
                    User_Interface.MenuMessage = "How many would you like to buy?";
                    User_Interface.DisplayMessage();
                    inventory.AddSugar(Convert.ToInt32(Console.ReadLine()));
                    BuyItems();
                    break;
                case "finish":
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    BuyItems();
                    break;


            }
        }

    }
}
