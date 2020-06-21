using DAL.Contratos;
using DAL.Tools;
using Dominio;
using Servicios.Dominio.Exceptions;
using Servicios.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Sql
{
    internal class CustomerRepository : IGenericRepository<Customer>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Customer] (FirstName, LastName, DateBirth, Doc, IdAddress) VALUES (@FirstName, @LastName, @DateBirth, @Doc, @IdAddress)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Customer] SET (FirstName= @FirstName, LastName=@LastName, DateBirth=@DateBirth, Doc=@Doc, IdAddress = @IdAddress) WHERE IdCustomer = @IdCustomer";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Customer] WHERE IdCustomer = @IdCustomer";
        }

        private string SelectOneStatement
        {
            get => "SELECT IdCustomer, FirstName, LastName, DateBirth, Doc, IdAddress FROM [dbo].[Customer] WHERE IdCustomer = @IdCustomer";
        }

        private string SelectAllStatement
        {
            get => "SELECT IdCustomer, FirstName, LastName, DateBirth, Doc, IdAddress FROM [dbo].[Customer]";
        }
        #endregion

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            try
            {
                
                List<Customer> customers = new List<Customer>();
                using (var dr = SqlHelper.ExecuteReader(SelectAllStatement, System.Data.CommandType.Text))
                {
                    Object[] values = new Object[dr.FieldCount];

                    while (dr.Read())
                    {
                        dr.GetValues(values);
                        //Adaptar los values que vienen en el array a un objeto Customer.
                        Customer c = new Customer();
                        c.FirstName = values[2].ToString();

                        customers.Add(c);
                    }
                }
                return customers;
            }
            catch (Exception ex)
            {
                FacadeServicio.ManejarExepciones(new DALException(ex));
                return null;
            }
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
