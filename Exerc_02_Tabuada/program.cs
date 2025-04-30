using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para ver a tabuada:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}
