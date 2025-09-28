namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public int Memoria { get; set; } 
        public string IMEI { get; set; }
        
        private int _memoriaLivreMB;

        public Smartphone(string numero, string modelo, string imei, int memoriaGB)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoriaGB;
            
            // CONVERSÃO: Convertemos a memória total (em GB) para Megabytes para o cálculo interno.
            _memoriaLivreMB = memoriaGB * 1024; // 1GB = 1024MB
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando o {Modelo}... Número: {Numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação no {Modelo}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        
        protected bool GerenciarMemoria(int tamanhoAppMB)
        {
            if (tamanhoAppMB <= _memoriaLivreMB)
            {
                _memoriaLivreMB -= tamanhoAppMB;
                // Saída de dados melhorada para mostrar a memória restante em MB e GB para clareza.
                double memoriaRestanteGB = (double)_memoriaLivreMB / 1024;

                Console.WriteLine($"  -> Memória utilizada: {tamanhoAppMB}MB.");
                Console.WriteLine($"  -> Memória restante: {memoriaRestanteGB:F2}GB ({_memoriaLivreMB}MB)."); // Ordem invertida
                return true;
            }
            else
            {
                // Mostramos a memória livre também em GB para o usuário ter uma ideia melhor.
                double memoriaLivreGB = (double)_memoriaLivreMB / 1024;
                Console.WriteLine($"  -> ERRO: Sem espaço suficiente para instalar!");
                Console.WriteLine($"     Livre: {memoriaLivreGB:F2}GB ({_memoriaLivreMB}MB), Requerido: {tamanhoAppMB}MB."); // Ordem invertida
                return false;
            }
        }
        
        public void ExibirDetalhes()
        {
            double memoriaLivreGB = (double)_memoriaLivreMB / 1024;
            // Cálculo da memória usada
            int memoriaUsadaMB = (Memoria * 1024) - _memoriaLivreMB;
            double memoriaUsadaGB = (double)memoriaUsadaMB / 1024;

            Console.WriteLine("\n--- Detalhes do Aparelho ---");
            Console.WriteLine($"  Marca: {GetType().Name}");
            Console.WriteLine($"  Modelo: {Modelo}");
            Console.WriteLine($"  Número: {Numero}");
            Console.WriteLine($"  IMEI: {IMEI}");
            Console.WriteLine($"  Memória Total: {Memoria}GB ({Memoria * 1024}MB)");
            // NOVO FORMATO: GB (MB)
            Console.WriteLine($"  Memória Usada: {memoriaUsadaGB:F2}GB ({memoriaUsadaMB}MB)");
            // NOVO FORMATO: GB (MB)
            Console.WriteLine($"  Memória Livre: {memoriaLivreGB:F2}GB ({_memoriaLivreMB}MB)");
            Console.WriteLine("----------------------------");
        }
    }
}