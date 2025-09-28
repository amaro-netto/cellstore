namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone // O Iphone herda de Smartphone
    {
        // Construtor: Passa os parâmetros para o construtor da classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Polimorfismo: Implementação específica do iPhone para a instalação de apps.
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' na App Store do iPhone...");
        }
    }
}