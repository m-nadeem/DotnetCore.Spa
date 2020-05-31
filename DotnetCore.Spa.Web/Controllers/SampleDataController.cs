using System.Collections.Generic;
using System.Linq;
using Dotnet.Core.DomainModel.Models;
using Dotnet.Core.Service.Contract;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.Spa.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleDataController : ControllerBase
    {
        private readonly IStoreService storeService;
        public SampleDataController(IStoreService dataCollection)
        {
            storeService = dataCollection;
        }

        [HttpGet("getContacts")]
        public IEnumerable<StoreModel> getContacts()
        {
            return storeService.GetDataCollection();
        }

        [HttpGet("getContact")]
        public StoreModel getContact([FromQuery] int id)
        {
            return storeService.GetDataCollection().FirstOrDefault(d => d.Id == id);
        }
    }
}
