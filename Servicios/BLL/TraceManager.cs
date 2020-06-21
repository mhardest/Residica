using Servicios.Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Servicios.Dominio.Security.Composite;

namespace Servicios.BLL
{
	public sealed class TraceManager
	{
		#region Singleton
		private readonly static TraceManager _instance = new TraceManager();

		public static TraceManager Current
		{
			get
			{
				return _instance;
			}
		}

		private TraceManager()
		{
			//Implement here the initialization code
		}
		#endregion

		public void Write(string message, EventLevel e, Usuario user = null)
		{
			using (System.IO.StreamWriter file =
		   new System.IO.StreamWriter(@"C:\LogResidica.txt", true))
			{
				file.WriteLine("Exception: " + message + ", Tipo Exception: " + e + ", Usuario: " + user);
			}
		}

		private void Write(string message, EventLevel e)
		{
			using (StreamWriter file = new System.IO.StreamWriter(@"C:\LogResidica.txt", true))
			{
				file.WriteLine("Exception: " + message + ", Tipo Exception: " + e);
			}	
		}
	}
}
