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
    public partial class Settings : Form
    {

        Validate validate = new Validate();

        public Settings()
        {
            InitializeComponent();

            InitializeClassificationData();

            this.tbRdays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tb_Keypress);
            this.tbRadded.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tb_Keypress);
            this.tbRprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tb_Keypress);

            this.tbCdays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tb_Keypress);
            this.tbCadded.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tb_Keypress);
            this.tbCprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(tb_Keypress);
        }

        //Save temp
        public void SaveClassification()
        {

            Residential.days = Int32.Parse(tbRdays.Text);
            Residential.addedPrice = Int32.Parse(tbRadded.Text);
            Residential.price = Int32.Parse(tbRprice.Text);

            Commercial.days = Int32.Parse(tbCdays.Text);
            Commercial.addedPrice = Int32.Parse(tbCadded.Text);
            Commercial.price = Int32.Parse(tbCprice.Text);
        }


        //accepts numbers and single point only
        private void tb_Keypress(object sender, KeyPressEventArgs e)
        {
            validate.NumbersSinglePointOnly(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveClassification();
            MessageBox.Show("Saved");
        }

        private void Classification_Load(object sender, EventArgs e)
        {

        }

        //initialize classifications. Residential and Commercial
        public void InitializeClassificationData()
        {
            tbRdays.Text = "12";
            tbRadded.Text = "30";
            tbRprice.Text = "180";

            tbCdays.Text = "30";
            tbCadded.Text = "50";
            tbCprice.Text = "600";
        }

    }
}
