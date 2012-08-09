using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.IDAL;

namespace Juntos.DAL.Implementation
{
    public class PersonDao : IBaseDao<Person>
    {
        public void Add(Person entidade)
        {

            JuntosContext.Instance.persons.Add(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public void Update(Person entidade)
        {
            JuntosContext.Instance.SaveChanges();
        }

        public void Delete(Person entidade)
        {
            JuntosContext.Instance.persons.Remove(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public IEnumerable<Person> ListByExpression(Func<Person, bool> expressaoDeConsulta)
        {
            return JuntosContext.Instance.persons.Where(expressaoDeConsulta);
        }

        public List<Person> ListAll()
        {

            return JuntosContext.Instance.persons.ToList();
        }

        public Person ListById(long id)
        {

            return JuntosContext.Instance.persons.Where(a => a.Id == id).FirstOrDefault();

        }
        
        
    }
}
