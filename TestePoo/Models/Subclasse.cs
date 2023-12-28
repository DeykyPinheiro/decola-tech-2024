namespace TestePoo.Models
{
    public class Subclasse : PersonagemHeranca
    {
        public int DanoBase { get; set; }

        public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
        {
            DanoBase = danoBase;
        }

        public void CalcularDano()
        {
            Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
        }
    }
}