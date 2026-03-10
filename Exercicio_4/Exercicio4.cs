namespace EstudosCsharp.Exercicio_4;

// Crie um programa que implemente um quiz simples de perguntas e respostas. 
// Utilize um dicionário para armazenar as perguntas e as respostas corretas.

public class Exercicio4
{
    public static void Quiz()
    {
        Dictionary<string, string> perguntas_respostas = new()
        {
        {"O que significa HTML?","HyperText Markup Language"},
        {"Qual linguagem é muito usada para análise de dados?","Python"},
        {"O que é um banco de dados?", "Um sistema para armazenar e organizar dados"},
        };
    
        int pontuacao = 0;
        foreach (var perguntas in perguntas_respostas)
        {
            Console.WriteLine(perguntas.Key);
            string resposta = Console.ReadLine()!;

            if (resposta.Equals(perguntas.Value))
            {
                Console.WriteLine("Certa resposta!");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Tente novamente na próxima!");
            }
        }

        Console.WriteLine($"Sua pontuação foi de {pontuacao} pontos");

    }
}