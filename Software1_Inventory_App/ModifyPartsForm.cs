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
    public partial class ModifyPartsForm : Form
    {
        
        public ModifyPartsForm()
        {
            InitializeComponent();

          
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
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
                CreateAndSavePart();
            }
            
     

            this.Close();
        }

        private void CreateAndSavePart()
        {
            //Reference the part that user wants to update
            int partID = Int32.Parse(idTextBox.Text);
            Part part = Inventory.LookUpPart(partID);

            if (inHouseButton.Checked)
            {
                InHouse newInHousePart = new InHouse(partID, nameTextBox.Text, Int32.Parse(inventoryTextBox.Text), Decimal.Parse(priceTextBox.Text),
                                                     Int32.Parse(minTextBox.Text), Int32.Parse(maxTextBox.Text), Int32.Parse(machineIDCompanyTextBox.Text));

                Inventory.UpdatePart(partID, newInHousePart);
            }
            else if (outsourcedButton.Checked)
            {
                Outsourced newOutsourcedPart = new Outsourced(partID, nameTextBox.Text, Int32.Parse(inventoryTextBox.Text), Decimal.Parse(priceTextBox.Text),
                                                     Int32.Parse(minTextBox.Text), Int32.Parse(maxTextBox.Text), machineIDCompanyTextBox.Text);
                Inventory.UpdatePart(partID, newOutsourcedPart);

            }
        }

        private bool ValidateTextBoxes()
        {
            try
            {

                Convert.ToInt32(inventoryTextBox.Text);
                Convert.ToInt32(minTextBox.Text);
                Convert.ToInt32(maxTextBox.Text);
                Convert.ToDecimal(priceTextBox.Text);

                if (inHouseButton.Checked)
                {
                    Convert.ToInt32(machineIDCompanyTextBox.Text);
                }


                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Inventory, Price, Min, Max, Machine ID fields must be numbers");
                return false;
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CheckIfTextBoxesAreEmpty()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Name != "idTextBox")
                {
                    
                    if(this.Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text)))
                    {
                        saveButton.Enabled = false;
                    }
                    else
                    {
                        saveButton.Enabled = true;
                    }
                    
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfTextBoxesAreEmpty();
        }

        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfTextBoxesAreEmpty();
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfTextBoxesAreEmpty();
        }

        private void MinTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfTextBoxesAreEmpty();
        }

        private void MaxTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfTextBoxesAreEmpty();
        }

        private void MachineIDCompanyTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckIfTextBoxesAreEmpty();
        }

        private void InHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            machineIDcompanyLabel.Text = "Machine ID";
        }

        private void OutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            machineIDcompanyLabel.Text = "Company Name";
        }
    }
}
