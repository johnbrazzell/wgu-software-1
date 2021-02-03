using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1_Inventory_App
{
    public class InHouse : Part
    {
        private int _machineID;
        
        public int GetMachineID()
        {
            return _machineID;
        }

        public void SetMachineID(int machineID)
        {
            _machineID = machineID;
        }

        public InHouse()
        {

        }

        public InHouse(string name, int inventory, decimal price, int min, int max, int machineID)
        {
          
            GeneratePartID();
            SetName(name);
            SetStock(inventory);
            SetPrice(price);
            SetMin(min);
            SetMax(max);
            SetMachineID(machineID);

        }

        public InHouse(int partID, string name, int inventory, decimal price, int min, int max, int machineID)
        {
            SetPartID(partID);
            SetName(name);
            SetStock(inventory);
            SetPrice(price);
            SetMin(min);
            SetMax(max);
            SetMachineID(machineID);

        }
    }
}
