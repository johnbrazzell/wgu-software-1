using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1_Inventory_App
{
   
    public partial class ModifyProductsForm : Form
    {
        public DataGridViewRow currentRow;
        public ModifyProductsForm()
        {
            InitializeComponent();
        }

   
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBoxes())
            {
                return;
            }
            else if (Convert.ToInt32(minTextBox.Text) > Convert.ToInt32(maxTextBox.Text))
            {
                MessageBox.Show("Min field must be less than Max");
                return;
            }
            else if (Convert.ToInt32(minTextBox.Text) <= Convert.ToInt32(maxTextBox.Text) &&
                    Convert.ToInt32(inventoryTextBox.Text) < Convert.ToInt32(minTextBox.Text) || Convert.ToInt32(inventoryTextBox.Text) > Convert.ToInt32(maxTextBox.Text))
            {
                MessageBox.Show("Inventory can't be less than Min or Greater than Max");
                return;
            }
            else
            {
                CreateAndSaveProduct();
            }

            this.Close();
        }

        private bool ValidateTextBoxes()
        {
            try
            {

                Convert.ToInt32(inventoryTextBox.Text);
                Convert.ToInt32(minTextBox.Text);
                Convert.ToInt32(maxTextBox.Text);
                Convert.ToDecimal(priceTextBox.Text);

           

                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Inventory, Price, Min, Max, Machine ID fields must be numbers");
                return false;
            }

        }

        private void CreateAndSaveProduct()
        {
            int productID = Int32.Parse(idTextBox.Text);
            Product product = Inventory.LookupProduct(productID);
            product.AssociatedParts.Clear();
            foreach (DataGridViewRow row in associatedPartsGridview.Rows)
            {
                //get all the parts added to the gridview
                //add them to the associated products list
                string partIDValue = row.Cells[0].Value.ToString();
                int partID = Int32.Parse(partIDValue);
                Part partToAdd;
                partToAdd = Inventory.LookUpPart(partID);

                //Populate the associated products list for the new product
                product.AddAssociatedPart(partToAdd);

            }

            product.Name = nameTextBox.Text;
            product.Price = Decimal.Parse(priceTextBox.Text);
            product.InStock = Int32.Parse(inventoryTextBox.Text);
            product.Min = Int32.Parse(minTextBox.Text);
            product.Max = Int32.Parse(maxTextBox.Text);
            //product.AssociatedParts = product.AssociatedParts;

            Inventory.UpdateProduct(productID, product);
        }

        private void DeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            if (associatedPartsGridview.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in associatedPartsGridview.SelectedRows)
                {

                    currentRow = row;
                    associatedPartsGridview.Rows.RemoveAt(currentRow.Index);

                }
            }
        }

        private void AddCandidatePartsButton_Click(object sender, EventArgs e)
        {

            //Check for selected rows
            //Full Row Select Mode is on - only one row can be chosen at a time
            foreach (DataGridViewRow row in allCandidatePartsGridView.SelectedRows)
            {
                string partValue = row.Cells[0].Value.ToString();
                int partID = Int32.Parse(partValue);
                currentRow = row;

                Part partToAdd = Inventory.LookUpPart(partID);


                string[] newRow = { partToAdd.GetPartID().ToString(), partToAdd.GetName(),
                                    partToAdd.GetStock().ToString(), partToAdd.GetPrice().ToString(),
                                    partToAdd.GetMin().ToString(), partToAdd.GetMax().ToString()};

                associatedPartsGridview.Rows.Add(newRow);

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Inventory.SearchInventory(allCandidatePartsGridView, searchTextBox);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Inventory.UpdateSearchView(allCandidatePartsGridView, searchTextBox);
        }
    }
}
