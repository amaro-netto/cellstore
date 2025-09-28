namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        
        // A propriedade Memoria (o total) permanece em GB (para o usuário ver a especificação).
        public int Memoria { get; set; } 
        public string IMEI { get; set; }
        
        // Campo privado que armazena a memória livre, mas agora será em Megabytes (MB)
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
                Console.WriteLine($"  -> Memória restante: {_memoriaLivreMB}MB ({memoriaRestanteGB:F2}GB).");
                return true;
            }
            else
            {
                // Mostramos a memória livre também em GB para o usuário ter uma ideia melhor.
                double memoriaLivreGB = (double)_memoriaLivreMB / 1024;
                Console.WriteLine($"  -> ERRO: Sem espaço suficiente para instalar!");
                Console.WriteLine($"     Livre: {_memoriaLivreMB}MB ({memoriaLivreGB:F2}GB), Requerido: {tamanhoAppMB}MB.");
                return false;
            }
        }
    }
}