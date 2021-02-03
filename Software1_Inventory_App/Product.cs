using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1_Inventory_App
{
    public class Product
    {
        private static int ProductID = 0;
        private int _productID;
        private List<Part> _associatedPartsList = new List<Part>();
        //property AssociatedParts: BindingList<Part> or could be a List<Part> 
        //each product should store its own list
        //when looking up a product just get the list from the product and display it
        public List<Part> AssociatedParts
        {
            get { return _associatedPartsList; }
            set { _associatedPartsList = value; }
        }

   
        //property ProductID: int
        public int GetProductID()
        {
            return _productID;
        }

        public void SetProductID(int productID)
        {
            _productID = productID;
        }

        public void GenerateProductID()
        {
            _productID = ProductID;
            ++ProductID;
        }

        //property Name: string
        public string Name { get; set; }
        //property Price: decimal
        public decimal Price { get; set; }
        //property InStock: int
        public int InStock { get; set; }
        //property Min: int
        public int Min { get; set; }
        //property Max: int
        public int Max { get; set; }

        public Product()
        {
            GenerateProductID();
        }

        public Product(string name, decimal price, int stock, int min, int max, List<Part> associatedParts)
        {
            GenerateProductID();
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
            AssociatedParts = associatedParts;
        }
        //function AddAssociatedPart(Part): void
        public void AddAssociatedPart(Part part)
        {
            if (part.GetType() == typeof(InHouse))
            {
                InHouse newPart = part as InHouse;
                _associatedPartsList.Add(newPart);
            }
            else if (part.GetType() == typeof(Outsourced))
            {
                Outsourced newPart = part as Outsourced;
                _associatedPartsList.Add(newPart);
            }
        }
        //function RemoveAssociatedPart(int): bool
        public bool RemoveAssociatedPart(int removePart)
        {
            return false;
        }
        //function LookupAssociatedPart(int): part
        public Part LookUpAssociatedPart(int partID)
        {
            foreach(Part part in AssociatedParts)
            {
                if(part.GetPartID() == partID)
                {
                    return part;
                }
            }

            return null;
        }
    }
}
