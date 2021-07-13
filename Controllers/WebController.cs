using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ShoppingListApp.Models;

namespace ShoppingListApp.Controllers
{
    public class WebController : ApiController
    {
        private ShoppingRepository repo = ShoppingRepository.Current;

        public IEnumerable<ShoppingList> GetFullList() 
        {
            return repo.GetAll();
        }

        public ShoppingList GetRecord(int id) 
        {
            return repo.Get(id);
        }

        [HttpPost]
        public ShoppingList CreateRecord(ShoppingList item) 
        {
            return repo.Add(item);
        }

        //[HttpPut]
        //public ShoppingList UpdateRecord(ShoppingList item)
        //{
        //    return repo.Update(item);
        //}

        public void DeleteRecord(int id) 
        {
            repo.Remove(id);
        }

    }
}