﻿using System.Xml.Linq;

namespace ObixClientLibrary.Extensions
{

    public static class DecimalObixExtensions
    {

        public static XElement ObixXmlValue(this decimal value)
        {
            XElement element = new XElement("real");
            element.SetAttributeValue("val", value.ToString());
            return element;
        }

        public static decimal? ObixRealValue(this XElement element)
        {
            XAttribute valAttr;

            if (element.Name.LocalName != "real" || element.HasAttributes == false || (valAttr = element.Attribute("val")) == null)
            {
                return null;
            }

            if (decimal.TryParse(element.ObixValue(), out decimal val) == false)
            {
                return null;
            }

            return val;
        }
    }

}

