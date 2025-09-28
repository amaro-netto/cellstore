using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
// Criando uma instância (objeto) da classe Nokia
Nokia nokia = new Nokia(numero: "1234-5678", modelo: "Tijolão", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake"); // Chamada polimórfica

Console.WriteLine("\n----------------------------------\n");

Console.WriteLine("Smartphone iPhone:");
// Criando uma instância (objeto) da classe Iphone
Iphone iphone = new Iphone(numero: "9876-5432", modelo: "iPhone 15", imei: "999999999", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram"); // Chamada polimórfica