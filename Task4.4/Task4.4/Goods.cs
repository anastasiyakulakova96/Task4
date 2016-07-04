using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Goods
    {
        public List<Product> goods;

        public List<Product> ListOfGoods()
        {
            goods = new List<Product>();
            goods.Add(new Product(1, "Phone", 100, 0));
            goods.Add(new Product(2, "Notebook", 200, 0));
            goods.Add(new Product(3, "TV", 150, 0));

            return goods;
        }

        public void ShowGoodsAndPrice()
        {
            for (int i = 0; i < goods.Count; i++)
            {
                Console.WriteLine("ID:" + goods[i].getId() + " name:" + goods[i].getName() + " price:" + goods[i].getPrice());
            }
            Console.WriteLine();
        }

    }
}
