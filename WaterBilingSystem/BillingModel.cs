using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WaterBilingSystem
{
    class BillingModel: Classification
    {
        //define property
        private double amountDue { get; set; }

        //get the volume reading by passing present and previous parameters
        public double getVolumeRead(double pres, double prev) { 
            return pres - prev;
        }

        

        //get the Amount Due by passing Classification and Volume Read parameters
        public double getAmountDue(string classification, double volumeRead)
        {
            try
            {
                if (classification.ToLower() == "residential") {
                  
                    if (volumeRead <= Residential.days)
                    {
                        amountDue = Residential.price;
                    }
                    else
                    {
                        amountDue = Residential.price + (volumeRead - Residential.days) * Residential.addedPrice;
                    }
                }

                else if (classification.ToLower() == "commercial")
                {
                    if (volumeRead <= Commercial.days)
                    {
                        amountDue = Commercial.price;
                    }
                    else
                    {
                        amountDue = Commercial.price + (volumeRead - Commercial.days) * Commercial.addedPrice;
                    }
                }

                else {
                    return 0;
                }

                return amountDue;
            }
            catch (Exception)
            {
                throw;
            }   
        }

    }

    class Classification 
    {
      
    }

    class Residential : Classification 
    {
        public static double price { get; set; }
        public static int days { get; set; }
        public static int addedPrice { get; set; }
    }

    class Commercial : Classification 
    {
        public static double price { get; set; }
        public static int days { get; set; }
        public static int addedPrice { get; set; }
    }

}
