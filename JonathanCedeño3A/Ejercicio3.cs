using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCedeño3A
{
    public class Ejercicio3
    {
        public Ejercicio3(){
        
        }
        public void analizar()
        {
            Console.WriteLine("Escriba un numero");
            String num1 = Console.ReadLine();
            int valor1 = Convert.ToInt32(num1);
            Console.WriteLine("Escriba otro numero");
            String num2 = Console.ReadLine();
            int valor2 = Convert.ToInt32(num2);
            Console.WriteLine("Escribe el tercer numero");
            String num3 = Console.ReadLine(); 
            int valor3 = Convert.ToInt32(num3);
            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine(num1 + " es mayor");
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine(num2 + " es mayor");
            }
            else
            {
                Console.WriteLine(num3 + "es mayor");
            }
        }
    }
}
