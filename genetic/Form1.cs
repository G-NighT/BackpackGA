using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genetic
{
    public partial class Form1 : Form
    {
        Random rnd;
        List<Item> items;
        Rukzak _rukzak;

        public Form1()
        {
            InitializeComponent();
            items = new List<Item>();
            this.fill();
            showList();
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart2.Series[0].Points.Clear();

            listViewItems.Clear();
            rnd = new Random();
            showList();
            _rukzak = new Rukzak(Decimal.ToInt32(nudParent.Value),Decimal.ToDouble(nudWeight.Value),rnd,items,Decimal.ToInt32(nudChild.Value), Decimal.ToInt32(nudP.Value));
            plot();
            label_best.Text = _rukzak.getBestObrazec();
            label_cennost.Text = _rukzak.getBestPrice();
            label_ves.Text = _rukzak.getBestWeight();

            char[] CH = label_best.Text.ToCharArray();
            int li = 0;
            foreach (char ch_ in CH)
            {
                if (ch_ == '1')
                {
                    listViewItems.Items[li].BackColor = Color.PaleGreen;
                }
                li++;
            }
        }

        public void plot()
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            for (int i = 0; i < Decimal.ToInt32(nudP.Value); i++)
            {
                for (int j = 0; j < _rukzak.population[i].getCount(); j++)
                {
                    chart1.Series[2].Points.AddXY(i, _rukzak.population[i].getObrazec(j).price);
                }

                for (int j = 0; j < _rukzak.parent[i].getCount(); j++)
                {
                    chart1.Series[1].Points.AddXY(i, _rukzak.parent[i].getObrazec(j).price);
                }

                if (i > 0)
                {
                    chart1.Series[0].Points.AddXY(i, _rukzak.population[i].getObrazec(0).price);
                    chart2.Series[0].Points.AddXY(i, _rukzak.population[i].getObrazec(0).weight);
                }
            }
        }

        public void fill()
        {
            items.Add(new Item(7,777));
            items.Add(new Item(4,444));
            items.Add(new Item(12,64));
            items.Add(new Item(3,703));
            items.Add(new Item(11,648));
            items.Add(new Item(7,326));
        }

        public void showList()
        {
            listViewItems.Clear();
            listViewItems.Columns.Add("Вес");
            listViewItems.Columns.Add("Цена");

            for (int i = 0; i < items.Count; i++)
            {
                ListViewItem item1 = new ListViewItem(new[] {items[i].getWeight().ToString(),items[i].getCost().ToString()});
                listViewItems.Items.Add(item1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            items.Add(new Item(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)));
            showList();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart2.Series[0].Points.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            items.Add(new Item(rnd.Next(1,20), rnd.Next(20,1000)));
            showList();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart2.Series[0].Points.Clear();
        }
    }
}
