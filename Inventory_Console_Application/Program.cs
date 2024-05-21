using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace midterm_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("-------------Electronic Store Inventory Management Store------------------");
                Console.WriteLine("\n");
                // instantiate classes
                InventoryList inventories = new InventoryList();
                Category category = new Category();
                Store store = new Store();
                // function to display Store Details
                store.displayStoreDetails();
                // set variable to keep track of item ids in inventory to use it for deleting records
                int lastInventoryId = inventories.itemList.Count;
                // function call to open menu
                openMenu();



                // function to add item in inventory
                void addItemToInventrory()
                {
                    Inventory inventory = new Inventory();
                    inventory.itemId = lastInventoryId + 1;
                    lastInventoryId = inventory.itemId;
                    Console.WriteLine("\n Add New Inventry Item");
                    Console.Write("Item Name : ");
                    inventory.itemName = Console.ReadLine();

                    // ask user to add quantity until he adds valid
                    bool isValidQuantity = true;
                    do
                    {
                        Console.Write("Quantity: ");
                        int quantity;

                        isValidQuantity = int.TryParse(Console.ReadLine(), out quantity);
                        // function call to check if user has entered valid guest id
                        if (isValidQuantity)
                        {
                            inventory.quantity = quantity;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid quantity");
                        }

                    } while (!isValidQuantity);


                    // ask user to add unit price until he adds valid
                    bool isValidUnitPrice = true;
                    do
                    {
                        Console.Write("Unit Price : ");
                        double unitPrice;

                        isValidQuantity = double.TryParse(Console.ReadLine(), out unitPrice);
                        // function call to check if user has entered valid guest id
                        if (isValidQuantity)
                        {
                            inventory.pricePerUnit = unitPrice;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid Unit Price");
                        }

                    } while (!isValidQuantity);


                    // ask user to select item category until he adds valid
                    bool isValidCategory = true;
                    do
                    {
                        Console.WriteLine("Select Numer Corresponding to Category: ");
                        category.displayCategories();
                        string selectedCategory = Console.ReadLine();
                        // function to check if valid category selected by user
                        isValidCategory = category.validateCategory(selectedCategory);
                        if (isValidCategory)
                        {
                            inventory.categoryId = int.Parse(selectedCategory);
                            // fetch category name and store it
                            inventory.categoryName = category.getCategoryName(inventory.categoryId);
                        }
                        else
                        {
                            Console.WriteLine("\nYou have selected wrong option for category, Please Try Again!!");
                        }

                    } while (!isValidCategory);

                    // calculate total item price
                    inventory.totalPrice = inventory.getTotalPrice(inventory.quantity, inventory.pricePerUnit);
                    inventories.itemList.Add(inventory);


                }


                // function to display inventory
                void displayInventrory()
                {
                    // call class function to display inventory list
                    inventories.displayInventoryList();

                }

                // function to search inventory by name
                void searchInventoryByItemName()
                {
                    Console.WriteLine("Enter an item name that you want to search");
                    string itemName = Console.ReadLine();
                    // class function call
                    inventories.searchInventoryByItemName(itemName);

                }

                // function to search inventory item by category id
                void searchInventoryByCategory()
                {
                    bool isValidCategory = true; ;
                    do
                    {
                        Console.WriteLine("Please select a category to search (Add corresponding number to category)");
                        category.displayCategories();
                        string selectedCategory = Console.ReadLine();
                        isValidCategory = category.validateCategory(selectedCategory);
                        if (isValidCategory)
                        {
                            // class function call
                            inventories.searchInventoryByCategory(int.Parse(selectedCategory));
                        }
                        else
                        {
                            Console.WriteLine("please Enter Valid Category Number");
                        }

                    } while (!isValidCategory);





                }

                // function to delete inventory item by item Id
                void deleteInventoryItem()
                {
                    bool isValidItemNo = true;
                    do
                    {
                        Console.WriteLine("Enter Item ID To Delete");
                        string selectedItemNo = Console.ReadLine();
                        int itemId;
                        isValidItemNo = int.TryParse(selectedItemNo, out itemId);
                        if (isValidItemNo)
                        {
                            // class function call to delete inventory item 
                            inventories.deleteInventoryItem(itemId);

                        }
                        else
                        {
                            Console.WriteLine("please Enter Valid Item No");
                        }

                    } while (!isValidItemNo);


                }


                // function to clear inventory items
                void clearInventory()
                {
                    inventories.clearInventory();
                }






                // function to display menu
                void openMenu()
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("Choose an option below");
                        Console.WriteLine("1. Add a New Item To Inventory\r\n2. Display Inventory Items\r\n3. Search Inventory\r\n4. Display Item By Category \r\n5. Delete Item From Inventory\r\n6. Clear Inventory\r\n7. Exit\n");
                        string userChoice = Console.ReadLine();
                        switch (userChoice)
                        {
                            case "1":
                                addItemToInventrory();
                                openMenu();
                                break;
                            case "2":
                                displayInventrory();
                                openMenu();
                                break;
                            case "3":
                                searchInventoryByItemName();
                                openMenu();
                                break;
                            case "4":
                                searchInventoryByCategory();
                                openMenu();
                                break;
                            case "5":
                                deleteInventoryItem();
                                openMenu();
                                break;
                            case "6":
                                clearInventory();
                                openMenu();
                                break;
                            case "7":
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("You have selected wrong option");
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }






    }
    }
