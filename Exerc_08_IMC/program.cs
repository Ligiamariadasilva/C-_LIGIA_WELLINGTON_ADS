using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu peso (em kg): ");
        string entradaPeso = Console.ReadLine().Replace(',', '.');

        Console.Write("Digite sua altura (em metros): ");
        string entradaAltura = Console.ReadLine().Replace(',', '.');

        double peso = double.Parse(entradaPeso, CultureInfo.InvariantCulture);
        double altura = double.Parse(entradaAltura, CultureInfo.InvariantCulture);

        double imc = peso / (altura * altura);

        Console.WriteLine($"\nSeu IMC é: {imc.ToString("F2", CultureInfo.InvariantCulture)}");

        if (imc < 18.5)
            Console.WriteLine("Classificação: Abaixo do peso");
        else if (imc < 25)
            Console.WriteLine("Classificação: Peso normal");
        else if (imc < 30)
            Console.WriteLine("Classificação: Sobrepeso");
        else
            Console.WriteLine("Classificação: Obesidade");
    }
}

