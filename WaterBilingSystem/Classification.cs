using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterBilingSystem
{
    class Classification : IClassification
    {
        public double prev { get; set; }
        public double pres { get; set; }
        public double price { get; set; }
        public int days { get; set; }
        public int addedPrice { get; set; }
    }

    class Residential : Classification
    {
    
    }

    class Commercial : Classification
    {
      
    }
}
