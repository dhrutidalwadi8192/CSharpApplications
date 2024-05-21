using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_exam
{
    internal class Store
    {
        // class variables
        string storeName = String.Empty;
        string storeAddress = String.Empty;
        string ownerFirstName = String.Empty;
        string ownerLastName = String.Empty;
        InventoryList inventoryList = new InventoryList();

        // default Constructor
        public Store()
        {
            this.storeName = "Dhruti Electronic Store";
            this.storeAddress = "129,Bold Street, Hamilton, L8P 4R1";
            this.ownerFirstName = "Dhrutiben";
            this.ownerLastName = "Dalwadi";
        }


        // method to display Store Details
        public void displayStoreDetails() {
            try {
                Console.WriteLine("----------------STORE DETAILS----------------");
                Console.WriteLine($"Store Name : {this.storeName}");
                Console.WriteLine($"Address : {this.storeAddress}");
                Console.WriteLine($"Owner Name : {this.ownerFirstName} {this.ownerLastName}");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Current Inventory List :");
                inventoryList.displayInventoryList();
            }
            catch(Exception e)

            {
                Console.WriteLine(e.Message);
            }
           


        }

    }
}
