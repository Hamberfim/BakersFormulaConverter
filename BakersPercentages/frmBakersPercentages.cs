/***************************************************************
* Name        : frmBakersPercentages
* Author      : Anthony Hamlin
* Created     : 03/13/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : 2021 MIT
*               specifications or project scope
* Description : This program take in user input
*               Flour weight along with a bread formula of water salt is the minimum input
*               The application converts the formula percentage values of the additional ingredients 
*               to grams bases on the flour weight       
***************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakersPercentages
{
    public partial class frmBakersPercentages : Form
    {
        public frmBakersPercentages()
        {
            InitializeComponent();

            // Zero all fields
            txtFlourInputBase.Text = "0";
            txtEnterWaterPercent.Text = "0";
            txtEnterSaltPercent.Text = "0";
            txtEnterYeastPercent.Text = "0";
            txtEnterStarterPercent.Text = "0";
            txtEnterFatOilPercent.Text = "0";

            txtWaterResultsQuantity.Text = "0";
            txtSaltResultsQuantity.Text = "0";
            txtYeastResultsQuantity.Text = "0";
            txtStarterResultsQuantity.Text = "0";
            txtFatOilResultsQuantity.Text = "0";

            rdoNapolitanoRecipe.Checked = false;
            rdoPainaLAncienne.Checked = false;
            rdoSourdoughBaguettes.Checked = false;
            rdoCiabatta.Checked = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFlourBase_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void frmBakersPercentages_Load(object sender, EventArgs e)
        {

        }

        private void txtEnterWater_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // get base flour weight for calculations
                decimal FlourInputBase = Convert.ToDecimal(txtFlourInputBase.Text);

                //====== Water Calculations ======
                // get water precent
                decimal waterAsDecimal = Convert.ToDecimal(txtEnterWaterPercent.Text);
                // calculate water percent as a decimal
                waterAsDecimal = waterAsDecimal / 100;
                // calculate water decimal to grams based on flour weight
                decimal WaterResultsQuantity = waterAsDecimal * FlourInputBase;
                // set water result text box
                txtWaterResultsQuantity.Text = WaterResultsQuantity.ToString("f2");

                //====== Salt calculations ======
                //get salt percent
                decimal saltAsDecimal = Convert.ToDecimal(txtEnterSaltPercent.Text);
                // calculate salt percent as decimal
                saltAsDecimal = saltAsDecimal / 100;
                // calculate salt decimal to grams based on flour weight
                decimal saltResultQuantity = saltAsDecimal * FlourInputBase;
                // set salt result text box
                txtSaltResultsQuantity.Text = saltResultQuantity.ToString("f2");

                //====== Yeast calculations ======
                // get yeast percent
                decimal yeastAsDecimal = Convert.ToDecimal(txtEnterYeastPercent.Text);
                // calculate yeast percent as decimal
                yeastAsDecimal = yeastAsDecimal / 100;
                // calculate yeast decimal to grams based on flour weight
                decimal YeastResultsQuantity = yeastAsDecimal * FlourInputBase;
                // set yest result text box
                txtYeastResultsQuantity.Text = YeastResultsQuantity.ToString("f2");

                //====== Starter calculations ======
                // get starter percent
                decimal starterAsDecimal = Convert.ToDecimal(txtEnterStarterPercent.Text);
                // calculate starter percent as decimal
                starterAsDecimal = starterAsDecimal / 100;
                // calculate starter decimal to grams based on flour weight
                decimal StarterResultsQuantity = starterAsDecimal * FlourInputBase;
                // set starter result text box
                txtStarterResultsQuantity.Text = StarterResultsQuantity.ToString("f2");

                //====== Fat/oil calculations ======
                // get Fat/oil percent
                decimal fatAsDecimal = Convert.ToDecimal(txtEnterFatOilPercent.Text);
                // calculate Fat/oil percent as decimal
                fatAsDecimal = fatAsDecimal / 100;
                // calculate Fat/oil decimal to grams based on flour weight
                decimal FatOilResultsQuantity = fatAsDecimal * FlourInputBase;
                // set Fat/oil result text box
                txtFatOilResultsQuantity.Text = FatOilResultsQuantity.ToString("f2");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message + " !!! Input must a be a number !!!");  // console output
                // Pop-up app error message
                string title = "Exception Error";
                string message = "Input must a be a Number!";
                MessageBox.Show(error.Message + " " + message, title);
            }

            txtFlourInputBase.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFlourInputBase.Text = "0";
            txtEnterWaterPercent.Text = "0";
            txtEnterSaltPercent.Text = "0";
            txtEnterYeastPercent.Text = "0";
            txtEnterStarterPercent.Text = "0";
            txtEnterFatOilPercent.Text = "0";

            txtWaterResultsQuantity.Text = "0";
            txtSaltResultsQuantity.Text = "0";
            txtYeastResultsQuantity.Text = "0";
            txtStarterResultsQuantity.Text = "0";
            txtFatOilResultsQuantity.Text = "0";

            rdoNapolitanoRecipe.Checked = false;
            rdoPainaLAncienne.Checked = false;
            rdoSourdoughBaguettes.Checked = false;
            rdoCiabatta.Checked = false;

            txtFlourInputBase.Focus();
        }

        // populate converter with a selected dough formula
        private void btnSelectFormula_Click(object sender, EventArgs e)
        {
            if (rdoNapolitanoRecipe.Checked)
            {
                // Napolitano pizza dough
                txtEnterWaterPercent.Text = "69.1";
                txtEnterSaltPercent.Text = "2.2";
                txtEnterYeastPercent.Text = "0.54";
            }

            if (rdoPainaLAncienne.Checked)
            {
                txtEnterWaterPercent.Text = "79.6";
                txtEnterSaltPercent.Text = "2.0";
                txtEnterYeastPercent.Text = "0.7";
            }

            if(rdoSourdoughBaguettes.Checked)
            {
                txtEnterWaterPercent.Text = "73.0";
                txtEnterSaltPercent.Text = "2.0";
                txtEnterYeastPercent.Text = "2.0";
                txtEnterStarterPercent.Text = "3.33";
            }

            if(rdoCiabatta.Checked)
            {
                txtEnterWaterPercent.Text = "76.0";
                txtEnterSaltPercent.Text = "2.0";
                txtEnterYeastPercent.Text = "1.2";
            }

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "Baker's Percent - Formula Converter";
            string message1 = "Convert baker's percent formulas into gram based recipes.";
            string message2 = "Created By adhamlin, inspired by Tok.";
            string message3 = "Copyright © 2021 adhamlin";
            MessageBox.Show(message1 + "\n" + message2 + "\n" + message3, title);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
