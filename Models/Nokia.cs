namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Construtor já faz a atribuição na classe base
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            // Simula um tamanho aleatório para o aplicativo (entre 10MB e 50MB)
            int tamanhoApp = new Random().Next(10, 51); 

            Console.WriteLine($"Tentando instalar o aplicativo '{nomeApp}' ({tamanhoApp}MB) via Ovi Store no Nokia...");
            
            // Chama a lógica de memória da classe base
            if (GerenciarMemoria(tamanhoApp))
            {
                Console.WriteLine($"** {nomeApp} instalado com sucesso no {Modelo}! **");
            }
            // A mensagem de erro já é impressa pelo método GerenciarMemoria
        }
    }
}