using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coso
{
    class Program
    {
        static void Main(string[] args) //Punto de entrada del programa
        {
            DispositivoMovil miIphone = new DispositivoMovil(); //tipo, nombre, inicialización
            miIphone.Almacenamiento = 64;
            miIphone.Ram = 16;
            miIphone.ResolAlto = 1920;
            miIphone.ResolAncho = 1080;
            miIphone.color = new Color();
            miIphone.color.Red = 100;
            miIphone.color.Green = 40;
            miIphone.color.Blue = 30;

            DispositivoMovil miSamsung = new DispositivoMovil();
            miSamsung.Almacenamiento = 128;
            miSamsung.Ram = 16;
            miSamsung.ResolAlto = 1920;
            miSamsung.ResolAncho = 1080;
            miSamsung.color = new Color();
            miSamsung.color.Red = 30;
            miSamsung.color.Green = 40;
            miSamsung.color.Blue = 60;

            DispositivoMovil miXiaomi = new DispositivoMovil();
            miXiaomi.Almacenamiento = 256;
            miXiaomi.Ram = 8;
            miXiaomi.ResolAlto = 1080;
            miXiaomi.ResolAncho = 1920;
            miXiaomi.color = new Color();
            miXiaomi.color.Red = 60;
            miXiaomi.color.Green = 70;
            miXiaomi.color.Blue = 65;
        }
    }
}
