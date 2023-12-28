namespace TestePoo.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }


        public int Idade { get; }

        public string Nome { get; }


        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }

    }
}