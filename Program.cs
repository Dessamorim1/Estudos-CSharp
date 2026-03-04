// Station 52
// Linguagem fortemente tipada e é necessário uo uso do ;

using EstudosCsharp.Exercicio_1;

string texto = "Boas vindas";
List<string> listaDasBandas = [];
List<string> ListaTeste = ["A","B","C"];

Exercicio1.NumerosParesFor();
Exercicio1.NumerosPareForeach();

void ExibirMensagem()
{
    Console.WriteLine(texto);
}

void ExibirOpcoes()
{
    ExibirMensagem();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua escolha: ");
    string opcao = Console.ReadLine()!;
    int opcaoConv = int.Parse(opcao);
    switch (opcaoConv)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            Console.Write("Escolheu 3");
            break;
        case -1:
            Console.Write("Saindo....");
            break;
        default:
            Console.Write("Opção Inválida");
            break;
    }
}

void adivinhar()
{
    Random ra = new();
    int a = ra.Next(1, 101);
    int numC = 0;
    Console.Write("Adivinhe um número de 1 até 100: ");
    do
    {
        string num = Console.ReadLine()!;
        numC = int.Parse(num);
        if (numC == a)
        {
            Console.WriteLine("Parabéns vc acertou!");
            break;
        }
        else if (numC > a)
        {
            Console.WriteLine("O número é menor");
        }
        else
        {
            Console.WriteLine("O número é maior");
        }
    } while (numC != a);
}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoes();
}

void ExibirBandas()
{
    Console.Clear();
    Console.WriteLine("Bandas cadastradas: ");

    if (listaDasBandas.Count == 0)
    {
        Console.WriteLine("Nenhuma registro de banda encontrado, você pode cadastrar uma no menu!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoes();
    }
    else
    {
        // for (int i = 0; i < listaDasBandas.Count; i++)
        // {
        //     Console.WriteLine($"{i+1} - {listaDasBandas[i]}");
        // }
        foreach (string banda in listaDasBandas)
        {
            Console.WriteLine($"Banda: {banda}"); 
        }
        foreach(string letra in ListaTeste)
        {
            Console.WriteLine($"{letra}");
        }
    }
    Console.WriteLine("Digite qualquer tecla para voltar ao menu....");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoes();
}

ExibirOpcoes();
adivinhar();