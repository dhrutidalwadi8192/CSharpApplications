using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_exam
{


    internal class Inventory
    {
        // class variables
        public int itemId = 0;
        public string itemName = string.Empty;
        public int quantity = 0;
        public double pricePerUnit = 0;
        public string categoryName = string.Empty;
        public int categoryId = 0;
        public double totalPrice = 0;

        // default constructor
        public Inventory() { }

        // constructor to initialize hard coded values
        public Inventory(int itemId, string itemName, int quantity, double pricePerUnit, int categoryId, string categoryName,double totalPrice)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.quantity = quantity;
            this.pricePerUnit = pricePerUnit;
            this.categoryName = categoryName;
            this.categoryId = categoryId;
            this.totalPrice = totalPrice;
        }

        // function to get total price
        public double getTotalPrice(int quantity,double pricePerUnit)
        {
            return quantity* pricePerUnit;
        }


    }
}
