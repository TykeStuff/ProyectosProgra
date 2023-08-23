using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto ferrari = new Auto();
            ferrari.modelo = "Ferrari F1";
            ferrari.velocidad = 120;

            Auto mclaren = new Auto();
            mclaren.modelo = "MC 2443";
            mclaren.velocidad = 140;

            PistaCarreras pista1 = new PistaCarreras();
            pista1.nombre = "Hermanos Rodriguez";
            pista1.longitud = 4.303f; //son km

            pista1.Competir(ferrari, mclaren);

            //Esta línea espera que presiones enter para countinuar
            Console.ReadLine();

        }
    }
}
