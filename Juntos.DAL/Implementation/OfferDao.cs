using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.DAL.Interfaces;

namespace Juntos.DAL.Implementation
{
    public class OfferDao : IBaseDao<Offer>
    {
        public void Add(Offer entidade)
        {

            JuntosContext.Instance.offers.Add(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public void Update(Offer entidade)
        {
            JuntosContext.Instance.SaveChanges();
        }

        public void Delete(Offer entidade)
        {
            JuntosContext.Instance.offers.Remove(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public IEnumerable<Offer> ListByExpression(Func<Offer, bool> expressaoDeConsulta)
        {
            return JuntosContext.Instance.offers.Where(expressaoDeConsulta);
        }

        public List<Offer> ListAll()
        {

            return JuntosContext.Instance.offers.ToList();
        }

        public Offer ListById(long id)
        {

            return JuntosContext.Instance.offers.Where(a => a.Id == id).FirstOrDefault();

        }
        
        

    }
}
