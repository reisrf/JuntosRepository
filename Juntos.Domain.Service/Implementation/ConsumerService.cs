using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.Domain.Services.Interfaces;
using Juntos.Infrastructure.Repository.Interfaces;

namespace Juntos.Domain.Service.Implementation
{
    public class ConsumerService  : PersonService<Consumer>, IConsumerService 
    {
        public ConsumerService(IConsumerRepository repository)
            : base(repository)
        {
        }


    }
}
