using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contratos
{
    public interface IGenericRepository<T> where T : class, new()
    {
        void Insert(T o);

        void Update(T o);

        void Delete(Guid id);

        IEnumerable<T> GetAll();

        T GetOne(Guid id);
    }
}
