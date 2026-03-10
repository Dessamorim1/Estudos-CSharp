namespace EstudosCsharp.Exercicio_6;

// Com base na lista de super carros fornecida abaixo, onde a chave é o nome do carro e os 
// valores são quantas vezes esse carro foi vendido por ano, calcule a média de uma chave específica.

public class Exercicio6
{
    public static void CalcMedia()
    {

    Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
        { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
        { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
        { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
        { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
        { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
    };

    double media = vendasCarros["Bugatti Veyron"].Average();
    Console.WriteLine($"A média é de {media}");
    
    }
}

