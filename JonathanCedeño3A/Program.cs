using System;

namespace JonathanCedeño3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1 uno = new Ejercicio1();
            Ejercicio2 dos = new Ejercicio2();
            Ejercicio3 tres = new Ejercicio3();
            Ejercicio4 cuatro = new Ejercicio4();
            Ejercicio5 cinco = new Ejercicio5();
            Ejercicio6 seis = new Ejercicio6();
            Ejercicio7 siete = new Ejercicio7();
            Ejercicio8 ocho = new Ejercicio8();
            Ejercicio9 nueve = new Ejercicio9();
            Ejercicio10 dies = new Ejercicio10();
            Boolean estado=false;
            String respuesta = "";
            do
            {
                do
                {
                    estado = false;
                    Console.WriteLine("Elija el numero del ejercicio a probar");
                    String caso = Console.ReadLine();
                    int obcion = Convert.ToInt32(caso);
                    switch (obcion)
                    {
                        case 1:
                            uno.funcion();
                            break;
                        case 2:
                            dos.analizar();
                            break;
                        case 3:
                            tres.analizar();
                            break;
                        case 4:
                            cuatro.leer();
                            break;
                        case 5:
                            cinco.suma();
                            break;
                        case 6:
                            seis.sumar();
                            break;
                        case 7:
                            siete.determinar();
                            break;
                        case 8:
                            ocho.mostrar();
                            break;
                        case 9:
                            nueve.promediar();
                            break;
                        case 10:
                            dies.calcular();
                            break;
                        default:
                            Console.WriteLine("Valor ingresado no valido");
                            estado = true;
                            break;
                    }
                } while (estado);
                Console.WriteLine("Desea probar otro ejersicio s/n (cualquier otro valor ingresado finalizara el programa)");
                respuesta = Console.ReadLine();
            } while (respuesta == "s" || respuesta == "S" );
        }
    }
}