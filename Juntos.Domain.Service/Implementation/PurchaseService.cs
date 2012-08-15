using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Services.Implementation;
using Juntos.Domain.Model;
using Juntos.Domain.Services.Interfaces;
using Juntos.Infrastructure.Repository.Interfaces;
namespace Juntos.Domain.Service.Implementation
{
    public class PurchaseService : BaseService<Purchase>, IPurchaseService
    {
        public PurchaseService(IPurchaseRepository repository)
            : base(repository)
        {
        }



    }
}
