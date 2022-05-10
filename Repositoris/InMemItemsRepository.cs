using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public class InMemItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id= Guid.NewGuid(), Name = "Potion", Price = 9, CreateData = DateTimeOffset.UtcNow},
            new Item { Id= Guid.NewGuid(), Name = "Iron", Price = 19, CreateData = DateTimeOffset.UtcNow},
            new Item { Id= Guid.NewGuid(), Name = "Shild", Price = 29, CreateData = DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem (Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }
        
    }
}