using CsvHelper;
using Npgsql;
using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Data;
using SampleApp.Class;

namespace SampleApp.DAL
{
    public class GetDataKaprem : GetData
    {

        public static Dictionary<int, string> GetUlus()
        {
            Dictionary<int, string> uluses = new Dictionary<int, string>();
            uluses.Add(1, "Абыйский");
            uluses.Add(2, "Верхнеколымский");
            uluses.Add(3, "Алданский");
            uluses.Add(4, "Амгинский");
            uluses.Add(5, "Булунский");
            uluses.Add(6, "Анабарский");
            uluses.Add(7, "Верхоянский");
            uluses.Add(8, "Аллаиховский");
            uluses.Add(9, "Верхневилюйский");
            uluses.Add(10, "Горный");
            uluses.Add(11, "Жиганский");
            uluses.Add(12, "Кобяйский");
            uluses.Add(13, "Вилюйский");
            uluses.Add(14, "Ленский");
            uluses.Add(15, "Мегино-Кангаласский");
            uluses.Add(16, "Момский Национальный");
            uluses.Add(17, "Намский");
            uluses.Add(18, "Мирнинский");
            uluses.Add(19, "Оймяконский");
            uluses.Add(20, "Олекминский");
            uluses.Add(21, "Нижнеколымский");
            uluses.Add(22, "Нюрбинский");
            uluses.Add(23, "Среднеколымский");
            uluses.Add(24, "Сунтарский");
            uluses.Add(25, "Оленекский эвенкийский национальный");
            uluses.Add(26, "Усть-Майский");
            uluses.Add(27, "Усть-Алданский");
            uluses.Add(28, "Таттинский");
            uluses.Add(29, "Томпонский");
            uluses.Add(30, "Усть-Янский");
            uluses.Add(31, "Чурапчинский");
            uluses.Add(32, "Хангаласский");
            uluses.Add(33, "Эвено-Бытантайский Национальный");
            uluses.Add(34, "Якутск");
            uluses.Add(35, "Нерюнгри");
            uluses.Add(36, "Жатай");
            return uluses;



        }

        public static Dictionary<string, string> GetReverseUlus()
        {
            Dictionary<string, string> uluses = new Dictionary<string, string>();
            uluses.Add("Абыйский", "oso_abi@ol_sz2");
            uluses.Add("Аллаиховский", "oso_ala@ol_sz2");
            uluses.Add("Алданский", "oso_ald@ol_sz4");
            uluses.Add("Амгинский", "oso_amg@ol_sz3");
            uluses.Add("Анабарский", "oso_ana@ol_sz2");
            uluses.Add("Булунский", "oso_bul@ol_sz2");
            uluses.Add("Чурапчинский", "oso_chu@ol_sz2");
            uluses.Add("Эвено-Бытантайский Национальный", "oso_evb@ol_sz2");
            uluses.Add("Жатай", "oso_gat@ol_sz3");
            uluses.Add("Жиганский", "oso_gig@ol_sz3");
            uluses.Add("Горный", "oso_gor@ol_sz2");
            uluses.Add("Хангаласский", "oso_han@ol_sz4");
            uluses.Add("Кобяйский","oso_kob@ol_sz4");
            uluses.Add("Ленский", "oso_len@ol_sz2");
            uluses.Add("Мегино-Кангаласский","oso_mgk@ol_sz4");
            uluses.Add("Мирнинский","oso_mir@ol_sz3" );
            uluses.Add("Момский Национальный","oso_mom@ol_sz2");
            uluses.Add("Намский","oso_nam@ol_sz3");
            uluses.Add("Нерюнгри","oso_ner@ol_sz4" );
            uluses.Add("Нюрбинский","oso_niu@ol_sz3");
            uluses.Add("Нижнеколымский","oso_nko@ol_sz4");
            uluses.Add("Олекминский","oso_olk@ol_sz4");
            uluses.Add("Оленекский эвенкийский национальный","oso_oln@ol_sz2");
            uluses.Add("Оймяконский","oso_oym@ol_sz3");
            uluses.Add("Среднеколымский","oso_skl@ol_sz3");
            uluses.Add("Сунтарский","oso_sun@ol_sz3");
            uluses.Add("Таттинский","oso_tat@ol_sz4");
            uluses.Add("Томпонский","oso_tom@ol_sz4");
            uluses.Add("Усть-Алданский","oso_ual@ol_sz4");
            uluses.Add("Усть-Майский","oso_uma@ol_sz4");
            uluses.Add("Усть-Янский","oso_usy@ol_sz3");
            uluses.Add("Вилюйский","oso_vil@ol_sz3");
            uluses.Add("Верхнеколымский","oso_vkl@ol_sz2");
            uluses.Add("Верхневилюйский","oso_vvl@ol_sz2");
            uluses.Add("Верхоянский","oso_vya@ol_sz4");
            uluses.Add("Якутск","oso_ykt@ol_sz3");
            return uluses;



        }

        //принимаем ссылку на форму для вытаскивания месяца и года
        public override List<Record> Load(LiquidTechnologies.Test.SampleApp form)
        {
            errorList = new List<ErrorItem>();
            string dir = System.AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(dir + "\\Log.txt"))
            {
                File.Delete(dir + "\\Log.txt");
            }

            CultureInfo culture = new CultureInfo("ru-RU");
            culture.NumberFormat.NumberDecimalSeparator = ".";
            culture.NumberFormat.CurrencyDecimalSeparator = ".";
            culture.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;


            List<Record> records = new List<Record>();
            DateTime date = DateTime.ParseExact(form.dateTimeGetter.Text, "MMMM yyyy", CultureInfo.CurrentCulture);
            //год для поиска в таблицах по годам
            int year = date.Year;
            //по какой год будем искать - зависит от года
            int yearEnd = year - 3;
            //год для выплаты
            int yearPayment = date.Year;
            string yearBase = year.ToString().Substring(year.ToString().Length - 2);
            int month = date.Month;
            int dateStart = 1;
            int dateEnd = 0;
            //находим последний день месяца
            if (month < 12)
                dateEnd = new DateTime(date.Year, month + 1, 1).AddDays(-1).Day;
            else
                dateEnd = 31;

            string monthVal = "";
            if (month < 10)
                monthVal = "0" + month;
            //сперва находим - есть ли авансовый год

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=10.50.0.82;Port=5432;Database=SubsUOW;User Id=postgres;Password=3I5BEvynPQ;"))
            {
                NpgsqlCommand cmd = new NpgsqlCommand("select get_max_year() as max_year", conn);
                conn.Open();
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int maxYear = 0;

                        maxYear = Int32.Parse(reader["max_year"].ToString());
                        //увеличиваем на год если есть авансовый год
                        if (maxYear != year)
                            year++;
                    }
                }
            }

            Dictionary<string, string> reverseUluses = GetReverseUlus();

            for (int i = year; i > yearEnd; i--)
            {
                string commandText = "select DISTINCT 'Fact' as RecType, " +
                    "'0688203c-0fe1-49bc-88d6-40f6fee800b6' as LMSZID," +
                    "'59c8cf04-a207-4704-b40f-f0843b230b11' as categoryID, " +
                    "'0336.000001' as ONMSZCode,  " +
                    "zayavitel.snils as SNILS_recip," +
                    "zayavitel.familia as FamilyName_recip, " +
                    "zayavitel.imya as Name_recip," +
                    "zayavitel.otchestvo as Patronomic_recip, " +
                    "(CASE WHEN zayavitel.pol = 'М' THEN 'М' ELSE 'Ж' END) as Gender_recip," +
                    "to_char(zayavitel.data_rozhd,'dd.mm.yyyy') as BirthDate_recip," +
                    "'01' as doctype_recip," +
                    "zayavitel.passport_seria as doc_Series_recip," +
                    "zayavitel.passport_number as doc_Number_recip, " +
                    "to_char(zayavitel.data_vidachi_passport, 'dd.mm.yyyy') as doc_IssueDate_recip," +
                    "zayavitel.kem_vidan_passport as doc_Issuer_recip," +
                    "zayavitel.snils as SNILS_reason," +
                    "zayavitel.familia as FamilyName_reason," +
                    "zayavitel.imya as Name_reason," +
                    "zayavitel.otchestvo as Patronomic_reason, " +
                    "(CASE WHEN zayavitel.pol = 'М' THEN 'М' ELSE 'Ж' END) as Gender_reason," +
                    "to_char(zayavitel.data_rozhd,'dd.mm.yyyy') as BirthDate_reason, " +
                    "'01' as doctype_reason," +
                    "zayavitel.passport_seria as doc_Series_reason," +
                    "zayavitel.passport_number as doc_Number_reason, " +
                    "to_char(zayavitel.data_vidachi_passport, 'dd.mm.yyyy') as doc_IssueDate_reason, " +
                    "zayavitel.kem_vidan_passport as doc_Issuer_reason," +
                    "to_char(zayav.data_reshenia, 'dd.mm.yyyy') as decision_date, " +
                    "to_char(zayav.komp_s, 'dd.mm.yyyy') as dateStart, " +
                    "to_char(zayav.komp_po, 'dd.mm.yyyy') as dateFinish," +
                    "'Нет' as UsingSign, " +
                    "'' as Criteria," +
                    "'01' as FormCode," +
                    "payment.clear_payment as amount," +
                    "'01' as measuryCode," +
                    "'Нет' as monetization," +
                    "'' as content," +
                    "'' as comment," +
                    "payment.id_z as id_z, payment.id_rayon as id_rayon, " +
                //айдишка и год заявления нужна для последующего выбора снилсов для проживающих
                    "zayav.id as id_zayav," + i + " as year, " +
                    "zayav.number_zayavka as number_z, "+
                    "rayon.rayon as rayon "+
                    "from " +
                    " payment" + yearPayment + " payment " +
                    " join reestr on payment.id_reestr= reestr.id " +
                    " join zayavlenie" + i + " zayav on zayav.id_z= payment.id_z " +
                    " join zayavitel on payment.id_z= zayavitel.id " +
                    " join rayon on rayon.id=payment.id_rayon "+
                    " where reestr.month_year= date'" + yearPayment + "-" + month + "-01' and zayav.restore= false and zayav.proveden= true " +
                    " and zayav.data_dok>='" + yearPayment + "-" + month + "-01' and zayav.data_dok<='" + yearPayment + "-" + month + "-" + dateEnd + "' order by rayon,FamilyName_recip,Name_recip,Patronomic_recip";

                using (NpgsqlConnection conn = new NpgsqlConnection("Server=10.50.0.82;Port=5432;Database=SubsUOW;User Id=postgres;Password=3I5BEvynPQ;"))
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(commandText, conn);
                    conn.Open();
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Record record = new Record();
                            try
                            {
                                record.IdZayavka = reader["id_zayav"].ToString();
                            }
                            catch (Exception ex)
                            {
                                //id-шек - только перерасчет
                                //вообще пропускаем - не разобраться за какой месяц дали, по какому заявлению и т.д
                                continue;
                                
                            }
                            record.Year = reader["year"].ToString();
                            record.RecType = reader["RecType"].ToString().Trim();
                            record.LmszId = reader["LMSZID"].ToString().Trim();
                            record.CategoryId = reader["categoryID"].ToString().Trim();
                            record.OnmszCode = reader["ONMSZCode"].ToString().Trim();
                            record.SnilsRecip = reader["SNILS_recip"].ToString().Trim();
                            record.FamilyNameRecip = reader["FamilyName_recip"].ToString().Trim();
                            record.NameRecip = reader["Name_recip"].ToString().Trim();
                            record.NumberZ = reader["number_z"].ToString();
                            record.Oso = reverseUluses[reader["rayon"].ToString()];
                            try
                            {
                                record.PatronymicRecip = reader["Patronomic_recip"].ToString().Trim();
                            }
                            catch (Exception)
                            {
                                record.PatronymicRecip = "-";
                            }
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
                            try
                            {
                                record.PatronymicReason = reader["Patronomic_reason"].ToString().Trim();
                            }
                            catch
                            {
                                record.PatronymicReason = "-";
                            }
                            record.GenderReason = reader["Gender_reason"].ToString().Trim();
                            record.BirthdateReason = DateTime.ParseExact(reader["BirthDate_reason"].ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                            record.DoctypeReason = reader["doctype_reason"].ToString();
                            record.DocSeriesReason = reader["doc_Series_reason"].ToString().Replace(" ", "").Trim();
                            record.DocNumberReason = reader["doc_Number_reason"].ToString().Trim();
                            record.DocIssueDateReason = DateTime.ParseExact(reader["doc_IssueDate_reason"].ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                            record.DocIssuerReason = reader["doc_Issuer_reason"].ToString().Trim();
                            record.DecisionDate = (reader["decision_date"].ToString() == "") ? (DateTime?)null : DateTime.ParseExact(reader["decision_date"].ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                            record.DateStart = (reader["dateStart"].ToString() == "") ? (DateTime?)null : DateTime.ParseExact(reader["dateStart"].ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                            record.DateFinish = (reader["dateFinish"].ToString() == "") ? (DateTime?)null : DateTime.ParseExact(reader["dateFinish"].ToString(), "dd.MM.yyyy", CultureInfo.CurrentCulture);
                            record.UsingSign = reader["usingSign"].ToString().Trim();
                            record.Criteria = reader["criteria"].ToString().Trim();
                            record.FormCode = reader["FormCode"].ToString().Trim();
                            if (reader["amount"].ToString() == "")
                                continue;
                            else if (decimal.Parse(reader["amount"].ToString()) == 0)
                                continue;
                            record.Amount = (reader["amount"].ToString() == "") ? (Decimal?)null : Decimal.Parse(reader["amount"].ToString().Replace(',', '.'));
                            record.MeasuryCode = reader["measuryCode"].ToString();
                            record.Monetization = reader["monetization"].ToString();
                            record.Comment = reader["comment"].ToString();
                            record.IdRayon = Int32.Parse(reader["id_rayon"].ToString());


                            //если снилс не проходит, то пропускаем
                            if (record.RecType == "Fact")
                            {
                                if (!CheckSnilsKapRem(record, GetUlus(), false))
                                    continue;
                            }
                            else
                            {
                                if (!CheckSnilsKapRem(record, GetUlus(), true))
                                    continue;
                            }
                           

                            records.Add(record);
                        }
                    }
                }
            }

            Dictionary<int, string> monthes = Monthes();
            using (TextWriter writer = new StreamWriter("капрем_" + monthes[month] + "_" + yearPayment + ".csv", false, Encoding.GetEncoding(1251)))
            {

                var csv = new CsvWriter(writer);
                csv.Configuration.Delimiter = ";";
                csv.WriteRecords(records); // where values implements IEnumerable
            }

            return records;
        }

        //Группировка для XML
        public override List<RecordXML> GetXMLRecords(List<Record> records)
        {

            string dir = System.AppDomain.CurrentDomain.BaseDirectory;
            if (File.Exists(dir + "\\test.txt"))
            {
                File.Delete(dir + "\\test.txt");
            }
            Dictionary<string, string> ulusDict = GetUlusDict();

            List<RecordXML> list = new List<RecordXML>();

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=10.50.0.82;Port=5432;Database=SubsUOW;User Id=postgres;Password=3I5BEvynPQ;"))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {

                    cmd.Connection = conn;
                    conn.Open();
                    //делаем запросы
                    foreach (Record rec in records)
                    {


                        //сперва выясняем проживающий одинокий или нет
                        //находим год
                        int year = rec.DateFinish.Value.Year;
                        int cnt = 0;
                        cmd.CommandText = "select count(*) as cnt from rodstvennik" + year + " where id_zayavka=" + rec.IdZayavka;
                        //если нет родственников, то проезжаем
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cnt = Int32.Parse(reader["cnt"].ToString());

                            }

                        }
                        //одинокий
                        if (cnt == 0)
                        {
                            //не делаем запрос - тупо перезапишем


                            RecordXML odinokiy = new RecordXML();
                            odinokiy.Oso = rec.Oso;
                            odinokiy.NumberZ = rec.NumberZ;
                            odinokiy.IdZayavka = rec.IdZayavka;
                            odinokiy.RecType = rec.RecType;
                            odinokiy.LmszId = rec.LmszId;
                            odinokiy.CategoryId = rec.CategoryId;
                            odinokiy.OnmszCode = rec.OnmszCode;
                            odinokiy.SnilsRecip = rec.SnilsRecip;
                            odinokiy.FamilyNameRecip = rec.FamilyNameRecip;
                            odinokiy.NameRecip = rec.NameRecip;
                            odinokiy.PatronymicRecip = rec.PatronymicRecip;
                            odinokiy.GenderRecip = rec.GenderRecip;
                            odinokiy.BirthDateRecip = rec.BirthDateRecip;
                            odinokiy.DoctypeRecip = rec.DoctypeRecip;
                            if (!CheckDocumentOwner(rec, ulusDict, "01"))
                                continue;

                            odinokiy.DocSeriesRecip = rec.DocSeriesRecip;
                            odinokiy.DocNumberRecip = rec.DocNumberRecip;
                            odinokiy.DocIssueDateRecip = rec.DocIssueDateRecip;
                            odinokiy.DocIssuerRecip = rec.DocIssuerRecip;
                            odinokiy.prozhiv = null;
                            odinokiy.DecisionDate = rec.DecisionDate;
                            odinokiy.DateStart = rec.DateStart;
                            odinokiy.DateFinish = rec.DateFinish;
                            odinokiy.UsingSign = rec.UsingSign;
                            odinokiy.Criteria = rec.Criteria;
                            odinokiy.FormCode = rec.FormCode;
                            odinokiy.Amount = rec.Amount;
                            odinokiy.MeasuryCode = rec.MeasuryCode;
                            odinokiy.Monetization = rec.Monetization;
                            odinokiy.Content = rec.Content;
                            odinokiy.Comment = rec.Content;
                            list.Add(odinokiy);
                        }
                        else
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
                            //тут делаем запрос к родственникам
                            cmd.CommandText = "select * from rodstvennik" + year + " where id_zayavka=" + rec.IdZayavka;
                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {

                                    //проживающий может быть как с паспортом, так и с свидетельством
                                    int idDoc = Int32.Parse(reader["id_doc"].ToString());

                                    Prozhiv prozhiv = new Prozhiv();
                                    //если тип документа паспорт 1 если пусто (будет 0), то тогда на ошибку
                                   
                                   
                                    prozhiv.BirthdateReason = DateTime.Parse(reader["date_rozhd"].ToString());
                                    if (idDoc == 1)
                                    {
                                        prozhiv.DocIssueDateReason = DateTime.Parse(reader["data_vidachi_passport"].ToString());
                                        prozhiv.DocIssuerReason = reader["kem_vidan_passport"].ToString();
                                        prozhiv.DocNumberReason = reader["passport_number"].ToString();
                                        prozhiv.DoctypeReason = "01";
                                        prozhiv.DocSeriesReason =reader["passport_seria"].ToString();


                                    }
                                    //свидетельство о рождении
                                    else if (idDoc == 2)
                                    {
                                        prozhiv.DocIssueDateReason = DateTime.Parse(reader["data_vidachi_svid"].ToString());
                                        prozhiv.DocIssuerReason = null;
                                        prozhiv.DocNumberReason = reader["svid_number"].ToString();
                                        prozhiv.DoctypeReason = "05";
                                        prozhiv.DocSeriesReason = reader["svid_ser"].ToString();
                                    }

                                    prozhiv.FamilyNameReason = reader["Familia"].ToString();
                                    prozhiv.GenderReason = reader["pol"].ToString();
                                    prozhiv.NameReason = reader["imya"].ToString();
                                    prozhiv.PatronymicReason = reader["otchestvo"].ToString();
                                    prozhiv.SnilsReason = reader["snils"].ToString();
                                    //выкидываем (не добавляем вообще заявителя)
                                    if (idDoc == 0)
                                    {
                                        if (!CheckDocumentProzhiv(rec, prozhiv, ulusDict, "00"))
                                            continue;

                                    }
                                    if (idDoc == 1)
                                    {
                                        if (!CheckDocumentProzhiv(rec, prozhiv, ulusDict, "01"))
                                            continue;

                                    }
                                    if (idDoc == 2)
                                    {
                                        if (!CheckDocumentProzhiv(rec, prozhiv, ulusDict, "05"))
                                            continue;

                                    }
                                   





                                   


                                    neOdinokiy.prozhiv.Add(prozhiv);

                                }

                            }
                            list.Add(neOdinokiy);

                        }

                    }

                    conn.Close();




                }





            }




            using (TextWriter writer = new StreamWriter("kaprem_XML.csv", false, Encoding.GetEncoding(1251)))
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

             

        

            

       
