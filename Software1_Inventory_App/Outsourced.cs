using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1_Inventory_App
{
    public class Outsourced : Part
    {
        private string _companyName;
        //property CompanyName: string
        public string GetCompanyName()
        {
            return _companyName;
        }

        public void SetCompanyName(string companyName)
        {
            _companyName = companyName;
        }
        
        public Outsourced()
        {

        }
 

        public Outsourced(string name, int inventory, decimal price, int min, int max, string companyName)
        {
            GeneratePartID();
            this.SetName(name);
            this.SetStock(inventory);
            this.SetPrice(price);
            this.SetMin(min);
            this.SetMax(max);
            this.SetCompanyName(companyName);
        }

        public Outsourced(int partID, string name, int inventory, decimal price, int min, int max, string companyName)
        {
            SetPartID(partID);
            SetName(name);
            SetStock(inventory);
            SetPrice(price);
            SetMin(min);
            SetMax(max);
            SetCompanyName(companyName);
        }
    }
}
