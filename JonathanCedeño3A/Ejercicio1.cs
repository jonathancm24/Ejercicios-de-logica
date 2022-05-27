using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCedeño3A
{
    public class Ejercicio1
    {
        public Ejercicio1()
        {

        }
        public void funcion()
        {
            Console.WriteLine("escriba un numero");
            String num1 = Console.ReadLine();
            int valor1 = Convert.ToInt32(num1);
            Console.WriteLine("escriba otro numero");
            String num2 = Console.ReadLine();
            int valor2 = Convert.ToInt32(num2);
            if (valor1 > valor2)
            {
                Console.WriteLine(num1 + " es mayor");
            }
            else
            {
                Console.WriteLine(num2 + " es mayor");
            }
        }
    }
}
