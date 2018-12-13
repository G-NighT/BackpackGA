using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genetic
{
    // Класс рюкзака
    class Rukzak
    {
        double vmestimost;
        List<Item> items = new List<Item>();
        public List<Population> population = new List<Population>();
        public List<Population> parent = new List<Population>();
        int countPopul;

        public Rukzak(int startPopul, double vmestimost, Random rnd, List<Item> items, int pop, int iter)
        {
            this.vmestimost = vmestimost;
            this.population.Add(new Population(startPopul, items, rnd, vmestimost));
            this.countPopul = pop;
            this.items = items;

            while (population.Count <= iter)
            {
                createChildren(rnd, countPopul, startPopul);
                if (population[population.Count - 1].getObrazec(0).price <
                    population[population.Count - 2].getObrazec(0).price)
                {
                    population.RemoveAt(population.Count - 1);
                }
            }
        }

        // Создаем потомка.
        // Выбираем 10 лучших родителей из популяции,
        // Случайно выбираем двух родителей,
        // Случайно выбираем гены и перекрещиваем их (каждый десятый ген мутирует),
        // Повторяем пока не будет достигнуто нужное количество потомков,
        // Чистим и сортируем популяцию.

        public void createChildren(Random rnd, int count, int countParent)
        {
            if (parent.Count == 0)
            {
                parent.Add(new Population(population[0]));
                population.Add(new Population(count, parent[0], rnd, items));
            }
            else
            {
                parent.Add(new Population(population[population.Count - 1], parent[parent.Count - 1], countParent));
                population.Add(new Population(count, parent[parent.Count-1], rnd, items));
            }
            if (clearPopul(population.Count - 1))
            {
                population[population.Count - 1].orderObrazec();
            }
        }

        // Удаляем в выбранной популяции особи с превосходящим весом
        // Сортируем по цене
        public bool clearPopul(int i)
        {
            int c = countPopul;
            for (int k = 0; k < c; k++)
            {
                if (population[i].getCount() < 2)
                {
                    population.RemoveAt(i);
                    return false;
                }
                if (vmestimost < population[i].getObrazec(k).weight)
                {
                    population[i].deleteObrazec(k);
                    c--;
                    k--;
                }
            }
            return true;
        }

        public string getBestObrazec()
        {
            string str = "";
            int s = population[population.Count - 1].getObrazec(0).getDnk().Count();
            for (int i = 0; i < s; i++)
            {
                str = str + population[population.Count - 1].getObrazec(0).getDnk()[i].ToString();
            }
            return str;
        }
        public string getBestWeight()
        {
            string str = (population[population.Count - 1].getObrazec(0).weight).ToString();
            return str;
        }
        public string getBestPrice()
        {
            string str = (population[population.Count - 1].getObrazec(0).price).ToString();
            return str;
        }
    }
}
