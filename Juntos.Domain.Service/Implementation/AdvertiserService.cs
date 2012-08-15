using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.Domain.Services.Interfaces;
using Juntos.Infrastructure.Repository.Interfaces;

namespace Juntos.Domain.Service.Implementation
{
    public class AdvertiserService : PersonService<Advertiser>, IAdvertiserService 
    {
        public AdvertiserService(IAdvertiserRepository repository) : base(repository)
        {
        }
    }
 }
