using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class M1
    {
       
            public void Multi()
        {
            int n1,n2,pro;
            Console.WriteLine("Ingrese un numero Entero");
            n1 = int.Parse(Console.ReadLine());
            if(n1==0)
            {
                Console.WriteLine("La multiplicacion es 0");
            }
            else if(n1>0&n1<0)
            {
                Console.WriteLine("Ingrese un numero Entero");
                n2 = int.Parse(Console.ReadLine());
                pro = n1 * n2;
                Console.WriteLine("El Producto de los numeros es :"+pro);
            }
        }

      
        public void Method2()
        {
            int n3, n4, div;
            Console.WriteLine("Ingrese un numero Entero");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero Entero");
            n4 = int.Parse(Console.ReadLine());

            if (n4>0&n4<0)
            {
                div = n3 / n4;
                Console.WriteLine("La division de los numeros es :"+div);
            }

            else if(n4==0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
        }

        
         public void Captura()
        {
            for (int i = 0; i < 4; i++)
            {
                string nom;
                Console.WriteLine("EScriba nombre de los Alumnos:");
                nom=Console.ReadLine();
                Console.WriteLine("NOmbre es:" + nom);
            }
        }

        
             public void Edades()
            {
                for (int i = 0; i < 4; i++)
                {
                    int edad;
                    Console.WriteLine("EScriba la edad de los alumnos");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Edad es:" + edad);
                }
            }
        }
  }

 

