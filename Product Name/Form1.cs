using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Name
{
    public partial class Form1 : Form
    {
        private bool updatingValues;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbcategory.Items.Clear();
            cmbcategory.Items.AddRange(new object[]
            {
                "Electronics",
                "Food",
                "Clothing",
                "Household",
                "Other"
            });

            cmbcategory.SelectedIndex = -1;
            checkbox.Checked = true;
            txtBarcode.Select();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblbarcode_Click(object sender, EventArgs e)
        {

        }

        private void lbldescrip_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblOrigin_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblCost_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblMarkup_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string validationMessage = ValidateForm();
            if (validationMessage != null)
            {
                MessageBox.Show(validationMessage, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("The product was saved successfully.", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescript_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            txtBarcode.Text = txtBarcode.Text.Trim();
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtcost_TextChanged(object sender, EventArgs e)
        {
            UpdatePriceFromCostAndMarkup();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            UpdateMarkupFromCostAndPrice();
        }

        private void txtmarkup_TextChanged(object sender, EventArgs e)
        {
            UpdatePriceFromCostAndMarkup();
        }

        private void ClearForm()
        {
            updatingValues = true;
            try
            {
                txtBarcode.Clear();
                txtName.Clear();
                txtDescript.Clear();
                cmbcategory.SelectedIndex = -1;
                rdlocal.Checked = false;
                rdabroad.Checked = false;
                checkbox.Checked = true;
                txtcost.Clear();
                txtprice.Clear();
                txtmarkup.Clear();
            }
            finally
            {
                updatingValues = false;
            }

            txtBarcode.Select();
        }

        private string ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
                return "Enter a barcode.";

            if (!txtBarcode.Text.All(char.IsDigit))
                return "Barcode must contain digits only.";

            if (string.IsNullOrWhiteSpace(txtName.Text))
                return "Enter a product name.";

            if (string.IsNullOrWhiteSpace(txtDescript.Text))
                return "Enter a product description.";

            if (cmbcategory.SelectedIndex < 0)
                return "Select a product category.";

            if (!rdlocal.Checked && !rdabroad.Checked)
                return "Select whether the product is manufactured locally or abroad.";

            decimal cost;
            decimal price;
            decimal markup;
            if (!TryGetDecimal(txtcost.Text, out cost) || cost <= 0)
                return "Enter a cost greater than zero.";

            if (!TryGetDecimal(txtprice.Text, out price) || price <= 0)
                return "Enter a price greater than zero.";

            if (!TryGetDecimal(txtmarkup.Text, out markup) || markup < 0)
                return "Enter a markup of zero or greater.";

            if (price < cost)
                return "Price cannot be less than cost.";

            return null;
        }

        private void UpdatePriceFromCostAndMarkup()
        {
            if (updatingValues)
                return;

            decimal cost;
            decimal markup;
            if (!TryGetDecimal(txtcost.Text, out cost) || !TryGetDecimal(txtmarkup.Text, out markup))
                return;

            updatingValues = true;
            try
            {
                txtprice.Text = (cost * (1 + markup / 100m)).ToString("0.00", CultureInfo.CurrentCulture);
            }
            finally
            {
                updatingValues = false;
            }
        }

        private void UpdateMarkupFromCostAndPrice()
        {
            if (updatingValues)
                return;

            decimal cost;
            decimal price;
            if (!TryGetDecimal(txtcost.Text, out cost) || cost <= 0 || !TryGetDecimal(txtprice.Text, out price))
                return;

            updatingValues = true;
            try
            {
                txtmarkup.Text = ((price - cost) / cost * 100m).ToString("0.##", CultureInfo.CurrentCulture);
            }
            finally
            {
                updatingValues = false;
            }
        }

        private static bool TryGetDecimal(string value, out decimal result)
        {
            return decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out result);
        }
    }
}
