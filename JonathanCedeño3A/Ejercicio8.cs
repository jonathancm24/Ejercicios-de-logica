using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCedeño3A
{
    public class Ejercicio8
    {
        public Ejercicio8() {
        }   
        public void mostrar()
        {
            int a = 1;
            Console.WriteLine(a);
            a = a - 1;
            do
            {
                a = a + 3;
                Console.WriteLine(a);

            } while (a != 3000);
        }
    }
}
