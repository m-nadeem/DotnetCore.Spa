using Dotnet.Core.DomainModel.Models;
using Dotnet.Core.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet.Core.Service.Implementation
{
    public class StoreService: IStoreService
    {
        private static StoreModel[] storeModel = new[]
        {
            new StoreModel()
                {
                    Id = 1,
                    FirstName = "Merlina",
                    LastName= "Morlon",
                    Email = "mmorlon0@omniture.com",
                    Gender = "Female",
                    Phone = "876-952-6560",
                    Workplace = "Gabtune"
                },
                new StoreModel()
                {
                    Id = 2,
                    FirstName = "Freddie",
                    LastName = "Andretti",
                    Email = "fandretti1@sfgate.com",
                    Gender = "Male",
                    Phone = "601-202-6491",
                    Workplace = "Cogilith"
                },
                 new StoreModel()
                {
                    Id = 3,
                    FirstName = "Gerald",
                    LastName = "Newcombe",
                    Email = "gnewcombe2@addtoany.com",
                    Gender = "Male",
                    Phone = "583-756-2259",
                    Workplace = "Eabox"
                },
                  new StoreModel()
                {
                    Id = 4,
                    FirstName = "Tades",
                    LastName = "Hurleston",
                    Email = "thurleston3@cbc.ca",
                    Gender = "Male",
                    Phone = "845-701-4719",
                    Workplace = "Jaxworks"
                },
                   new StoreModel()
                {
                    Id = 5,
                    FirstName = "Karol",
                    LastName = "Muttitt",
                    Email = "kmuttitt4@fc2.com",
                    Gender = "Female",
                    Phone = "834-437-5578",
                    Workplace = "Youbridge"
                }
        };
        public IEnumerable<StoreModel> GetDataCollection()
        {
            return storeModel;
        }
    }
}
