using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.External
{
    ///<summary>
    ///		Contiene los formatos posibles para el archivo log de excepciones.
    ///</summary>
    ///public enum AutomovilesEnum : int {
    public enum FormatLogEnum : int
    {
        /// <summary>
        /// TEXT
        /// </summary>
        TEXT = 0,
        /// <summary>
        /// XML
        /// </summary>
        XML
    }
    /// <summary>
    /// Contiene los valores nulos de los tipos de datos 
    /// utilizados por una "Business Entity".
    /// </summary>
    public sealed class DataTypes
    {

        ///<summary>
        /// ShortNull.
        ///</summary>
        public static readonly short ShortNull = short.MinValue;

        ///<summary>
        /// IntNull.
        ///</summary>
        public static readonly int IntNull = 0;//int.MinValue;

        ///<summary>
        /// IntNull.
        ///</summary>
        public static readonly Int64 BigIntNull = Int64.MinValue;

        ///<summary>
        /// LongNull.
        ///</summary>
        public static readonly long LongNull = long.MinValue;

        ///<summary>
        /// DoubleNull.
        ///</summary>
        public static readonly double DoubleNull = double.MinValue;

        ///<summary>
        /// SingleNull.
        ///</summary>
        public static readonly float SingleNull = float.MinValue;

        ///<summary>
        /// DecimalNull.
        ///</summary>
        public static readonly decimal DecimalNull = decimal.MinValue;

        ///<summary>
        /// StringNull.
        ///</summary>
        public static readonly string StringNull = "@@@###$$$";

        ///<summary>
        /// DateNull.
        ///</summary>
        public static readonly DateTime DateNull = DateTime.MaxValue;

        ///<summary>
        /// DateNull.
        ///</summary>
        public static readonly Guid GuidNull = Guid.Empty;

        ///<summary>
        /// DateNull.
        ///</summary>
        public static readonly Byte ByteNull = Byte.MinValue;

        ///<summary>
        /// ObjectNull.
        ///</summary>
        public static readonly object ObjectNull = null;

        ///<summary>
        /// Constructor Privado.
        ///</summary>
        private DataTypes() { }

        /// <summary>
        /// Determines whether the specified property value is null.
        /// </summary>
        /// <param name="propertyValue">The property value.</param>
        /// <param name="oReturnIfIsNull">The o return if is null.</param>
        /// <returns></returns>
        public static object IsNull(object propertyValue, object oReturnIfIsNull)
        {
            if (IsNull(propertyValue))
            {
                return oReturnIfIsNull;
            }
            else
            {
                return propertyValue;
            }
        }
        /// <summary>
        /// Determines whether the specified property value is null.
        /// </summary>
        /// <param name="propertyValue">The property value.</param>
        /// <returns>
        /// 	<c>true</c> if the specified property value is null; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNull(object propertyValue)
        {
            bool blnReturnValue;
            blnReturnValue = false;
            if ((propertyValue == null) || (propertyValue == DBNull.Value))
            {
                blnReturnValue = true;
            }
            else
            {
                if (propertyValue.GetType() == typeof(short))
                {
                    if (((short)propertyValue) == ShortNull)
                    {
                        blnReturnValue = true;
                    }
                }
                else if (propertyValue.GetType() == typeof(int))
                {
                    if (((int)propertyValue) == IntNull)
                    {
                        blnReturnValue = true;
                    }
                }
                else if (propertyValue.GetType() == typeof(long))
                {
                    if (((long)propertyValue) == LongNull)
                    {
                        blnReturnValue = true;
                    }
                }
                else if (propertyValue.GetType() == typeof(double))
                {
                    if (((double)propertyValue) == DoubleNull)
                    {
                        blnReturnValue = true;
                    }
                }
                else if (propertyValue.GetType() == typeof(float))
                {
                    if (((float)propertyValue) == SingleNull)
                    {
                        blnReturnValue = true;
                    }
                }
                else if (propertyValue.GetType() == typeof(string))
                {
                    if (((string)propertyValue) == StringNull)
                    {
                        blnReturnValue = true;
                    }
                }
                else if (propertyValue.GetType() == typeof(System.DateTime))
                {
                    if (((System.DateTime)propertyValue) == DateNull)
                    {
                        blnReturnValue = true;
                    }
                }
                else if (propertyValue.GetType() == typeof(Decimal))
                {
                    if (((Decimal)propertyValue) == DecimalNull)
                    {
                        blnReturnValue = true;
                    }
                }
                else
                {
                    blnReturnValue = false;
                }
            }
            return blnReturnValue;
        }

        //public static string Clear(object oObjeto, string strNewLine) {
        //    //object value;
        //    string strReturnValue = "";
        //    string strProperty;

        //    if ((oObjeto != null) && 
        //        (oObjeto is Framework.CommonLibrary.BusinessEntities.GenericEntity)) {
        //        Type controlType = oObjeto.GetType();
        //        PropertyInfo[] properties = controlType.GetProperties();
        //        foreach (PropertyInfo controlProperty in properties) {

        //            strProperty = string.Format("{1} ({0}) = {2}",
        //                    controlProperty.PropertyType.Name,
        //                    controlProperty.Name,
        //                    DataTypes.IsNull(controlProperty.GetValue(oObjeto, null), @"[null]"));
        //            controlProperty.SetValue(

        //        }
        //    } else {
        //        strReturnValue = "Null";
        //    }
        //    return strReturnValue;
        //}

        //public static string NullToString(bool? boolValue) {
        //    string strReturnValue = string.Empty;
        //    if (boolValue.HasValue) {
        //        strReturnValue = NullToString((object)boolValue);
        //    } else {
        //        strReturnValue = "Null";
        //    }
        //    return strReturnValue;
        //}

        /// <summary>
        /// NullToString.
        /// </summary>
        /// <param name="propertyValue">The property value.</param>
        /// <returns></returns>
        public static string NullToString(object propertyValue)
        {
            string strReturnValue = string.Empty;
            if (propertyValue == null)
            {
                strReturnValue = "Null";
            }
            else
            {
                strReturnValue = Convert.ToString(propertyValue);
                if (propertyValue.GetType() == typeof(short))
                {
                    if (((short)propertyValue) == ShortNull)
                    {
                        strReturnValue = "Null";
                    }
                }
                else if (propertyValue.GetType() == typeof(int))
                {
                    if (((int)propertyValue) == IntNull)
                    {
                        strReturnValue = "Null";
                    }
                }
                else if (propertyValue.GetType() == typeof(long))
                {
                    if (((long)propertyValue) == LongNull)
                    {
                        strReturnValue = "Null";
                    }
                }
                else if (propertyValue.GetType() == typeof(double))
                {
                    if (((double)propertyValue) == DoubleNull)
                    {
                        strReturnValue = "Null";
                    }
                }
                else if (propertyValue.GetType() == typeof(float))
                {
                    if (((float)propertyValue) == SingleNull)
                    {
                        strReturnValue = "Null";
                    }
                }
                else if (propertyValue.GetType() == typeof(string))
                {
                    if (((string)propertyValue) == StringNull)
                    {
                        strReturnValue = "Null";
                    }
                }
                else if (propertyValue.GetType() == typeof(System.DateTime))
                {
                    if (((System.DateTime)propertyValue) == DateNull)
                    {
                        strReturnValue = "Null";
                    }
                }
                else if (propertyValue.GetType() == typeof(System.Boolean))
                {
                    strReturnValue = propertyValue.ToString();
                }
                else
                {
                    strReturnValue = propertyValue.GetType().ToString();
                }
            }
            return strReturnValue;
        }

        /// <summary>
        /// Retorna DBNull.Value en caso de que la propiedad de la entidad del Framework.
        /// sea nula.
        /// </summary>
        /// <param name="propertyValue">Propiedad de un objeto BusinessEntity del Framework a evaluar.</param>
        /// <returns></returns>
        public static object ToDBNull(object propertyValue)
        {
            if (IsNull(propertyValue))
            {
                return (object)System.DBNull.Value;
            }
            else
            {
                return propertyValue;
            }
        }

        /// <summary>
        ///		Evalua y retorna un objeto en caso de ser null (BD).
        /// </summary>
        /// <param name="oEvaluar">Objeto a Evaluar</param>
        /// <param name="oReturnIfIsNull">Objeto a retornar en caso de que oEvaluar sea Null.</param>
        /// <returns>Retorn oEvaluar o oReturnIfIsNull en caso de que oEvaluar sea Null.</returns>
        public static object IsDBNull(object oEvaluar, object oReturnIfIsNull)
        {
            //if ((oEvaluar == DBNull.Value) || (oEvaluar == null)){
            if (IsDBNull(oEvaluar))
            {
                return oReturnIfIsNull;
            }
            else
            {
                return oEvaluar;
            }
        }

        /// <summary>
        ///		Evalua y retorna si un objeto es dbnull.
        /// </summary>
        /// <param name="oEvaluar">Objeto a Evaluar</param>
        /// <returns>Retorna true si es dbnull, false si no lo es</returns>
        public static bool IsDBNull(object oEvaluar)
        {
            if ((oEvaluar == null) || (oEvaluar == DBNull.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// NullToString.
        /// </summary>
        /// <param name="propertyValue">The property value.</param>
        /// <returns></returns>
        public static string NullToSQLServerString(object propertyValue)
        {
            string strReturnValue = string.Empty;

            if (propertyValue == null)
            {
                strReturnValue = "Null";
            }
            else
            {
                if (propertyValue.GetType() == typeof(short))
                {
                    if (((short)propertyValue) == ShortNull)
                    {
                        strReturnValue = "Null";
                    }
                    else
                    {
                        strReturnValue = propertyValue.ToString();
                    }
                }
                else if (propertyValue.GetType() == typeof(int))
                {
                    if (((int)propertyValue) == IntNull)
                    {
                        strReturnValue = "Null";
                    }
                    else
                    {
                        strReturnValue = propertyValue.ToString();
                    }
                }
                else if (propertyValue.GetType() == typeof(long))
                {
                    if (((long)propertyValue) == LongNull)
                    {
                        strReturnValue = "Null";
                    }
                    else
                    {
                        strReturnValue = propertyValue.ToString();
                    }
                }
                else if (propertyValue.GetType() == typeof(double))
                {
                    if (((double)propertyValue) == DoubleNull)
                    {
                        strReturnValue = "Null";
                    }
                    else
                    {
                        //strReturnValue = propertyValue.ToString();
                        strReturnValue = Format((float)propertyValue, 4); //propertyValue.ToString();
                    }
                }
                else if (propertyValue.GetType() == typeof(float))
                {
                    if (((float)propertyValue) == SingleNull)
                    {
                        strReturnValue = "Null";
                    }
                    else
                    {
                        strReturnValue = Format((float)propertyValue, 3); //propertyValue.ToString();

                    }
                }
                else if (propertyValue.GetType() == typeof(string))
                {
                    if (((string)propertyValue) == StringNull)
                    {
                        strReturnValue = "Null";
                    }
                    else
                    {
                        strReturnValue = "'" + propertyValue.ToString() + "'";
                    }
                }
                else if (propertyValue.GetType() == typeof(System.DateTime))
                {
                    if (((System.DateTime)propertyValue) == DateNull)
                    {
                        strReturnValue = "Null";
                    }
                    else
                    {
                        strReturnValue = "'" + ((DateTime)propertyValue).ToString("yyyy-MM-dd hh:mm:ss.fff") + "'";
                    }
                }
                else if (propertyValue.GetType() == typeof(System.Boolean))
                {
                    if ((bool)propertyValue)
                    {
                        strReturnValue = "1";
                    }
                    else
                    {
                        strReturnValue = "0";
                    }
                }
                else
                {
                    strReturnValue = propertyValue.GetType().ToString();
                }
            }
            return strReturnValue;
        }
        /// <summary>
        /// Formatear un valor de Tipo float. 
        /// </summary>
        /// <remarks>
        /// ej:  
        ///  string strTotal = FormatHelper.Format(10.5, 3);
        /// </remarks>
        /// <param name="valor">un valor Float a formatear</param>
        /// <param name="cantidadDecimales">cantidad de Decimales que se incluiran</param>
        /// <returns>Un string con el valor float formateado y con 'cantidadDecimales' decimales</returns>
        public static string Format(float valor, int cantidadDecimales)
        {
            string strReturnValue, strFormat;

            strFormat = "{0:f" + cantidadDecimales + "}";
            // GenericDefault={1:f2}
            strReturnValue = string.Format(System.Globalization.CultureInfo.InvariantCulture, strFormat, valor);
            return strReturnValue;
        }
    }
}
