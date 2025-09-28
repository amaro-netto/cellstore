namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        
        // Memória livre para simular uso de apps
        private int _memoriaLivre; // Campo privado para controle interno

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            _memoriaLivre = memoria; // Inicialmente, a memória livre é igual à total
        }

        public void Ligar()
        {
            // Agora usamos a propriedade Numero para um retorno mais detalhado
            Console.WriteLine($"Ligando o {Modelo}... Número: {Numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação no {Modelo}...");
        }

        // Método abstrato permanece, mas a lógica de verificação de memória será aplicada aqui,
        // mas a mensagem final será polimórfica (implementada nas classes filhas).
        public abstract void InstalarAplicativo(string nomeApp);
        
        // Novo método para verificar e gerenciar o uso da memória
        protected bool GerenciarMemoria(int tamanhoApp)
        {
            if (tamanhoApp <= _memoriaLivre)
            {
                _memoriaLivre -= tamanhoApp;
                Console.WriteLine($"  -> Memória utilizada: {tamanhoApp}MB. Memória restante: {_memoriaLivre}MB.");
                return true;
            }
            else
            {
                Console.WriteLine($"  -> ERRO: Sem espaço suficiente! Livre: {_memoriaLivre}MB, Requerido: {tamanhoApp}MB.");
                return false;
            }
        }
    }
}