using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCedeño3A
{
    public class Ejercicio7
    {
        public Ejercicio7() { 
        
        }
        public void determinar()
        {
            String R = "";
            do
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
                if (valor1 == valor2 && valor1 == valor3)
                {
                    Console.WriteLine("Los numeros forman un triangulo equilátero");
                }
                else if (valor2 == valor1 || valor2 == valor3 || valor1 == valor3 )
                {
                    Console.WriteLine("Los numeros forman un triangulo isóceles");
                }
                else
                {
                    Console.WriteLine("Los numeros forman un triangulo escaleno");
                }
                Console.WriteLine("Desea continuar s/n");
                R = Console.ReadLine();
            } while (R == "s" || R == "S");
        }
    }
}
