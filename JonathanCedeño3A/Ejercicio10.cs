using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCedeño3A
{
    public class Ejercicio10
    {
        public Ejercicio10()
        {

        }
        public void calcular()
        {
            Console.WriteLine("ingrese un numero");
            String num = Console.ReadLine();
            int valor = Convert.ToInt32(num);
            int fact = 1;
            for (int i = 1; i <= valor; i++)
            {
                fact *= i;
            }
            Console.WriteLine("El numero factorial de "+ valor+" es: "+ fact);
        }

    }
}
