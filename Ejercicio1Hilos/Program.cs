using System;
using System.Collections.Generic;//contiene interfaces y clases que definen colecciones genericas,permiten estar tipadas
using System.Linq;//conjunto de extensiones integradas en c#,permite trabajar mas comodo
using System.Text;//contiene clases que representan codificaciones de caracteres
using System.Threading;
namespace Ejercicio1Hilos
{
    class Program
    {
            static void Main(string[] args)
            {
                Thread x = new Thread(metodo1);
                Thread y = new Thread(metodo2);
                x.Start(); y.Start();
            }
            static void metodo1()
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Personas ingresando al tren");
                    Thread.Sleep(500);
                }
            }
            static void metodo2()
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Personas saliendo del tren");
                    Thread.Sleep(500);
                }
            }
    }
}
