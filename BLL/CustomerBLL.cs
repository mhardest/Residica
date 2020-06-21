using DAL.Factories;
using Dominio;
using Servicios.Dominio.Exceptions;
using Servicios.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public sealed class CustomerBLL
    {
		#region Singleton
		private readonly static CustomerBLL _instance = new CustomerBLL();

		public static CustomerBLL Current
		{
			get
			{
				return _instance;
			}
		}

		private CustomerBLL()
		{
			//Implement here the initialization code
		}
		#endregion

		public IEnumerable<Customer> GetAll()
		{
			try
			{
				//FacadeServicio.Write("Estor pasando por el getall", System.Diagnostics.Tracing.EventLevel.Informational);


				//throw new ClienteMenorEdadException(); //Exception esperadas por el negocio...


				int number = 0;
				int total = 7 / number;

				return Factory.Current.GetCustomerRepository().GetAll();
			}
			catch (BLLException ex)
			{
				FacadeServicio.ManejarExepciones(ex);
				return null;
			}
			catch (Exception ex)
			{
				/*if(ex is BLLException)
					FacadeService.ManageException(ex);
				else
					FacadeService.ManageException(new BLLException(ex));*/

				FacadeServicio.ManejarExepciones(new BLLException(ex));
				return null;
			}
		}
	}
}
