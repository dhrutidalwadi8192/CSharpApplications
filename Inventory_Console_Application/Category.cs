using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_exam
{

    internal class Category
    {
        enum ItemCategory
        {
            Mobile,
            TV,
            Laptop
        }

        public void displayCategories()
        {

            // iterate on guest category enum and display category id and name
            foreach (int i in Enum.GetValues(typeof(ItemCategory)))
            {
                Console.WriteLine($"{i}. {Enum.GetName(typeof(ItemCategory), i)}");
            }
        }



        // function to get category name from category Id
        public string getCategoryName(int categoryId)
        {
            return Enum.GetName(typeof(ItemCategory), categoryId);
        }



        // function to check if entered category option by user is valid or not
        public bool validateCategory(string selectedCategory)
        {
            int categoryId;
            // check if entered value is a valid number
            if (int.TryParse(selectedCategory, out categoryId))
            {
                // if id found in guest category enum then return true
                return Enum.IsDefined(typeof(ItemCategory), categoryId);
            }
            else
            {
                return false;
            }

        }
    }
}
