using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_exam
{
    // interface for inventory list
    internal interface IInventoryList
    {
        // list of compulsory method to implement
        void displayInventoryList();

        void searchInventoryByItemName(string itemName);

        void searchInventoryByCategory(int categoryId);

        void deleteInventoryItem(int itemId);
    }
}
