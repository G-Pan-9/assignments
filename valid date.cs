using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string testDate = "nhnejdheh;#11;+:$?3773;#;#hebs02292028ndbd!$;73;:hs!+37)";
            Regex rgx = new Regex(@"(([0][1-9]|[1][0-2])([0-2][1-9]|[1-2][0]|[3][0-1])\d{4})");
            Match mat = rgx.Match(testDate);
            string a = mat.ToString();
            //Console.WriteLine(a);
            
         string year = a.Substring(a.Length - 4);
             // Console.WriteLine(year);
              int yyyy = Int32.Parse(year);
         string month = a.Substring(0,2);
             // Console.WriteLine(month);
              int mm = Int32.Parse(month);
         string date = a.Substring(2,2);
             // Console.WriteLine(date);
              int dd = Int32.Parse(date);
         
           // this case is for the months with 31 days 
            if((dd>=01 && dd<=31) && (mm==01 || mm==03 || mm==05 || mm==07 || mm==08 || mm==10 || mm==12))
                Console.WriteLine(a);
           // this case is for the months with 30 days
            else if((dd>=01 && dd<=30) && (mm==04 || mm==06 || mm==09 || mm==11))
                Console.WriteLine(a);
          // this case is for the month February with 28 days, not a leap year 
            else if((dd>=01 && dd<=28) && (mm==02))
                Console.WriteLine(a);
           // this case is ofr the month february in a leap year
            else if (dd==29 && mm==2 && (yyyy%400==0 ||(yyyy%4==0 && yyyy%100!=0)))
                Console.WriteLine(a);
            else
                Console.WriteLine("invalid");
         
               Console.ReadLine();
        }
    }
}
