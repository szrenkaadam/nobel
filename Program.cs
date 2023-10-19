﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nobel
{
    class Program
    {
        static void Main(string[] args)
        {
            var dijazottak = new List<Dijazott>();
            using var sr = new StreamReader(@"..\..\..\src\orvos_nobeldijasok.txt",
                Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                dijazottak.Add(new(sr.ReadLine()));
            }
            Console.WriteLine($"3. feladat: Díjazottak száma: { dijazottak.Count}");

                var f4 = dijazottak.Max(d => d.Ev);

                Console.WriteLine($"4. feladat: Utolsó év: {f4}");

                Console.WriteLine($"5. feladat: Kérem adja meg egy ország kódját:");
                string ok = Console.ReadLine();
                var f5 = dijazottak.Where(d => d.Orszag == ok).ToList();

            if (f5.Count == 0) Console.WriteLine("Az országban nem volt díjazott");
            else if (f5.Count ==1)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }



            }
        }
    }
}
