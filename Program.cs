// Station 52
// Linguagem fortemente tipada e é necessário uo uso do ;

using System.Globalization;

String texto = "Boas vindas";

void ExibirMensagem()
{
    Console.WriteLine(texto);
}

void ExibirOpcoes()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua escolha: ");
    string opcao = Console.ReadLine()!;
    int opcaoConv = int.Parse(opcao);
    switch(opcaoConv)
    {
        case 1: Console.Write($"Escolheu {opcaoConv}");
            break;
        case 2: Console.Write("Escolheu {0}",opcaoConv);
            break;
        case 3: Console.Write("Escolheu 3");
            break;
        case -1: Console.Write("Saindo....");
            break;
        default: Console.Write("Opção Inválida");
            break;
    }
}

void adivinhar()
{
    Random ra = new();
    int a = ra.Next(1,101);
    int numC = 0;
    Console.Write("Adivinhe um número de 1 até 100: ");
    do
    {
        string num = Console.ReadLine()!;
        numC = int.Parse(num);
        if(numC == a)
        {
            Console.WriteLine("Parabéns vc acerto!");
            break;
        } else if(numC > a) {
            Console.WriteLine("O número é menor");
        } else {
            Console.WriteLine("O número é maior");
        }
    } while(numC != a);
}

ExibirMensagem();
ExibirOpcoes();
adivinhar();