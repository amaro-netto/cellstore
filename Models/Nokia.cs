namespace DesafioPOO.Models
{
    // A classe Nokia herda todas as propriedades e métodos da classe Smartphone.
    public class Nokia : Smartphone
    {
        // Construtor: Chamamos o construtor da classe base (Smartphone) usando 'base'
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        
        // Polimorfismo: Sobrescrevemos o método abstrato e damos a ele o comportamento do Nokia.
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia...");
        }
    }
}