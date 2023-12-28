namespace DesafioCelular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        public string Modelo { get; set; }

        public string IMEI { get; set; }

        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public abstract void ExibirListaDeApps();


        public abstract void InstalarAplicativo(string nome);

        public void Ligar()
        {
            Console.WriteLine($"Ligando celular");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligacao no celular");
        }

        public void ApresentacaoSmartphone()
        {
            Console.WriteLine($"Meu numero é {Numero}, modelo é {Modelo}, IMEI {IMEI}, memoria {Memoria}");
        }
    }
}