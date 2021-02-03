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
    public partial class AddPartsForm : Form
    {

        private MainScreen _mainScreen;
        private List<TextBox> _textboxList = new List<TextBox>();
      
   

   
        public AddPartsForm()
        {
            InitializeComponent();
            InitializeTextboxList();
            saveButton.Enabled = false;
            idTextBox.Enabled = false;
        
            _mainScreen = Application.OpenForms["MainScreen"] as MainScreen;
            idTextBox.Text = "";
     
        }

        private void InitializeTextboxList()
        {
            _textboxList.Add(nameTextBox);
            _textboxList.Add(inventoryTextBox);
            _textboxList.Add(priceTextBox);
            _textboxList.Add(minTextBox);
            _textboxList.Add(maxTextBox);
            _textboxList.Add(machineIDtextBox);
        }
        private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            machineIDLabel.Text = "Machine ID";
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            machineIDLabel.Text = "Company Name";
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
                CreateAndSavePart();
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
                
                if(inHouseRadioButton.Checked)
                {
                    Convert.ToInt32(machineIDtextBox.Text);
                }


                return true;
            }
            catch (Exception)
            {
                
                MessageBox.Show("Inventory, Price, Min, Max, Machine ID fields must be numbers");
                return false;
            }

        }

        private void CreateAndSavePart()
        {
            if (inHouseRadioButton.Checked)
            {
     
                InHouse inhousePart = new InHouse(nameTextBox.Text, Int32.Parse(inventoryTextBox.Text), Decimal.Parse(priceTextBox.Text),
                    Int32.Parse(minTextBox.Text), Int32.Parse(maxTextBox.Text), Int32.Parse(machineIDtextBox.Text));
                idTextBox.Text = inhousePart.GetPartID().ToString();
             
                Inventory.AddPart(inhousePart);
              
                
                this.Close();

            }

            if (outsourcedRadioButton.Checked)
            {
                Outsourced outsourcedPart = new Outsourced(nameTextBox.Text, Int32.Parse(inventoryTextBox.Text), Decimal.Parse(priceTextBox.Text),
                    Int32.Parse(minTextBox.Text), Int32.Parse(maxTextBox.Text), machineIDtextBox.Text);

             
                Inventory.AddPart(outsourcedPart);
      
                this.Close();
            }
        }



        private bool CheckForText()
        {
            foreach(TextBox textBox in _textboxList)
           {
               if(String.IsNullOrEmpty(textBox.Text))
                {
                   saveButton.Enabled = false;
                   return false;
               }
                
           }

           return true;
        }

        private void CheckToEnableSaveButton()
        {
            if (CheckForText())
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckToEnableSaveButton();
        }




        private void InventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckToEnableSaveButton();
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckToEnableSaveButton();
        }

        private void MinTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckToEnableSaveButton();
        }

        private void MaxTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckToEnableSaveButton();
        }

        private void MachineIDtextBox_TextChanged(object sender, EventArgs e)
        {
            CheckToEnableSaveButton();
        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
