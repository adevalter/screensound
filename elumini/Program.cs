String mensagemDeBoasVindas = "Boas Vindas o Screen Sound";
List<string> listadasBandas = new List<string>() { "U2", "Bruno e Marrone" };   

void ExibirLogo()
{
    Console.WriteLine(@"
    
░█████╗░░██╗░░░░░░░██╗  ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔══██╗░██║░░██╗░░██║  ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
███████║░╚██╗████╗██╔╝  ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
██╔══██║░░████╔═████║░  ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██║░░██║░░╚██╔╝░╚██╔╝░  ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░  ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Seja bem vindo ao AdeWeb Screen Sound");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 pra registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliara a banda");
    Console.WriteLine("Digite 4 para exibir a méda de uma banda");
    Console.WriteLine("Digte -1 ara sair");

    Console.Write("\nDigite a sua Opção: ");
    int opcaoEscolhiada = int.Parse(Console.ReadLine());

    switch (opcaoEscolhiada)
    {
        case 1: RegistrarBanda();
            break;
        case 2: ExibirBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você Digitou a opção " + opcaoEscolhiada); 
            break;
        case 4: Console.WriteLine("Você Digitou a opção " + opcaoEscolhiada); 
            break;
        case -1: Console.WriteLine("FIM 😁 ");
            break;
            default: Console.WriteLine("Opção inválida");
            break;
    }
}
Console.WriteLine("Qual é o seu nome?");
string nome = Console.ReadLine();
Console.WriteLine($"Olá, {nome}!");


void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine(@"
    
░█▀▀█ ░█▀▀▀ ░█▀▀█ ▀█▀ ░█▀▀▀█ ▀▀█▀▀ ░█▀▀█ ░█▀▀▀█ 　 ░█▀▀▄ ░█▀▀▀ 　 ░█▀▀█ ─█▀▀█ ░█▄─░█ ░█▀▀▄ ─█▀▀█ ░█▀▀▀█ 
░█▄▄▀ ░█▀▀▀ ░█─▄▄ ░█─ ─▀▀▀▄▄ ─░█── ░█▄▄▀ ░█──░█ 　 ░█─░█ ░█▀▀▀ 　 ░█▀▀▄ ░█▄▄█ ░█░█░█ ░█─░█ ░█▄▄█ ─▀▀▀▄▄ 
░█─░█ ░█▄▄▄ ░█▄▄█ ▄█▄ ░█▄▄▄█ ─░█── ░█─░█ ░█▄▄▄█ 　 ░█▄▄▀ ░█▄▄▄ 　 ░█▄▄█ ░█─░█ ░█──▀█ ░█▄▄▀ ░█─░█ ░█▄▄▄█
");
    Console.Write("Digite nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listadasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas()
{
    Console.WriteLine(@"
    
▒█▀▀▀ ▀▄▒▄▀ ▀█▀ ▒█▀▀█ ▀█▀ ▒█▀▀█ 　 ▒█▀▀█ ░█▀▀█ ▒█▄░▒█ ▒█▀▀▄ ░█▀▀█ ▒█▀▀▀█ 
▒█▀▀▀ ░▒█░░ ▒█░ ▒█▀▀▄ ▒█░ ▒█▄▄▀ 　 ▒█▀▀▄ ▒█▄▄█ ▒█▒█▒█ ▒█░▒█ ▒█▄▄█ ░▀▀▀▄▄ 
▒█▄▄▄ ▄▀▒▀▄ ▄█▄ ▒█▄▄█ ▄█▄ ▒█░▒█ 　 ▒█▄▄█ ▒█░▒█ ▒█░░▀█ ▒█▄▄▀ ▒█░▒█ ▒█▄▄▄█
"
        );
    /*
    for (int i = 0;  i < listadasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listadasBandas[i]} ");

    }
    */
    foreach ( var banda in listadasBandas)
    {
        Console.WriteLine($"Banda: {banda} ");
    }
    Console.WriteLine("\nDigite uma telca para voltar ao menu principal");
    Console.ReadLine();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirLogo();
ExibirOpcoesDoMenu();



