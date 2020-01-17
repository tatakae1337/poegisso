using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


namespace SampleApp.Class

{
    [Serializable]
    class Chelovek
    {
        

        //public Int32 chelID { get; set; }
        public String FamilyName { get; set; } 
        public String FirstName { get; set; }
        public String Patronymic { get; set; }
        public String SNILS { get; set; }
        public String LMSZID { get; set; } 
        public String Fact { get; set; }
        public String ID { get; set; }
        public String OSZCode { get; set; }
        public String MSZ_receiver { get; set; }
        public String Elements { get; set; }

        //этот класс для csv, xml
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public string F { get; set; }



    }
}

