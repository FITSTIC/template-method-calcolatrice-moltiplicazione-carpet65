using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcolatriceSrandard
{
    class Program
    {
        abstract class Calcolatrice
        {
            private void PowerOn()
            {
                Console.WriteLine("La calcolatrice è accesa.");
            }
            private void Canc()
            {
                Console.WriteLine("La memoria cancellata.");
            }
            protected virtual int InputX()
            {
                 Console.WriteLine("Inserire il primo Valore: ");
                 return Convert.ToInt32(Console.ReadLine());
            }

            protected virtual int InputY()
            {
                Console.WriteLine("Inserire il secondo Valore: ");
                return Convert.ToInt32(Console.ReadLine());
            }

            protected abstract int Moltiplica(int x, int y);

            private void WriteRes(int res)
            {
                Console.WriteLine("Il risultato è: " + res);
            }

            private void PowerOff()
            {
                Console.WriteLine("Calcolatrice spenta.");
            }

            public void Molt()
            {
                PowerOn();
                Canc();
                int x = InputX();
                int y = InputY();
                int res = Moltiplica(x,y);
                WriteRes(res);
                PowerOff();
                Console.WriteLine();
            }
        }

        class CalcStandard : Calcolatrice
        {
            protected override int Moltiplica(int x, int y)
            {
                return x * y;
            }
        }

        class CalcContadina : Calcolatrice
        {
            protected override int Moltiplica(int x, int y)
            {
                int z = y;

                for (int i = 1; i < x; i++)
                {
                   z = z + y;
                }
                return z;
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Calcolatrice standard");
            var calc1 = new CalcStandard();
            calc1.Molt();

            Console.WriteLine("Calcolatrice contadina");
            var calc2 = new CalcContadina();
            calc1.Molt();

            Console.ReadKey();
        }
        
    }
   
}
