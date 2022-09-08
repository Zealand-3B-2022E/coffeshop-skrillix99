using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public virtual int Price { get; set; }

        public abstract string Strength();

        public Coffee(int Price)
        {
            Price = 20;
        }

    }
}
