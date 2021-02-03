using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1_Inventory_App
{
    public abstract class Part
    {
        private static int PartID = 0;
        private int _partID;
        private string _name;
        private decimal _price;
        private int _inStock;
        private int _min;
        private int _max;

        //property PartID: int
        public int GetPartID()
        {
            return _partID;
        }

        public void SetPartID(int partID)
        {
            _partID = partID;
        }
        public void GeneratePartID()
        {
          
            _partID = PartID;
            ++PartID;
            //return PartID;
        }
        ////property Name: string
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        //property Price: decimal
        public decimal GetPrice()
        {
            return _price;
        }

        public void SetPrice(decimal price)
        {
            _price = price;
        }
        //property InStock: int
        public int GetStock()
        {
            return _inStock;
        }

        public void SetStock(int inStock)
        {
            _inStock = inStock;
        }

        //property Min: int
        public int GetMin()
        {
            return _min;
        }

        public void SetMin(int min)
        {
            _min = min;
        }
        //property Max: int
        public int GetMax()
        {
            return _max;
        }

        public void SetMax(int max)
        {
            _max = max;
        }
    }
}
