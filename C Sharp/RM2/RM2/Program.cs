using System;

class Program
{
    static void Main()
    {
        const int numriStudentëve = 5;
        const int numriLëndëve = 3;
        int[,] notat = new int[numriStudentëve, numriLëndëve];


        for (int student = 0; student < numriStudentëve; student++)
        {
            for (int lenda = 0; lenda < numriLëndëve; lenda++)
            {
                Console.Write($"Shkruani notën për studentin {student + 1} në lëndën {lenda + 1}: ");
                notat[student, lenda] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nNotat e futur:");
        for (int student = 0; student < numriStudentëve; student++)
        {
            for (int lenda = 0; lenda < numriLëndëve; lenda++)
            {
                Console.Write(notat[student, lenda] + "\t");
            }
            Console.WriteLine();
        }


        Console.WriteLine("\nShuma dhe mesatarja për çdo student:");
        for (int student = 0; student < numriStudentëve; student++)
        {
            int total = 0;
            for (int lenda = 0; lenda < numriLëndëve; lenda++)
            {
                total += notat[student, lenda];
            }
            double avg = total / (double)numriLëndëve;
            Console.WriteLine($"Studenti {student + 1} - Shuma: {total}, Mesatarja: {avg:F2}");
        }


        Console.Write("\nShkruani faktor shumëzimi: ");
        int faktor = int.Parse(Console.ReadLine());
        for (int student = 0; student < numriStudentëve; student++)
        {
            for (int lenda = 0; lenda < numriLëndëve; lenda++)
            {
                notat[student, lenda] *= faktor;
            }
        }


        Console.WriteLine("\nNotat pas shumëzimit:");
        for (int student = 0; student < numriStudentëve; student++)
        {
            for (int lenda = 0; lenda < numriLëndëve; lenda++)
            {
                Console.Write(notat[student, lenda] + "\t");
            }
            Console.WriteLine();
        }


        Console.WriteLine("\nNota më e lartë dhe më e ulët për secilin student:");
        for (int student = 0; student < numriStudentëve; student++)
        {
            int notaMin = notat[student, 0];
            int notaMax = notat[student, 0];
            for (int lenda = 1; lenda < numriLëndëve; lenda++)
            {
                if (notat[student, lenda] < notaMin) notaMin = notat[student, lenda];
                if (notat[student, lenda] > notaMax) notaMax = notat[student, lenda];
            }
            Console.WriteLine($"Studenti {student + 1} - Nota më e ulët: {notaMin}, Nota më e lartë: {notaMax}");
        }
    }
}