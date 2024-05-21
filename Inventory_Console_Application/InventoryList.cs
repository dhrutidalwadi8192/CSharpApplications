using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_exam
{
    internal class InventoryList : List<Inventory>
    {

        // declare item array list
        public ArrayList itemList = new ArrayList();


        // default constructor - to set initial values
        public InventoryList()
        {
            // add defualt values in inventory list
            itemList.Add(new Inventory(1, "iphone 15", 2, 50, 0, "Mobile", 100));
            itemList.Add(new Inventory(2, "Samsumng Lite", 4, 100.43, 1, "TV", 400));
            itemList.Add(new Inventory(3, "Laptop", 2, 60, 2, "Laptop", 120));

        }

        // function to display room list
        public void displayInventoryList()
        {
            if(itemList.Count > 0)
            {
                // function to display items from given array list
                displayInventoryList(itemList);
            }
            else
            {
                Console.WriteLine("No Items Found");
            }
            

        }

        // function to display items from given array list
        public void displayInventoryList(ArrayList items)
        {
            int totalItems = items.Count;
            int totalQuantities = 0;
            double totalPrice = 0;


            foreach (var item in items.Cast<Inventory>())
            {

               
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Item Id : {item.itemId}");
                Console.WriteLine($"Item Name : {item.itemName}");
                Console.WriteLine($"Quantity  : {item.quantity}");
                Console.WriteLine($"Unit Price : {item.pricePerUnit}");
                Console.WriteLine($"Category : {item.categoryName}");

                // calculate total price and quantity
                Console.WriteLine($"Total Price : {item.totalPrice.ToString("F2")}");
                totalQuantities += item.quantity;
                totalPrice += item.totalPrice;
            }

            Console.WriteLine("\n--------------- INVENTORY SUMMARY -------------------");
            Console.WriteLine("\n");
            Console.WriteLine($"Total Items in Inventory : {totalItems}");
            Console.WriteLine($"Total Items Quantity : {totalQuantities}");


            Console.WriteLine($"Total Price : {totalPrice.ToString("F2")}");

        }

        // function to search inventory by item name
        public void searchInventoryByItemName(string itemName)
        {
            // declare filtered array list
            ArrayList filteredInventory = new ArrayList();

            foreach (var item in itemList.Cast<Inventory>())
            {
                // search item by item name
                if (item.itemName.ToLower() == itemName.ToLower())
                {
                    filteredInventory.Add(item);
                }
            }

            // if items found then display it
            if (filteredInventory.Count > 0)
            {
                displayInventoryList(filteredInventory);
            }
            else
            {
                Console.WriteLine($"--------No Items found with : {itemName} ----");
            }

        }


        // function to search inventory by category id
        public void searchInventoryByCategory(int selectedCategoryId)
        {
            Category category = new Category();
            ArrayList filteredInventory = new ArrayList();
            // search item by category
            foreach (var item in itemList.Cast<Inventory>())
            {
                if (item.categoryId == selectedCategoryId)
                {
                    filteredInventory.Add(item);
                }
            }
            // if items found then display it
            if (filteredInventory.Count > 0)
            {
                displayInventoryList(filteredInventory);
            }
            else
            {
                Console.WriteLine($"-----No Items found with : {category.getCategoryName(selectedCategoryId)}----");
            }
        }

        // function to delete inventory item by item id
        public void deleteInventoryItem(int itemId)
        {
            int itemIndexToDelete = -1;
            // find index of item to remove based on item id
            for (int i = 0; i < itemList.Count; i++)
            {
                Inventory item = (Inventory)itemList[i];
                if (item.itemId == itemId)
                {
                    itemIndexToDelete = i;
                    break;

                }

            }
            if(itemIndexToDelete > -1)
            {
                itemList.RemoveAt(itemIndexToDelete);
                Console.WriteLine("Item removed from the inventory");
            }
            else
            {
                Console.WriteLine("--------Item Not Found-----");
            }

        }

        // function to clear inventory
        public void clearInventory()
        {
            this.itemList.Clear();
        }

    }
}
