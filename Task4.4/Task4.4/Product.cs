using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Product
    {
        private int id;
        private String name;
        private int price;
        private int count;

        public Product(int id,String name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public Product(int id, String name, int price, int count)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.count = count;
        }


        public void setCount(int count)
        {
            this.count = count;
        }

        public int getPrice()
        {
            return price;
        }

        public String getName()
        {
            return name;
        }

        public int getId()
        {
            return id;
        }

        public int getCount()
        {
            return count;
        }
    }
}
