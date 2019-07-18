using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1


{

    class hilfe
    {


        public static int dividiere(int a, int b)
        {
            return a / b;
        }


        public static int subtrahiere(int a, int b)
        {
            return a - b;
        }


        public static int addiere(int a, int b)
        {
            return a + b;

        }

        public static int exp1(int a, int b)
        {
            int Ergebnis = 1;

            for (; b > 0; b--)
            {
                Ergebnis = Ergebnis * a;
            }

            return Ergebnis;

        }

        public static int exp2(int a, int b)
        {
            int erg = 1;
            while(b>0)
            {
                erg = erg * a;
                b--;
            }
            return erg;
        }

        public static int exp3(int a, int b)
       
        {
            
            if (a == 1 && b == 1)
            {
                return 1;
            }

            int erg = 1;
            do
            {
                erg = erg * a;
                b--;
            }

            while (b>0);           

            return erg;

        }


        public static int rek(int a, int b)
        {
            if (b > 0)
            {
               return rek(a, b - 1) * a;
            }
            else
            {
                return 1;
            }

        }

        

    }
}
