
//List<string> listadasBandas = new List<string>() { "U2", "Bruno e Marrone" };
using System.ComponentModel.DataAnnotations.Schema;

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Bruno e Marrone", new List<int> {10,9,7} );
bandasRegistradas.Add("U2", new List<int>());

string[] exibirTituloMenu =
{
    @"

███████╗██╗███╗░░░███╗
██╔════╝██║████╗░████║
█████╗░░██║██╔████╔██║
██╔══╝░░██║██║╚██╔╝██║
██║░░░░░██║██║░╚═╝░██║
╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝
",
        @"
    
░█▀▀█ ░█▀▀▀ ░█▀▀█ ▀█▀ ░█▀▀▀█ ▀▀█▀▀ ░█▀▀█ ░█▀▀▀█ 　 ░█▀▀▄ ░█▀▀▀ 　 ░█▀▀█ ─█▀▀█ ░█▄─░█ ░█▀▀▄ ─█▀▀█ ░█▀▀▀█ 
░█▄▄▀ ░█▀▀▀ ░█─▄▄ ░█─ ─▀▀▀▄▄ ─░█── ░█▄▄▀ ░█──░█ 　 ░█─░█ ░█▀▀▀ 　 ░█▀▀▄ ░█▄▄█ ░█░█░█ ░█─░█ ░█▄▄█ ─▀▀▀▄▄ 
░█─░█ ░█▄▄▄ ░█▄▄█ ▄█▄ ░█▄▄▄█ ─░█── ░█─░█ ░█▄▄▄█ 　 ░█▄▄▀ ░█▄▄▄ 　 ░█▄▄█ ░█─░█ ░█──▀█ ░█▄▄▀ ░█─░█ ░█▄▄▄█
",
@"
    
▒█▀▀▀ ▀▄▒▄▀ ▀█▀ ▒█▀▀█ ▀█▀ ▒█▀▀█ 　 ▒█▀▀█ ░█▀▀█ ▒█▄░▒█ ▒█▀▀▄ ░█▀▀█ ▒█▀▀▀█ 
▒█▀▀▀ ░▒█░░ ▒█░ ▒█▀▀▄ ▒█░ ▒█▄▄▀ 　 ▒█▀▀▄ ▒█▄▄█ ▒█▒█▒█ ▒█░▒█ ▒█▄▄█ ░▀▀▀▄▄ 
▒█▄▄▄ ▄▀▒▀▄ ▄█▄ ▒█▄▄█ ▄█▄ ▒█░▒█ 　 ▒█▄▄█ ▒█░▒█ ▒█░░▀█ ▒█▄▄▀ ▒█░▒█ ▒█▄▄▄█
",
@"

░█▀▀█ ▒█░░▒█ ░█▀▀█ ▒█░░░ ▀█▀ ░█▀▀█ ▒█▀▀█ 　 ▒█▀▀█ ░█▀▀█ ▒█▄░▒█ ▒█▀▀▄ ░█▀▀█ 
▒█▄▄█ ░▒█▒█░ ▒█▄▄█ ▒█░░░ ▒█░ ▒█▄▄█ ▒█▄▄▀ 　 ▒█▀▀▄ ▒█▄▄█ ▒█▒█▒█ ▒█░▒█ ▒█▄▄█ 
▒█░▒█ ░░▀▄▀░ ▒█░▒█ ▒█▄▄█ ▄█▄ ▒█░▒█ ▒█░▒█ 　 ▒█▄▄█ ▒█░▒█ ▒█░░▀█ ▒█▄▄▀ ▒█░▒█
",
@"  

█▀▄▀█ █▀▀ █▀▀▄ ░▀░ █▀▀█ 　 █▀▀▄ █▀▀ 　 █░░█ █▀▄▀█ █▀▀█ 　 █▀▀▄ █▀▀█ █▀▀▄ █▀▀▄ █▀▀█ 
█░▀░█ █▀▀ █░░█ ▀█▀ █▄▄█ 　 █░░█ █▀▀ 　 █░░█ █░▀░█ █▄▄█ 　 █▀▀▄ █▄▄█ █░░█ █░░█ █▄▄█ 
▀░░░▀ ▀▀▀ ▀▀▀░ ▀▀▀ ▀░░▀ 　 ▀▀▀░ ▀▀▀ 　 ░▀▀▀ ▀░░░▀ ▀░░▀ 　 ▀▀▀░ ▀░░▀ ▀░░▀ ▀▀▀░ ▀░░▀

"
    };



void ExibirLogo()
{
    Console.WriteLine(@"
    
░█████╗░░██╗░░░░░░░██╗  ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔══██╗░██║░░██╗░░██║  ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
███████║░╚██╗████╗██╔╝  ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
██╔══██║░░████╔═████║░  ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██║░░██║░░╚██╔╝░╚██╔╝░  ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░  ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
"

);
    Console.WriteLine("Seja bem vindo ao AdeWeb Screen Sound");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 pra registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar a banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digte -1 ara sair");

    Console.Write("\nDigite a sua Opção: ");
    string  escolha = Console.ReadLine();
    int opcaoEscolhida = int.Parse(escolha);

    switch (opcaoEscolhida)
    {
        case 1: RegistrarBanda(opcaoEscolhida);
            break;
        case 2: ExibirBandasRegistradas(opcaoEscolhida);
            break;
        case 3: AvaliarUmaBanca(opcaoEscolhida); 
            break;
        case 4: ExibirMedia(opcaoEscolhida);
            break;
        case -1: Encerrar(opcaoEscolhida);
            break;
            default: Console.WriteLine("Opção inválida");
            break;
    }
}

void Encerrar(int opcaoEscolhida)
{
    Console.Clear();
    Console.WriteLine(exibirTituloMenu[0]);
}

void RegistrarBanda(int opcaoTitulo)
{
    Console.Clear();
    Console.WriteLine(exibirTituloMenu[opcaoTitulo]);
    Console.Write("Digite nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda,new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    ExibirMensagemVoltarMenuPrincipal();
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas(int opcaoTitulo)
{
    Console.Clear();
    Console.WriteLine(exibirTituloMenu[opcaoTitulo]);
    /*
    for (int i = 0;  i < listadasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listadasBandas[i]} ");

    }
    */
    foreach ( var banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda} ");
    }
    Console.WriteLine("\nDigite uma telca para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanca(int opcaoTitulo)
{
    Console.Clear();
    Console.WriteLine(exibirTituloMenu[opcaoTitulo]);
    Console.Write("Digite nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

        Console.WriteLine($"Qual nota a banda {nomeDaBanda} merece ?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        ExibirMensagemVoltarMenuPrincipal();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        ExibirMensagemVoltarMenuPrincipal();
        ExibirOpcoesDoMenu();
    }
}


void ExibirMedia(int opcaoTitulo)
{
    Console.Clear();
    Console.WriteLine(exibirTituloMenu[opcaoTitulo]);
    Console.Write("Digite nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

        Console.WriteLine($"\nA méda da banda {nomeDaBanda} é {CalculaMedia(bandasRegistradas, nomeDaBanda)}");
        ExibirMensagemVoltarMenuPrincipal();
        ExibirOpcoesDoMenu();

    }
    else {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        ExibirMensagemVoltarMenuPrincipal();
        ExibirOpcoesDoMenu();
    }

}


ExibirLogo();
ExibirOpcoesDoMenu();

static double CalculaMedia(Dictionary<string, List<int>> bandasRegistradas, string nomeDaBanda)
{
    List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
    
    return notasDaBanda.Average();
}

static void ExibirMensagemVoltarMenuPrincipal()
{
    Console.WriteLine("Digite uma telca para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
}