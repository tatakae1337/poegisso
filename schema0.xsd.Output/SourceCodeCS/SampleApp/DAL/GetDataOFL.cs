using CsvHelper;
using IBM.Data.Informix;
using SampleApp.Class;
using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using static SampleApp.Model.Record;

namespace SampleApp.DAL
{
    public class GetDataOFL : GetData   
    {
    
        //принимаем ссылку на форму
        public override List<Record> Load(LiquidTechnologies.Test.SampleApp form)
        {
            errorList = new List<ErrorItem>();
            string dir = System.AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(dir + "\\Log.txt"))
            {
                File.Delete(dir + "\\Log.txt");
                
            }

            //забираем через формат в месяцы
            DateTime date = DateTime.ParseExact(form.dateTimeGetter.Text, "MMMM yyyy", CultureInfo.CurrentCulture);
            int year = date.Year;
            string yearBase = year.ToString().Substring(year.ToString().Length - 2);
            int month = date.Month;
            int dateStart = 1;
            int dateEnd = 0;

            if (month < 12)
                dateEnd = new DateTime(date.Year, month + 1, 1).AddDays(-1).Day;
            else
                dateEnd = 31;

            string monthVal = "";
			if (month < 10)
				monthVal = "0" + month;
			else
				monthVal = "" + month;
			

            String connString = String.Empty;
            String logFile = String.Empty;
			//создаем все улусы
			
            List<string> uluses = new List<string>();
			//uluses.Add("oso_amg@ol_sz3");   //ok	

			
			uluses.Add("oso_abi@ol_sz2");	//ok
            uluses.Add("oso_ala@ol_sz2");   //ok
			uluses.Add("oso_ald@ol_sz4");	//ok
            uluses.Add("oso_amg@ol_sz3");	//ok	
            uluses.Add("oso_ana@ol_sz2");	//ok
            uluses.Add("oso_bul@ol_sz2");	//ok
            uluses.Add("oso_chu@ol_sz2");
            uluses.Add("oso_evb@ol_sz2");
            uluses.Add("oso_gat@ol_sz3");
            uluses.Add("oso_gig@ol_sz3");
            uluses.Add("oso_gor@ol_sz2");
            uluses.Add("oso_han@ol_sz4");
            uluses.Add("oso_kob@ol_sz4");
            uluses.Add("oso_len@ol_sz2");
            uluses.Add("oso_mgk@ol_sz4");
            uluses.Add("oso_mir@ol_sz3");
            uluses.Add("oso_mom@ol_sz2");
			uluses.Add("oso_nam@ol_sz3");
            uluses.Add("oso_ner@ol_sz4");
            uluses.Add("oso_niu@ol_sz3");
            uluses.Add("oso_nko@ol_sz4");
            uluses.Add("oso_olk@ol_sz4");
            uluses.Add("oso_oln@ol_sz2");
            uluses.Add("oso_oym@ol_sz3");
            uluses.Add("oso_skl@ol_sz3");
            uluses.Add("oso_sun@ol_sz3");
            uluses.Add("oso_tat@ol_sz4");
            uluses.Add("oso_tom@ol_sz4");
            uluses.Add("oso_ual@ol_sz4");
            uluses.Add("oso_uma@ol_sz4");
            uluses.Add("oso_usy@ol_sz3");
            uluses.Add("oso_vil@ol_sz3");
            uluses.Add("oso_vkl@ol_sz2");
            uluses.Add("oso_vvl@ol_sz2");
            uluses.Add("oso_vya@ol_sz4");
            uluses.Add("oso_ykt@ol_sz3");
			


			GetDataOFL prg = new GetDataOFL();
            Dictionary<int, string> typesDoc = GetTypeDocs();
            Dictionary<string, string> ulusDict = GetUlusDict();
            List<Record> records = new List<Record>();

            //  {

            string commandText = "";
            foreach (string ulus in uluses)
            {
				// connString = reader.ReadElementString("ConnectionString");
				//  logFile = reader.ReadElementString("LogFile");


				//    IfxConnection conn = new IfxConnection("Server=ol_sz;Host=10.50.91.17;Service=1526;Database=master14;Password=Rhbbcnvjl11;User ID=informix;Client Locale=ru_ru.CP1251;Database Locale=ru_ru.915;Max Pool Size=500;Pooling=True;Protocol=olsoctcp;Connection Lifetime=1200;Connection Timeout=60;");

                try
                {

					string year_string = year.ToString();
					string ulus_charge = ulus.Remove(7,7) + "_charge_" + year_string.Remove(0,2) + ulus.Remove(0,7); //МЕНЯТЬ ГОД 18/19

                    commandText = "SELECT " +
                            "t_id.number_z as number_zaj," +
                    "t_id.id_zayavka as id_zayav, " +

                    " CASE WHEN g.kod_rod = 99 THEN 'Fact' " +
                    " ELSE 'Reason' " +
                    " END as RecType, " +
                    " CASE WHEN g.kod_rod = 99 THEN '7469941b-6731-4944-be3a-3a6d39c921d2' " +
                    " ELSE '' " +
                    " END as LMSZID, " +
                    " CASE WHEN g.kod_rod = 99 THEN '46277ffb-fc85-42ed-ab76-23e059f26317' " +
                    " ELSE '' " +
                    " END as categoryID, " +
                    " CASE WHEN g.kod_rod = 99 THEN '0336.000001' " +
                    " ELSE '' " +
                    " END as ONMSZCode, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.SNILS_recip_ " +
                    " ELSE '' " +
                    " END as SNILS_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.FamilyName_recip_ " +
                    " ELSE '' " +
                    " END as FamilyName_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.Name_recip_ " +
                    " ELSE '' " +
                    " END as Name_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.Patronymic_recip_ " +
                    " ELSE '' " +
                    " END as Patronymic_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.Gender_recip_ " +
                    " ELSE '' " +
                    " END as Gender_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN TO_CHAR(t_id.BirthDate_recip_, '%d.%m.%Y') " +
                    " ELSE '' " +
                    " END as BirthDate_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.doctype_recip_ " +
                    " ELSE '' " +
                    " END as doctype_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.doc_Series_recip_ " +
                    " ELSE '' " +
                    " END as doc_Series_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.doc_Number_recip_ " +
                    " ELSE '' " +
                    " END as doc_Number_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN TO_CHAR(t_id.doc_IssueDate_recip_, '%d.%m.%Y') " +
                    " ELSE '' " +
                    " END as doc_IssueDate_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.doc_Issuer_recip_ " +
                    " ELSE '' " +
                    " END as doc_Issuer_recip, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.SNILS_reason_ " +
                    " ELSE pr_sp.snils " +
                    " END as SNILS_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.FamilyName_reason_ " +
                    " ELSE g.fam " +
                    " END as FamilyName_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.Name_reason_ " +
                    " ELSE g.ima " +
                    " END as Name_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.Patronymic_reason_ " +
                    " ELSE g.otch " +
                    " END as Patronymic_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.Gender_reason_ " +
                    " ELSE g.sex " +
                    " END as Gender_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.BirthDate_reason_ " +
                    " ELSE g.dat_rog " +
                    " END as BirthDate_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.kod_doc " +
                   //--------------------------------------------------------------
                   " ELSE pr_pasp.kod_doc " +
                    //  "ELSE (CASE pr_pasp.kod_doc=2 THEN '05' ELSE '01' END)"+
                    //-----------------------------------------------------------------
                    " END as doctype_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.doc_Series_reason_ " +
                    " ELSE pr_pasp.serij " +
                    " END as doc_Series_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.doc_Number_reason_ " +
                    " ELSE pr_pasp.nomer " +
                    " END as doc_Number_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.doc_IssueDate_reason_ " +
                    " ELSE pr_pasp.vid_dat " +
                    " END as doc_IssueDate_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.doc_IssueDate_reason_ " +
                    " ELSE pr_pasp.vid_dat " +
                    " END as doc_IssueDate_reason, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.doc_Issuer_reason_ " +
                    " ELSE pr_pasp.vid_mes " +
                    " END as doc_Issuer_reason_, " +
                    " CASE WHEN g.kod_rod = 99 THEN TO_CHAR(t_id.decision_date_,'%d.%m.%Y') " +
                    " ELSE '' " +
                    " END as decision_date, " +
                    " CASE WHEN g.kod_rod = 99 THEN TO_CHAR(t_id.dateStart_,'%d.%m.%Y') " +
                    " ELSE '' " +
                    " END as dateStart, " +
                    " CASE WHEN g.kod_rod = 99 THEN TO_CHAR(t_id.dateFinish_,'%d.%m.%Y') " +
                    " ELSE '' " +
                    " END as dateFinish, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.usingSign_ " +
                    " ELSE '' " +
                    " END as usingSign, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.criteria_ " +
                    " ELSE '' " +
                    " END as criteria, " +
                    " CASE WHEN g.kod_rod = 99 THEN t_id.FormCode_ " +
                    " ELSE '' " +
                    " END as FormCode, " +
                    " CASE WHEN g.kod_rod = 99 THEN TO_CHAR(t_id.amount_) " +
                    " ELSE '' " +
                    " END as amount, " +
                    " CASE WHEN g.kod_rod = 99 THEN measuryCode_ " +
                    " ELSE '' " +
                    " END as measuryCode, " +
                    " CASE WHEN g.kod_rod = 99 THEN monetization_ " +
                    " ELSE '' " +
                    " END as monetization, " +
                    " CASE WHEN g.kod_rod = 99 THEN content_ " +
                    " ELSE '' " +
                    " END as content, " +
                    " CASE WHEN g.kod_rod = 99 THEN comment_ " +
                    " ELSE '' " +
                    " END as comment " +
                    " from " + ulus + ":zaj_subs_regis r " +
                    " left join " + ulus + ":lcount_subsidy l on l.nzp_lcount = r.nzp_lcount " +
                    " left join " + ulus + ":sr_gilec g on g.nzap_gilec = l.nzap_gilec " +
                    " left join " + ulus + ":s_demo_group d on d.nzp_demo_group = r.nzp_demo_group " +
                    " join " + ulus + ":soc_pasp pr_sp on g.nzap_gilec = pr_sp.nzap_gilec " +
                    " join " + ulus + ":sr_pasp pr_pasp on g.nzap_gilec = pr_pasp.nzap_gilec " +
                    " right join(select " +
                    "zaj.request_number as number_z," +
                    "pasp.kod_doc as kod_doc," +
                    " zaj.nzp_zaj_sl as id_zayavka, " +
                    " sp.snils as SNILS_recip_, " +
                    " gil.fam as FamilyName_recip_, " +
                    " gil.ima as Name_recip_, " +
                    " gil.otch as Patronymic_recip_, " +
                    " gil.sex as Gender_recip_, " +
                    " gil.dat_rog as BirthDate_recip_, " +
                    " '01' as doctype_recip_, " +
                    " pasp.serij as doc_Series_recip_, " +
                    " pasp.nomer as doc_Number_recip_, " +
                    " pasp.vid_dat as doc_IssueDate_recip_, " +
                    " pasp.vid_mes as doc_Issuer_recip_, " +
                    " sp.snils as SNILS_reason_, " +
                    " gil.fam as FamilyName_reason_, " +
                    " gil.ima as Name_reason_, " +
                    " gil.otch as Patronymic_reason_, " +
                    " gil.sex as Gender_reason_, " +
                    " gil.dat_rog as BirthDate_reason_, " +
                    " '01' as doctype_reason_, " +
                    " pasp.serij as doc_Series_reason_, " +
                    " pasp.nomer as doc_Number_reason_, " +
                    " pasp.vid_dat as doc_IssueDate_reason_, " +
                    " pasp.vid_mes as doc_Issuer_reason_, " +
                    " zaj.date_decision as decision_date_, " +
                    " zaj.start_subsidy as dateStart_, " +
                    " zaj.finish_subsidy as dateFinish_, " +
                    " 'Нет' as usingSign_, " +
                    " '' as criteria_, " +
                    " '01' as FormCode_, " +
					" (CASE WHEN SUM(ch.sum_subsidy) is NULL THEN 0 ELSE SUM(ch.sum_subsidy) END) as amount_, " + //тут суммируется сумма субсидии по каждой услуге
                    " '01' as measuryCode_, " +
                    " 'Нет' as monetization_, " +
                    " '' as content_, " +
                    " '' as comment_ " +
                    " from " + ulus + ":zaj_subs_lgot zaj " +
                    " left join " + ulus + ":soc_pasp  sp on zaj.nzap_gilec = sp.nzap_gilec   " +
                    " left join " + ulus + ":sr_pasp pasp on zaj.nzap_gilec = pasp.nzap_gilec " +
					" left join " + ulus + ":sr_gilec gil on zaj.nzap_gilec = gil.nzap_gilec  " +
                    " left join " + ulus_charge + ":sz_charge_" + monthVal.ToString() + " ch  " +
                    " on ch.nzap_gilec = zaj.nzap_gilec " +
                    " where zaj.start_subsidy between MDY(" + monthVal + ",01," + year.ToString() + ") and MDY(" + monthVal + "," + dateEnd.ToString() + "," + year.ToString() + ") " +
					" AND gil.kod_rod=99 and zaj.nzp_subs_decision =1 " + //and ch.sum_subsidy is not null " + //чтобы не попали заявления, заведенные задним числом и по которым нет суммы
					" group by 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,33,34,35,36)t_id on r.nzp_zaj_sl = t_id.id_zayavka " +
                    " order by r.nzp_zaj_sl,g.kod_rod desc ";
				//	string zaproz = "select * from oso_abi:zaj_subs_lgot";
				
				/*
					commandText = " SELECT COUNT(*) " +
						" from " + ulus + ":sr_gilec gil " +
						" join " + ulus + ":soc_pasp sp on gil.nzap_gilec = sp.nzap_gilec " +
						" join " + ulus + ":sr_pasp pasp on gil.nzap_gilec = pasp.nzap_gilec " +
						" join " + ulus + ":zaj_subs_lgot zaj on gil.nzap_gilec = zaj.nzap_gilec " +
						" join msz14_charge_" + yearBase + ":receiving_list_" + monthVal.ToString() + " ch " +
						" on ch.nzap_gilec = gil.nzap_gilec " +
						" WHERE zaj.start_subsidy between MDY(" + monthVal + ",01," + year.ToString() + ") and MDY(" + monthVal + "," + dateEnd.ToString() + "," + year.ToString() + ") AND ch.nzp_exp = 6 AND gil.kod_rod=99 ";
						*/


	
					IfxConnection conn = new IfxConnection("Server=ol_sz;Database=master14;Host=10.50.0.74;Service=9088;Password=info:R{2013;User ID=portal;Client Locale=ru_ru.CP1251;Database Locale=ru_ru.915;Max Pool Size=500;Pooling=True;Protocol=olsoctcp;Connection Lifetime=1200;Connection Timeout=60;");

					IfxCommand cmd = new IfxCommand(commandText, conn);
					cmd.CommandTimeout = 600;
                    conn.Open();
                    using (IfxDataReader reader = cmd.ExecuteReader())
                    {
                       
                        while (reader.Read())
                        {
                            
                            Record record = new Record();
                            record.NumberZ = reader["number_zaj"].ToString();
                            record.Oso = ulus;
                            record.IdZayavka = reader["id_zayav"].ToString();
                            record.RecType = reader["RecType"].ToString().Trim();
                            record.LmszId = reader["LMSZID"].ToString().Trim();
                            record.CategoryId = reader["categoryID"].ToString().Trim();
                            record.OnmszCode = reader["ONMSZCode"].ToString().Trim();
                            record.SnilsRecip = reader["SNILS_recip"].ToString().Trim();
                            record.FamilyNameRecip = reader["FamilyName_recip"].ToString().Trim();
                            record.NameRecip = reader["Name_recip"].ToString().Trim();
                            record.PatronymicRecip = reader["Patronymic_recip"].ToString().Trim();
                            record.GenderRecip = reader["Gender_recip"].ToString().Trim();

                            record.BirthDateRecip = (reader["BirthDate_recip"].ToString() == "") ? (DateTime?)null : DateTime.ParseExact(reader["BirthDate_recip"].ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                            record.DoctypeRecip = reader["doctype_recip"].ToString().Trim();
                            record.DocSeriesRecip = reader["doc_Series_recip"].ToString().Replace(" ", "").Trim();
                            record.DocNumberRecip = reader["doc_Number_recip"].ToString().Trim();

                            record.DocIssueDateRecip = (reader["doc_IssueDate_recip"].ToString() == "") ? (DateTime?)null : DateTime.ParseExact(reader["doc_IssueDate_recip"].ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                            record.DocIssuerRecip = reader["doc_Issuer_recip"].ToString().Trim();
                            record.SnilsReason = reader["SNILS_reason"].ToString().Trim();
                            record.FamilyNameReason = reader["FamilyName_reason"].ToString().Trim();
                            record.NameReason = reader["Name_reason"].ToString().Trim();
                            record.PatronymicReason = reader["Patronymic_reason"].ToString().Trim();
                            record.GenderReason = reader["Gender_reason"].ToString().Trim();
                            record.BirthdateReason = DateTime.ParseExact(reader["BirthDate_reason"].ToString(), "dd.MM.yyyy H:mm:ss", CultureInfo.CurrentCulture);
                           
                            // record.DoctypeReason = reader["doctype_reason"].ToString();
                          
                            record.DocSeriesReason = reader["doc_Series_reason"].ToString().Replace(" ", "").Trim();
                            record.DocNumberReason = reader["doc_Number_reason"].ToString().Trim();
                            record.DocIssueDateReason = DateTime.ParseExact(reader["doc_IssueDate_reason"].ToString(), "dd.MM.yyyy H:mm:ss", CultureInfo.CurrentCulture);
                            record.DocIssuerReason = reader["doc_Issuer_reason_"].ToString().Trim();
                            record.DecisionDate = (reader["decision_date"].ToString() == "") ? (DateTime?)null : DateTime.ParseExact(reader["decision_date"].ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                            record.DateStart = (reader["dateStart"].ToString() == "") ? (DateTime?)null : DateTime.ParseExact(reader["dateStart"].ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                            record.DateFinish = (reader["dateFinish"].ToString() == "") ? (DateTime?)null : DateTime.ParseExact(reader["dateFinish"].ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                            record.UsingSign = reader["usingSign"].ToString().Trim();
                            record.Criteria = reader["criteria"].ToString().Trim();
                            record.FormCode = reader["FormCode"].ToString().Trim();
                            record.Amount = (reader["amount"].ToString() == "") ? (Decimal?)null : Decimal.Parse(reader["amount"].ToString().Replace(',', '.'));
                            record.MeasuryCode = reader["measuryCode"].ToString();
                            record.Monetization = reader["monetization"].ToString();
                            record.Comment = reader["comment"].ToString();
                            //меняем свидетельство о рождении - если что, кроме паспортов и свидетельства, то нужен справочник отдельно заводить
                            string typeDoc = "";
                            if (reader["doctype_reason"].ToString() == "41")
                                //паспорт
                                typeDoc = "01";
                            else if (reader["doctype_reason"].ToString() == "2")
                                //свидетельство
                                typeDoc = "05";
                            else
                            {
                                //другой документ - делаем логирование и не включаем в файл
                                typeDoc = reader["doctype_reason"].ToString();
                                ErrorOtherDocument(record, typesDoc, ulusDict, Int32.Parse(typeDoc),record.RecType);
                                continue;

                            }
                            record.DoctypeReason = typeDoc;
                            //если снилс не проходит, то пропускаем
                            if (record.RecType == "Fact")
                            {
                                if (!CheckSnilsOFL(record, ulusDict, false))
                                    continue;
                            }
                            else
                            {
                                if (!CheckSnilsOFL(record, ulusDict, true))
                                    continue;
                            }
                           
                                records.Add(record);

                        }


                    }

					conn.Close();


				}
                catch (Exception ex)
                {
					int d = 0;
                }

            }

            //записываем в файл csv данные для анализа

            //Dictionary<int, string> monthes = Monthes();
            //using (TextWriter writer = new StreamWriter("офл_до_" + monthes[month] + "_" + year + ".csv", false, Encoding.GetEncoding(1251)))
            //{

            //    var csv = new CsvWriter(writer);
            //    csv.Configuration.Delimiter = ";";
            //    csv.WriteRecords(records); // where values implements IEnumerable
            //}


            return records;

        }

        //private bool CheckPassportSvidProzhiv(Record record, Dictionary<string, string> ulusDict)
        //{
        //    Regex regexSerPasp = new Regex(@"^[0-9]{4}$");
        //    Regex regexNumberPasp = new Regex(@"^[0-9]{6}$");
        //    //{1,3} -число повторов от 1 до 3
        //    Regex regexSerSvid = new Regex(@"[IVXLCDM]{1,3}[\-][А-Я]{2}");

        //    Match match=regexSerPasp.Match(record.)
        //}

        private Dictionary<int,string>GetTypeDocs()
        {
            Dictionary<int, string> typeDocs = new Dictionary<int, string>();
            typeDocs.Add(1, "Паспорт СССР");
            typeDocs.Add(2, "Свидетельство о рождении");
            typeDocs.Add(3, "Справка формы 33");
            typeDocs.Add(4, "Временное удостоверение");
            typeDocs.Add(5, "Военный билет солдата");
            typeDocs.Add(6, "Свидет-во о праве на льготы");
            typeDocs.Add(7, "Св-во о рег-ции ходатайства");
          // typeDocs.Add(8, "");
            typeDocs.Add(9, "Удостоверение инвалида ВОВ");
            typeDocs.Add(10, "Удостоверение участника ВОВ");
            typeDocs.Add(11, "Удостоверение о награде");
          //  typeDocs.Add(12, "Паспорт ССС");
            typeDocs.Add(13, "Справка архива");
            typeDocs.Add(14, "Справка военкомата");
            //typeDocs.Add(15, "Паспорт СССР");
            typeDocs.Add(16, "Трудовая книжка");
            typeDocs.Add(17, "Удостоверение пенсионера");
            typeDocs.Add(18, "Удостоверение несоверш. узника");
            typeDocs.Add(19, "Справка о ранении на ВОВ");
            typeDocs.Add(20, "За победу над Гермнией в ВОВ");
            typeDocs.Add(21, "За победу над Японией");
            typeDocs.Add(22, "За трудовую доблесть");
         //   typeDocs.Add(23, "Паспорт СССР");
            typeDocs.Add(24, "За трудовое отличие");
            typeDocs.Add(25, "За оборону города ...");
            typeDocs.Add(26, "Житель блокадного Ленинграда");
            typeDocs.Add(27, "Справка труженика тыла");
      //      typeDocs.Add(28, "Паспорт СССР");
      //     typeDocs.Add(29, "Паспорт СССР");
            typeDocs.Add(30, "Удостоверение вдоды УВОВ");
            typeDocs.Add(31, "Справка ВТЭК");
            typeDocs.Add(32, "Удост. род-й и жен погибш. в/с");
            typeDocs.Add(33, "Справка");
            typeDocs.Add(34, "Удостоверение ветерана труда");
            typeDocs.Add(35, "Справка бюро МСЭ");

            typeDocs.Add(36, "Справка пенсионного отдела");
      //      typeDocs.Add(37, "Паспорт СССР");
      //     typeDocs.Add(38, "Паспорт СССР");
      //      typeDocs.Add(39, "Паспорт СССР");
            typeDocs.Add(40, "Паспорт Минморфлота");
            typeDocs.Add(41, "Паспорт РФ");
      //      typeDocs.Add(42, "Паспорт СССР");
            typeDocs.Add(43, "Загранпаспорт РФ");
            typeDocs.Add(44, "Паспорт моряка");
            typeDocs.Add(45, "Иностранный паспорт");
            typeDocs.Add(46, "Миграционный паспорт");
            typeDocs.Add(47, "Удостоверение личности офицера");
            typeDocs.Add(48, "Вид на жительство");
            typeDocs.Add(49, "Удостоверение беженца в РФ");


            typeDocs.Add(50, "Удост. многодетной семьи");
            typeDocs.Add(51, "Удост. участн. аварии на ЧАЭС");
            typeDocs.Add(52, "Удостоверение инвалида СА");
            typeDocs.Add(53, "Свидет.о праве на льготы реаб.");
            typeDocs.Add(54, "Удост. инвалида с детства");
            typeDocs.Add(55, "Другой документ");
            typeDocs.Add(56, "Удост. инв.уч. аварии на ЧАЭС");
            typeDocs.Add(57, "Дипломатический паспорт РФ");
            typeDocs.Add(58, "Заграничный паспорт РФ");
            typeDocs.Add(59, "Военный билет офицера");
            //typeDocs.Add(60, "Паспорт СССР");
            //typeDocs.Add(61, "Паспорт СССР");
            //typeDocs.Add(62, "Паспорт СССР");
            //typeDocs.Add(63, "Паспорт СССР");
            //typeDocs.Add(64, "Паспорт СССР");
            //typeDocs.Add(65, "Паспорт СССР");
            //typeDocs.Add(66, "Паспорт СССР");
            //typeDocs.Add(67, "Паспорт СССР");
            //typeDocs.Add(68, "Паспорт СССР"); 
            //typeDocs.Add(69, "Паспорт СССР");
            typeDocs.Add(70, "Удостоверение ветерана ВОВ");

            typeDocs.Add(71, "Удостоверение ветерана ПОР");
            typeDocs.Add(72, "Удост. уч-ка аварии на ПО МАЯК");
            typeDocs.Add(73, "Справка о праве на компенсацию");
            typeDocs.Add(74, "Удост-е эвакуир. из зоны отч-я");
            typeDocs.Add(75, "Удост. ветерана боевых действ.");
            typeDocs.Add(76, "Паспорт гражданина Белоруссии");
            typeDocs.Add(77, "Паспорт гражданина Киргизии");
            typeDocs.Add(78, "Св-во о рожд. другого гос-ва");
            typeDocs.Add(79, "Св-во о рожд. государства СНГ");
            typeDocs.Add(80, "Удостоверение");



            return typeDocs;

        }

        public override List<RecordXML> GetXMLRecords(List<Record> records)
        {
            Dictionary<string, string> ulusDict = GetUlusDict();

      
          

            List<RecordXML> list = new List<RecordXML>();

            //сперва сгруппируем по айдишке заявления
            List<string> ids = records.Select(p => p.IdZayavka).Distinct().ToList();
            //теперь обходим по айдишкам заявлений
            foreach (string id in ids)
            {
                //берем только хозяев
                List<Record> item = records.Where(p => p.IdZayavka == id).Where(s=>s.RecType=="Fact").ToList();
                List<Record> prozhivWithOwner = records.Where(p => p.IdZayavka == id).ToList();
                //если одинокий, тогда
                if (item.Count == 1 && prozhivWithOwner.Count==1)
                {
                    RecordXML odinokiy = new RecordXML();
                    odinokiy.Oso = item[0].Oso;
                    odinokiy.NumberZ = item[0].NumberZ;
                    odinokiy.IdZayavka = item[0].IdZayavka;
                    odinokiy.RecType = item[0].RecType;
                    odinokiy.LmszId = item[0].LmszId;
                    odinokiy.CategoryId = item[0].CategoryId;
                    odinokiy.OnmszCode = item[0].OnmszCode;
                    odinokiy.SnilsRecip = item[0].SnilsRecip;
                    odinokiy.FamilyNameRecip = item[0].FamilyNameRecip;
                    odinokiy.NameRecip = item[0].NameRecip;
                    odinokiy.PatronymicRecip = item[0].PatronymicRecip;
                    odinokiy.GenderRecip = item[0].GenderRecip;
                    odinokiy.BirthDateRecip = item[0].BirthDateRecip;
                    odinokiy.DoctypeRecip = item[0].DoctypeRecip;
                    //Выкидываем в лог если паспорт не соответствует шаблону

                    if (!CheckDocumentOwner(item[0], ulusDict, "01"))
                        continue;

                    odinokiy.DocSeriesRecip = item[0].DocSeriesRecip;
                    odinokiy.DocNumberRecip = item[0].DocNumberRecip;
                    odinokiy.DocIssueDateRecip = item[0].DocIssueDateRecip;
                    odinokiy.DocIssuerRecip = item[0].DocIssuerRecip;
                    odinokiy.prozhiv = null;
                    odinokiy.DecisionDate = item[0].DecisionDate;
                    odinokiy.DateStart = item[0].DateStart;
                    odinokiy.DateFinish = item[0].DateFinish;
                    odinokiy.UsingSign = item[0].UsingSign;
                    odinokiy.Criteria = item[0].Criteria;
                    odinokiy.FormCode = item[0].FormCode;
                    odinokiy.Amount = item[0].Amount;
                    odinokiy.MeasuryCode = item[0].MeasuryCode;
                    odinokiy.Monetization = item[0].Monetization;
                    odinokiy.Content = item[0].Content;
                    odinokiy.Comment = item[0].Content;
                    list.Add(odinokiy);
                }
                //не одинокий
                else if(item.Count == 1 && prozhivWithOwner.Count > 1)
                {
                    Record rec = item.Where(p => p.RecType == "Fact").FirstOrDefault();
             
                    if (rec != null)
                    {
                        RecordXML neOdinokiy = new RecordXML();
                        neOdinokiy.Oso = rec.Oso;
                        neOdinokiy.NumberZ = rec.NumberZ;
                        neOdinokiy.IdZayavka = rec.IdZayavka;
                        neOdinokiy.RecType = rec.RecType;
                        neOdinokiy.LmszId = rec.LmszId;
                        neOdinokiy.CategoryId = rec.CategoryId;
                        neOdinokiy.OnmszCode = rec.OnmszCode;
                        neOdinokiy.SnilsRecip = rec.SnilsRecip;
                        neOdinokiy.FamilyNameRecip = rec.FamilyNameRecip;
                        neOdinokiy.NameRecip = rec.NameRecip;
                        neOdinokiy.PatronymicRecip = rec.PatronymicRecip;
                        neOdinokiy.GenderRecip = rec.GenderRecip;
                        neOdinokiy.BirthDateRecip = rec.BirthDateRecip;
                        neOdinokiy.DoctypeRecip = rec.DoctypeRecip;

                        //выкидываем в лог
                        if (!CheckDocumentOwner(rec, ulusDict, "01"))
                            continue;


                        neOdinokiy.DocSeriesRecip = rec.DocSeriesRecip;
                        neOdinokiy.DocNumberRecip = rec.DocNumberRecip;
                        neOdinokiy.DocIssueDateRecip = rec.DocIssueDateRecip;
                        neOdinokiy.DocIssuerRecip = rec.DocIssuerRecip;

                        neOdinokiy.DecisionDate = rec.DecisionDate;
                        neOdinokiy.DateStart = rec.DateStart;
                        neOdinokiy.DateFinish = rec.DateFinish;
                        neOdinokiy.UsingSign = rec.UsingSign;
                        neOdinokiy.Criteria = rec.Criteria;
                        neOdinokiy.FormCode = rec.FormCode;
                        neOdinokiy.Amount = rec.Amount;
                        neOdinokiy.MeasuryCode = rec.MeasuryCode;
                        neOdinokiy.Monetization = rec.Monetization;
                        neOdinokiy.Content = rec.Content;
                        neOdinokiy.Comment = rec.Content;


                        neOdinokiy.prozhiv = new List<Prozhiv>();

                        List<Record> reasons = prozhivWithOwner.Where(p => p.RecType == "Reason").ToList();
                        foreach (Record reason in reasons)
                        {
                          
                           //проживающий может быть как с паспортом, так и с свидетельством
                           Prozhiv prozhiv = new Prozhiv();
                            prozhiv.BirthdateReason = reason.BirthdateReason;
                            prozhiv.DocIssueDateReason = reason.DocIssueDateReason;
                            prozhiv.DocIssuerReason = reason.DocIssuerReason;
                            prozhiv.DocNumberReason = reason.DocNumberReason;
                            prozhiv.DoctypeReason = reason.DoctypeReason;
                            prozhiv.FamilyNameReason = reason.FamilyNameReason;
                            prozhiv.GenderReason = reason.GenderReason;
                            prozhiv.NameReason = reason.NameReason;
                            prozhiv.PatronymicReason = reason.PatronymicReason;
                            prozhiv.SnilsReason = reason.SnilsReason;
                            prozhiv.DocSeriesReason = reason.DocSeriesReason;
                            if (reason.DoctypeReason == "05")
                            {
                                //сюда могут прийти пустые свидетельства о рождении
                                //если что-нибудь пустое то выкидываем лог

                                //if (!CheckSvid(reason, ulusDict))
                                //    //пропускаем
                                //    continue;
                                //пытаемся исправить сперва
                                

                                string corrected = new ErrorItem().ErrorSwipe(reason.DocSeriesReason);
                                //пропускаем если неправильно
                                if (!new ErrorItem().CheckSvidSer(corrected, reason, ulusDict))
                                    continue;
                                prozhiv.DocSeriesReason = corrected;
                                //проверяем номер свидетельства
                                if (!CheckDocumentProzhiv(rec,prozhiv, ulusDict, "05"))
                                    continue;
                            }
                            else if(reason.DoctypeReason=="01")
                            {
                                if (!CheckDocumentProzhiv(rec,prozhiv, ulusDict, "01"))
                                    continue;
                                
                                
                            }
                            else
                            {
                                //пропускаем другие документы
                                continue;
                            }
                          
                          
                            neOdinokiy.prozhiv.Add(prozhiv);

                        }
                        list.Add(neOdinokiy);
                    }
                }

            }

            Dictionary<int, string> monthes = Monthes();
            //using (TextWriter writer = new StreamWriter("офл_XML.csv", false, Encoding.GetEncoding(1251)))
            //{

            //    var csv = new CsvWriter(writer);
            //    csv.Configuration.Delimiter = ";";
            ///*    foreach(RecordXML rec in list)
            //    {

            //        csv.WriteRecord(rec);
            //        if(rec.prozhiv!=null)
            //        {
            //            foreach(Prozhiv prozhiv in rec.prozhiv)
            //            {
            //                csv.WriteRecord(prozhiv);
            //            }

            //        }

            //    }
            //    */
            //    csv.WriteRecords(list); // where values implements IEnumerable

            //}

            using (TextWriter writer = new StreamWriter("ofl_XML.csv", false, Encoding.GetEncoding(1251)))
            {
                List<ChelovekCsv> listcsv = new List<ChelovekCsv>();
                List<RecordXML> list2csv = new List<RecordXML>();
                //int id = 1;

                foreach (var rec in list)
                {
                    var item = new RecordXML();

                    item.IdZayavka = rec.IdZayavka;
                    item.Year = rec.Year;
                    item.RecType = rec.RecType;
                    switch (rec.Oso)
                    {
                        case "oso_abi@ol_sz2":
                            item.Oso = "Абыйский";
                            break;
                        case "oso_ala@ol_sz2":
                            item.Oso = "Аллаиховский";
                            break;
                        case "oso_ana@ol_sz2":
                            item.Oso = "Анабарский";
                            break;
                        case "oso_bul@ol_sz2":
                            item.Oso = "Булунский";
                            break;
                        case "oso_chu@ol_sz2":
                            item.Oso = "Чурапчинский";
                            break;
                        case "oso_evb@ol_sz2":
                            item.Oso = "Эвено-Бытантайский";
                            break;
                        case "oso_gor@ol_sz2":
                            item.Oso = "Горный";
                            break;
                        case "oso_len@ol_sz2":
                            item.Oso = "Ленский";
                            break;
                        case "oso_mom@ol_sz2":
                            item.Oso = "Момский";
                            break;
                        case "oso_oln@ol_sz2":
                            item.Oso = "Оленёкский";
                            break;
                        case "oso_vkl@ol_sz2":
                            item.Oso = "Верхнеколымский";
                            break;
                        case "oso_vvl@ol_sz2":
                            item.Oso = "Верхневилюйский";
                            break;
                        case "oso_amg@ol_sz3":
                            item.Oso = "Амгинский";
                            break;
                        case "oso_gat@ol_sz3":
                            item.Oso = "Жатайский";
                            break;
                        case "oso_gig@ol_sz3":
                            item.Oso = "Жиганский";
                            break;
                        case "oso_mir@ol_sz3":
                            item.Oso = "Мирнинский";
                            break;
                        case "oso_nam@ol_sz3":
                            item.Oso = "Намский";
                            break;
                        case "oso_niu@ol_sz3":
                            item.Oso = "Нюрбинский";
                            break;
                        case "oso_oym@ol_sz3":
                            item.Oso = "Оймяконский";
                            break;
                        case "oso_skl@ol_sz3":
                            item.Oso = "Среднеколымский";
                            break;
                        case "oso_sun@ol_sz3":
                            item.Oso = "Сунтарский";
                            break;
                        case "oso_usy@ol_sz3":
                            item.Oso = "Усть-Янский";
                            break;
                        case "oso_vil@ol_sz3":
                            item.Oso = "Вилюйский";
                            break;
                        case "oso_ykt@ol_sz3":
                            item.Oso = "Якутск";
                            break;
                        case "oso_ald@ol_sz4":
                            item.Oso = "Алданский";
                            break;
                        case "oso_han@ol_sz4":
                            item.Oso = "Хангаласский";
                            break;
                        case "oso_kob@ol_sz4":
                            item.Oso = "Кобяйский";
                            break;
                        case "oso_mgk@ol_sz4":
                            item.Oso = "Мегино-Кангаласский";
                            break;
                        case "oso_ner@ol_sz4":
                            item.Oso = "Нерюнгринский";
                            break;
                        case "oso_nko@ol_sz4":
                            item.Oso = "Нижнеколымский";
                            break;
                        case "oso_olk@ol_sz4":
                            item.Oso = "Олёкминский";
                            break;
                        case "oso_tat@ol_sz4":
                            item.Oso = "Таттинский";
                            break;
                        case "oso_tom@ol_sz4":
                            item.Oso = "Томпонский";
                            break;
                        case "oso_ual@ol_sz4":
                            item.Oso = "Усть-Алданский";
                            break;
                        case "oso_uma@ol_sz4":
                            item.Oso = "Усть-Майский";
                            break;
                        case "oso_vya@ol_sz4":
                            item.Oso = "Верхоянский";
                            break;
                    }
                    item.NumberZ = rec.NumberZ;
                    item.LmszId = rec.LmszId;
                    item.CategoryId = rec.CategoryId;
                    item.OnmszCode = rec.OnmszCode;
                    item.SnilsRecip = rec.SnilsRecip;
                    item.FamilyNameRecip = rec.FamilyNameRecip;
                    item.NameRecip = rec.NameRecip;
                    item.PatronymicRecip = rec.PatronymicRecip;
                    item.GenderRecip = rec.GenderRecip;
                    item.BirthDateRecip = rec.BirthDateRecip;
                    item.DoctypeRecip = rec.DoctypeRecip;
                    item.DocSeriesRecip = rec.DocSeriesRecip;
                    item.DocNumberRecip = rec.DocNumberRecip;
                    item.DocIssueDateRecip = rec.DocIssueDateRecip;
                    item.DocIssuerRecip = rec.DocIssuerRecip;
                    item.SnilsReason = rec.SnilsReason;
                    item.FamilyNameReason = rec.FamilyNameReason;
                    item.NameReason = rec.NameReason;
                    item.PatronymicReason = rec.PatronymicReason;
                    item.GenderReason = rec.GenderReason;
                    item.BirthdateReason = rec.BirthdateReason;
                    item.DoctypeReason = rec.DocIssuerReason;
                    item.DocSeriesReason = rec.DocSeriesReason;
                    item.DocNumberReason = rec.DocNumberReason;
                    item.DocIssueDateReason = rec.DocIssueDateReason;
                    item.DocIssuerReason = rec.DocIssuerReason;
                    item.DecisionDate = rec.DecisionDate;
                    item.DateStart = rec.DateStart;
                    item.DateFinish = rec.DateFinish;
                    item.UsingSign = rec.UsingSign;
                    item.Criteria = rec.Criteria;
                    item.FormCode = rec.FormCode;
                    item.Amount = rec.Amount;
                    item.MeasuryCode = rec.MeasuryCode;
                    item.Monetization = rec.Monetization;
                    item.Content = rec.Content;
                    item.Comment = rec.Comment;
                    item.IdRayon = rec.IdRayon;
                    item.prozhiv = rec.prozhiv;

                    list2csv.Add(item);
                }
                var sortedUsers = from u in list2csv
                                  orderby u.Oso, u.FamilyNameRecip, u.NameRecip, u.PatronymicRecip
                                  select u;

                var csv = new CsvWriter(writer);
                csv.Configuration.Delimiter = ";";
                foreach (var rec in sortedUsers)
                {
                    var item = new ChelovekCsv();

                    item.IdZayavka = rec.IdZayavka;

                    item.Rayon = rec.Oso;
                    item.FamilyNameRecip = rec.FamilyNameRecip;
                    item.NameRecip = rec.NameRecip;
                    item.PatronymicRecip = rec.PatronymicRecip;

                    item.BirthDateRecip = rec.BirthDateRecip;
                    item.DocSeriesRecip = rec.DocSeriesRecip;
                    item.DocNumberRecip = rec.DocNumberRecip;
                    item.DocIssueDateRecip = rec.DocIssueDateRecip;
                    item.DocIssuerRecip = rec.DocIssuerRecip;


                    item.DecisionDate = rec.DecisionDate;
                    item.DateStart = rec.DateStart;
                    item.DateFinish = rec.DateFinish;
                    item.Amount = rec.Amount;
                    listcsv.Add(item);

                    if (rec.prozhiv != null)
                    {
                        foreach (Prozhiv prozhiv in rec.prozhiv.OrderBy(f => f.FamilyNameReason).ThenBy(n => n.NameReason).ThenBy(o => o.PatronymicReason))
                        {
                            var item2 = new ChelovekCsv();

                            item2.IdZayavka = rec.IdZayavka;
                            item2.Rayon = item.Rayon;

                            item2.FamilyNameReason = prozhiv.FamilyNameReason;
                            item2.NameReason = prozhiv.NameReason;
                            item2.PatronymicReason = prozhiv.PatronymicReason;
                            item2.GenderReason = prozhiv.GenderReason;
                            item2.BirthdateReason = prozhiv.BirthdateReason;
                            item2.DocNumberReason = prozhiv.DocNumberReason;
                            item2.DocSeriesReason = prozhiv.DocSeriesReason;
                            item2.DocIssuerReason = prozhiv.DocIssuerReason;
                            item2.DocIssueDateReason = prozhiv.DocIssueDateReason;
                            listcsv.Add(item2);

                        }

                    }
                    //id++;
                }

                csv.WriteRecords(listcsv); // where values implements IEnumerable

            }
            return list;
        }

        
        
    }
}
