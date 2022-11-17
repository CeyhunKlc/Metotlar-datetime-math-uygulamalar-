﻿using System;

namespace metotlar_datetime_math
{
    class program
    {
        static void Main(string[]args)
        { 
            Console.WriteLine(DateTime.Now); //günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); //11
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Now
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Nowember

            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

           Console.WriteLine("***** Math Kütüphanesi*****");

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); // 25;
            Console.WriteLine(Math.Sin(10)); // 25;
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3));   //23
            Console.WriteLine(Math.Round(22.3));    //22
            Console.WriteLine(Math.Round(22.7));   //23
            Console.WriteLine(Math.Floor(22.7));  //22

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

             Console.WriteLine(Math.Pow(3,4)); // 3 üzeri 4 ü verir.81.
            Console.WriteLine(Math.Sqrt(9)); // karekök alır. 3.
            Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logaritmik karşılığını getirir.
            Console.WriteLine(Math.Exp(3)); // e üzeri 3 verir.
            Console.WriteLine(Math.Log10(10)); //10 sayısının  logaritma 10 tabanındaki karşılığı.
            


            
        }
    }
}       