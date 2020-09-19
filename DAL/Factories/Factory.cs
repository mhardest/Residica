using DAL.Contratos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factories
{
	public sealed class Factory
	{
		#region Singleton
		private readonly static Factory _instance = new Factory();

		public static Factory Current
		{
			get
			{
				return _instance;
			}
		}

		private Factory()
		{
			//Implement here the initialization code
		}
		#endregion
		/*
		public IGenericRepository<Customer> GetCustomerRepository()
		{
			//Reflection ->  Conocer la meta data de un determinado modelo binario -> .dll/.exe

			//PARAMETRIZACIÓN...
			string nombreNamespaceClaseAccesoDatos = ConfigurationManager.AppSettings["AccesoDatos"] + ".CustomerRepository"; //FullName

			//A partir de un string yo puedo obtener la instancia de un objeto dinámicamente...
			object instancia = Activator.CreateInstance(Type.GetType(nombreNamespaceClaseAccesoDatos));

			return instancia as IGenericRepository<Customer>;
		}
		*/
	}
}
