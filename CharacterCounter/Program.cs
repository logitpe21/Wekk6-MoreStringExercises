using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonnanime pikkust kokku
            //Length omadust kasutamata
            Console.WriteLine("sisesta eesnimi:");
            string fisrtName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();
            string fullName = $"{fisrtName}{lastName}";

            int charCounter = 0;

            foreach(char c in fullName)
            {
                charCounter++;
            }

            Console.WriteLine(charCounter);
        }
    }
}
