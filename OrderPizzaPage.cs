using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace MyFirstWiinFrameProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            UpdateOrderSummary();
        }





        private float CalculateSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);

            if (rbMeduim.Checked)
                return Convert.ToSingle(rbMeduim.Tag);

            if (rbLarg.Checked)
                return Convert.ToSingle(rbLarg.Tag);

            return 0;
        }

        private float CalculateCrustPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);

            if (rbThickCrust.Checked)
                return Convert.ToSingle(rbThickCrust.Tag);

            return 0;
        }

        private float CalculateToppingsPrice()
        {
            float price = 0;

            CheckBox[] toppings =
            {
                ChkExtracheese,
                ChkMushrooms,
                ChkTomatoes,
                ChkOnion,
                ChkOLives,
                ChkGreenPeppers
            };

            foreach (CheckBox topping in toppings)
            {
                if (topping.Checked)
                    price += Convert.ToSingle(topping.Tag);
            }

            return price;
        }



        private float CalculateTotalPrice()
        {
            return CalculateSizePrice()
                   + CalculateCrustPrice()
                   + CalculateToppingsPrice();

        }

        private void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
                lblSize.Text = "Small";

            else if (rbMeduim.Checked)
                lblSize.Text = "Medium";

            else if (rbLarg.Checked)
                lblSize.Text = "Large";


        }

        private void UpdateToppings()
        {
            UpdateTotalPrice();

            List<string> toppings = new List<string>();

            if (ChkExtracheese.Checked)
                toppings.Add("Extra Cheese");

            if (ChkMushrooms.Checked)
                toppings.Add("Mushrooms");

            if (ChkTomatoes.Checked)
                toppings.Add("Tomatoes");

            if (ChkOnion.Checked)
                toppings.Add("Onion");

            if (ChkOLives.Checked)
                toppings.Add("Olives");

            if (ChkGreenPeppers.Checked)
                toppings.Add("Green Peppers");

            if (toppings.Count == 0)
                lblToppings.Text = "No Toppings";
            else
                lblToppings.Text = string.Join(", ", toppings);
        }

        private void UpdateCrustType()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked)
                lblCrustType.Text = "Thin Crust";

            else if (rbThickCrust.Checked)
                lblCrustType.Text = "Thick Crust";


        }

        private void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
                lblWhereToEat.Text = "Eat In";

            else if (rbTakeOut.Checked)
                lblWhereToEat.Text = "Take Out";


        }

        private void UpdateTotalPrice()
        {


            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        private void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrustType();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }





        private void ResetForm()
        {

            rbSmall.Checked = true;
            rbMeduim.Checked = false;
            rbLarg.Checked = false;

            rbThinCrust.Checked = true;
            rbThickCrust.Checked = false;

            rbEatIn.Checked = true;
            rbTakeOut.Checked = false;

            ChkExtracheese.Checked = false;
            ChkMushrooms.Checked = false;
            ChkTomatoes.Checked = false;
            ChkOnion.Checked = false;
            ChkOLives.Checked = false;
            ChkGreenPeppers.Checked = false;

            gbOrderSummary.Location = new Point(601, 343);
            gbOrderSummary.Width = 195;
            gbOrderSummary.Height = 318;

            gbSize.Visible = true;
            gbToppings.Visible = true;
            gbcrustType.Visible = true;
            gbwhereToEat.Visible = true;

            btnOrderPizza.Visible = true;
            
            UpdateOrderSummary();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void ChkExtracheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkOLives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnOrderPizza_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);



                UpdateOrderSummary();

                gbSize.Visible = false;
                gbToppings.Visible = false;
                gbcrustType.Visible = false;
                gbwhereToEat.Visible = false;

                btnOrderPizza.Visible = false;
                gbOrderSummary.Location=new Point(245,140);
                gbOrderSummary.Width = 300;
                gbOrderSummary.Height = 400;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

       
    }
}

