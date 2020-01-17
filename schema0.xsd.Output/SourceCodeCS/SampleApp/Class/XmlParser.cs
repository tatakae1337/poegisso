using LiquidTechnologies.Runtime.Net40;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SampleApp.Model
{
    public class XmlParser
    {
        public XmlDateTime Parse(string dt)
        {
            DateTime date = DateTime.ParseExact(dt, "yyyy-MM-dd", CultureInfo.CurrentCulture);
            return new XmlDateTime(date);
        }
        public XmlDateTime ParseIso(string dt)
        {
            DateTime date = DateTime.ParseExact(dt, "yyyy-MM-ddTH:mm:ss", CultureInfo.CurrentCulture);
            return new XmlDateTime(date);
            
        }
        
    }
}
