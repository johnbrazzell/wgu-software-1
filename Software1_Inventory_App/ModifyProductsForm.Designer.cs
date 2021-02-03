namespace Software1_Inventory_App
{
    partial class ModifyProductsForm
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
            this.modifyProductLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.allCandidatePartsLabel = new System.Windows.Forms.Label();
            this.allAssociatedPartsLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.addCandidatePartsButton = new System.Windows.Forms.Button();
            this.deleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.allCandidatePartsGridView = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartsGridview = new System.Windows.Forms.DataGridView();
            this.assocPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assocPartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssocPartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.allCandidatePartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.modifyProductLabel.Location = new System.Drawing.Point(35, 29);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(102, 17);
            this.modifyProductLabel.TabIndex = 0;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(71, 166);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idLabel.Location = new System.Drawing.Point(95, 108);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inventoryLabel.Location = new System.Drawing.Point(50, 226);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(66, 17);
            this.inventoryLabel.TabIndex = 0;
            this.inventoryLabel.Text = "Inventory";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceLabel.Location = new System.Drawing.Point(76, 289);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 17);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Price";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minLabel.Location = new System.Drawing.Point(12, 380);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(30, 17);
            this.minLabel.TabIndex = 0;
            this.minLabel.Text = "Min";
            // 
            // allCandidatePartsLabel
            // 
            this.allCandidatePartsLabel.AutoSize = true;
            this.allCandidatePartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.allCandidatePartsLabel.Location = new System.Drawing.Point(381, 63);
            this.allCandidatePartsLabel.Name = "allCandidatePartsLabel";
            this.allCandidatePartsLabel.Size = new System.Drawing.Size(128, 17);
            this.allCandidatePartsLabel.TabIndex = 0;
            this.allCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // allAssociatedPartsLabel
            // 
            this.allAssociatedPartsLabel.AutoSize = true;
            this.allAssociatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.allAssociatedPartsLabel.Location = new System.Drawing.Point(384, 286);
            this.allAssociatedPartsLabel.Name = "allAssociatedPartsLabel";
            this.allAssociatedPartsLabel.Size = new System.Drawing.Size(230, 17);
            this.allAssociatedPartsLabel.TabIndex = 0;
            this.allAssociatedPartsLabel.Text = "Parts Associated With This Product";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxLabel.Location = new System.Drawing.Point(197, 380);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(33, 17);
            this.maxLabel.TabIndex = 0;
            this.maxLabel.Text = "Max";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(165, 105);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(165, 163);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(165, 226);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventoryTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(165, 286);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(74, 377);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTextBox.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(721, 32);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(160, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(615, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // addCandidatePartsButton
            // 
            this.addCandidatePartsButton.Location = new System.Drawing.Point(785, 245);
            this.addCandidatePartsButton.Name = "addCandidatePartsButton";
            this.addCandidatePartsButton.Size = new System.Drawing.Size(96, 55);
            this.addCandidatePartsButton.TabIndex = 3;
            this.addCandidatePartsButton.Text = "Add";
            this.addCandidatePartsButton.UseVisualStyleBackColor = true;
            this.addCandidatePartsButton.Click += new System.EventHandler(this.AddCandidatePartsButton_Click);
            // 
            // deleteAssociatedPartButton
            // 
            this.deleteAssociatedPartButton.Location = new System.Drawing.Point(785, 462);
            this.deleteAssociatedPartButton.Name = "deleteAssociatedPartButton";
            this.deleteAssociatedPartButton.Size = new System.Drawing.Size(96, 55);
            this.deleteAssociatedPartButton.TabIndex = 3;
            this.deleteAssociatedPartButton.Text = "Delete";
            this.deleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.deleteAssociatedPartButton.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(664, 556);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 37);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(778, 556);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 37);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // allCandidatePartsGridView
            // 
            this.allCandidatePartsGridView.AllowUserToAddRows = false;
            this.allCandidatePartsGridView.AllowUserToDeleteRows = false;
            this.allCandidatePartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCandidatePartsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.partInventory,
            this.partPrice,
            this.partMin,
            this.partMax});
            this.allCandidatePartsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.allCandidatePartsGridView.Location = new System.Drawing.Point(381, 96);
            this.allCandidatePartsGridView.Name = "allCandidatePartsGridView";
            this.allCandidatePartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allCandidatePartsGridView.Size = new System.Drawing.Size(500, 143);
            this.allCandidatePartsGridView.TabIndex = 4;
            // 
            // partID
            // 
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            // 
            // partName
            // 
            this.partName.HeaderText = "Name";
            this.partName.Name = "partName";
            // 
            // partInventory
            // 
            this.partInventory.HeaderText = "Inventory";
            this.partInventory.Name = "partInventory";
            // 
            // partPrice
            // 
            this.partPrice.HeaderText = "Price";
            this.partPrice.Name = "partPrice";
            // 
            // partMin
            // 
            this.partMin.HeaderText = "Min";
            this.partMin.Name = "partMin";
            // 
            // partMax
            // 
            this.partMax.HeaderText = "Max";
            this.partMax.Name = "partMax";
            // 
            // associatedPartsGridview
            // 
            this.associatedPartsGridview.AllowUserToAddRows = false;
            this.associatedPartsGridview.AllowUserToDeleteRows = false;
            this.associatedPartsGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assocPartID,
            this.assocPartName,
            this.assocPartInventory,
            this.assocPartPrice,
            this.assocPartMin,
            this.AssocPartMax});
            this.associatedPartsGridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.associatedPartsGridview.Location = new System.Drawing.Point(381, 316);
            this.associatedPartsGridview.Name = "associatedPartsGridview";
            this.associatedPartsGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsGridview.Size = new System.Drawing.Size(500, 140);
            this.associatedPartsGridview.TabIndex = 5;
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
            // AssocPartMax
            // 
            this.AssocPartMax.HeaderText = "Max";
            this.AssocPartMax.Name = "AssocPartMax";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(251, 377);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 1;
            // 
            // ModifyProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 606);
            this.Controls.Add(this.associatedPartsGridview);
            this.Controls.Add(this.allCandidatePartsGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteAssociatedPartButton);
            this.Controls.Add(this.addCandidatePartsButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.allAssociatedPartsLabel);
            this.Controls.Add(this.allCandidatePartsLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.modifyProductLabel);
            this.Name = "ModifyProductsForm";
            this.Text = "ModifyProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.allCandidatePartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyProductLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label allCandidatePartsLabel;
        private System.Windows.Forms.Label allAssociatedPartsLabel;
        private System.Windows.Forms.Label maxLabel;
        public System.Windows.Forms.TextBox idTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox inventoryTextBox;
        public System.Windows.Forms.TextBox priceTextBox;
        public System.Windows.Forms.TextBox minTextBox;
        public System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addCandidatePartsButton;
        private System.Windows.Forms.Button deleteAssociatedPartButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn assocPartMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssocPartMax;
        public System.Windows.Forms.DataGridView associatedPartsGridview;
        public System.Windows.Forms.DataGridView allCandidatePartsGridView;
    }
}