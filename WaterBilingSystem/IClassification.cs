using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterBilingSystem
{
    interface IClassification
    {
        double prev { get; set; }
        double pres { get; set; }
        double price { get; set; }
        int days { get; set; }
        int addedPrice { get; set; }
    }
}
