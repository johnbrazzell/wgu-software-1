namespace Software1_Inventory_App
{
    partial class AddPartsForm
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
            this.inHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.machineIDLabel = new System.Windows.Forms.Label();
            this.machineIDtextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inHouseRadioButton
            // 
            this.inHouseRadioButton.AutoSize = true;
            this.inHouseRadioButton.Location = new System.Drawing.Point(129, 12);
            this.inHouseRadioButton.Name = "inHouseRadioButton";
            this.inHouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.inHouseRadioButton.TabIndex = 0;
            this.inHouseRadioButton.TabStop = true;
            this.inHouseRadioButton.Text = "In-House";
            this.inHouseRadioButton.UseVisualStyleBackColor = true;
            this.inHouseRadioButton.CheckedChanged += new System.EventHandler(this.InHouseRadioButton_CheckedChanged);
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.Location = new System.Drawing.Point(220, 12);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadioButton.TabIndex = 1;
            this.outsourcedRadioButton.TabStop = true;
            this.outsourcedRadioButton.Text = "Outsourced";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            this.outsourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(71, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Add Part";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(220, 93);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(220, 140);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 4;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.InventoryTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(220, 187);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(99, 270);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTextBox.TabIndex = 6;
            this.minTextBox.TextChanged += new System.EventHandler(this.MinTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(294, 270);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 7;
            this.maxTextBox.Tag = "max";
            this.maxTextBox.TextChanged += new System.EventHandler(this.MaxTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(126, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(126, 140);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(66, 17);
            this.inventoryLabel.TabIndex = 9;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(126, 190);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(80, 17);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price / Cost";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(53, 271);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(30, 17);
            this.minLabel.TabIndex = 11;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(244, 271);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(33, 17);
            this.maxLabel.TabIndex = 12;
            this.maxLabel.Text = "Max";
            // 
            // machineIDLabel
            // 
            this.machineIDLabel.AutoSize = true;
            this.machineIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineIDLabel.Location = new System.Drawing.Point(53, 323);
            this.machineIDLabel.Name = "machineIDLabel";
            this.machineIDLabel.Size = new System.Drawing.Size(78, 17);
            this.machineIDLabel.TabIndex = 13;
            this.machineIDLabel.Text = "Machine ID";
            // 
            // machineIDtextBox
            // 
            this.machineIDtextBox.Location = new System.Drawing.Point(175, 322);
            this.machineIDtextBox.Name = "machineIDtextBox";
            this.machineIDtextBox.Size = new System.Drawing.Size(161, 20);
            this.machineIDtextBox.TabIndex = 14;
            this.machineIDtextBox.TextChanged += new System.EventHandler(this.MachineIDtextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(220, 51);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 15;
          
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(126, 54);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID";
            this.idLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(275, 376);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 37);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.machineIDtextBox);
            this.Controls.Add(this.machineIDLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.outsourcedRadioButton);
            this.Controls.Add(this.inHouseRadioButton);
            this.Name = "AddPartsForm";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inHouseRadioButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label machineIDLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox inventoryTextBox;
        public System.Windows.Forms.TextBox priceTextBox;
        public System.Windows.Forms.TextBox minTextBox;
        public System.Windows.Forms.TextBox maxTextBox;
        public System.Windows.Forms.TextBox machineIDtextBox;
    }
}