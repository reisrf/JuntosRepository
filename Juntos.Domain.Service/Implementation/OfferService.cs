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
    public class OfferService : BaseService<Offer>, IOfferService 
    {
        public OfferService(IOfferRepository repository)
            : base(repository)
        {
        }


        public void Publish(long idOferta)
        {
            Offer offer = this.Repository.FindById(idOferta);

            if (offer.status == OfferStatus.Created)
            {
                offer.Publish();
                this.Repository.Update(offer);
            }
            

           

        }

        public void Finalize(long idOferta)
        {
            Offer offer = this.Repository.FindById(idOferta);
            if (offer.status != OfferStatus.Ended) 
            {
                offer.End();
                this.Repository.Update(offer);
            }
        }

    }
}
