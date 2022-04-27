using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTK7_Events
{
    public delegate void StockControl();
    public class Product
    {
        public event StockControl StockControlEvent;
    }
}
