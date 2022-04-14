using System;
using System.Collections.Generic;

namespace Generic_type
{
    class Program
    {
        static void Main(string[] args)
        {
            PLanguage pl1 = new PLanguage("Python", 1991);
            PLanguage pl2 = new PLanguage("C++",1983 );
            PLanguage pl3 = new PLanguage("C#", 2001);
            PLanguage pl4 = new PLanguage("Java",1995);
            List<PLanguage> pl = new List<PLanguage>();
            pl.Add(pl1);
            pl.Add(pl2);
            pl.Add(pl3);
            pl.Add(pl4);
            pl.Sort((x, y) => x.Year - y.Year);
            

            foreach (var item in pl)
            {
                Console.WriteLine(item.Year);
            }
            //foreach (var item in pl)
            //{
            //    Console.WriteLine(item.Name);
            //}
            foreach (var item in pl)
            {
                Console.WriteLine($"{item.Name} and {item.Year}");
            }
           






        }
    }
}
    

