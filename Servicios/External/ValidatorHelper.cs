using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Servicios.External
{
    //2,147,483,647 (0x7FFFFFFF) a -2,147,483,648 (0x80000000.)
    #region Enum ...
    /// <summary>
    ///   Tipos de Validaciones Numericas.
    /// </summary>
    public enum ValidateDateEnum : int
    {
        /// <summary>Formato YYYY/MM/DD</summary>
        YYYYMMDD = 0,
        /// <summary>Formato DD/MM/YYYY</summary>
        DDMMYYYY = 1
    }

    /// <summary>
    ///   Tipos de Validaciones Numericas.
    /// </summary>
    public enum ValidateNumbersEnum : int
    {
        // NUMBER es viejo. Usar Digit, Int o Decimal

        /// <summary>
        /// Number: Contiene Digitos [0123546789], punto decimal, y el signo - al principio si es negativo.
        /// No contiene comas ni comienza o termina con un punto.
        /// </summary>
        Number = 0,
        /// <summary>NumberPositive: Contiene Digitos [0123546789], punto decimal, y el signo - al principio si es negativo.</summary>
		NumberPositive = 1,
        /// <summary>NumberPositiveZero: Contiene Digitos [0123546789], punto decimal, y el signo - al principio si es negativo. Puede Contener Cero.</summary>
		NumberPositiveZero = 2,
        /// <summary>NumberNegative</summary>
		NumberNegative = 3,
        /// <summary>NumberNegativeZero</summary>
		NumberNegativeZero = 4,
        /// <summary>Digit: Contiene solo Digitos [0123546789] (no punto decimal) y si es negativo, el signo - al principio. Puede Contener Cero.</summary>
		Digit = 5,
        /// <summary>DigitPositive: Contiene solo Digitos [0123546789] (no punto decimal).</summary>
		DigitPositive = 6,
        /// <summary>DigitPositiveZero: Contiene solo Digitos [0123546789] (no punto decimal). Puede Contener Cero.</summary>
		DigitPositiveZero = 7,
        /// <summary>DigitNegative: Contiene solo Digitos [0123546789] (no punto decimal) y - al principio.</summary>
		DigitNegative = 8,
        /// <summary>DigitNegativeZero: Contiene solo Digitos [0123546789] (no punto decimal) y - al principio. Puede Contener Cero.</summary>
		DigitNegativeZero = 9,
        /// <summary>Int: Contiene solo Digitos [0123546789] (no punto decimal) y si es negativo, el signo - al principio. Puede Contener Cero.</summary>
		Int = 10,
        /// <summary>IntPositive: Contiene solo un numero Entero (Int32 del Framework -2147483647 a 2147483647) (sin punto decimal).</summary>
		IntPositive = 11,
        /// <summary>IntPositiveZero: Contiene solo un numero Entero (Int32 del Framework) (sin punto decimal). Puede Contener Cero.</summary>
		IntPositiveZero = 12,
        /// <summary>IntNegative: Contiene solo un numero Entero (Int32 del Framework) (sin punto decimal) y - al principio.</summary>
		IntNegative = 13,
        /// <summary>IntNegativeZero: Contiene solo un numero Entero (Int32 del Framework) (sin punto decimal) y - al principio. Puede Contener Cero.</summary>
		IntNegativeZero = 14,
        /// <summary>
        /// Double: Contiene Digitos [0123546789], punto decimal, y el signo - al principio si es negativo.
        /// No contiene comas ni comienza o termina con un punto.
        /// </summary>
        Double = 15,
        /// <summary>DoublePositive: Contiene Digitos [0123546789], punto decimal, y el signo - al principio si es negativo.</summary>
        DoublePositive = 16,
        /// <summary>DoublePositiveZero: Contiene Digitos [0123546789], punto decimal, y el signo - al principio si es negativo. Puede Contener Cero.</summary>
        DoublePositiveZero = 17,
        /// <summary>DoubleNegative: </summary>
        DoubleNegative = 18,
        /// <summary>DoubleNegativeZero: </summary>
        DoubleNegativeZero = 19
    };
    /// <summary>
    ///   Tipos de Validaciones Alfanumericas.
    /// </summary>
    public enum ValidateStringsEnum : int
    {
        /// <summary>Alpha: Solo los caracteres a-z, A-Z</summary>
		Alpha = 0,
        /// <summary>AlphaSpace: Solo los caracteres a-z, A-Z y Space</summary>
		AlphaSpace = 1,
        /// <summary>AlphaNum: Solo los caracteres a-z, A-Z y 0-9</summary>
		AlphaNum = 2,
        /// <summary>AlphaNumSpace: Solo los caracteres a-z, A-Z, 0-9 y Espacio</summary>
		AlphaNumSpace = 3,
        /// <summary>Email: Email segun la norma RFC822</summary>
		Email = 4,
        /// <summary>IP: Solamente direcciones IP [0-255].[0-255].[0-255].[0-255] </summary>
		IP = 5,
        /// <summary>URL: Solamente Url's</summary>
		URL = 6,
        /// <summary>Hour: Una hora que este entre 00:00 and 23:59. Se debe incluir los 0 (Ceros).</summary>
		Hour = 7,
        /// <summary>String: Sin validacion.</summary>
		String = 8,
        /// <summary>OnlyNumbers: Solo los caracteres 0-9.</summary>
        OnlyNumbers = 9,
        /// <summary>EmailDelimited: Emails segun la norma RFC822, separados por puntos y comas(;)</summary>
        EmailDelimited = 13,
        //		/// <summary>Date: Valida si es una Fecha (sin la hora).</summary>
        //		Date			= 10
        //		/// <summary>Time: Valida si es una Fecha (sin la hora).</summary>
        //		Time			= 11,
        //		/// <summary>DateTime: Valida si es una Fecha (sin la hora).</summary>
        //		DateTime		= 12
        /// <summary>Telephone: Numeros telefonicos con espaciosm quiones, barras etc.. puntos.</summary>
        Telephone = 14,
        /// <summary />
        EmailTest = 15,
        /// <summary>EmailDelimited: Emails segun la norma RFC822, separados por puntos y comas(;)</summary>
        GUID = 16,
        /// <summary>Hour12: Una hora que este entre 00:00 and 11:59. Se debe incluir los 0 (Ceros).</summary>
        Hour12 = 17,
        /// <summary>Patente: 3 Letras y 3 numeros.</summary>
        Patente = 18,
        /// <summary>Patente 2016 "AUTO": 2 Letras , 3 numeros y 2 Letras.</summary>
        PatenteNuevaAutomovil = 19


    }


    #endregion

    /// <summary>
    /// La Clase ValidatorHelper Encapsula metodos comunes a la validacion de Tipos de Datos.
    /// </summary>
    public sealed class ValidatorHelper
    {

        #region Constructor ...
        /// <summary>
        /// Constructor privado de la Clase estatica. 
        /// </summary>
        private ValidatorHelper() { }
        #endregion

        /// <summary>
        /// Valida un string y su extension
        /// </summary>
        /// <param name="strValue"></param>
        /// <param name="intType"></param>
        /// <param name="blnRequired">Obligatorio</param>
        /// <param name="dblMinimo">Mínima longitud incluyente</param>
        /// <param name="dblMaximo">Máxima longitud incluyente</param>
        /// <returns>True si es válido</returns>
        public static bool ValidateString(string strValue, ValidateStringsEnum intType, bool blnRequired, double dblMinimo, double dblMaximo)
        {
            bool blnReturnValue;

            blnReturnValue = ValidateString(strValue, intType, blnRequired);
            if (blnReturnValue)
            {
                if (blnRequired)
                {
                    // valido min y max valor
                    if (strValue.Length > dblMaximo)
                    {
                        blnReturnValue = false;
                    }
                    if (strValue.Length < dblMinimo)
                    {
                        blnReturnValue = false;
                    }
                }
            }
            return blnReturnValue;
        }

        /// <summary>
        /// Valida un string
        /// </summary>
        /// <param name="strValue"></param>
        /// <param name="intType"></param>
        /// <param name="blnRequired">Obligatorio</param>
        /// <returns>True si es válido</returns>
        public static bool ValidateString(string strValue, ValidateStringsEnum intType, bool blnRequired)
        {
            Regex reg;
            string strPattern = "";

            // No puso Nada.
            if ((strValue == null) || (strValue.Length == 0))
            {
                // Es Requerido.
                if (blnRequired)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            switch (intType)
            {
                //((\(\d{3,4}\)|\d{3,4}-)\d{4,9}(-\d{1,5}|\d{0}))|(\d{4,12}) Telephone

                case ValidateStringsEnum.Hour:
                    strPattern = @"^([0-1][0-9]|2[0-3]):[0-5][0-9]$";
                    break;
                case ValidateStringsEnum.Hour12:
                    strPattern = @"^([0-1][0-9]|1[0-1]):[0-5][0-9]$";
                    break;
                case ValidateStringsEnum.Alpha:
                    strPattern = @"^[a-zA-ZñÑáÁéÉíÍóÓúÚ]+$";
                    break;
                case ValidateStringsEnum.AlphaSpace:
                    strPattern = @"^[a-zA-Z ñÑáÁéÉíÍóÓúÚ]+$";
                    break;
                case ValidateStringsEnum.AlphaNum:
                    strPattern = @"^[a-zA-Z0-9ñÑáÁéÉíÍóÓúÚ]+$";
                    break;
                case ValidateStringsEnum.AlphaNumSpace:
                    strPattern = @"^[a-zA-Z0-9 ñÑáÁéÉíÍóÓúÚ]+$";
                    break;
                case ValidateStringsEnum.Email:
                    //if (true) {
                    strPattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                    //} else {

                    //    //Este patron es mejor, pues valida el siguiente email :"benjamintrombetta.@hotmail.com"
                    //    strPattern = 
                    //        @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" +
                    //        @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." +
                    //        @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" +
                    //        @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
                    //}
                    break;
                case ValidateStringsEnum.EmailTest:

                    //Este patron es mejor, pues valida el siguiente email :"benjamintrombetta.@hotmail.com"
                    strPattern =
                        @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" +
                        @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." +
                        @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" +
                        @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

                    break;
                case ValidateStringsEnum.IP:
                    strPattern = @"^\b((25[0-5]|2[0-4]\d|[01]\d\d|\d?\d)\.){3}(25[0-5]|2[0-4]\d|[01]\d\d|\d?\d)\b$";
                    break;
                case ValidateStringsEnum.URL:
                    //strPattern = @"^((((https?|ftps?|gopher|telnet|nntp)://)|(mailto:|news:))(%[0-9A-Fa-f]{2}|[-()_.!~*';/?:@&=+$,A-Za-z0-9])+)([).!';/?:,][[:blank:]])?$";
                    strPattern = @"^((http|ftp|https|www)://)?([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$";


                    break;
                case ValidateStringsEnum.String:
                    return true;
                case ValidateStringsEnum.OnlyNumbers:
                    strPattern = @"^[0-9]+$";
                    break;
                //				case ValidateStringsEnum.Date:
                //					strPattern = @"/^\d{1,2}(\-|\/|\.)\d{1,2}\1\d{4}$/"
                case ValidateStringsEnum.Telephone:
                    strPattern = @"^[0-9 \-().\/]+$";
                    break;
                case ValidateStringsEnum.GUID:
                    strPattern = @"^(\{){0,1}[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}(\}){0,1}$";
                    break;
                case ValidateStringsEnum.Patente:
                    strPattern = @"^[a-zA-Z][a-zA-Z][a-zA-Z][0-9][0-9][0-9]+$";
                    break;
                case ValidateStringsEnum.PatenteNuevaAutomovil:
                    strPattern = @"^[a-zA-Z][a-zA-Z][0-9][0-9][0-9][a-zA-Z][a-zA-Z]+$";
                    break;
                default:
                    return false;
            }
            //
            // Evaluo la expresion.
            //
            reg = new Regex(strPattern);
            return reg.IsMatch(strValue);
        }




        /// <summary>
        /// Valida un número y su valor
        /// </summary>
        /// <param name="intValue"></param>
        /// <param name="intType"></param>
        /// <param name="blnRequired"></param>
        /// <param name="dblMinimo">Mínimo valor incluyente</param>
        /// <param name="dblMaximo">Máximo valor incluyente</param>
        /// <returns></returns>
        public static bool ValidateNumber(int intValue, ValidateNumbersEnum intType, bool blnRequired, float dblMinimo, float dblMaximo)
        {
            return ValidateNumber(intValue.ToString(), intType, blnRequired, dblMinimo, dblMaximo);
        }

        /// <summary>
        /// Valida un número y su valor
        /// </summary>
        /// <param name="strValue"></param>
        /// <param name="intType"></param>
        /// <param name="blnRequired"></param>
        /// <param name="dblMinimo">Mínimo valor incluyente</param>
        /// <param name="dblMaximo">Máximo valor incluyente</param>
        /// <returns></returns>
        public static bool ValidateNumber(string strValue, ValidateNumbersEnum intType, bool blnRequired, float dblMinimo, float dblMaximo)
        {
            bool blnReturnValue;

            blnReturnValue = ValidateNumber(strValue, intType, blnRequired);
            if (blnReturnValue)
            {
                if (blnRequired)
                {
                    // valido min y max valor
                    if (float.Parse(strValue) > dblMaximo)
                    {
                        blnReturnValue = false;
                    }
                    if (float.Parse(strValue) < dblMinimo)
                    {
                        blnReturnValue = false;
                    }
                }
            }
            return blnReturnValue;
        }


        /// <summary>
        /// Valida un número
        /// </summary>
        /// <param name="intValue"></param>
        /// <param name="intType"></param>
        /// <param name="blnRequired"></param>
        /// <returns></returns>
        public static bool ValidateNumber(int intValue, ValidateNumbersEnum intType, bool blnRequired)
        {
            return ValidateNumber(intValue.ToString(), intType, blnRequired);
        }
        /// <summary>
        /// Valida un número
        /// </summary>
        /// <param name="strValue"></param>
        /// <param name="intType"></param>
        /// <param name="blnRequired"></param>
        /// <returns></returns>
        public static bool ValidateNumber(string strValue, ValidateNumbersEnum intType, bool blnRequired)
        {
            // Falta validar (convertir si es DigitPositive, etc...)
            Regex reg;
            string strPattern = "";
            int intNumero;
            long lngNumero;
            double dblNumero;
            bool blnReturnValue = false;


            if (strValue == null)
            {
                return false;
            }
            // No puso Nada.
            if (strValue.Length == 0)
            {
                // Es Requerido.
                if (blnRequired)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            //reg = new Regex(strPattern);
            switch (intType)
            {
                case ValidateNumbersEnum.Number:
                    //a number can has digits, a decimal and - ( if negative ) at beginning and
                    //cannot have period at the end and no spaces or commas in between
                    strPattern = @"^-{0,1}\d*\.{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);

                    break;
                case ValidateNumbersEnum.Double:
                    //a number can has digits, a decimal and - ( if negative ) at beginning and
                    //cannot have period at the end and no spaces or commas in between
                    strPattern = @"^-{0,1}\d*\.{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        blnReturnValue = double.TryParse(strValue, out dblNumero);
                    }
                    break;
                case ValidateNumbersEnum.NumberPositive:
                    //a positive number can has digits, a decimal and no -ve  and cannot have period at the end
                    strPattern = @"^\d*\.{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        dblNumero = Convert.ToDouble(strValue);
                        blnReturnValue = (dblNumero > 0);
                    }
                    break;
                case ValidateNumbersEnum.DoublePositive:
                    //a positive number can has digits, a decimal and no -ve  and cannot have period at the end
                    strPattern = @"^\d*\.{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        blnReturnValue = double.TryParse(strValue, out dblNumero);
                        if (blnReturnValue)
                        {
                            blnReturnValue = (dblNumero > 0);
                        }
                    }
                    break;
                case ValidateNumbersEnum.NumberPositiveZero:
                    //a positive number can has digits, a decimal and no - and cannot have period at the end
                    strPattern = @"^\d*\.{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        dblNumero = Convert.ToDouble(strValue);
                        blnReturnValue = (dblNumero >= 0);
                    }
                    break;
                case ValidateNumbersEnum.DoublePositiveZero:
                    //a positive number can has digits, a decimal and no -ve  and cannot have period at the end
                    strPattern = @"^\d*\.{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        blnReturnValue = double.TryParse(strValue, out dblNumero);
                        if (blnReturnValue)
                        {
                            blnReturnValue = (dblNumero >= 0);
                        }
                    }
                    break;
                case ValidateNumbersEnum.NumberNegative:
                    //a negative number can has digits, a decimal and must have - at beginning and cannot have period at end
                    strPattern = @"^-\d*\.{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        dblNumero = Convert.ToDouble(strValue);
                        blnReturnValue = (dblNumero < 0);
                    }
                    break;
                case ValidateNumbersEnum.DoubleNegative:
                    //a negative number can has digits, a decimal and must have - at beginning and cannot have period at end
                    strPattern = @"^-\d*\.{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        blnReturnValue = double.TryParse(strValue, out dblNumero);
                        if (blnReturnValue)
                        {
                            blnReturnValue = (dblNumero < 0);
                        }
                    }
                    break;
                case ValidateNumbersEnum.NumberNegativeZero:
                    //a negative number can has digits, a decimal and must have -ve at beginning and cannot have period at end
                    strPattern = @"^-\d*\.{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        dblNumero = Convert.ToDouble(strValue);
                        blnReturnValue = (dblNumero <= 0);
                    }
                    break;
                case ValidateNumbersEnum.DoubleNegativeZero:
                    //a negative number can has digits, a decimal and must have -ve at beginning and cannot have period at end
                    strPattern = @"^-\d*\.{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        blnReturnValue = double.TryParse(strValue, out dblNumero);
                        if (blnReturnValue)
                        {
                            blnReturnValue = (dblNumero <= 0);
                        }
                    }
                    break;
                case ValidateNumbersEnum.Digit:
                    //a digit can have digits( no decimal) and - ( if negative ) at beginning
                    strPattern = @"^-{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);

                    break;

                case ValidateNumbersEnum.Int:
                    //a digit can have digits( no decimal) and - ( if negative ) at beginning
                    strPattern = @"^-{0,1}\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        blnReturnValue = int.TryParse(strValue, out intNumero);
                    }
                    break;

                case ValidateNumbersEnum.DigitPositive:
                    //a digit can have only digits( no decimal) and  no - ( negative ) at beginning
                    strPattern = @"^\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        //blnReturnValue = long.TryParse(strValue, out lngNumero);
                        //if (blnReturnValue) {
                        //    blnReturnValue = (lngNumero > 0);
                        //}
                        lngNumero = Convert.ToInt64(strValue);
                        blnReturnValue = (lngNumero > 0);
                    }
                    break;

                case ValidateNumbersEnum.IntPositive:
                    //a digit can have only digits( no decimal) and  no - ( negative ) at beginning
                    strPattern = @"^\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        blnReturnValue = int.TryParse(strValue, out intNumero);
                        if (blnReturnValue)
                        {
                            blnReturnValue = (intNumero > 0);
                        }
                    }
                    break;
                case ValidateNumbersEnum.DigitPositiveZero:
                    //a digit can have only digits( no decimal) and  no - ( negative ) at beginning
                    strPattern = @"^\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        lngNumero = Convert.ToInt64(strValue);
                        blnReturnValue = (lngNumero >= 0);
                    }
                    break;
                case ValidateNumbersEnum.IntPositiveZero:
                    //a digit can have only digits( no decimal) and  no - ( negative ) at beginning
                    strPattern = @"^\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        blnReturnValue = int.TryParse(strValue, out intNumero);
                        if (blnReturnValue)
                        {
                            blnReturnValue = (intNumero >= 0);
                        }
                    }
                    break;
                case ValidateNumbersEnum.DigitNegative:
                    //a digit can have only digits( no decimal) and  - ( negative ) at beginning
                    strPattern = @"^-\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        lngNumero = Convert.ToInt64(strValue);
                        blnReturnValue = (lngNumero < 0);
                    }
                    break;
                case ValidateNumbersEnum.IntNegative:
                    //a digit can have only digits( no decimal) and  no - ( negative ) at beginning
                    strPattern = @"^-\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        blnReturnValue = int.TryParse(strValue, out intNumero);
                        if (blnReturnValue)
                        {
                            blnReturnValue = (intNumero < 0);
                        }
                    }
                    break;
                case ValidateNumbersEnum.DigitNegativeZero:
                    //a digit can have only digits( no decimal) and  - ( negative ) at beginning
                    strPattern = @"^-\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        lngNumero = Convert.ToInt64(strValue);
                        blnReturnValue = (lngNumero <= 0);
                    }
                    break;
                case ValidateNumbersEnum.IntNegativeZero:
                    //a digit can have only digits( no decimal) and  no - ( negative ) at beginning
                    strPattern = @"^-\d+$";
                    reg = new Regex(strPattern);
                    blnReturnValue = reg.IsMatch(strValue);
                    if (blnReturnValue)
                    {
                        blnReturnValue = int.TryParse(strValue, out intNumero);
                        if (blnReturnValue)
                        {
                            blnReturnValue = (intNumero <= 0);
                        }
                    }
                    break;
                default:
                    //return false;
                    break;
            }
            //
            // Evaluo la expresion.
            //
            //reg = new Regex(strPattern);
            return blnReturnValue;
        }

        //		private bool isNumeric(string subject) { 
        //			return(System.Text.RegularExpressions.Regex.IsMatch(subject,"^[-0-9]*.[.0-9].[0-9]*$")); 
        //		} 
        //public static int GetYears(DateTime BirthDate) {
        //    // get the difference in years
        //    int years = DateTime.Now.Year - BirthDate.Year;
        //    // subtract another year if we're before the
        //    // birth day in the current year
        //    if (DateTime.Now.Month < BirthDate.Month ||
        //        (DateTime.Now.Month == BirthDate.Month &&
        //        DateTime.Now.Day < BirthDate.Day)) {
        //        years--;
        //    }
        //    return years;
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BirthDate"></param>
        /// <returns></returns>
        public static int GetYears(DateTime BirthDate)
        {
            return GetYears(BirthDate, DateTime.Now);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BirthDate"></param>
        /// <param name="dtmDateToCompare"></param>
        /// <returns></returns>
        public static int GetYears(DateTime BirthDate, DateTime dtmDateToCompare)
        {
            // get the difference in years
            int years = dtmDateToCompare.Year - BirthDate.Year;
            // subtract another year if we're before the
            // birth day in the current year
            if (dtmDateToCompare.Month < BirthDate.Month ||
                (dtmDateToCompare.Month == BirthDate.Month &&
                dtmDateToCompare.Day < BirthDate.Day))
            {
                years--;
            }
            return years;
        }


        #region Methods...
        /// <summary>
        /// Evalua si el parametro enviado es un numero, o si se puede convertir a numero.
        /// </summary>
        /// <remarks>
        /// ej:  
        ///  bool blnEsNumerico1 = ValidatorHelper.IsNumeric(5);	
        ///  bool blnEsNumerico2 = ValidatorHelper.IsNumeric("5");	
        /// </remarks>
        /// <param name="valor">objeto a evaluar.</param>
        /// <returns>true en caso de que el valor es o se puede convertir a un numero, sino false</returns>
        public static bool IsNumeric(object valor)
        {
            bool blnReturnValue = false;
            if ((valor != null) && (valor != DBNull.Value))
            {
                try
                {
                    double d = System.Double.Parse(valor.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                    blnReturnValue = true; ;
                    //} catch (FormatException) {
                }
                catch /*(Exception ex) */
                {
                    //blnReturnValue = false;
                }
            }
            return blnReturnValue;
        }
        /// <summary>
        /// Evalua si el parametro enviado es un numero entero, o si se puede convertir al mismo.
        /// </summary>
        /// <remarks>
        /// ej:  
        ///  bool blnEsEntero1 = IsInteger(5);			// true
        ///  bool blnEsEntero2 = IsInteger("5");		// true
        ///  bool blnEsEntero3 = IsInteger(4.5);		// false
        /// </remarks>
        /// <param name="valor">objeto a evaluar.</param>
        /// <returns>true en caso de que el valor es o se puede convertir a un Entero, sino false</returns>
        public static bool IsInteger(object valor)
        {
            //IsInteger: new Regex(@"^\d+$");
            bool blnReturnValue = true;
            char[] vecCaracteres = null;
            try
            {
                //double d = System.Double.Parse(valor.ToString(), System.Globalization.NumberStyles.Any); 
                if (IsNumeric(valor))
                {
                    vecCaracteres = valor.ToString().ToCharArray();
                    foreach (char chrCaracter in vecCaracteres)
                    {
                        // If the given character is in between 0 and 9 then 
                        // return true, otherwise false. 
                        if ((chrCaracter < '0' || chrCaracter > '9') && chrCaracter != '-')
                        {
                            blnReturnValue = false;
                        }
                    }
                }
                else
                {
                    blnReturnValue = false;
                }
            }
            catch (FormatException)
            {
                blnReturnValue = false;
            }
            return blnReturnValue;
        }
        /// <summary>
        /// Evalua si el parametro enviado es un DateTime, o si se puede convertir al mismo.
        /// </summary>
        /// <remarks>
        /// ej:  
        ///  bool blnEsDateTime1 = ValidatorHelper.IsDate("2004/14/04");		// true
        ///  bool blnEsDateTime2 = ValidatorHelper.IsDate(System.DateTime.Now);	// true
        ///  bool blnEsDateTime3 = ValidatorHelper.IsDate(4.5);					// false
        /// </remarks>
        /// <param name="strDateTime">string a evaluar.</param>
        /// <returns>true en caso de que el valor es o se puede convertir a un DateTime, sino false</returns>
        public static bool IsDate(string strDateTime)
        {
            return IsDate(strDateTime, true);
        }

        /// <summary>
        /// Evalua si el parametro enviado es un DateTime, o si se puede convertir al mismo.
        /// </summary>
        /// <remarks>
        /// ej:  
        ///  bool blnEsDateTime1 = ValidatorHelper.IsDate("2004/14/04");		// true
        ///  bool blnEsDateTime2 = ValidatorHelper.IsDate(System.DateTime.Now);	// true
        ///  bool blnEsDateTime3 = ValidatorHelper.IsDate(4.5);					// false
        /// </remarks>
        /// <param name="strDateTime">string a evaluar.</param>
        /// <param name="blnRequired">Indica se es requerido o no.</param>
        /// <returns>true en caso de que el valor es o se puede convertir a un DateTime, sino false</returns>
        public static bool IsDate(string strDateTime, bool blnRequired)
        {
            DateTime dt;
            bool blnReturnValue = true;

            if ((strDateTime.Length == 0) && (!blnRequired))
            {
                blnReturnValue = true;
            }
            else
            {

                try
                {
                    dt = DateTime.Parse(strDateTime, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch
                {
                    blnReturnValue = false;
                }

            }
            return blnReturnValue;
        }



        //public static bool IsDate(string valor, string strFormat) {
        //    DateTime dt;
        //    bool blnReturnValue = true;
        //    try {
        //        dt = DateTime.Parse(valor, System.Globalization.CultureInfo.InvariantCulture);
        //    } catch {
        //        blnReturnValue = false;
        //    }
        //    return blnReturnValue;



        //    //String _dateFormat = "MM/dd/yyyy";
        //    //DateTime myDate;

        //    //if (DateTime.TryParseExact(valuationDateString, _dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out tempDate)) {
        //    //    myDate = tempDate;
        //    //}

        //} 
        /// <summary>
        ///		Evalua si el parametro enviado es un DateTime, o si se puede convertir al mismo.
        /// </summary>
        /// <param name="strDia"></param>
        /// <param name="strMes"></param>
        /// <param name="strAno"></param>
        /// <returns>true en caso de que el valor es o se puede convertir a un DateTime, sino false</returns>
        public static bool IsDate(string strDia, string strMes, string strAno)
        {
            return IsDate(strAno + "/" + strMes + "/" + strDia);
        }

        /// <summary>
        /// Evalua si el parametro enviado es un Boolean, o si se puede convertir al mismo.
        /// </summary>
        /// <remarks>
        /// ej:  
        ///  bool blnEsBoolean1	= ValidatorHelper.IsBoolean("0");		// true
        ///  bool blnEsBoolean2	= ValidatorHelper.IsBoolean("1");		// true
        ///  bool blnEsBoolean3	= ValidatorHelper.IsBoolean("true");	// true
        ///  bool blnEsBoolean4	= ValidatorHelper.IsBoolean("false");	// true
        ///  bool blnEsBoolean5	= ValidatorHelper.IsBoolean("No");		// false
        ///  bool blnEsBoolean6	= ValidatorHelper.IsBoolean("Sí");		// false
        /// </remarks>
        /// <param name="valor">string a evaluar.</param>
        /// <returns>true en caso de que el valor es o se puede convertir a un bool, sino false</returns>
        public static bool IsBoolean(string valor)
        {
            bool blnReturnValue = true;
            bool blnTest;
            try
            {
                blnTest = bool.Parse(valor);
            }
            catch
            {
                blnReturnValue = false;
            }
            return blnReturnValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strEmail"></param>
        /// <returns></returns>
        public static bool IsEmail(string strEmail)
        {
            return ValidatorHelper.ValidateString(strEmail, ValidateStringsEnum.Email, true);
        }

        //public static bool IsEmail(string strEmail, string strDelimiter) {
        //    return ValidatorHelper.ValidateString(strEmail, ValidateStringsEnum.Email, true);
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strEmail"></param>
        /// <param name="strDelimiter"></param>
        /// <returns></returns>
        public static bool IsEmail(string strEmail, string strDelimiter)
        {
            bool blnReturnValue = true;
            string[] arrEmail;
            string[] arrSeparatorsParameter = new string[] { strDelimiter };

            if (strEmail != "")
            {
                //arrEmail = strEmail.Split(";,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                arrEmail = strEmail.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                if (arrEmail.Length > 0)
                {
                    for (int i = 0; i < arrEmail.Length; i++)
                    {
                        if (arrEmail[i].Trim().Length > 0)
                        {
                            if (!ValidatorHelper.IsEmail(arrEmail[i].Trim()))
                            {
                                blnReturnValue = false;
                            }
                        }
                    }
                }
            }
            return blnReturnValue;
        }


        //		/// <summary>
        //		/// 
        //		/// </summary>
        //		/// <param name="strValor"></param>
        //		/// <returns></returns>
        //		public static bool IsFloat2(string strValor) {
        //			//string strPattern = "^[\\w\\-]+[\\.\\w\\-]*[\\@]+[\\w\\-\\.]+\\.[A-Z_a-z]{2,5}$";
        //			string strPattern = @"^\$(\d+)?(\.\d+)?$";
        //			Regex reg = new Regex(strPattern);
        //			return reg.IsMatch(strValor);
        //		}
        #endregion

        #region  ASP Comun
        //		Function IsAlpha(ByVal strTexto)
        //			IsAlpha = Test(strTexto, "^[a-zA-Z]+$", True)
        //		End Function
        //		
        //		Function IsHexaDecimal(ByVal strTexto)
        //			IsHexaDecimal = Test(strTexto, "^[a-fA-F0-9]+$", True)
        //		End Function
        //		
        //		Function IsNumeric(ByVal strTexto)
        //			IsNumeric = Test(strTexto, "^[0-9]+$", True)
        //		End Function
        //		
        //		Function IsAlphaNumeric(ByVal strTexto)
        //			IsAlphaNumeric = Test(strTexto, "^[a-zA-Z0-9]+$", True)
        //		End Function
        //		
        //		Function IsSQL(ByVal strTexto)
        //			IsSQL = Test(strTexto, "^[a-zA-Z0-9 _-]", True)
        //			'IsSQL = Test(strTexto, "^[a-zA-Z0-9 _-]+$", True)
        //			'IsSQL = Test(strTexto, "^[a-zA-Z0-9_ ]+$", True)
        //			'IsSQL = Test(strTexto, "^[a-z|A-Z|0-9|_ -]+$", True)
        //			'IsSQL = Test(strTexto, "(/./.)+$", True)
        //		End Function
        //
        //		Function Test(ByVal strTexto, ByVal strPattern, ByVal blnIgnoreCase)
        //		' Function matches pattern, returns true or false
        //		' varIgnoreCase must be TRUE (match is case insensitive) or FALSE (match is case sensitive)
        //		Dim objRegExp 
        //			Set objRegExp = New RegExp
        //					With objRegExp
        //						.Pattern = strPattern
        //						.IgnoreCase = blnIgnoreCase
        //						.Global = True
        //					End With
        //				Test = objRegExp.Test (strTexto)
        //			Set objRegExp = nothing
        //		end function
        #endregion

        #region CUIT/CUIL
        /// <summary>
        ///     Calcula el dígito verificador dado un CUIT completo o sin él.
        /// </summary>
        /// <param name="strCUIT">El CUIT como String sin guiones</param>
        /// <returns>El valor del dígito verificador calculado.</returns>
        private static int CalcularDigitoCuit(string strCUIT)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = strCUIT.ToCharArray();
            int total = 0;
            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }
            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }

        /// <summary>
        /// Valida el CUIT ingresado.
        /// </summary>
        /// <param name="strCUIT" />Número de CUIT como string con o sin guiones
        /// <returns>True si el CUIT es válido y False si no.</returns>
        public static bool IsCUIT(string strCUIT)
        {
            if (strCUIT == null)
            {
                return false;
            }
            //Quito los guiones, el cuit resultante debe tener 11 caracteres.
            strCUIT = strCUIT.Replace("-", string.Empty);
            if (strCUIT.Length != 11)
            {
                return false;
            }
            else
            {
                int calculado = CalcularDigitoCuit(strCUIT);
                int digito = int.Parse(strCUIT.Substring(10));
                return calculado == digito;
            }
        }
        #endregion
    }

    #region Validate Email
    /// <summary>
    /// 
    /// </summary>
	public class ValidateEmail
    {
        // Email Validation Level to do
        /// <summary>
        /// 
        /// </summary>
        public enum EmailValidationLevel
        {
            /// <summary>
            /// 
            /// </summary>
            Syntax = 0,            //Validate the syntax of an email only.
            /// <summary>
            /// 
            /// </summary>
            Domain = 1,            //Validate the email at mailbox level only.
            /// <summary>
            /// 
            /// </summary>
            MailBox = 2,            //Validate the email at mailbox level only.
            /// <summary>
            /// 
            /// </summary>
            Full = 3             //

        }
        // The Email Validation Results
        /// <summary>
        /// 
        /// </summary>
        public enum ValidationResponse
        {
            /// <summary />
            Success = 0,    //Email Validation Success.
            /// <summary />
            InvalidSyntax = 1,    //	Email as an invalid syntax.
            /// <summary />
            InvalidDomain = 2,    //	The mailbox cannot receive email.
            /// <summary />
            InvalidMailBox = 3,    //	The mailbox cannot receive email.
            /// <summary />
            Error = 4     //If an Error as been trigerred.
        }
        /// <summary>
        /// 
        /// </summary>
        public ValidateEmail() { }
        /*

			EmailValidation Members

			EmailValidation overview
			Public Instance Constructors
			EmailValidation Constructor 	Default Constructor
			Public Instance Properties
			DnsServer	Get or set the DNS server to query from you can you as form of xxx.xxx.xxx.xxx or a domain name
			EmailToValidate	Get or set the email address to validate
			FromEmailAddress	Get or set the from email address default is localhost@localhost.com
			GetErrorString	Get the error that has occured in string format
			GetLog	Get a log of all the action taken ( Read Only )
			SMTP_Timeout	get or set the timeout in second for the smtp connection before it timeout
			UseDnsCache	Use the ASP.NET caching for domain by default it's set to true.
			ValidationLevel	Get or set the email validation level to perform default is Syntax and Mailbox Level
			ValidDTL	get or set the TLD requirement ( Top Level Domain i.e. .com, .net ... )
		  
		 
		 */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sEmail"></param>
        /// <returns></returns>
        public long ChatMailServer(string sEmail)
        {
            NetworkStream oStream;
            string sFrom;
            string sTo;
            //int tResponse ;
            //int ConnectUP ;
            string sResponse;
            //int iResponse ;
            //string sToSend;
            string Remote_Addr;
            string mserver;
            string[] sText;

            sTo = @"<" + sEmail + @">";

            //sperate domain name from user name
            //sText = sEmail.Split(CType("@", Char));
            sText = sEmail.Split('@');

            ArrayList arrServers = NSLookup(sText[1]);
            //mserver = NSLookup(sText[1]);

            //If mail server is blank then fail
            if (arrServers.Count == 0)
            {
                return 4;
            }
            mserver = (string)arrServers[0]; //Esto lo debo hacer por cada uno.

            //Needs to be a valid domain name
            Remote_Addr = "unicenter.com.ar";
            sFrom = @"<test@" + Remote_Addr + ">";

            //Create Object as late as possible
            TcpClient oConnection = new TcpClient();
            try
            {

                //Set connection based on load 
                oConnection.SendTimeout = 3000;

                //Connecting on SMTP port
                oConnection.Connect(mserver, 25);

                //Get Stream from Mailserver
                oStream = oConnection.GetStream();

                //Collect Response
                sResponse = GetData(oStream);
                sResponse = TalkToServer(oStream, "HELO " + Remote_Addr + Environment.NewLine);
                sResponse = TalkToServer(oStream, "MAIL FROM: " + sFrom + Environment.NewLine);
                if (ValidResponse(sResponse))
                {
                    sResponse = TalkToServer(oStream, "RCPT TO: " + sTo + Environment.NewLine);
                    if (ValidResponse(sResponse))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                TalkToServer(oStream, "QUIT" + Environment.NewLine);
                oConnection.Close();
                oStream = null;
            }
            catch
            {
                return 3;
            }
            return 0;
        }


        private string GetData(NetworkStream oStream)
        {
            Byte[] bResponse = new byte[1024];
            string sResponse = "";

            int lenStream = oStream.Read(bResponse, 0, 1024);

            if (lenStream > 0)
            {
                sResponse = Encoding.ASCII.GetString(bResponse, 0, 1024);

            }

            return sResponse;

        }


        private string SendData(NetworkStream oStream, string sToSend)
        {
            string sResponse;
            Byte[] bArray = Encoding.ASCII.GetBytes(sToSend.ToCharArray());

            oStream.Write(bArray, 0, bArray.Length);

            sResponse = GetData(oStream);

            return sResponse;

        }


        private bool ValidResponse(string sResult)
        {
            bool bResult = false;
            int iFirst;

            if (sResult.Length > 1)
            {
                iFirst = Convert.ToInt32(sResult.Substring(0, 1));
                if (iFirst < 3)
                {
                    bResult = true;
                }
            }
            return bResult;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oStream"></param>
        /// <param name="sToSend"></param>
        /// <returns></returns>
        private string TalkToServer(NetworkStream oStream, string sToSend)
        {
            string sresponse = null;
            sresponse = SendData(oStream, sToSend);
            return sresponse;
        }



        //This Function fires off a NS lookup and uses a regx expression to find the server
        //This idea was from a posting off the microsoft newsgroups
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sDomain"></param>
        /// <returns></returns>
        public ArrayList NSLookup(string sDomain)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.FileName = "nslookup";
            info.Arguments = "-type=MX " + sDomain.ToUpper().Trim();

            Process ns;
            ns = Process.Start(info);
            StreamReader sout;
            sout = ns.StandardOutput;
            Regex reg = new Regex(@"mail exchanger = (?<server>[^\\\s]+)");
            ArrayList arrMailServers = new ArrayList();
            string response = "";

            do
            {
                response = sout.ReadLine();
                Match amatch = reg.Match(response);
                //Debug.WriteLine(response);
                if (amatch.Success)
                {
                    arrMailServers.Add(amatch.Groups["server"].Value);
                    //break;
                }
            } while (sout.Peek() > -1);

            return arrMailServers;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputEmail"></param>
        /// <returns></returns>
        public static bool isEmail(string inputEmail)
        {
            //inputEmail = NulltoString(inputEmail);
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
    #endregion


}
