using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_25
{
    internal class Electronic : Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Electronic(string name,double price,int quantity)
        {
            Name= name;
            Price= price;
            Quantity= quantity;
        }
       public  double GetPrice()
        {
            return Price;
        }

       public double ReduceStock(int reduce)
        {
            return Quantity - reduce;
        }
    }
}
