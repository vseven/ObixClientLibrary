using ObixClientLibrary.Extensions;
using System;
using System.Xml.Linq;

namespace ObixClientLibrary.Extensions
{
    public static class DateTimeObixExtensions
    {
        public static XElement ObixXmlValue(this DateTime value)
        {
            XElement element = new XElement("abstime");
            element.SetAttributeValue("val", value.ToString());
            return element;
        }

        public static DateTime? ObixAbstimeValue(this XElement element)
        {
            if (element.Name.LocalName != "abstime" || element.HasAttributes == false || (_ = element.Attribute("val")) == null)
            {
                return null;
            }

            return DateTime.TryParse(element.ObixValue(), out DateTime val) == false ? null : (DateTime?)val;
        }
    }
}

