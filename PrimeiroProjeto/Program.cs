//Screen Sound

string mensagemBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string>{"U2, The Beatles, Calypso"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 7, 4 });
bandasRegistradas.Add("AC/DC", new List<int> {});

void ExibirLogo()
{
    Console.WriteLine(@"

█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");                      
                                                                   
    Console.Write("\nDigite sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMedia();
            break; ;
        case -1: Console.WriteLine("Fim do programa");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    ExibirTitulo("Registro das bandas");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTitulo("Exibindo bandas registradas");
    //for(int i=0; i<listaDasBandas.Count; i++)
    //{
     //   Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda:{banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTitulo(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}


void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar:");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota {nomeDaBanda} merece:");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine("\nA nota foi registrada com sucesso");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTitulo("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja a média:");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = bandasRegistradas[nomeDaBanda];
        int soma = 0;
        for(int i=0; i< notas.Count; i++)
        {
            soma += notas[i];
        }
        int media = soma / notas.Count;
        Console.WriteLine($"A média para a banda {nomeDaBanda} é {media}");
    }
    else
    {
        Console.WriteLine("não foi encontrada uma média para a banda desejada");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();
