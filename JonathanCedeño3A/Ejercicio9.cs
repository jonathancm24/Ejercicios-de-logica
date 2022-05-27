using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanCedeño3A
{
    public class Ejercicio9
    {
        public Ejercicio9()
        {

        }
        public void promediar() 
        {
            int num;
            int total = 0;
            int cant=0;
            do
            {
                cant++;
                Console.WriteLine("Escriba un numero (para finalizar ingrese un cero)");
                String valor = Console.ReadLine();
                num = Convert.ToInt32(valor);
                total = num + total;
            } while (num != 0);
            int resultado = total / (cant -1 );
            Console.WriteLine("El promedio de los numeros ingresados es: " + resultado);
        }
    }
}
