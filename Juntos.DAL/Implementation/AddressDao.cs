using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.IDAL;

namespace Juntos.DAL.Implementation
{
    public class AddressDao : IBaseDao<Address>
    {

                  

        public void Add(Address entidade) 
        {

            JuntosContext.Instance.addresses.Add(entidade);
            JuntosContext.Instance.SaveChanges();
                   
        }

        public void Update(Address entidade) 
        {
            JuntosContext.Instance.SaveChanges();
        }

        public void Delete(Address entidade) 
        {
            JuntosContext.Instance.addresses.Remove(entidade);
            JuntosContext.Instance.SaveChanges();
        
        }

        public IEnumerable<Address> ListByExpression(Func<Address, bool> expressaoDeConsulta)
        { 
            return JuntosContext.Instance.addresses.Where(expressaoDeConsulta);
        }

        public List<Address> ListAll() 
        {

            return JuntosContext.Instance.addresses.ToList();
        }

        public Address ListById(long id) 
        {

            return JuntosContext.Instance.addresses.Where(a => a.Id == id).FirstOrDefault();
        
        }
    }
}
