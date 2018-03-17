using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaterBilingSystem
{
    public partial class Main : Form
    {

        //instantiate classes
        Billing bill = new Billing();
        Validate validate = new Validate();
       
        public Main()
        {
            InitializeComponent();
          
            //initialize keypress
            this.tbPrev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tb_Keypress);
            this.tbPres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tb_Keypress);
        }

     
        //accepts numbers and single point only
        private void tb_Keypress(object sender, KeyPressEventArgs e)
        {
            validate.NumbersSinglePointOnly(sender, e);
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            //simple return if not valid
            if (!IsUserInputValid()) 
            {
                return;
            }

            //get data what to pass in classification
            var dataClass = SetClass(cboClass.Text.ToLower());

            //get the volume reading and amount due
            var volumeRead = bill.getVolumeRead(dataClass.prev, dataClass.pres);
            var amountDue = bill.getAmountDue(volumeRead, dataClass);

            //displaying outputs
            lbvRead.Text = volumeRead.ToString();
            lbAmount.Text = "Php. " + amountDue.ToString("#,##0.00");
        }

        //reset outputs
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbvRead.Text = "0";
            lbAmount.Text = "Php. 0.00";
        }

        //set data to an object base on classification
        private Classification SetClass(string classStr)
        {

            switch (classStr)
            {
                case "residential":
                    Residential res = new Residential();
                    res.prev = Double.Parse(tbPrev.Text);
                    res.pres = Double.Parse(tbPres.Text);
                    res.days = Int32.Parse(tbRdays.Text);
                    res.addedPrice = Int32.Parse(tbRadded.Text);
                    res.price = Int32.Parse(tbRprice.Text);
                    return res;
                case "commercial":
                    Commercial com = new Commercial();
                    com.prev = Double.Parse(tbPrev.Text);
                    com.pres = Double.Parse(tbPres.Text);
                    com.days = Int32.Parse(tbCdays.Text);
                    com.addedPrice = Int32.Parse(tbCadded.Text);
                    com.price = Int32.Parse(tbCprice.Text);
                    return com;
                default:
                    MessageBox.Show(classStr + " Not implemeted yet");
                    return new Classification();
            }
          
        }

        //return true if user input is valid else false
        private bool IsUserInputValid() 
        {
            Validate validate = new Validate();

            //initialize previous and present reading
            var presRead = Double.Parse(tbPres.Text);
            var prevRead = Double.Parse(tbPrev.Text);

            if (!validate.isEmpty(tbPres.Text, tbPrev.Text))
            {
                MessageBox.Show("Missing input/s");
                return false;
            }
            else if (!validate.isPrevReadingValid(presRead, prevRead))
            {
                MessageBox.Show("Present Reading is less than Previous Reading");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
