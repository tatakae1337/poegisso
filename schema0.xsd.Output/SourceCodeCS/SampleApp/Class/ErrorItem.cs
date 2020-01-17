using SampleApp.DAL;
using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SampleApp.Class
{
    public class ErrorItem
    {
       public string Ulus { get; set; }
       public string NumberZ { get; set; }
       public string ErrorText { get; set; }
       public string FIO { get; set; }

        public void SaveToCsv()
        {


        }
        //попытка исправления серий свидетельств о рождении
        public string ErrorSwipe(string item)
        {
            string temp = item.ToUpper();
            //находим строку без тире
            int found = temp.IndexOf('-');
            if (found<0)
            {
                //добавляем третьим символом справа -
                string tempStart = temp.Substring(0,temp.Length - 2);
                string tempEnd = temp.Substring(temp.Length - 2,2);
                temp = tempStart + "-" + tempEnd;

            }
            //сперва в верхний регистр, заменяем 1 на I, английские на русские символы
            StringBuilder result = new StringBuilder(temp);
            result = result.Replace("1", "I");
            result = result.Replace("2", "II");
            result = result.Replace("3", "III");
            result = result.Replace("C","С");
            result = result.Replace("H", "Н");
            return result.ToString();
        }

        public bool CheckSvidSer(string item,Record rec,Dictionary<string,string>ulusDict)
        {
            //если isProzhiv=true то это проживающий, иначе заявитель
            //^ - означает начало строки [0-9] -какие символы разрешены,{4} - число повторов

            //{1,3} -число повторов от 1 до 3
            Regex regexSerSvid = new Regex(@"[IVXLCDM]{1,3}[\-][А-Я]{2}");
            //проверяем серию свидетельства
            Match match = regexSerSvid.Match(item);
            if (match.Success == false)
            {
                Logger.WriteToLog(ulusDict[rec.Oso] + ";" + "№ заявки: " +
                    rec.NumberZ.Trim() + ";ОШИБКА сер свид о рожд прожив: " +
                    rec.DocSeriesReason + ";" + rec.FamilyNameReason + " " +
                   rec.NameReason + " " + rec.PatronymicReason + ";");

                ErrorItem errorItem = new ErrorItem();
                errorItem.Ulus = ulusDict[rec.Oso];
                errorItem.NumberZ = "№ заявки: " + rec.NumberZ.Trim();
                errorItem.ErrorText = "ОШИБКА сер свид о рожд прожив: " + rec.DocSeriesReason;
                errorItem.FIO = "проживающий: " + rec.FamilyNameReason + " " +
                         rec.NameReason + " " + rec.PatronymicReason;
                GetData.errorList.Add(errorItem);
                return false;
            }
            return true;

        }
    }
}
