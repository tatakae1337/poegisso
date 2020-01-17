using SampleApp.Class;
using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SampleApp.DAL
{
	public abstract class GetData
	{
		public static List<ErrorItem> errorList;
		public virtual List<Record> Load(LiquidTechnologies.Test.SampleApp form)
		{
			return null;
		}


		public Dictionary<string, string> GetUlusDict()
		{
			Dictionary<string, string> ulusDict = new Dictionary<string, string>();
			ulusDict.Add("oso_abi@ol_sz2", "Абыйский");
			ulusDict.Add("oso_ala@ol_sz2", "Аллаиховский");
			ulusDict.Add("oso_ald@ol_sz4", "Алданский");
			ulusDict.Add("oso_amg@ol_sz3", "Амгинский");
			ulusDict.Add("oso_ana@ol_sz2", "Анабарский");
			ulusDict.Add("oso_bul@ol_sz2", "Булунский");
			ulusDict.Add("oso_chu@ol_sz2", "Чурапчинский");
			ulusDict.Add("oso_evb@ol_sz2", "Эвено-Бытантайский");
			ulusDict.Add("oso_gat@ol_sz3", "п. Жатай");
			ulusDict.Add("oso_gig@ol_sz3", "Жиганский");
			ulusDict.Add("oso_gor@ol_sz2", "Горный");
			ulusDict.Add("oso_han@ol_sz4", "Хангаласский");
			ulusDict.Add("oso_kob@ol_sz4", "Кобяйский");
			ulusDict.Add("oso_len@ol_sz2", "Ленский");
			ulusDict.Add("oso_mgk@ol_sz4", "Мегино-Кангаласский");
			ulusDict.Add("oso_mir@ol_sz3", "Мирнинский");
			ulusDict.Add("oso_mom@ol_sz2", "Момский");
			ulusDict.Add("oso_nam@ol_sz3", "Намский");
			ulusDict.Add("oso_ner@ol_sz4", "Нерюнгринский");
			ulusDict.Add("oso_niu@ol_sz3", "Нюрбинский");
			ulusDict.Add("oso_nko@ol_sz4", "Нижнеколымский");
			ulusDict.Add("oso_olk@ol_sz4", "Олекминский");
			ulusDict.Add("oso_oln@ol_sz2", "Оленекский");
			ulusDict.Add("oso_oym@ol_sz3", "Оймяконский");
			ulusDict.Add("oso_skl@ol_sz3", "Среднеколымский");
			ulusDict.Add("oso_sun@ol_sz3", "Сунтарский");
			ulusDict.Add("oso_tat@ol_sz4", "Таттинский");
			ulusDict.Add("oso_tom@ol_sz4", "Томпонский");
			ulusDict.Add("oso_ual@ol_sz4", "Усть-Алданский");
			ulusDict.Add("oso_uma@ol_sz4", "Усть-Майский");
			ulusDict.Add("oso_usy@ol_sz3", "Усть-Янский");
			ulusDict.Add("oso_vil@ol_sz3", "Вилюйский");
			ulusDict.Add("oso_vkl@ol_sz2", "Верхнеколымский");
			ulusDict.Add("oso_vvl@ol_sz2", "Верхневилюйский");
			ulusDict.Add("oso_vya@ol_sz4", "Верхоянский");
			ulusDict.Add("oso_ykt@ol_sz3", "г. Якутск");
			return ulusDict;
		}

		public Dictionary<int, string> Monthes()
		{
			Dictionary<int, string> monthes = new Dictionary<int, string>();
			monthes.Add(1, "январь");
			monthes.Add(2, "февраль");
			monthes.Add(3, "март");
			monthes.Add(4, "апрель");
			monthes.Add(5, "май");
			monthes.Add(6, "июнь");
			monthes.Add(7, "июль");
			monthes.Add(8, "август");
			monthes.Add(9, "сентябрь");
			monthes.Add(10, "октябрь");
			monthes.Add(11, "ноябрь");
			monthes.Add(12, "декабрь");
			return monthes;
		}


		//логирование паспорта и свидетельства


		public bool CheckDocumentOwner(Record rec, Dictionary<string, string> ulusDict, string docType)
		{
			//int yu = 0;
			//if (rec.FamilyNameReason.ToUpper().Trim() == "СЕКОВ")
			//    yu++;
			//если isProzhiv=true то это проживающий, иначе заявитель
			//^ - означает начало строки [0-9] -какие символы разрешены,{4} - число повторов
			Regex regexSerPasp = new Regex(@"^[0-9]{4}$");
			Regex regexNumberPasp = new Regex(@"^[0-9]{6}$");
			//{1,3} -число повторов от 1 до 3
			//  Regex regexSerSvid = new Regex(@"[IVXLCDM]{1,3}[\-][А-Я]{2}");
			//проверяем паспорт для заявителя
			if (docType == "01")
			{
				//проверяем серию паспорта
				Match match = regexSerPasp.Match(rec.DocSeriesRecip);
				if (match.Success == false)
				{
					Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " + rec.NumberZ.Trim() + ";ОШИБКА сер пасп заявит:" +
						rec.DocSeriesRecip + ";" + rec.FamilyNameRecip + " " +
					   rec.NameRecip + " " + rec.PatronymicRecip + ";");
					ErrorItem errorItem = new ErrorItem();
					errorItem.Ulus = ulusDict[rec.Oso];
					errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
					errorItem.ErrorText = "ОШИБКА сер пасп заявит: " + rec.DocSeriesRecip;
					errorItem.FIO = "заявитель: " + rec.FamilyNameRecip + " " +
							 rec.NameRecip + " " + rec.PatronymicRecip;
					errorList.Add(errorItem);
					return false;
				}
                
                if (rec.DocSeriesRecip == "1111")
                {
                    Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " + rec.NumberZ.Trim() + ";ОШИБКА сер пасп заявит:" +
                                            rec.DocSeriesRecip + ";" + rec.FamilyNameRecip + " " +
                                           rec.NameRecip + " " + rec.PatronymicRecip + ";");
                    ErrorItem errorItem = new ErrorItem();
                    errorItem.Ulus = ulusDict[rec.Oso];
                    errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
                    errorItem.ErrorText = "ОШИБКА сер пасп заявит: " + rec.DocSeriesRecip;
                    errorItem.FIO = "заявитель: " + rec.FamilyNameRecip + " " +
                             rec.NameRecip + " " + rec.PatronymicRecip;
                    errorList.Add(errorItem);
                    return false;

                }
                if (rec.DocNumberRecip == "111111")
                {
                    Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " + rec.NumberZ.Trim() +
						";ОШИБКА номер пасп заявит: " + rec.DocNumberRecip + ";" + rec.FamilyNameRecip + " " +
					   rec.NameRecip + " " + rec.PatronymicRecip + ";");
					ErrorItem errorItem = new ErrorItem();
					errorItem.Ulus = ulusDict[rec.Oso];
					errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
					errorItem.ErrorText = "ОШИБКА номер пасп заявит: " + rec.DocNumberRecip;
					errorItem.FIO = "заявитель: " + rec.FamilyNameRecip + " " +
							 rec.NameRecip + " " + rec.PatronymicRecip;
					errorList.Add(errorItem);
					return false;

                }

				//проверяем номер паспорта
				match = regexNumberPasp.Match(rec.DocNumberRecip);
				if (match.Success == false)
				{
					Logger.WriteToLog(ulusDict[rec.Oso] + ";" + " № заявки: " + rec.NumberZ.Trim() +
						";ОШИБКА номер пасп заявит: " + rec.DocNumberRecip + ";" + rec.FamilyNameRecip + " " +
					   rec.NameRecip + " " + rec.PatronymicRecip + ";");
					ErrorItem errorItem = new ErrorItem();
					errorItem.Ulus = ulusDict[rec.Oso];
					errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
					errorItem.ErrorText = "ОШИБКА номер пасп заявит: " + rec.DocNumberRecip;
					errorItem.FIO = "заявитель: " + rec.FamilyNameRecip + " " +
							 rec.NameRecip + " " + rec.PatronymicRecip;
					errorList.Add(errorItem);
					return false;
				}
                
                
			}

			return true;

		}

		public bool CheckDocumentProzhiv(Record rec, Prozhiv prozhiv, Dictionary<string, string> ulusDict, string docType)
		{
			Regex regexSerPasp = new Regex(@"^[0-9]{4}$");
			Regex regexNumberPasp = new Regex(@"^[0-9]{6}$");
			//{1,3} -число повторов от 1 до 3
			//  Regex regexSerSvid = new Regex(@"[IVXLCDM]{1,3}[\-][А-Я]{2}");
			//иначе если  это паспорт проживающего
			if (docType == "01")
			{
				//проверяем серию паспорта
				Match match = regexSerPasp.Match(prozhiv.DocSeriesReason);
				if (match.Success == false)
				{
					Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " +
						rec.NumberZ.Trim() + ";ОШИБКА сер пасп прожив: " +
						prozhiv.DocSeriesReason + ";" + prozhiv.FamilyNameReason + " " +
					   prozhiv.NameReason + " " + prozhiv.PatronymicReason + ";");
					ErrorItem errorItem = new ErrorItem();
					errorItem.Ulus = ulusDict[rec.Oso];
					errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
					errorItem.ErrorText = "ОШИБКА сер пасп прожив: " + prozhiv.DocSeriesReason;
					errorItem.FIO = "прожив: " + prozhiv.FamilyNameReason + " " +
							 prozhiv.NameReason + " " + prozhiv.PatronymicReason;
					errorList.Add(errorItem);
					return false;

				}
                if(rec.DocSeriesReason=="1111")
                {
                    Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " +
                        rec.NumberZ.Trim() + ";ОШИБКА сер пасп прожив: " +
                        prozhiv.DocSeriesReason + ";" + prozhiv.FamilyNameReason + " " +
                       prozhiv.NameReason + " " + prozhiv.PatronymicReason + ";");
                    ErrorItem errorItem = new ErrorItem();
                    errorItem.Ulus = ulusDict[rec.Oso];
                    errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
                    errorItem.ErrorText = "ОШИБКА сер пасп прожив: " + prozhiv.DocSeriesReason;
                    errorItem.FIO = "прожив: " + prozhiv.FamilyNameReason + " " +
                             prozhiv.NameReason + " " + prozhiv.PatronymicReason;
                    errorList.Add(errorItem);
                    return false;


                }
                if (rec.DocNumberReason == "111111")
                {
                    Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " +
                        rec.NumberZ.Trim() + ";ОШИБКА номер пасп прожив: " + prozhiv.DocNumberReason +
                        ";" + prozhiv.FamilyNameReason + " " +
                       prozhiv.NameReason + " " + prozhiv.PatronymicReason + ";");

                    ErrorItem errorItem = new ErrorItem();
                    errorItem.Ulus = ulusDict[rec.Oso];
                    errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
                    errorItem.ErrorText = "ОШИБКА номер пасп прожив: " + prozhiv.DocNumberReason;
                    errorItem.FIO = "прожив: " + prozhiv.FamilyNameReason + " " +
                             prozhiv.NameReason + " " + prozhiv.PatronymicReason;
                    errorList.Add(errorItem);
                    return false;

                }

                    //проверяем номер паспорта
                    match = regexNumberPasp.Match(prozhiv.DocNumberReason);
				if (match.Success == false)
				{
					Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " +
						rec.NumberZ.Trim() + ";ОШИБКА номер пасп прожив: " + prozhiv.DocNumberReason +
						";" + prozhiv.FamilyNameReason + " " +
					   prozhiv.NameReason + " " + prozhiv.PatronymicReason + ";");

					ErrorItem errorItem = new ErrorItem();
					errorItem.Ulus = ulusDict[rec.Oso];
					errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
					errorItem.ErrorText = "ОШИБКА номер пасп прожив: " + prozhiv.DocNumberReason;
					errorItem.FIO = "прожив: " + prozhiv.FamilyNameReason + " " +
							 prozhiv.NameReason + " " + prozhiv.PatronymicReason;
					errorList.Add(errorItem);
					return false;

				}
			}
			//просто свидетельство проверим
			else if (docType == "05")
			{

				//проверяем номер свидетельства
				Match match = regexNumberPasp.Match(prozhiv.DocNumberReason);
				if (match.Success == false)
				{
					Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " +
						rec.NumberZ.Trim() + ";ОШИБКА номер свид о рожд прожив: " + prozhiv.DocNumberReason +
						";" + prozhiv.FamilyNameReason + " " +
					   prozhiv.NameReason + " " + prozhiv.PatronymicReason + ";");

					ErrorItem errorItem = new ErrorItem();
					errorItem.Ulus = ulusDict[rec.Oso];
					errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
					errorItem.ErrorText = "ОШИБКА номер свид о рожд прожив: " + prozhiv.DocNumberReason;
					errorItem.FIO = "прожив: " + prozhiv.FamilyNameReason + " " +
							 prozhiv.NameReason + " " + prozhiv.PatronymicReason;
					errorList.Add(errorItem);
					return false;
				}
			}
            else if(docType == "00")
            {
                Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " +
                                        rec.NumberZ.Trim() + ";ОШИБКА номер пасп прожив: " + prozhiv.DocNumberReason +
                                        ";" + prozhiv.FamilyNameReason + " " +
                                       prozhiv.NameReason + " " + prozhiv.PatronymicReason + ";");

                ErrorItem errorItem = new ErrorItem();
                errorItem.Ulus = ulusDict[rec.Oso];
                errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
                errorItem.ErrorText = "ОШИБКА номер пасп прожив: " + prozhiv.DocNumberReason;
                errorItem.FIO = "прожив: " + prozhiv.FamilyNameReason + " " +
                         prozhiv.NameReason + " " + prozhiv.PatronymicReason;
                errorList.Add(errorItem);
                return false;



            }
			return true;
		}

		public bool CheckSnilsOFL(Record rec, Dictionary<string, string> ulusDict, bool isProzhiv)
		{

            string snils = "";
            var charsToRemove = new string[] { " ", "-" };



         

			if (isProzhiv == false)
			{

                snils = rec.SnilsRecip;
                foreach (var c in charsToRemove)
                {
                    snils = snils.Replace(c, "");
                }

                bool checkControl = CheckSnilsProcOFL(snils, rec, ulusDict, false);
                if (!checkControl)
                    return false;


              
			}
			else
			{
                snils = rec.SnilsReason;
                foreach (var c in charsToRemove)
                {
                    snils = snils.Replace(c, "");
                }

                bool checkControl = CheckSnilsProcOFL(snils, rec, ulusDict, true);
                if (!checkControl)
                    return false;

            
			}
			return true;
		}


		public bool CheckSnilsKapRem(Record rec, Dictionary<int, string> ulusDict, bool isProzhiv)
		{
            //Regex regexSnils = new Regex(@"^[0-9]{11}$");
            string snils = "";
            var charsToRemove = new string[] { " ", "-" };
            


            if (isProzhiv == false)
			{
                snils = rec.SnilsRecip;
                foreach (var c in charsToRemove)
                {
                    snils = snils.Replace(c,"");
                }

                bool checkControl = CheckSnilsProcKapremont(snils, rec, ulusDict, true);
                if (!checkControl)
                    return false;
               
			}
			else
			{

                snils = rec.SnilsRecip;
                foreach (var c in charsToRemove)
                {
                    snils = snils.Replace(c, "");
                }

                bool checkControl = CheckSnilsProcKapremont(snils, rec, ulusDict, false);
                if (!checkControl)
                    return false;


                //Match match = regexSnils.Match(rec.SnilsRecip);
              
			}
			return true;
		}


		public void ErrorOtherDocument(Record rec,Dictionary<int,string>docTypes, Dictionary<string, string> ulusDict,int docType,string zayavitel)
        {
            //
            if (zayavitel == "Fact")
            {
                Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " + rec.NumberZ.Trim() + ";" +
                          "ОШИБКА документа: " + docTypes[docType] + ";заявитель: " + rec.FamilyNameRecip + " " +
                         rec.NameRecip + " " + rec.PatronymicRecip + ";");
                ErrorItem errorItem = new ErrorItem();
                errorItem.Ulus = ulusDict[rec.Oso];
                errorItem.NumberZ = "№ заявки: "+ rec.NumberZ.Trim();
                errorItem.ErrorText = "ОШИБКА документа: " + docTypes[docType];
                errorItem.FIO = "заявитель: " + rec.FamilyNameRecip + " " +
                         rec.NameRecip + " " + rec.PatronymicRecip;
                errorList.Add(errorItem);
            }
            else
            {
                Logger.WriteToLog("rayon: "+ulusDict[rec.Oso] + ";" + " № заявки: " + rec.NumberZ.Trim() + ";" +
                    "ОШИБКА документа: " + docTypes[docType] + ";проживающий: " + rec.FamilyNameReason +
                       " " + rec.NameReason + " " + rec.PatronymicReason + ";");
                ErrorItem errorItem = new ErrorItem();
                errorItem.Ulus = ulusDict[rec.Oso];
                errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
                errorItem.ErrorText = "ОШИБКА документа: " + docTypes[docType];
                errorItem.FIO = "проживающий: " + rec.FamilyNameReason + " " +
                         rec.NameReason + " " + rec.PatronymicReason;
                errorList.Add(errorItem);
            }
        }


        public virtual List<RecordXML> GetXMLRecords(List<Record>records)
        {
            return null;
        }
     //проверка снилса по алгоритму для капремонта
        public bool CheckSnilsProcKapremont(string snils,Record rec, Dictionary<int, string> ulusDict,bool isProzhiv)
        {
          
            bool result = false;
            long snilsNum = Int64.Parse(snils);
            long sum = 0;
            for(int i=0;i<9;i++)
            {
                sum += Int64.Parse(snils[i].ToString()) * (9 - i);
            }
            long checkDigit = 0;
            if (sum < 100)
            {
                checkDigit = sum;
            }
            else if (sum > 101)
            {
                checkDigit = sum % 101;
                if (checkDigit == 100)
                {
                    checkDigit = 0;
                }
            }
            if(checkDigit==Int64.Parse(snils.Substring(snils.Length-2)))
            {
                result = true;
            }
            else
            {
                if (!isProzhiv)
                {
                    Logger.WriteToLog("rayon: " + ulusDict[rec.IdRayon] + "; год: " + rec.Year + "; № заявки: " + rec.NumberZ.Trim() + ";" +
                         "ОШИБКА контрольной суммы СНИЛСА: " + rec.SnilsRecip + ";заявитель: " + rec.FamilyNameRecip + " " +
                        rec.NameRecip + " " + rec.PatronymicRecip + ";");
                }
                else
                {
                    Logger.WriteToLog("rayon: " + ulusDict[rec.IdRayon] + "; год: " + rec.Year + "; № заявки: " + rec.NumberZ.Trim() + ";" +
                      "ОШИБКА контрольной суммы СНИЛСА: " + rec.SnilsRecip + ";проживающий: " + rec.FamilyNameReason + " " +
                     rec.NameReason + " " + rec.PatronymicReason + ";");

                }

            }


            return result;
            
        }
    //проверка снилса по алгоритму для ОФЛ
        public bool CheckSnilsProcOFL(string snils, Record rec, Dictionary<string, string> ulusDict, bool isProzhiv)
        {

            bool result = false;
            long snilsNum = Int64.Parse(snils);
            long sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += Int64.Parse(snils[i].ToString()) * (9 - i);
            }
            long checkDigit = 0;
            if (sum < 100)
            {
                checkDigit = sum;
            }
            else if (sum > 101)
            {
                checkDigit = sum % 101;
                if (checkDigit == 100)
                {
                    checkDigit = 0;
                }
            }
            if (checkDigit == Int64.Parse(snils.Substring(snils.Length - 2)))
            {
                result = true;
            }
            else
            {
                if (!isProzhiv)
                {
                    Logger.WriteToLog("rayon: " + ulusDict[rec.Oso] + "; год: " + rec.Year + "; № заявки: " + rec.NumberZ.Trim() + ";" +
                         "ОШИБКА контрольной суммы СНИЛСА: " + rec.SnilsRecip + ";заявитель: " + rec.FamilyNameRecip + " " +
                        rec.NameRecip + " " + rec.PatronymicRecip + ";");
                }
                else
                {
                    Logger.WriteToLog("rayon: " + ulusDict[rec.Oso] + "; год: " + rec.Year + "; № заявки: " + rec.NumberZ.Trim() + ";" +
                      "ОШИБКА контрольной суммы СНИЛСА: " + rec.SnilsRecip + ";проживающий: " + rec.FamilyNameReason + " " +
                     rec.NameReason + " " + rec.PatronymicReason + ";");

                }

            }


            return result;

        }
    }
}
