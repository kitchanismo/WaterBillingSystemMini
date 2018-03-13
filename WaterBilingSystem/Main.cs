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
        BillingModel billing = new BillingModel();
        Validate validate = new Validate();
        Settings set = new Settings();

        public Main()
        {
            InitializeComponent();
            set.SaveClassification();

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
            //validate if user input empty
            if (!validate.isUserInputValid(tbPres.Text, tbPrev.Text))
            {
                MessageBox.Show("Missing input/s");
                return;
            }
            
            //initialize previous and present reading
            var presRead = Double.Parse(tbPres.Text);
            var prevRead = Double.Parse(tbPrev.Text);

            //validate reading
            if (!validate.isPrevReadingValid(presRead, prevRead))
            {
                MessageBox.Show("Present Reading is less than Previous Reading");
                return;
            }

            //get the volume reading and amount due
            var volumeRead = billing.getVolumeRead(presRead, prevRead);
            var amountDue = billing.getAmountDue(cboClass.Text, volumeRead);

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


        private void button1_Click(object sender, EventArgs e)
        {
         
            set.ShowDialog();
        }

    }
}
