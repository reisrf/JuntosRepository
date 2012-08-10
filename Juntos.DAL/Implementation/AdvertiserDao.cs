using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.DAL.Interfaces;


namespace Juntos.DAL.Implementation
{
    public class AdvertiserDao : IBaseDao<Advertiser>
    {
        public void Add(Advertiser entidade)
        {

            JuntosContext.Instance.advertisers.Add(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public void Update(Advertiser entidade)
        {
            JuntosContext.Instance.SaveChanges();
        }

        public void Delete(Advertiser entidade)
        {
            JuntosContext.Instance.advertisers.Remove(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public IEnumerable<Advertiser> ListByExpression(Func<Advertiser, bool> expressaoDeConsulta)
        {
            return JuntosContext.Instance.advertisers.Where(expressaoDeConsulta);
        }

        public List<Advertiser> ListAll()
        {

            return JuntosContext.Instance.advertisers.ToList();
        }

        public Advertiser ListById(long id)
        {

            return JuntosContext.Instance.advertisers.Where(a => a.Id == id).FirstOrDefault();

        }
    }
}
