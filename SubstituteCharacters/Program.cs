using System;

namespace SubstituteCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm asendab kõik 'a' tähed kasutaja nimes tärniga (*)
            //programm kuvab tulemust konsoolis

            Console.WriteLine("sisesta eesnimi:");
            string fisrtName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();
            string fullName = $"{fisrtName} {lastName}";

            fullName = fullName.Replace('a', '*');

            Console.WriteLine(fullName);
        }
    }
}
