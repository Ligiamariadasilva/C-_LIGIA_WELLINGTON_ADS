using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int numeroSecreto = rnd.Next(1, 101); // de 1 a 100
        int tentativa = 0;
        int palpites = 0;

        Console.WriteLine("Adivinhe o número entre 1 e 100!");

        while (tentativa != numeroSecreto)
        {
            Console.Write("Digite seu palpite: ");
            tentativa = int.Parse(Console.ReadLine());
            palpites++;

            if (tentativa < numeroSecreto)
                Console.WriteLine("O número secreto é maior!");
            else if (tentativa > numeroSecreto)
                Console.WriteLine("O número secreto é menor!");
        }

        Console.WriteLine($"\nParabéns! Você acertou em {palpites} tentativa(s).");
    }
}
