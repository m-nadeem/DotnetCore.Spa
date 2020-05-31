using Dotnet.Core.DomainModel.Models;
using Dotnet.Core.Service.Contract;
using NUnit.Framework;
using System.Linq;

namespace Dotnet.Core.Tests.Services
{
    class StoreTests
    {
        private readonly IStoreService _service;

        private static readonly StoreModel sampleData = new StoreModel()
        {
            Id = 1,
            FirstName = "Merlina",
            LastName = "Morlon",
            Email = "mmorlon0@omniture.com",
            Gender = "Female",
            Phone = "876-952-6560",
            Workplace = "Gabtune"
        };

        [Test]
        public void can_return_collection()
        {
            var incomingData = _service.GetDataCollection();
            Assert.AreEqual(incomingData.First().Id, sampleData.Id);
        }
    }
}
