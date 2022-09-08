using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class Latte : Coffee
    {
        public Latte(int price) : base(price)
        {

        }

        public override int Price { get => base.Price; set => base.Price = 40; }
        public override string Strength()
        {
            return "Weak";
        }
    }
}
