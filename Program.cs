using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        #region Props

        static List<int> numbersList = new List<int>()
        {
            34,56,77,32,-12,45,-66,23
        };
        static List<string> townsList = new List<string>()
        {
            "Bat Yam","Bat Galim","Jerusalem","Tel Aviv","Natania","Ashdod", "Eilat","Kiryat Shemona"
        };
        static List<City> citiesList = new List<City>()
        {
            new City {Name = "Hod Hashron", NumberOfPopulation = 1230000, Id ="12"},
            new City {Name = "Ramat Hashron", NumberOfPopulation = 777000, Id ="11"},
            new City {Name = "Kiryat Yam", NumberOfPopulation = 5000, Id ="13"},
            new City {Name = "Kiryat Ata", NumberOfPopulation = 330000, Id ="14"},
            new City {Name = "Beer Tuvia", NumberOfPopulation = 2000, Id ="15"},
            new City {Name = "Beer Sheva", NumberOfPopulation = 34000, Id ="16"},
            new City {Name = "Dimona", NumberOfPopulation = 500000, Id ="17"},
            new City {Name = "Mitspe Ramon", NumberOfPopulation = 8000, Id ="18"},
        };
        #endregion


        static void Main(string[] args)
        {
            #region Ques 1
            //Fitch Negative Numbers
            ////  By Query:

            var query1 = from number in numbersList
                         where number < 0
                         select number;

            foreach (var negativeNumber in query1)
            {
                Console.WriteLine(negativeNumber);
            }

            Console.WriteLine("========================================");

            //// By Lambda Query:

            var lambdaQuery = numbersList.Where(n => n < 0);


            foreach (var negativeNumber in lambdaQuery)
            {
                Console.WriteLine(negativeNumber);
            }

            Console.WriteLine("========================================");

            #endregion

            #region Ques 2 
            // Fitch All Even Numbers And Sort Them Big To Small
            ////  By Query:
            ///

            var query2 = from number in numbersList
                         where (number % 2 == 1)
                         orderby number descending
                         select number;

            foreach (var evenNumber in query2)
            {
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine("========================================");

            //// By Lambda Query:
            ///

            var lambdaQuery2 = numbersList.Where(n => n % 2 == 1).OrderByDescending(n => n);

            foreach (var evenNumber in lambdaQuery2)
            {
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine("========================================");

            #endregion

            #region Ques 3
            // Fitch All Numbers Biger Then 5 And Not Dividing by 3, Select number * 3: 
            ////  By Query:
            ///


            var query3 = from number in numbersList
                         where number > 5 && number % 3 != 0
                         select number * 3;

            foreach (var number in query3)
            {
                Console.WriteLine(number);
            }

            //// By Lambda Query:
            ///

            var lambdeQuery3 = numbersList.Where(n => n > 5 && n % 3 != 0).Select(n => n * 3);


            foreach (var number in lambdeQuery3)
            {
                Console.WriteLine(number);
            }

            #endregion

            #region Ques 7
            //// Sort All Towns And Fitch First 3:
            // By Query:

            var query7 = from town in townsList
                         orderby town
                         select town.Take(3);

            // By Lmabda Query:

            var lambdaQuery7 = townsList.OrderBy(t => t).Take(3);


            #endregion

            #region Ques 8
            //// Fitch Cities Where Population Is More Then 25,000.
            // By Query

            var query8 = from city in citiesList
                         where city.NumberOfPopulation > 25000
                         select city;

            // By Lambde Query:

            var lambdaQuery8 = citiesList.Where(c => c.NumberOfPopulation > 25000);

            #endregion

            #region Ques 9
            //// Fitch Cities Where Population Is More Then 25,000, return Names
            // By Query

            var query9 = from city in citiesList
                         where city.NumberOfPopulation > 25000
                         select city.Name;

            // By Lambde Query:

            var lambdaQuery9 = citiesList.Where(c => c.NumberOfPopulation > 25000).Select(c => c.Name);

            #endregion

            #region Ques 10
            //// Fitch Cities Where Population Is More Then 25,000, return Names
            // By Query

            var query10 = from city in citiesList
                          where city.NumberOfPopulation > 25000
                          select new { city.Name, IsCity = true };
                          


            // By Lambde Query:

            var lambdaQuery10 = citiesList.Where(c => c.NumberOfPopulation > 25000).Select(c => c.Name);

            #endregion

        }

        #region Ques 4
        Func<string, List<string>> GetTownsListContainStringByQuery = town =>
         {
        return townsList.FindAll(t => t.Contains(town));
         };

        #endregion

        #region Ques 5

        public static Func<string, List<string>> GetTownsListNotStartWithStringByQuery = town =>
         {
          return townsList.FindAll(t => !t.StartsWith(town));
         };

        #endregion

        #region Ques 6
        public static Func<string, string> GetFirstTownContainStringByQuery = x =>
        {
          return townsList.Find(t => t.Contains(x));
        };

        #endregion

    }
}
