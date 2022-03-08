using System;

namespace Formatif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Examen formatif");
            Flotte flotte = new("Flotte A");
            flotte.ChargerFichier();
            flotte.Afficher();


        }
    }
}
