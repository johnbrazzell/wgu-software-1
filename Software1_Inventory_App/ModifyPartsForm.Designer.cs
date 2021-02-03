namespace Software1_Inventory_App
{
    partial class ModifyPartsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modifyPartLabel = new System.Windows.Forms.Label();
            this.inHouseButton = new System.Windows.Forms.RadioButton();
            this.outsourcedButton = new System.Windows.Forms.RadioButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.machineIDCompanyTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.machineIDcompanyLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifyPartLabel
            // 
            this.modifyPartLabel.AutoSize = true;
            this.modifyPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartLabel.Location = new System.Drawing.Point(12, 9);
            this.modifyPartLabel.Name = "modifyPartLabel";
            this.modifyPartLabel.Size = new System.Drawing.Size(88, 20);
            this.modifyPartLabel.TabIndex = 0;
            this.modifyPartLabel.Text = "Modify Part";
            // 
            // inHouseButton
            // 
            this.inHouseButton.AutoSize = true;
            this.inHouseButton.Location = new System.Drawing.Point(129, 12);
            this.inHouseButton.Name = "inHouseButton";
            this.inHouseButton.Size = new System.Drawing.Size(68, 17);
            this.inHouseButton.TabIndex = 1;
            this.inHouseButton.TabStop = true;
            this.inHouseButton.Text = "In-House";
            this.inHouseButton.UseVisualStyleBackColor = true;
            this.inHouseButton.CheckedChanged += new System.EventHandler(this.InHouseButton_CheckedChanged);
            // 
            // outsourcedButton
            // 
            this.outsourcedButton.AutoSize = true;
            this.outsourcedButton.Location = new System.Drawing.Point(220, 12);
            this.outsourcedButton.Name = "outsourcedButton";
            this.outsourcedButton.Size = new System.Drawing.Size(80, 17);
            this.outsourcedButton.TabIndex = 2;
            this.outsourcedButton.TabStop = true;
            this.outsourcedButton.Text = "Outsourced";
            this.outsourcedButton.UseVisualStyleBackColor = true;
            this.outsourcedButton.CheckedChanged += new System.EventHandler(this.OutsourcedButton_CheckedChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(221, 51);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.TextChanged += new System.EventHandler(this.IdTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(220, 93);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(220, 140);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 5;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.InventoryTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(294, 270);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 6;
            this.maxTextBox.TextChanged += new System.EventHandler(this.MaxTextBox_TextChanged);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(90, 270);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTextBox.TabIndex = 7;
            this.minTextBox.TextChanged += new System.EventHandler(this.MinTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(220, 187);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 8;
            this.priceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // machineIDCompanyTextBox
            // 
            this.machineIDCompanyTextBox.Location = new System.Drawing.Point(175, 322);
            this.machineIDCompanyTextBox.Name = "machineIDCompanyTextBox";
            this.machineIDCompanyTextBox.Size = new System.Drawing.Size(161, 20);
            this.machineIDCompanyTextBox.TabIndex = 9;
            this.machineIDCompanyTextBox.TextChanged += new System.EventHandler(this.MachineIDCompanyTextBox_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idLabel.Location = new System.Drawing.Point(126, 54);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(126, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inventoryLabel.Location = new System.Drawing.Point(126, 140);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(66, 17);
            this.inventoryLabel.TabIndex = 12;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceLabel.Location = new System.Drawing.Point(126, 190);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(80, 17);
            this.priceLabel.TabIndex = 13;
            this.priceLabel.Text = "Price / Cost";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minLabel.Location = new System.Drawing.Point(33, 271);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(30, 17);
            this.minLabel.TabIndex = 14;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxLabel.Location = new System.Drawing.Point(244, 271);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(33, 17);
            this.maxLabel.TabIndex = 15;
            this.maxLabel.Text = "Max";
            // 
            // machineIDcompanyLabel
            // 
            this.machineIDcompanyLabel.AutoSize = true;
            this.machineIDcompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.machineIDcompanyLabel.Location = new System.Drawing.Point(53, 323);
            this.machineIDcompanyLabel.Name = "machineIDcompanyLabel";
            this.machineIDcompanyLabel.Size = new System.Drawing.Size(78, 17);
            this.machineIDcompanyLabel.TabIndex = 16;
            this.machineIDcompanyLabel.Text = "Machine ID";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveButton.Location = new System.Drawing.Point(175, 376);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 37);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(275, 376);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 37);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ModifyPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.machineIDcompanyLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.machineIDCompanyTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.outsourcedButton);
            this.Controls.Add(this.inHouseButton);
            this.Controls.Add(this.modifyPartLabel);
            this.Name = "ModifyPartsForm";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyPartLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label machineIDcompanyLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.TextBox idTextBox;
        public System.Windows.Forms.TextBox minTextBox;
        public System.Windows.Forms.TextBox maxTextBox;
        public System.Windows.Forms.TextBox machineIDCompanyTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox inventoryTextBox;
        public System.Windows.Forms.TextBox priceTextBox;
        public System.Windows.Forms.RadioButton inHouseButton;
        public System.Windows.Forms.RadioButton outsourcedButton;
    }
}