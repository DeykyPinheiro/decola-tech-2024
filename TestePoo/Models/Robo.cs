
namespace TestePoo.Models
{
    public class Robo
    {

        public int VelocidadeAtual { get; set; } = 0;
        public int VelocidadeMaxima { get; }
        public int VelocidadeMinima { get; }

        public Robo(int vmin, int vmax)
        {
            VelocidadeMinima = vmin;
            VelocidadeMaxima = vmax;
            VelocidadeAtual = vmin;
        }

        public void Acelerar()
        {
            if (VelocidadeAtual < VelocidadeMaxima)
            {
                VelocidadeAtual++;
            }
        }

        public void Desacelerar()
        {
            if (VelocidadeAtual > VelocidadeMinima)
            {
                VelocidadeAtual--;
            }
        }

        public void ExecutarAcoes(string acoes)
        {

            char[] array = acoes.ToCharArray();
            foreach (char acao in array)
            {
                if (acao.Equals('A'))
                {
                    Acelerar();
                }
                if (acao.Equals('D'))
                {
                    Desacelerar();
                }
            }
        }
    }
}