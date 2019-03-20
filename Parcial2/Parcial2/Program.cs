using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("INgrese un numero del 1 al 4");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
             case 1:
                    M1 obj = new M1();
                    obj.Multi();
                    Console.ReadKey();
             break;
             case 2:
                    M1 obj2 = new M1();
                    obj2.Method2();
                    Console.ReadKey();
             break;

                case 3:
                    M1 obj3 = new M1();
                    obj3.Captura();
                    Console.ReadKey();
                break;
                case 4:
                    M1 obj4 = new M1();
                    obj4.Edades();
                    Console.ReadKey();
                break;
                default:
                Console.WriteLine("INgrese un numero del 1 al 4 unicamente");
                break;
            }
        }
    }
}
