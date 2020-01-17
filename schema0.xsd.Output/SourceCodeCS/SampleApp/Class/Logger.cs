using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SampleApp.Class
{
    public static class Logger
    {

        //имя файла для записи мониторинга
        public static string FileMonitor { get; set; }


        public static void WriteToLog(string s, bool isDate = true)
        {
            //  if (FileMonitor.Trim() == "")
            CreateLog();


            using (StreamWriter w = File.AppendText(FileMonitor))
            {
                string line = s.Trim();
                w.WriteLine(line);
            }



        }


        public static void CreateLog()
        {

            //если не существует, то создаем
            if (FileMonitor == null)
            {
                string dir = System.AppDomain.CurrentDomain.BaseDirectory;

                using (var file = System.IO.File.Create(dir + "\\Log.txt"))
                {
                    FileMonitor = "Log.txt";
                }
            }
        }


        public static void Create()
        {
            CreateLog();

        }
    }
}
