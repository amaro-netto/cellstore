namespace DesafioPOO.Models
{
    public class Iphone : Smartphone 
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Construtor já faz a atribuição na classe base
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            // Simula um tamanho aleatório para o aplicativo (entre 50MB e 100MB, geralmente apps de iPhone são maiores)
            int tamanhoApp = new Random().Next(50, 101);

            Console.WriteLine($"Tentando instalar o aplicativo '{nomeApp}' ({tamanhoApp}MB) via App Store no iPhone...");

            // Chama a lógica de memória da classe base
            if (GerenciarMemoria(tamanhoApp))
            {
                Console.WriteLine($"** {nomeApp} instalado com sucesso no {Modelo}! **");
            }
            // A mensagem de erro já é impressa pelo método GerenciarMemoria
        }
    }
}