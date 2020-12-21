using System;
using System.Collections.Generic;
using System.Linq;

namespace My_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Globalization.PersianCalendar persianCalandar =
                        new System.Globalization.PersianCalendar();

            int year = persianCalandar.GetYear(DateTime.Now);
            int month = persianCalandar.GetMonth(DateTime.Now);
            int day = persianCalandar.GetDayOfMonth(DateTime.Now);

            var datePersian = ($"{year}/{month}/{day}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(datePersian);
            Console.ResetColor();

            Data.DatabaseContext database = new Data.DatabaseContext();

            var date = database.GetDatas.ToArray();

            var select = database.GetDatas.Select(c => c.Date.Substring(0, 2)).Distinct();

            foreach (var number in select)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(number);
                Console.ResetColor();

            }

            Console.Write("Enter Years:");
            var getDate = Console.ReadLine();

            var data = database.GetDatas.ToArray();

            IEnumerable<IGrouping<string, Models.GetData>> query =
            from i in data
            group i by i.Code;

            foreach (var group in query)
            {
                Console.WriteLine($"Ingredients with {group.Key} calories");

                foreach (Models.GetData getData in group)
                {
                    var dateInData = getData.Date.Substring(0, 2);
                    if (dateInData == getDate)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{getData.Date}");
                        Console.ResetColor();
                    }
                }
            }

        }
    }
}
