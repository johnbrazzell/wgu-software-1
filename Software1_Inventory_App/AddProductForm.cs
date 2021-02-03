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
    public partial class AddProductForm : Form
    {
        public DataGridViewRow currentRow;
        public AddProductForm()
        {
            InitializeComponent();
            LoadCandidatePartsGridView();
        }

        private void LoadCandidatePartsGridView()
        {
            //MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;
            //DataGridView dgv = mainScreen.GetPartsGridView();
    
            for(int i = 0; i < Inventory.Parts.Count; i++)
            {
                string[] newRow = { Inventory.Parts[i].GetPartID().ToString(), Inventory.Parts[i].GetName(),
                                    Inventory.Parts[i].GetStock().ToString(), Inventory.Parts[i].GetPrice().ToString(),
                                    Inventory.Parts[i].GetMin().ToString(), Inventory.Parts[i].GetMax().ToString()};

                allCandidatePartsGridView.Rows.Add(newRow);
            }

        
        
        }

        private void CreateAndSaveProduct()
        {

            Product newProduct = new Product();
            Part partToAdd;
            foreach (DataGridViewRow row in partsAssociatedWithProductGridView.Rows)
            {
                //get all the parts added to the gridview
                //add them to the associated products list
                string partIDValue = row.Cells[0].Value.ToString();
                int partID = Int32.Parse(partIDValue);
                partToAdd = Inventory.LookUpPart(partID);
                
                //Populate the associated products list for the new product
                newProduct.AddAssociatedPart(partToAdd);

            }

            //Populate the rest of the Product fields based on the user input
            newProduct.Name = nameTextBox.Text;
            newProduct.InStock = Int32.Parse(inventoryTextBox.Text);
            newProduct.Price = Decimal.Parse(priceTextBox.Text);
            newProduct.Min = Int32.Parse(minTextBox.Text);
            newProduct.Max = Int32.Parse(maxTextBox.Text);


            Inventory.AddProduct(newProduct);
        }
        private void AllCandidatePartsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

                    partsAssociatedWithProductGridView.Rows.Add(newRow);
                    
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteAssociatedPartsButton_Click(object sender, EventArgs e)
        {
            if(partsAssociatedWithProductGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in partsAssociatedWithProductGridView.SelectedRows)
                {
                   
                    currentRow = row;
                    partsAssociatedWithProductGridView.Rows.RemoveAt(currentRow.Index);

                }
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
