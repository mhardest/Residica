using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Servicios.BLL
{
	internal sealed class LanguageManager
	{
		#region Singleton
		private readonly static LanguageManager _instance = new LanguageManager();

		public static LanguageManager Current
		{
			get
			{
				return _instance;
			}
		}

		private LanguageManager()
		{
			//Implement here the initialization code
		}
		#endregion

		public string Translate(string word)
		{
			//Apertura de archivos / Validar si la clave existe o no?

			string cultureInfo = Thread.CurrentThread.CurrentUICulture.Name;

			if (cultureInfo == "en-US")
			{
				StreamReader leer = new StreamReader(@"idioma.en-US");
				while(!leer.EndOfStream)
				{
					string dato = leer.ReadLine();
					int ubicacion = dato.IndexOf(":");
					string palabra = dato.Substring(0,ubicacion);
					if (palabra == word)
					{
						int inicio = ubicacion + 1;
						int fin = dato.Length;
						fin = fin - ubicacion - 1;
						return dato.Substring(inicio, fin);
					}
				}
				return word;
			}
			else
			{
				return word;
			}
		}

		public string Translate(string word, string cultureInfo)
		{
			//Apertura de archivos / Validar si la clave existe o no?
			if (cultureInfo == "en-US")
			{
				StreamReader leer = new StreamReader(@"idioma.en-US");
				return word;
			}
			else
			{
				return word;
			}
			
		}
	}
}
