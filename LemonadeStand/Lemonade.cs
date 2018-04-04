using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemonade
    {
        private int price;
        public int quality;
        public int numberOfLemons = Player.SetLemons();
        public int numberOfSugar = Player.SetSugar();
        public int numberOfIce = Player.SetIce();

        public void AddLemonsToPitcher(int numberToAdd)
        {

        }
        

        
        public static int GetQuality(int numberOfLemons, int numberOfSugar)
        {
            int result = numberOfLemons * numberOfSugar;
            return result;
        }
    }
}
