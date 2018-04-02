using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
        static class User_Interface
    {
        public static string MenuMessage;
        //public static string UserInput;
        public static void DisplayMessage()
        {
            Console.WriteLine(MenuMessage);
        }
        public static void GetUserInput()
        {
            Console.ReadLine();
        }
    }
}
