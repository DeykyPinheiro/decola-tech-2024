namespace TestePoo.Models
{
    public class Jogador
    {
        public Jogador(string nome, string nacionalidade, int idade, string posicao)
        {
            Nome = nome;
            Nacionalidade = nacionalidade;
            Idade = idade;
            Posicao = posicao;
            Console.WriteLine($"Jogador criado!");
        }

        public void Apresentar()
        {
            Console.WriteLine($"{Nome} {Nacionalidade} {Idade} Posição: {Posicao}");
        }


        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public int Idade { get; set; }
        public string Posicao { get; set; }


    }
}