using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPDCFacilityManager.Shared.Infrastructure.HttpDataService
{
    public interface IHttpUpdcDataClient
    {
        Task Login(string email, string password);
    }
}
