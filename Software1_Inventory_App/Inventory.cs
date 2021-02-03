using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Software1_Inventory_App
{
    public static class Inventory
    {
        private static List<Part> _allPartsList = new List<Part>();
        private static List<Product> _productsList = new List<Product>();
        //property Products: BindingList<Product> or List<Product>
        public static List<Product> Products
        {
            get { return _productsList; }
            set { _productsList = value; }
        }


        //property AllParts: BindingList<Part> or List<Part>
        public static List<Part> Parts
        {
            get { return _allPartsList; }
            set { _allPartsList = value; }
        }

        //function AddProduct(Product): void 
        public static void AddProduct(Product product)
        {
            MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;
            DataGridView dgv = mainScreen.GetProductsGridView();

            Products.Add(product);

            string[] partRow = new string[] { product.GetProductID().ToString(), product.Name, product.InStock.ToString(),
                                               product.Price.ToString(), product.Min.ToString(), product.Max.ToString() };

            dgv.Rows.Add(partRow);
        }
        //function RemoveProduct(int): bool
        public static bool RemoveProduct(int productID)
        {
            Product productToRemove;
            foreach (Product product in Products)
            {
                if (product.GetProductID() == productID)
                {
                    productToRemove = product;
                    Products.Remove(productToRemove);
                    break;
                }
            }

            MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;
            DataGridView dgv = mainScreen.GetProductsGridView();
            dgv.Rows.RemoveAt(mainScreen.currentProductsRowSelected.Index);

            return true;
        }
        //function LookUpProduct(int): Product
        public static Product LookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.GetProductID() == productID)
                {
                    return product;
                }
            }

            return null;
        }
        //function UpdateProdct(int, Product): void
        public static void UpdateProduct(int productID, Product product)
        {

            //Update the part in the list
            Product productToUpdate = Products.Find(p => p.GetProductID() == productID);
            int productIndex = Products.IndexOf(productToUpdate);
            Products[productIndex] = product;

            MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;
            DataGridView dgv = mainScreen.GetProductsGridView();


            string[] productRow = new string[] { product.GetProductID().ToString(), product.Name, product.InStock.ToString(),
                                               product.Price.ToString(), product.Min.ToString(), product.Max.ToString() };



            for (int i = 0; i < mainScreen.currentProductsRowSelected.Cells.Count; i++)
            {
                mainScreen.currentProductsRowSelected.Cells[i].Value = productRow[i].ToString();
            }




        }
        //function AddPart(Part): void
        public static void AddPart(Part part)
        {
            MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;
            DataGridView dgv = mainScreen.GetPartsGridView();

            if (part.GetType() == typeof(InHouse))
            {

                Parts.Add(part as InHouse);
                string[] partRow = new string[] { part.GetPartID().ToString(), part.GetName(), part.GetStock().ToString(),
                                               part.GetPrice().ToString(), part.GetMin().ToString(), part.GetMax().ToString() };

                dgv.Rows.Add(partRow);
            }
            else if (part.GetType() == typeof(Outsourced))
            {
                Outsourced partToAdd = part as Outsourced;
                Parts.Add(partToAdd);
                string[] partRow = new string[] { part.GetPartID().ToString(), part.GetName(), part.GetStock().ToString(),
                                               part.GetPrice().ToString(), part.GetMin().ToString(), part.GetMax().ToString() };

                dgv.Rows.Add(partRow);

            }

        }


        //function DeletePart(Part): bool
        public static bool DeletePart(Part part)
        {

            Parts.Remove(part);
            MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;
            DataGridView dgv = mainScreen.GetPartsGridView();
            dgv.Rows.RemoveAt(mainScreen.currentPartsRowSelected.Index);

            return true;
        }
        //function LookUpPart(int): Part
        public static Part LookUpPart(int partID)
        {

            foreach (Part part in Parts)
            {
                if (part.GetPartID() == partID)
                {
                    return part;
                }

            }

            return null;

        }
        //function UpdatePart(int, Part): void
        public static void UpdatePart(int partID, Part part)
        {
            //Reference the main screen and access the PartsGridView
            MainScreen mainScreen = Application.OpenForms["MainScreen"] as MainScreen;
            DataGridView dgv = mainScreen.GetPartsGridView();

            //Update the part in the list
            Part partToUpdate = Parts.Find(p => p.GetPartID() == partID);
            int partIndex = Parts.IndexOf(partToUpdate);
            Parts[partIndex] = part;


            //Update the PartsGridView with the new information
            string[] partRow = new string[] { part.GetPartID().ToString(), part.GetName(), part.GetStock().ToString(),
                                               part.GetPrice().ToString(), part.GetMin().ToString(), part.GetMax().ToString() };


            for (int i = 0; i < mainScreen.currentPartsRowSelected.Cells.Count; i++)
            {
                mainScreen.currentPartsRowSelected.Cells[i].Value = partRow[i].ToString();
            }




        }

        public static void UpdateSearchView(DataGridView dataGridView, TextBox searchTextBox)
        {
            if (String.IsNullOrEmpty(searchTextBox.Text))
            {

                foreach (DataGridViewRow row in dataGridView.Rows)
                {

                    row.Visible = true;


                }
            }
        }

        public static void SearchInventory(DataGridView dataGridView, TextBox searchTextBox)
        {


            if (string.IsNullOrEmpty(searchTextBox.Text.ToString()))
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {


                        if (row.Cells[i].Value.ToString() == searchTextBox.Text.ToString())
                        {
                            row.Visible = true;
                            break;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }
   

    }

    
}
