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
    public partial class MainScreen : Form
    {

        private DataGridView _partsGridView;
        private DataGridView _productsGridView;
        private bool _bAddPartsFormOpen = false;
        private bool _bModifyPartsFormOpen = false;
        private bool _bAddProductsFormOpen = false;
        private bool _bModifyProductsFormOpen = false;
        private int _partID;
        private int _productID;
        //private bool _isPartSearchBoxEmpty;

        public DataGridViewRow currentPartsRowSelected;
        public DataGridViewRow currentProductsRowSelected;


        //public bool GetPartsFormStatus()
        //{
        //    return _bAddPartsFormOpen;
        //}

        //public void SetPartsFormStatus(bool bSetFormStatus)
        //{
        //    _bAddPartsFormOpen = bSetFormStatus;
        //}

        public DataGridView GetProductsGridView()
        {
            return _productsGridView;
        }
        public DataGridView GetPartsGridView()
        {
            return _partsGridView;
        }
        public MainScreen()
        {
            InitializeComponent();

            _partsGridView = partsGridView;
            _productsGridView = productsGridView;

        }


        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            CheckActiveForms();
            if(_bAddProductsFormOpen)
            {
                return;
            }
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();

        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AddPartsButton_Click(object sender, EventArgs e)
        {
            CheckActiveForms(); // Check if an Add Parts form is already open, if yes don't open another one
            if (_bAddPartsFormOpen)
            {
                return;
            }
            AddPartsForm partsForm = new AddPartsForm();
            partsForm.Show();
        }



        private void ModifyPartsButton_Click(object sender, EventArgs e)
        {

            //Prevent program crashing if there are no rows to modify
            if(_partsGridView.Rows.Count == 0)
            {
                return;
            }

            CheckActiveForms(); // Check if a Modify Parts form is open, if yes don't open another one
            if (_bModifyPartsFormOpen)
            {
                return;
            }

           

            ModifyPartsForm modifyPartsForm = new ModifyPartsForm();
            CheckSelectedPartsRows();
            LoadPartsFormBoxes(modifyPartsForm);

            modifyPartsForm.Show();





        }
    
        // change to a bool return type
        private void CheckActiveForms()
        {
            FormCollection formCollection = Application.OpenForms;

            foreach (Form form in formCollection)
            {
                if (form.Name == "AddPartsForm")
                {
                    _bAddPartsFormOpen = true;
                }
                else
                {
                    _bAddPartsFormOpen = false;
                }

                if (form.Name == "ModifyPartsForm")
                {
                    _bModifyPartsFormOpen = true;
                }
                else
                {
                    _bModifyPartsFormOpen = false;
                }

                if(form.Name == "AddProductForm")
                {
                    _bAddProductsFormOpen = true;
                }
                else
                {
                    _bAddProductsFormOpen = false;
                }

                if(form.Name == "ModifyProductsForm")
                {
                    _bModifyProductsFormOpen = true;
                }
                else
                {
                    _bModifyProductsFormOpen = false;
                }

            }
        }

        private void CheckSelectedPartsRows()
        {
            //Check for selected rows
            //Full Row Select Mode is on - only one row can be chosen at a time
            foreach (DataGridViewRow row in _partsGridView.SelectedRows)
            {
                string partValue = row.Cells[0].Value.ToString();
                _partID = Int32.Parse(partValue);
                currentPartsRowSelected = row;
            }
        }

        private void CheckSelectedProductsRows()
        {
            foreach(DataGridViewRow row in _productsGridView.SelectedRows)
            {
                string productIDValue = row.Cells[0].Value.ToString();
                _productID = Int32.Parse(productIDValue);
                currentProductsRowSelected = row;
            }
        }

        private void LoadProductFormBoxes(ModifyProductsForm modifyProductsForm)
        {
            Product product = Inventory.LookupProduct(_productID);
            modifyProductsForm.idTextBox.Text = product.GetProductID().ToString();
            modifyProductsForm.nameTextBox.Text = product.Name;
            modifyProductsForm.inventoryTextBox.Text = product.InStock.ToString();
            modifyProductsForm.priceTextBox.Text = product.Price.ToString();
            modifyProductsForm.minTextBox.Text = product.Min.ToString();
            modifyProductsForm.maxTextBox.Text = product.Max.ToString();

     
            for (int i = 0; i < Inventory.Parts.Count; i++)
            {
                string[] newRow = { Inventory.Parts[i].GetPartID().ToString(), Inventory.Parts[i].GetName(),
                                    Inventory.Parts[i].GetStock().ToString(), Inventory.Parts[i].GetPrice().ToString(),
                                    Inventory.Parts[i].GetMin().ToString(), Inventory.Parts[i].GetMax().ToString()};

                modifyProductsForm.allCandidatePartsGridView.Rows.Add(newRow);
            }

            for(int i = 0; i < product.AssociatedParts.Count; i++)
            {
                string[] newRow = { product.AssociatedParts[i].GetPartID().ToString(), product.AssociatedParts[i].GetName(),
                                    product.AssociatedParts[i].GetStock().ToString(), product.AssociatedParts[i].GetPrice().ToString(),
                                    product.AssociatedParts[i].GetMin().ToString(), product.AssociatedParts[i].GetMax().ToString() };

                modifyProductsForm.associatedPartsGridview.Rows.Add(newRow);
            }

        }
        private void LoadPartsFormBoxes(ModifyPartsForm modifyPartsForm)
        {

            //Access the correct part that the user selected and load the data into the form
            Part part = Inventory.LookUpPart(_partID);
            if(part is InHouse)
            {
                modifyPartsForm.inHouseButton.Checked = true;
            }
            else if(part is Outsourced)
            {
                modifyPartsForm.outsourcedButton.Checked = true;
            }

            modifyPartsForm.idTextBox.Text = part.GetPartID().ToString();
            modifyPartsForm.nameTextBox.Text = part.GetName();
            modifyPartsForm.inventoryTextBox.Text = part.GetStock().ToString();
            modifyPartsForm.priceTextBox.Text = part.GetPrice().ToString();
            modifyPartsForm.minTextBox.Text = part.GetMin().ToString();
            modifyPartsForm.maxTextBox.Text = part.GetMax().ToString();

            //check the part type
            if (part.GetType() == typeof(InHouse))
            {
                modifyPartsForm.machineIDCompanyTextBox.Text = (part as InHouse).GetMachineID().ToString();

            }
            else if (part.GetType() == typeof(Outsourced))
            {

                modifyPartsForm.machineIDCompanyTextBox.Text = (part as Outsourced).GetCompanyName();
            }


        }
   
        private void DeletePartsButton_Click(object sender, EventArgs e)
        {
            if(_partsGridView.Rows.Count == 0)
            {
                return;
            }
            CheckSelectedPartsRows();
            Part part = Inventory.LookUpPart(_partID);

            var confirmResult = MessageBox.Show("Are you sure to delete this part?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Inventory.DeletePart(part);
            }
            else
            {
                return;
            }
            //Inventory.DeletePart(part);
        }

        private void PartSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Inventory.UpdateSearchView(_partsGridView, partSearchTextBox);
    
        }

        private void PartSearchButton_Click(object sender, EventArgs e)
        {

            Inventory.SearchInventory(_partsGridView, partSearchTextBox);
   
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if(_productsGridView.Rows.Count == 0)
            {
                return;
            }
            CheckSelectedProductsRows();

            var confirmResult = MessageBox.Show("Are you sure to delete this Product?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Product product = Inventory.LookupProduct(_productID);
                if(product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Unable to delete selected product.\nRemove associated parts from product first.");
                    return;
                }
               
                Inventory.RemoveProduct(_productID);

            }
            else
            {
                return;
            }
        
        }



        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            //Prevent program crashing if there are no rows to modify
            if (_productsGridView.Rows.Count == 0)
            {
                return;
            }

            CheckActiveForms();
            if(_bModifyProductsFormOpen)
            {
                return;
            }
            ModifyProductsForm modifyProductsForm = new ModifyProductsForm();
            CheckSelectedProductsRows();
            LoadProductFormBoxes(modifyProductsForm);

            modifyProductsForm.Show();

        }

        private void ProductSearchButton_Click(object sender, EventArgs e)
        {
            Inventory.SearchInventory(_productsGridView, productSearchTextBox);
        }

        private void ProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Inventory.UpdateSearchView(_productsGridView, productSearchTextBox);
        }
    }



}
