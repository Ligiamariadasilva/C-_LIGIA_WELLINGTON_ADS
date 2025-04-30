using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro positivo:");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Número inválido. Digite um número positivo.");
            return;
        }

        long fatorial = 1;
        int contador = numero;

        while (contador > 1)
        {
            fatorial *= contador;
            contador--;
        }

        Console.WriteLine($"Fatorial de {numero} é {fatorial}");
    }
}
