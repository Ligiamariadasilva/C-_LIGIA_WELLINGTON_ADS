using System;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotalEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"\nCadastro do produto {i}:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            produtos.Add(new Produto { Nome = nome, Preco = preco, Quantidade = quantidade });
        }

        Console.WriteLine("\n--- Produtos Cadastrados ---");
        foreach (Produto p in produtos)
        {
            Console.WriteLine($"Produto: {p.Nome}, Total em estoque: R$ {p.ValorTotalEstoque():F2}");
        }
    }
}
