using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApp.Model
{

    public class Record
    {
      
        public string IdChel { get; set; }
        public string IdZayavka { get; set; }
        public string Year { get; set; }
        public string RecType { get; set; }
        public string Oso { get; set; }
        public string NumberZ { get; set; }
        public string LmszId { get; set; }
        public string CategoryId { get; set; }
        public string OnmszCode { get; set; }
        public string SnilsRecip { get; set; }
        public string FamilyNameRecip { get; set; }
        public string NameRecip { get; set; }
        public string PatronymicRecip { get; set; }
        public string GenderRecip { get; set; }
        public DateTime? BirthDateRecip { get; set; }
        public string DoctypeRecip { get; set; }
        public string DocSeriesRecip { get; set; }
        public string DocNumberRecip { get; set; }
        public DateTime? DocIssueDateRecip { get; set; }
        public string DocIssuerRecip { get; set; }
        public string SnilsReason { get; set; }
        public string FamilyNameReason { get; set; }
        public string NameReason { get; set; }
        public string PatronymicReason { get; set; }
        public string GenderReason { get; set; }
        public DateTime? BirthdateReason { get; set; }
        public string DoctypeReason { get; set; }
        public string DocSeriesReason { get; set; }
        public string DocNumberReason { get; set; }
        public DateTime? DocIssueDateReason { get; set; }
        public string DocIssuerReason { get; set; }
        public DateTime? DecisionDate { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateFinish { get; set; }
        public string UsingSign { get; set; }
        public string Criteria { get; set; }
        public string FormCode { get; set; }
        public decimal? Amount { get; set; }
        public string MeasuryCode { get; set; }
        public string Monetization { get; set; }
        public string Content { get; set; }
        public string Comment { get; set; }
        public int IdRayon { get; set; }

    }

    public class RecordXML:Record
    {
      

        public List<Prozhiv> prozhiv;

    
    }

    public class Prozhiv
    {
        public string SnilsReason { get; set; }
        public string FamilyNameReason { get; set; }
        public string NameReason { get; set; }
        public string PatronymicReason { get; set; }
        public string GenderReason { get; set; }
        public DateTime? BirthdateReason { get; set; }
        public string DoctypeReason { get; set; }
        public string DocSeriesReason { get; set; }
        public string DocNumberReason { get; set; }
        public DateTime? DocIssueDateReason { get; set; }
        public string DocIssuerReason { get; set; }
        
      
    }

    public class ChelovekCsv
    {
        //public int Id { get; set; }
        public string IdZayavka { get; set; }
        public string Rayon { get; set; }
        public string FamilyNameRecip { get; set; }
        public string NameRecip { get; set; }
        public string PatronymicRecip { get; set; }

        public DateTime? BirthDateRecip { get; set; }
        public string DocSeriesRecip { get; set; }
        public string DocNumberRecip { get; set; }
        public DateTime? DocIssueDateRecip { get; set; } 
       
        public string DocIssuerRecip { get; set; }

        public DateTime? DecisionDate { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateFinish { get; set; }
        public decimal? Amount { get; set; }

       
        public string FamilyNameReason { get; set; }
        public string NameReason { get; set; }
        public string PatronymicReason { get; set; }
        public string GenderReason { get; set; }
        public DateTime? BirthdateReason { get; set; }
        public string DocSeriesReason { get; set; }
        public string DocNumberReason { get; set; }
        public DateTime? DocIssueDateReason { get; set; }
        public string DocIssuerReason { get; set; }
    }
}

