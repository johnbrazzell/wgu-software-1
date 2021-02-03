namespace Software1_Inventory_App
{
    partial class MainScreen
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
            this.partsGridView = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPartsButton = new System.Windows.Forms.Button();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProductsButton = new System.Windows.Forms.Button();
            this.modifyPartsButton = new System.Windows.Forms.Button();
            this.deletePartsButton = new System.Windows.Forms.Button();
            this.partSearchButton = new System.Windows.Forms.Button();
            this.partSearchTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // partsGridView
            // 
            this.partsGridView.AllowUserToAddRows = false;
            this.partsGridView.AllowUserToDeleteRows = false;
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.partInventory,
            this.partPrice,
            this.partMin,
            this.partMax});
            this.partsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partsGridView.Location = new System.Drawing.Point(12, 97);
            this.partsGridView.MultiSelect = false;
            this.partsGridView.Name = "partsGridView";
            this.partsGridView.ReadOnly = true;
            this.partsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsGridView.Size = new System.Drawing.Size(600, 290);
            this.partsGridView.TabIndex = 9;
            // 
            // partID
            // 
            this.partID.HeaderText = "Part ID";
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            // 
            // partName
            // 
            this.partName.HeaderText = "Name";
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
            // 
            // partInventory
            // 
            this.partInventory.HeaderText = "Inventory";
            this.partInventory.Name = "partInventory";
            this.partInventory.ReadOnly = true;
            // 
            // partPrice
            // 
            this.partPrice.HeaderText = "Price";
            this.partPrice.Name = "partPrice";
            this.partPrice.ReadOnly = true;
            // 
            // partMin
            // 
            this.partMin.HeaderText = "Min";
            this.partMin.Name = "partMin";
            this.partMin.ReadOnly = true;
            // 
            // partMax
            // 
            this.partMax.HeaderText = "Max";
            this.partMax.Name = "partMax";
            this.partMax.ReadOnly = true;
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(994, 52);
            this.productSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(102, 27);
            this.productSearchButton.TabIndex = 0;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.ProductSearchButton_Click);
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Location = new System.Drawing.Point(1118, 56);
            this.productSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(140, 20);
            this.productSearchTextBox.TabIndex = 1;
            this.productSearchTextBox.TextChanged += new System.EventHandler(this.ProductSearchTextBox_TextChanged);
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PartsLabel.Location = new System.Drawing.Point(8, 59);
            this.PartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(51, 24);
            this.PartsLabel.TabIndex = 2;
            this.PartsLabel.Text = "Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(680, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Products";
            // 
            // addPartsButton
            // 
            this.addPartsButton.Location = new System.Drawing.Point(353, 416);
            this.addPartsButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPartsButton.Name = "addPartsButton";
            this.addPartsButton.Size = new System.Drawing.Size(67, 21);
            this.addPartsButton.TabIndex = 6;
            this.addPartsButton.Text = "Add";
            this.addPartsButton.UseVisualStyleBackColor = true;
            this.addPartsButton.Click += new System.EventHandler(this.AddPartsButton_Click);
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productInventory,
            this.productPrice,
            this.productMin,
            this.productMax});
            this.productsGridView.Location = new System.Drawing.Point(684, 97);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(600, 290);
            this.productsGridView.TabIndex = 7;
            this.productsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
            // 
            // productID
            // 
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            // 
            // productInventory
            // 
            this.productInventory.HeaderText = "Inventory";
            this.productInventory.Name = "productInventory";
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            // 
            // productMin
            // 
            this.productMin.HeaderText = "Min";
            this.productMin.Name = "productMin";
            // 
            // productMax
            // 
            this.productMax.HeaderText = "Max";
            this.productMax.Name = "productMax";
            // 
            // addProductsButton
            // 
            this.addProductsButton.Location = new System.Drawing.Point(1037, 412);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(75, 23);
            this.addProductsButton.TabIndex = 8;
            this.addProductsButton.Text = "Add";
            this.addProductsButton.UseVisualStyleBackColor = true;
            this.addProductsButton.Click += new System.EventHandler(this.AddProductsButton_Click);
            // 
            // modifyPartsButton
            // 
            this.modifyPartsButton.Location = new System.Drawing.Point(443, 414);
            this.modifyPartsButton.Name = "modifyPartsButton";
            this.modifyPartsButton.Size = new System.Drawing.Size(75, 23);
            this.modifyPartsButton.TabIndex = 10;
            this.modifyPartsButton.Text = "Modify";
            this.modifyPartsButton.UseVisualStyleBackColor = true;
            this.modifyPartsButton.Click += new System.EventHandler(this.ModifyPartsButton_Click);
            // 
            // deletePartsButton
            // 
            this.deletePartsButton.Location = new System.Drawing.Point(537, 414);
            this.deletePartsButton.Name = "deletePartsButton";
            this.deletePartsButton.Size = new System.Drawing.Size(75, 23);
            this.deletePartsButton.TabIndex = 11;
            this.deletePartsButton.Text = "Delete";
            this.deletePartsButton.UseVisualStyleBackColor = true;
            this.deletePartsButton.Click += new System.EventHandler(this.DeletePartsButton_Click);
            // 
            // partSearchButton
            // 
            this.partSearchButton.Location = new System.Drawing.Point(318, 52);
            this.partSearchButton.Name = "partSearchButton";
            this.partSearchButton.Size = new System.Drawing.Size(102, 27);
            this.partSearchButton.TabIndex = 12;
            this.partSearchButton.Text = "Search";
            this.partSearchButton.UseVisualStyleBackColor = true;
            this.partSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // partSearchTextBox
            // 
            this.partSearchTextBox.Location = new System.Drawing.Point(443, 56);
            this.partSearchTextBox.Name = "partSearchTextBox";
            this.partSearchTextBox.Size = new System.Drawing.Size(140, 20);
            this.partSearchTextBox.TabIndex = 13;
            this.partSearchTextBox.TextChanged += new System.EventHandler(this.PartSearchTextBox_TextChanged);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(1118, 412);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductButton.TabIndex = 14;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(1199, 412);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProductButton.TabIndex = 15;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 475);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.partSearchTextBox);
            this.Controls.Add(this.partSearchButton);
            this.Controls.Add(this.deletePartsButton);
            this.Controls.Add(this.modifyPartsButton);
            this.Controls.Add(this.partsGridView);
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.addPartsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.productSearchTextBox);
            this.Controls.Add(this.productSearchButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPartsButton;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.Button modifyPartsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMax;
        private System.Windows.Forms.Button deletePartsButton;
        private System.Windows.Forms.DataGridView partsGridView;
        private System.Windows.Forms.Button partSearchButton;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button deleteProductButton;
    }
}

