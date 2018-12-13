using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genetic
{
    // Класс популяции
    class Population
    {
        List<Obrazec> popul = new List<Obrazec>();

        // Начальная популяция
        public Population(int count, List<Item> items, Random rnd, double w)
        {
            Obrazec sp;
            while (this.popul.Count<count)
            {
                sp = new Obrazec(items, rnd);
                if (sp.weight < w)
                {
                    this.popul.Add(sp);
                }
            }
        }

        // Потомки
        public Population(int count, Population parent, Random rnd, List<Item> items)
        {
            for (double i = 0; i < count; i++)
            {
                int k = rnd.Next(0, parent.popul.Count);
                Obrazec firstParent = parent.popul[k];

                int kk = rnd.Next(0, parent.popul.Count);
                while (k == kk) // kk должно быть отличным от k
                {
                    kk = rnd.Next(0, parent.popul.Count);
                }
                Obrazec secondParent = parent.popul[kk];

                //private void StartMutation()
                //{
                //    for (var i1 = 0; i1 < Math.Round((double)individCount / 10); i1++)
                //    {
                //        var individSelector = random.Next(0, individCount * 2);

                //        individ[individSelector].Mutation();
                //    }
                //}

                //if (i / 10.0 == (int)i / 10) // Мутировать (p) будут только 10%
                if (i < Math.Round((double)i / 10))
                {
                    //for (int i__1 = 0; i__1 < Math.Round((double)items.Count / 10); i__1++)
                    //{
                    //    random_obrazec = rnd__random.Next(0, items.Count * 2); // Выбрать случайное число 

                    //    l__individual[random_obrazec].mutation(); // Вызвать у особи мутацию
                    //}

                    int random_obrazec = rnd.Next(0, items.Count); // Выбрать случайное число 

                    //List<Obrazec> popull = new List<Obrazec>();
                    //foreach (Obrazec ob in popul)
                    //{
                    //    popull.Add(ob);
                    //}
                    //popull = popull.OrderBy(s => s.price).ToList();
                    //popull.Reverse();
                    //int u = popull.Count - 1;

                    k = rnd.Next(0, items.Count);
                    this.popul.Add(new Obrazec(firstParent, secondParent, k, items, random_obrazec)); // Создать особь-мутант
                }
                else
                {
                    k = rnd.Next(0, items.Count);
                    this.popul.Add(new Obrazec(firstParent, secondParent, k, items));
                }
            }
        }

        // Родительская
        public Population(Population pop)
        {
            for (int i = 0; i < pop.popul.Count; i++)
            {
                this.popul.Add(pop.popul[i]);
            }
        }

        public Population(Population pop, Population parent, int countParent)
        {
            for (int i = 0; i < countParent-2; i++)
            {
                if (i < pop.popul.Count)
                {
                    this.popul.Add(pop.popul[i]);
                }
            }

            int k = 0;
            while (this.popul.Count < countParent)
            {
                this.popul.Add(parent.popul[k]);
                k++;
            }
        }

        public Obrazec getObrazec(int k)
        {
            return this.popul[k];
        }

        public void deleteObrazec(int k)
        {
            popul.RemoveAt(k);
        }

        public void orderObrazec()
        {
            this.popul = popul.OrderBy(s => s.price).ToList();
            this.popul.Reverse();
        }

        public int getCount()
        {
            return this.popul.Count();
        }
    }
}
