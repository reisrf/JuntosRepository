using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.DAL.Interfaces;

namespace Juntos.DAL.Implementation
{
    public class CoordinateDao : IBaseDao<Coordinate>
    {

        public void Add(Coordinate entidade)
        {

            JuntosContext.Instance.coordinates.Add(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public void Update(Coordinate entidade)
        {
            JuntosContext.Instance.SaveChanges();
        }

        public void Delete(Coordinate entidade)
        {
            JuntosContext.Instance.coordinates.Remove(entidade);
            JuntosContext.Instance.SaveChanges();

        }

        public IEnumerable<Coordinate> ListByExpression(Func<Coordinate, bool> expressaoDeConsulta)
        {
            return JuntosContext.Instance.coordinates.Where(expressaoDeConsulta);
        }

        public List<Coordinate> ListAll()
        {

            return JuntosContext.Instance.coordinates.ToList();
        }

        public Coordinate ListById(long id)
        {

            return JuntosContext.Instance.coordinates.Where(a => a.Id == id).FirstOrDefault();

        }
    }
}
