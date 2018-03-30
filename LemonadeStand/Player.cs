using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        Inventory inventory = new Inventory();
        private int money;
        private void BuyItem()
        {
            User_Interface.MenuMessage = "What would you like to buy?";
            User_Interface.DisplayMessage();
            switch (Console.ReadLine())
            {
                case "lemons":
                    
                    break;

            }
        }

    }
}
