namespace EstudosCsharp.Exercicio_1;

public class Exercicio1
{
    public static void NumerosParesFor()
    {
        List<int> Numeros = [1, 3, 4, 5, 2, 6, 7, 8, 9, 12, 14, 15, 17, 18, 19, 21, 22];

        Console.WriteLine("Números Pares");
        for (int i = 0; i < Numeros.Count; i++)
        {
            if (Numeros[i] % 2 == 0)
            {
                Console.WriteLine(Numeros[i]);
            }
        }
    }

    public static void NumerosPareForeach()
    {
        List<int> Numeros = [1, 3, 4, 5, 2, 6, 7, 8, 9, 12, 14, 15, 17, 18, 19, 21, 22];

        Console.WriteLine("Números Pares");
        foreach (int numero in Numeros)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero);
            }
        }
    }

    public static void RetornaMedia()
    {
        var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
        { "Ana", new Dictionary<string, List<int>> {
            { "C#", new List<int> { 8, 7, 6 } },
            { "Java", new List<int> { 7, 6, 5 } },
            { "Python", new List<int> { 9, 8, 8 } }
        }},
        { "Maria", new Dictionary<string, List<int>> {
            { "C#", new List<int> { 6, 5, 4 } },
            { "Java", new List<int> { 8, 7, 6 } },
            { "Python", new List<int> { 6, 10, 5 } }
        }},
        { "Luiza", new Dictionary<string, List<int>> {
            { "C#", new List<int> { 2, 3, 10 } },
            { "Java", new List<int> { 8, 8, 8 } },
            { "Python", new List<int> { 7, 7, 7 } }
        }}
    };

        List<int> NotaMaria = notasAlunos["Maria"]["Java"];
        double mediaMaria = NotaMaria.Average();
        Console.WriteLine(mediaMaria);

        // Média da Maria em Python
        List<int> notasPythonMaria = notasAlunos["Maria"]["Python"];
        double mediaMariaEmPython = notasPythonMaria.Average();
        Console.WriteLine(mediaMariaEmPython);
    }
}