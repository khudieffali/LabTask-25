using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_25
{
    internal class Book : Product
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Book (string name,string author, double price, int quantity)
        {
            Name = name;
            Author = author;
            Price = price;
            Quantity = quantity;
        }
        public double GetPrice()
        {
          return Price;
        }

        public double ReduceStock(int reduce)
        {

            return Quantity-reduce;
        }
    }
}
