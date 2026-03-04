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
}