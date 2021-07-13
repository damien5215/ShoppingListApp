using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingListApp.Models
{
    public class ShoppingRepository
    {
        private static ShoppingRepository repo = new ShoppingRepository();

        public static ShoppingRepository Current 
        {
            get { return repo; }
        }

        private List<ShoppingList> data = new List<ShoppingList>
        {
            new ShoppingList
            {
                ShoppingListId = 1,
                ProductName = "Bread",
                Quantity = 1
            },
            new ShoppingList
            {
                ShoppingListId = 2,
                ProductName = "Milk",
                Quantity = 2
            },
            new ShoppingList
            {
                ShoppingListId = 3,
                ProductName = "Pancakes",
                Quantity = 2
            }
        };

        public IEnumerable<ShoppingList> GetAll() 
        {
            return data;
        }

        public ShoppingList Get(int id) 
        {
            return data
                .Where(r => r.ShoppingListId == id)
                .FirstOrDefault();
        }

        public ShoppingList Add(ShoppingList item) 
        {
            item.ShoppingListId = data.Count + 1;
            data.Add(item);
            return item;
        }

        public void Remove(int id) 
        {
            ShoppingList item = Get(id);
            if(item != null) 
            {
                data.Remove(item);
            }
        }

        public bool Update(ShoppingList item)
        {
            ShoppingList storedItem = Get(item.ShoppingListId);

            if (storedItem != null)
            {
                storedItem.ProductName = item.ProductName;
                storedItem.Quantity = item.Quantity;
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}