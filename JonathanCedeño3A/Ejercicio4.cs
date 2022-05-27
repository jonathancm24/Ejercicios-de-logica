using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCedeño3A
{
    public class Ejercicio4
    {
        public Ejercicio4()
        {

        }
        public void leer()
        {
            int num;
            do
            {
                Console.WriteLine("Escriba un numero");
                String valor = Console.ReadLine();
                num = Convert.ToInt32(valor);
            } while (num != 0);

        }
    }
}
