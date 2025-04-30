using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra ou frase:");
        string entrada = Console.ReadLine();

        // Remove espaços, pontuação e acentos (básico)
        string textoLimpo = Regex.Replace(entrada.ToLower(), "[^a-z0-9]", "");

        // Inverte o texto
        char[] array = textoLimpo.ToCharArray();
        Array.Reverse(array);
        string invertido = new string(array);

        if (textoLimpo == invertido)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }
}

