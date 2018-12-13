using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genetic
{
    // Одна вещь
    class Item
    {
        // Вес
        double weight;
        // Цена
        double cost;

        public Item(double w, double c)
        {
            this.weight = w;
            this.cost = c;
        }

        public double getWeight() { return this.weight; }

        public double getCost() { return this.cost; }
    }
}
