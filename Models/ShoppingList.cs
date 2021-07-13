using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingListApp.Models
{
    public class ShoppingList
    {
        public int ShoppingListId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}