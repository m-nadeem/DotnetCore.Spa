using Dotnet.Core.DomainModel.Models;
using System.Collections.Generic;

namespace Dotnet.Core.Service.Contract
{
    public interface IStoreService
    {
        public IEnumerable<StoreModel> GetDataCollection();
    }
}
