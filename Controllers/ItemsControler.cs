using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsControler : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsControler()
        {
            
        }
    }
}