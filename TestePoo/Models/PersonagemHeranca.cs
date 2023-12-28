namespace TestePoo.Models
{
    public class PersonagemHeranca
    {
            public string Nome { get; set; }
    public int Mana { get; set; }

    public PersonagemHeranca(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
    }
}