namespace Software1_Inventory_App
{
    partial class AddProductForm
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
            this.addProductLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.allCandidatePartsGridView = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allCandidatePartsLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.addCandidatePartsButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.partsAssociatedWithProductGridView = new System.Windows.Forms.DataGridView();
            this.assocPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteAssociatedPartsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.partsAssociatedWithProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allCandidatePartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedWithProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addProductLabel.Location = new System.Drawing.Point(35, 29);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(86, 17);
            this.addProductLabel.TabIndex = 0;
            this.addProductLabel.Text = "Add Product";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(615, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(721, 32);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(160, 20);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // allCandidatePartsGridView
            // 
            this.allCandidatePartsGridView.AllowUserToAddRows = false;
            this.allCandidatePartsGridView.AllowUserToDeleteRows = false;
            this.allCandidatePartsGridView.ColumnHeadersHeight = 21;
            this.allCandidatePartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.allCandidatePartsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.name,
            this.inventory,
            this.price,
            this.min,
            this.max});
            this.allCandidatePartsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.allCandidatePartsGridView.Location = new System.Drawing.Point(381, 96);
            this.allCandidatePartsGridView.Name = "allCandidatePartsGridView";
            this.allCandidatePartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allCandidatePartsGridView.Size = new System.Drawing.Size(500, 143);
            this.allCandidatePartsGridView.TabIndex = 3;
            this.allCandidatePartsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllCandidatePartsGridView_CellContentClick);
            // 
            // partID
            // 
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            this.partID.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // inventory
            // 
            this.inventory.HeaderText = "Inventory";
            this.inventory.Name = "inventory";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // min
            // 
            this.min.HeaderText = "Min";
            this.min.Name = "min";
            // 
            // max
            // 
            this.max.HeaderText = "Max";
            this.max.Name = "max";
            // 
            // allCandidatePartsLabel
            // 
            this.allCandidatePartsLabel.AutoSize = true;
            this.allCandidatePartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.allCandidatePartsLabel.Location = new System.Drawing.Point(381, 63);
            this.allCandidatePartsLabel.Name = "allCandidatePartsLabel";
            this.allCandidatePartsLabel.Size = new System.Drawing.Size(128, 17);
            this.allCandidatePartsLabel.TabIndex = 4;
            this.allCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idLabel.Location = new System.Drawing.Point(95, 108);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 5;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(71, 166);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inventoryLabel.Location = new System.Drawing.Point(50, 226);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(66, 17);
            this.inventoryLabel.TabIndex = 7;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceLabel.Location = new System.Drawing.Point(76, 289);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 17);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minLabel.Location = new System.Drawing.Point(12, 380);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(30, 17);
            this.minLabel.TabIndex = 9;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxLabel.Location = new System.Drawing.Point(197, 380);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(33, 17);
            this.maxLabel.TabIndex = 10;
            this.maxLabel.Text = "Max";
            // 
            // addCandidatePartsButton
            // 
            this.addCandidatePartsButton.Location = new System.Drawing.Point(785, 245);
            this.addCandidatePartsButton.Name = "addCandidatePartsButton";
            this.addCandidatePartsButton.Size = new System.Drawing.Size(96, 55);
            this.addCandidatePartsButton.TabIndex = 11;
            this.addCandidatePartsButton.Text = "Add";
            this.addCandidatePartsButton.UseVisualStyleBackColor = true;
            this.addCandidatePartsButton.Click += new System.EventHandler(this.AddCandidatePartsButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(165, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(165, 163);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(165, 226);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 14;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(165, 286);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 15;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(74, 377);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTextBox.TabIndex = 16;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(251, 377);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 17;
            // 
            // partsAssociatedWithProductGridView
            // 
            this.partsAssociatedWithProductGridView.AllowUserToAddRows = false;
            this.partsAssociatedWithProductGridView.AllowUserToDeleteRows = false;
            this.partsAssociatedWithProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsAssociatedWithProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assocPartID,
            this.assocPartName,
            this.assocPartInventory,
            this.assocPartPrice,
            this.assocPartMin,
            this.assocPartMax});
            this.partsAssociatedWithProductGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partsAssociatedWithProductGridView.Location = new System.Drawing.Point(381, 316);
            this.partsAssociatedWithProductGridView.Name = "partsAssociatedWithProductGridView";
            this.partsAssociatedWithProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsAssociatedWithProductGridView.Size = new System.Drawing.Size(500, 140);
            this.partsAssociatedWithProductGridView.TabIndex = 18;
            // 
            // assocPartID
            // 
            this.assocPartID.HeaderText = "Part ID";
            this.assocPartID.Name = "assocPartID";
            // 
            // assocPartName
            // 
            this.assocPartName.HeaderText = "Name";
            this.assocPartName.Name = "assocPartName";
            // 
            // assocPartInventory
            // 
            this.assocPartInventory.HeaderText = "Inventory";
            this.assocPartInventory.Name = "assocPartInventory";
            // 
            // assocPartPrice
            // 
            this.assocPartPrice.HeaderText = "Price";
            this.assocPartPrice.Name = "assocPartPrice";
            // 
            // assocPartMin
            // 
            this.assocPartMin.HeaderText = "Min";
            this.assocPartMin.Name = "assocPartMin";
            // 
            // assocPartMax
            // 
            this.assocPartMax.HeaderText = "Max";
            this.assocPartMax.Name = "assocPartMax";
            // 
            // deleteAssociatedPartsButton
            // 
            this.deleteAssociatedPartsButton.Location = new System.Drawing.Point(785, 462);
            this.deleteAssociatedPartsButton.Name = "deleteAssociatedPartsButton";
            this.deleteAssociatedPartsButton.Size = new System.Drawing.Size(96, 55);
            this.deleteAssociatedPartsButton.TabIndex = 19;
            this.deleteAssociatedPartsButton.Text = "Delete";
            this.deleteAssociatedPartsButton.UseVisualStyleBackColor = true;
            this.deleteAssociatedPartsButton.Click += new System.EventHandler(this.DeleteAssociatedPartsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(664, 556);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 37);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(778, 556);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 37);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // partsAssociatedWithProductLabel
            // 
            this.partsAssociatedWithProductLabel.AutoSize = true;
            this.partsAssociatedWithProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.partsAssociatedWithProductLabel.Location = new System.Drawing.Point(384, 286);
            this.partsAssociatedWithProductLabel.Name = "partsAssociatedWithProductLabel";
            this.partsAssociatedWithProductLabel.Size = new System.Drawing.Size(230, 17);
            this.partsAssociatedWithProductLabel.TabIndex = 22;
            this.partsAssociatedWithProductLabel.Text = "Parts Associated With This Product";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 606);
            this.Controls.Add(this.partsAssociatedWithProductLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteAssociatedPartsButton);
            this.Controls.Add(this.partsAssociatedWithProductGridView);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.addCandidatePartsButton);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.allCandidatePartsLabel);
            this.Controls.Add(this.allCandidatePartsGridView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addProductLabel);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.allCandidatePartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsAssociatedWithProductGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView allCandidatePartsGridView;
        private System.Windows.Forms.Label allCandidatePartsLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Button addCandidatePartsButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.DataGridView partsAssociatedWithProductGridView;
        private System.Windows.Forms.Button deleteAssociatedPartsButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label partsAssociatedWithProductLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn min;
        private System.Windows.Forms.DataGridViewTextBoxColumn max;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartMax;
    }
}