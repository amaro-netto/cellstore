using DesafioPOO.Models;

Console.WriteLine("----------------------------------");
Console.WriteLine("SIMULADOR DE SMARTPHONES - CODEBUDDY");
Console.WriteLine("----------------------------------\n");

// --- 1. Criando as instâncias dos SmartPhones ---

Console.WriteLine("Criando Smartphone Nokia...");
// Instância (objeto) da classe Nokia
Nokia nokia = new Nokia(numero: "1234-5678", modelo: "Tijolão", imei: "111111111", memoria: 64);
Console.WriteLine($"Nokia Modelo: {nokia.Modelo} | Memória: {nokia.Memoria}GB");

Console.WriteLine("\nCriando Smartphone iPhone...");
// Instância (objeto) da classe Iphone
Iphone iphone = new Iphone(numero: "9876-5432", modelo: "iPhone 15", imei: "999999999", memoria: 128);
Console.WriteLine($"iPhone Modelo: {iphone.Modelo} | Memória: {iphone.Memoria}GB");

Console.WriteLine("\n----------------------------------");

// --- 2. Lógica de Interação ---

// Variável para controlar o loop do menu
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("\nEscolha o Smartphone para interagir (ou 0 para Sair):");
    Console.WriteLine("1 - Nokia");
    Console.WriteLine("2 - iPhone");
    Console.Write("Opção: ");
    
    // Lê a escolha do usuário
    string escolhaCelular = Console.ReadLine();

    if (escolhaCelular == "0")
    {
        exibirMenu = false;
        break;
    }
    
    // Variável para guardar o celular escolhido (Nokia ou iPhone)
    Smartphone celularEscolhido = null;

    if (escolhaCelular == "1")
    {
        celularEscolhido = nokia;
        Console.WriteLine($"\n--- AÇÕES PARA NOKIA ({celularEscolhido.Modelo}) ---");
    }
    else if (escolhaCelular == "2")
    {
        celularEscolhido = iphone;
        Console.WriteLine($"\n--- AÇÕES PARA IPHONE ({celularEscolhido.Modelo}) ---");
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
        continue; // Volta para o início do loop
    }

    // --- Menu de Ações do Celular ---

    Console.WriteLine("Escolha uma ação:");
    Console.WriteLine("1 - Ligar");
    Console.WriteLine("2 - Receber Ligação");
    Console.WriteLine("3 - Instalar Aplicativo");
    Console.WriteLine("4 - Ver Detalhes do Aparelho"); // Nova opção
    Console.Write("Ação: ");

    string escolhaAcao = Console.ReadLine();

    switch (escolhaAcao)
    {
        case "1":
            celularEscolhido.Ligar();
            break;
        case "2":
            celularEscolhido.ReceberLigacao();
            break;
        case "3":
            Console.Write("Digite o nome do aplicativo para instalar: ");
            string nomeApp = Console.ReadLine();
            celularEscolhido.InstalarAplicativo(nomeApp);
            break;
        case "4": // Novo case para exibir detalhes
            celularEscolhido.ExibirDetalhes();
            break;
        default:
            Console.WriteLine("Ação inválida.");
            break;
    }
}

Console.WriteLine("\nEncerrando o sistema. Até logo!");