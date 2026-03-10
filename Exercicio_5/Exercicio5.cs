namespace EstudosCsharp.Exercicio_5;

// Criar um programa que simule um sistema de login 
// utilizando um dicionário para armazenar nomes de usuário e senhas.

public class Exercicio5
{
    public static void Login()
    {
        Dictionary<string, string> user_pass = new()
        {
         {"Admin", "1234"},
         {"Man", "@123"},
         {"Ad","324@"},
        };

        Console.WriteLine("Informe seu usuário: ");
        string user = Console.ReadLine()!;
        Console.WriteLine("Informe sua senha: ");
        string senha = Console.ReadLine()!;

            if (user_pass.ContainsKey(user) && user_pass[user] == senha)
            {
                Console.WriteLine("Login efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorreto!");
            }
    }
}