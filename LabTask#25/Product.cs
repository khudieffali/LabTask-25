using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_25
{
    internal interface Product
    {
        public double GetPrice();
        public double ReduceStock(int reduce);

    }
}
