using System;
using System.Collections.Generic;

namespace Juntos.IDAL
{
    public interface IBaseDao<TEntidade>
    {
        void Add(TEntidade entidade);

        void Update(TEntidade entidade);

        void Delete(TEntidade entidade);

        IEnumerable<TEntidade> ListByExpression(Func<TEntidade, bool> expressaoDeConsulta);

        List<TEntidade> ListAll();

        TEntidade ListById(long id);

    }
}
