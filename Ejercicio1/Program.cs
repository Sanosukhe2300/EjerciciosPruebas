﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables

            int a = 1001;
            long a3 = 444444;
            decimal a1 = 23.44M;
            Double a4 = 45.666;
            string b = "prueba";
            bool g = false;

            #endregion


            #region IF

            if(a == 1001 || a3 == 333333)
            {
                System.Console.WriteLine("Es IGUAL A 1000");
            }
            else
            {
                System.Console.WriteLine("no es  IGUAL A 1000");
            }          


            #endregion



            #region operadores logicos

            // == es igual
            // > mayor
            // < 
            // >= mayor igual
            // <= menor igual
            // && and
            // || or 
            // ++


            #endregion


            #region bucles
            //for
            //while

            for(int i = 0; i <= 10;  i++)
            {
                System.Console.WriteLine("Ciclo: " + i);

            }

            int g9 = 0;
            while(g9 <= 10)
            {
                System.Console.WriteLine("Ciclo While: " + g9);

                g9++;
                //g9 = g9 + 1;
                //g9 += 1;

            }


            int o = 3;

            int ab = 2;
            #endregion


        }
    }
}
