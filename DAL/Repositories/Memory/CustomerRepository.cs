using DAL.Contratos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Memory
{
    internal class CustomerRepository : IGenericRepository<Customer>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer o)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer o)
        {
            throw new NotImplementedException();
        }
    }
}
