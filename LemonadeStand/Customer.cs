using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {

        private int ThirstLevel;
        private int LikelihoodToBuy;
        private int GetLikelihoodToBuy(Random rng)
        {
            int result = rng.Next(1, 101);
            return result;
        }
    }
}
