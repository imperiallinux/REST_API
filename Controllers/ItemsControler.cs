using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsControler : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsControler()
        {
            repository = new InMemItemsRepository();
        }

        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }
    }
}