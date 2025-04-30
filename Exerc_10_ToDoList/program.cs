using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluido = new List<bool>();

        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("\n--- MENU TO-DO LIST ---");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Marcar tarefa como concluída");
            Console.WriteLine("3 - Sair e exibir lista final");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a descrição da tarefa: ");
                    string novaTarefa = Console.ReadLine();
                    tarefas.Add(novaTarefa);
                    concluido.Add(false);
                    break;

                case 2:
                    Console.WriteLine("\nTarefas:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluido[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }

                    Console.Write("Digite o número da tarefa concluída: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num >= 1 && num <= tarefas.Count)
                    {
                        concluido[num - 1] = true;
                        Console.WriteLine("Tarefa marcada como concluída!");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\n--- Lista Final de Tarefas ---");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluido[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }
                    Console.WriteLine("\nEncerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
