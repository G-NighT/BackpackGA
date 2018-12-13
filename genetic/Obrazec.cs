using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genetic
{
    // Класс образчика
    class Obrazec
    {
        int[] dnk;
        public double price;
        public double weight;

        public Obrazec(List<Item> items, Random rnd)
        {
            dnk = new int[items.Count];
            for (int i = 0; i < items.Count; i++)
            {
                dnk[i] = rnd.Next(2);
            }
            mathPrice(items);
            mathWeight(items);
        }

        public Obrazec(Obrazec a, Obrazec b, int rnd, List<Item> items)
        {
            dnk = new int[a.getDnk().Count()];
            for (int i = 0; i < rnd; i++)
            {
                dnk[i] = a.getDnk()[i];
            }
            for (int i = rnd; i < dnk.Count(); i++)
            {
                dnk[i] = b.getDnk()[i];
            }
            mathPrice(items);
            mathWeight(items);
        }

        public Obrazec(Obrazec a, Obrazec b, int k, List<Item> items, int p)
        {
            dnk = new int[a.getDnk().Count()];
            for (int i = 0; i < k; i++)
            {
                dnk[i] = a.getDnk()[i];
            }
            for (int i = k; i < dnk.Count(); i++)
            {
                dnk[i] = b.getDnk()[i];
            }
            mathPrice(items);
            mathWeight(items);
            mutagen(p);
        }

        public int[] getDnk()
        {
            return this.dnk;
        }

        private void mathPrice(List<Item> items)
        {
            this.price = 0;
            for (int i = 0; i<dnk.Count(); i++)
            {
                if (dnk[i] == 1)
                {
                    price += items[i].getCost();
                }
            }
        }

        private void mathWeight(List<Item> items)
        {
            this.weight = 0;
            for (int i = 0; i < dnk.Count(); i++)
            {
                if (dnk[i] == 1)
                {
                    weight += items[i].getWeight();
                }
            }
        }

        public void mutagen(int k)
        {
            if (this.dnk[k] == 0)
            {
                this.dnk[k] = 1;
            }
            else this.dnk[k] = 0;
        }

    }
}
