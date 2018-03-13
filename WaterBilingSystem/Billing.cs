using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WaterBilingSystem
{
    class Billing
    {
        //define property
        private double amountDue { get; set; }

        //get the volume reading by passing present and previous parameters
        public double getVolumeRead(IClassification _class)
        {
            return _class.pres - _class.prev;
        }

        //get the Amount Due by passing Volume Read parameters
        public double getAmountDue(double volumeRead, IClassification _class)
        {
            try
            {
                if (volumeRead <= _class.days)
                    {
                        amountDue = _class.price;
                    }
                    else
                    {
                        amountDue = _class.price + (volumeRead - _class.days) * _class.addedPrice;
                    }
             
                return amountDue;
            }
            catch (Exception)
            {
                throw;
            }   
        }

    }

}
