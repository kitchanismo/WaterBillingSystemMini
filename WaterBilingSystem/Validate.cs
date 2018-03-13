using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaterBilingSystem
{
    class Validate
    {

        public bool isPrevReadingValid(double pres, double prev)
        {

            if (pres < prev)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool isEmpty(string pres, string prev)
        {

            if (pres == "" || prev == "")
            {
                return false;
            }
            else if (Double.Parse(pres) == 0) 
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public void NumbersSinglePointOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            TextBox txtDecimal = sender as TextBox;

            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }

        }

    }
}
