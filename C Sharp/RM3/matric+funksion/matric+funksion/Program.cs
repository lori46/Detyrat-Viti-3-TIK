using System;

class Program
{
    static void Main()
    {
        Console.Write("Shkruani numrin e rreshtave (x): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Shkruani numrin e kolonave (y): ");
        int y = int.Parse(Console.ReadLine());

        int[,] matrica = new int[x, y];


        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write($"Vendosni elementin në pozitën ({i}, {j}): ");
                matrica[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int shuma = 0;
        int minimum = matrica[0, 0];
        int maksimum = matrica[0, 0];

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                shuma += matrica[i, j];

                if (matrica[i, j] < minimum)
                    minimum = matrica[i, j];

                if (matrica[i, j] > maksimum)
                    maksimum = matrica[i, j];
            }
        }

        Console.WriteLine($"Shuma e elementeve: {shuma}");
        Console.WriteLine($"Elementi minimal: {minimum}");
        Console.WriteLine($"Elementi maksimal: {maksimum}");

    }
}
