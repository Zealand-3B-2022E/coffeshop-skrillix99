using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class Cortado : Coffee
    {
        public Cortado(int Price) : base(Price)
        {
            Price = 25;
        }
        public override string Strength()
        {
            return "Medium";
        }

    }
}
