using System;

namespace SistemiINotave
{
    class Program
    {
        static void Main(string[] args)
        {
            int passingThreshold = 60;
            string userResponse;

            Console.WriteLine("Mirësevini në Sistemin e Notave!");

            do
            {
                // Deklarimi i variablave dhe marrja e pikëve nga përdoruesi
                Console.Write("Shkruani pikët për detyrat: ");
                int detyraPike = int.Parse(Console.ReadLine());

                Console.Write("Shkruani pikët për kuizet: ");
                int kuizPike = int.Parse(Console.ReadLine());

                Console.Write("Shkruani pikët për provimin: ");
                int provimPike = int.Parse(Console.ReadLine());

                int mesatare = (detyraPike + kuizPike + provimPike) / 3;
                Console.WriteLine("\nLlogaritja...");

                Console.WriteLine("Nota mesatare: " + mesatare);

                string nota;
                if (mesatare >= 90)
                    nota = "A";
                else if (mesatare >= 80)
                    nota = "B";
                else if (mesatare >= 70)
                    nota = "C";
                else if (mesatare >= 60)
                    nota = "D";
                else
                    nota = "F";

                Console.WriteLine("Nota: " + nota);

                if (mesatare >= passingThreshold)
                    Console.WriteLine("Urime! Ju keni kaluar kursin.");
                else
                    Console.WriteLine("Fatkeqësisht, ju nuk e kaluat kursin.");
                Console.Write("\nDëshironi të llogarisni notën për një student tjetër? (po/jo): ");
                userResponse = Console.ReadLine().ToLower();

                Console.WriteLine(); 

            } while (userResponse == "po");

            Console.WriteLine("Faleminderit që përdorët Sistemin e Notave!");
        }
    }
}
