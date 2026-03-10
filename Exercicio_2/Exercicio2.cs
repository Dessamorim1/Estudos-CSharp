using System.Numerics;

namespace EstudosCsharp.Exercicio_2;

// Criar um programa que permita ao usuário 
// inserir o nome do aluno e suas notas, e em seguida calcule e exiba a média das notas.

public class Exercicio2
{
    // Interativo
    public static void Notas()
    {
        Console.WriteLine("Bem-vindo");
        Console.WriteLine("Insira o nome do aluno: ");
        string nome = Console.ReadLine()!;
        double nota = 0;
        List<double> notas = [];
        Console.WriteLine("Insira as notas do aluno, caso não exista mais notas digite -1: ");
        do
        {
            nota = double.Parse(Console.ReadLine()!);
            if (nota != -1)
            {
                notas.Add(nota);
            }
        } while (nota != -1);

        double media = notas.Average();
        Console.WriteLine($" A média de {nome} foi de {Math.Round(media, 2)}");

    }

    // Ultilizando dicionários

    // Adicione notas para alguns alunos

    public static void Nota_dict()
    {
        Dictionary<string, List<double>> notasAlunos = new();

        // Adicione notas para alguns alunos
        notasAlunos["João"] = [8.5, 9.0, 7.5];
        notasAlunos["Maria"] = [7.0, 8.0, 6.5];

        foreach (var alunos in notasAlunos)
        {
            double soma = 0;
            for (int i = 0; i < alunos.Value.Count; i++)
            {
                soma = +soma + alunos.Value[i];
            }

            double media = soma / alunos.Value.Count;
            Console.WriteLine($"Média de {alunos.Key}: {media}");
        }

    }

}

