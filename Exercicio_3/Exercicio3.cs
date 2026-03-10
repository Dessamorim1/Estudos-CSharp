namespace EstudosCsharp.Exercicio_3;

// Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para 
// armazenar produtos e suas quantidades em estoque e mostre, a partir do
//  nome de um produto, sua quantidade em estoque.

public class Exercicio3
{

    public static void Estoque_loja()
    {
        Dictionary<string, int> Produtos = new() {
            { "camisetas", 50 },
            { "calças", 30 },
            { "tênis", 20 },
        };
        string produto = "camisetas";

        if (Produtos.ContainsKey(produto))
        {
            Console.WriteLine($"A quantidade do {produto} é de {Produtos[produto]}");
        }
        else
        {
            Console.WriteLine("Esse produto não existe");
        }

    }
}