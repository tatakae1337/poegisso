//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace SampleApp.Class
//{
//    public class SQLGenerator
//    {
//        public SQLInfo.CreateSQLStatement(string xmlPath)
//        {

//        }
//        private string[] AddSeparator(Hashtable fv, char sep)
//        {
//            int len = fv.Count;
//            int i = 0;
//            StringBuilder sbFields = new StringBuilder();
//            StringBuilder sbValues = new StringBuilder();
//            IDictionaryEnumerator fvEnum = fv.GetEnumerator();
//            while (fvEnum.MoveNext())
//            {
//                sbFields.Append(fvEnum.Key);
//                if (i < len - 1) sbFields.Append(sep);
//                sbValues.Append(fvEnum.Value);
//                if (i < len - 1) sbValues.Append(sep);
//                i++;
//            }
//        }
//    }
//}
