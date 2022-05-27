using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCedeño3A
{
    public class Ejercicio5
    { 
        public Ejercicio5()
        {
            
        }
        public void suma()
        {
            int total = 0;
            for (int i = 0; i <= 8 ; i++)
            {
                
                Console.WriteLine("Escriba un numero");
                String valor = Console.ReadLine();
                int num = Convert.ToInt32(valor);
                total = num + total;

            }
            Console.WriteLine("La suma de todos los numeros es: " + total);
        }
    }
}
