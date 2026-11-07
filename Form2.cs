using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Lucky_Cafe_Order
{
    public partial class Form2 : Form
    {
        Random random = new Random();
        int CustomerCount = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            string customername = txtCustomerName.Text;
            if (customername == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter a valid quantity");
                return;
            }

            double price = 0;
            string drink = "";

            if (rdoTea.Checked)
            {
                price = 1;
                drink = "Tea";
            }
            else if (rdoCoffee.Checked)
            {
                price = 2;
                drink = "Coffee";
            }
            else if (rdoJuice.Checked)
            {
                price = 3;
                drink = "Juice";
            }
            else
            {
                MessageBox.Show("Please select a drink ");
                return;
            }
            double total = price * quantity;
            double discount = 0;

            if (chkStudent.Checked)
            {
                discount = total * 0.10;
            }
            double finaltotal = total - discount;
            bool gotPrize = false;

            CustomerCount++;
            lstOrder.Items.Add("===Order" + CustomerCount + "===");
            lstOrder.Items.Add(CustomerCount + ")" + customername + "_" + drink);
            lstOrder.Items.Add("Customer Name:" + customername);
            lstOrder.Items.Add("Drink:" + drink + "($" + price.ToString("0.00") + ")");
            lstOrder.Items.Add("Quantity:" + quantity);

            if (chkStudent.Checked)
            {
                lstOrder.Items.Add("member Discount:10%");
            }
            else
            {
                lstOrder.Items.Add("member Discount: No");
            }
            lstOrder.Items.Add("Total Before Discount: $" + total.ToString("0.00"));

            lstOrder.Items.Add("Total Discount: $" + discount.ToString("0.00"));

            lstOrder.Items.Add("Final Total: $" + finaltotal.ToString("0.00"));

            lstOrder.Items.Add("Lucky Numbers:");

            for (int i = 1; i <= quantity; i++)
            {
                int luckynumber = random.Next(1, 51);

                lstOrder.Items.Add(i + ") Lucky Number: " + luckynumber);

                if (luckynumber == 7 || luckynumber == 17)
                {
                    gotPrize = true;
                }
            }

            if (gotPrize)
            {
                lstOrder.Items.Add("Lucky Message: You got a Free Cookie!");
            }
            else
            {
                lstOrder.Items.Add("Lucky Message: No prize this time.");
            }

            lstOrder.Items.Add("--------------------------------");

            lblTotalPrice.Text = "Total Price: $" + finaltotal.ToString("0.00");

            if (gotPrize)
            {
                lblResult.Text = "You got a Free Cookie!";
            }
            else
            {
                lblResult.Text = "No prize this time.";
            }

            MessageBox.Show("Order added successfully!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstOrder.Items.Count == 0)
                {
                    MessageBox.Show("No orders to save.");
                    return;
                }

                using (StreamWriter writer = File.AppendText("orders.txt,false"))
                {
                    for (int i = 0; i < lstOrder.Items.Count; i++)
                    {
                        writer.WriteLine(lstOrder.Items[i].ToString());
                    }
                }

                MessageBox.Show("Order saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("orders.txt"))
                {
                    MessageBox.Show("No saved file found.");
                    return;
                }

                lstOrder.Items.Clear();
                CustomerCount = 0;

                using (StreamReader reader = File.OpenText("orders.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        lstOrder.Items.Add(line);
                        if (line.StartsWith("===Order"))
                        {
                            CustomerCount++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtQuantity.Clear();

            lstOrder.Items.Clear();

            lblTotalPrice.Text = "TotalPrice:$0.00";
            lblResult.Text = "Lucky Message";

            chkStudent.Checked = false;

            rdoCoffee.Checked = false;
            rdoJuice.Checked = false;
            rdoTea.Checked = false;

            txtCustomerName.Focus();
        }
    }
}