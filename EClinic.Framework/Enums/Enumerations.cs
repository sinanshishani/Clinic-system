using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace EClinic.Framework.Enums
{
    public class Enumerations : IEnumerations
    {
        /// <summary>
        /// Return enum type vlaues and its description as list of NameValuePair
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <returns>list of TextValuePair</returns>
        public List<NameValuePair> GetNameValuePairs<T>()
        {
            List<NameValuePair> pairs = new List<NameValuePair>();
            IEnumerable<T> values = GetValues<T>();
            foreach (var item in values)
            {
                MemberInfo[] memInfo = (typeof(T)).GetMember(item.ToString());
                if (memInfo != null && memInfo.Length > 0)
                {
                    object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (attrs != null && attrs.Length > 0)
                    {
                        NameValuePair nameValue = new NameValuePair();
                        nameValue.Name = ((DescriptionAttribute)attrs[0]).Description;
                        nameValue.Value = (int)Convert.ChangeType(item, Enum.GetUnderlyingType(item.GetType()));
                        pairs.Add(nameValue);
                    }
                }
            }

            return pairs;
        }


        /// <summary>
        /// Get all values of specific enum
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <returns>Collection of enum values</returns>
        private IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        /// <summary>
        /// Return enum description of given enum vlaue
        /// </summary>
        /// <param name="value">enum value</param>
        /// <returns>String description of given enum value</returns>
        public string GetEnumDescription(Enum value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            FieldInfo fi = value.GetType().GetField(value.ToString());
            if (fi == null)
            {
                return string.Empty;
            }

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}