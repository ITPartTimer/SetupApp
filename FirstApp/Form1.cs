using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstApp.Models;
using FirstApp.BLL;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Turn off validate event when control losses focus
            //this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;

            // Testing defaults
            txtGauge.Text = "0.055";
            txtWidth.Text = "33.906";
            txtClear.Text = "0.005";
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
           
            // Get values from form and convert when needed
            string mach = lstMach.GetItemText(lstMach.SelectedItem);
            decimal knife = decimal.Parse(lstKnives.GetItemText(lstKnives.SelectedItem));
            decimal clear = decimal.Parse(txtClear.Text);
            decimal gauge = decimal.Parse(txtGauge.Text);

            // Calc male and female.  Keep decimal @ 3 digits
            decimal mWidth = Math.Round(decimal.Parse(txtWidth.Text), 3);
            decimal fWidth = Math.Round((mWidth - (2 * clear) - (2 * knife)), 3);

            // Create a new Mult
            Mult cut = new Mult();

            cut.male = mWidth;
            cut.female = fWidth;

            // Show calculated values
            lblMale.Text = cut.male.ToString();
            lblFemaleFormula.Text = cut.male.ToString() + " - (2 x " + knife.ToString() + ") - (2 x " + clear.ToString() + ") = " + cut.female.ToString();

            List<decimal> spacers = Invtry.GetArborSpacers(mach);
            lblSpacersInv.Text = string.Join(" / ", spacers.ToArray());

            /*
             * Male Tooling Calcs
             */
            Console.WriteLine("********************** MALE **********************");

            Setup sMale = new Setup();

            List<Tooling> blMale = new List<Tooling>();

            //Calc tooling for the Male cut
            blMale = sMale.CalcSetup(cut.male, mach, "male", false);

            // Sum qty x sz for all Tooling
            decimal sumToolingMale = 0;

            for (int k = 0; k < blMale.Count; k++)
                sumToolingMale = sumToolingMale + (blMale[k].qty * blMale[k].sz);

            // Show male tooling total as proof
            if (cut.male == sumToolingMale)
            {
                lblMaleSum.Text = sumToolingMale.ToString() + " ** TRUE **";
                lblMaleSum.ForeColor = Color.Green;
            }
            else
            {
                lblMaleSum.Text = sumToolingMale.ToString() + " ** FALSE **";
                lblMaleSum.ForeColor = Color.Red;
            }
                

            // Bind male tooling to GridView
            var bindingListMale = new BindingList<Tooling>(blMale);
            var sourceMale = new BindingSource(bindingListMale, null);

            // Format DataGridView
            gvMale.AutoGenerateColumns = true;
            gvMale.AutoSize = true;
            gvMale.DataSource = sourceMale;
            gvMale.AutoResizeColumns();

            /*
            * Female Tooling Calcs
            */
            Console.WriteLine("********************** FEMALE **********************");

            Setup sFemale = new Setup();

            List<Tooling> blFemale = new List<Tooling>();

            //Calc tooling for the Female cut
            blFemale = sFemale.CalcSetup(cut.female, mach, "female", false);

            // Sum qty x sz for all Tooling
            decimal sumToolingFemale = 0;

            for (int k = 0; k < blFemale.Count; k++)
                sumToolingFemale = sumToolingFemale + (blFemale[k].qty * blFemale[k].sz);

            // Show Female tooling total as proof
            if (cut.female == sumToolingFemale)
            {
                lblFemaleSum.Text = sumToolingFemale.ToString() + " ** TRUE **";
                lblFemaleSum.ForeColor = Color.Green;
            }
            else
            {
                lblFemaleSum.Text = sumToolingFemale.ToString() + " ** FALSE **";
                lblFemaleSum.ForeColor = Color.Red;
            }

            // Bind Female tooling to GridView
            var bindingListFemale = new BindingList<Tooling>(blFemale);
            var sourceFemale = new BindingSource(bindingListFemale, null);

            gvFemale.AutoGenerateColumns = true;
            gvFemale.AutoSize = true;
            gvFemale.DataSource = sourceFemale;
            gvFemale.AutoResizeColumns();
        }

        /*
         * Control Validations
         */
        #region Validation
        private void txtWidth_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (Helpers.DecimalTest(txtWidth.Text))
            {
                // Control passed validation
                cancel = false;
            }              
            else
            {
                //This control has failed validation
                cancel = true;
                this.errorProvider1.SetError(this.txtWidth, "Enter Width with 3 decimals");
            }

            e.Cancel = cancel;
        }

        private void txtWidth_Validated(object sender, EventArgs e)
        {
            //Control has validated, clear any error message.
            this.errorProvider1.SetError(this.txtWidth, string.Empty);
        }

        private void txtGauge_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (Helpers.DecimalTest(txtGauge.Text))
            {
                // Control passed validation
                cancel = false;
            }
            else
            {
                //This control has failed validation
                cancel = true;
                this.errorProvider1.SetError(this.txtGauge, "Enter Gauge with 3 decimals");
            }

            e.Cancel = cancel;
        }

        private void txtGauge_Validated(object sender, EventArgs e)
        {
            //Control has validated, clear any error message.
            this.errorProvider1.SetError(this.txtGauge, string.Empty);
        }

        private void txtClear_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            if (Helpers.DecimalTest(txtClear.Text))
            {
                // Control passed validation
                cancel = false;
            }
            else
            {
                //This control has failed validation
                cancel = true;
                this.errorProvider1.SetError(this.txtClear, "Enter Clearance with 3 decimals");
            }

            e.Cancel = cancel;
        }

        private void txtClear_Validated(object sender, EventArgs e)
        {
            //Control has validated, clear any error message.
            this.errorProvider1.SetError(this.txtClear, string.Empty);
        }
    
        private void lstMach_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bind male tooling to GridView
            string mach = lstMach.GetItemText(lstMach.SelectedItem);

            var bindingListKnives = new BindingList<decimal>(Invtry.GetKnives(mach));
            var sourceKnives = new BindingSource(bindingListKnives, null);

            lstKnives.DataSource = sourceKnives;
        }
        # endregion
    }
}
