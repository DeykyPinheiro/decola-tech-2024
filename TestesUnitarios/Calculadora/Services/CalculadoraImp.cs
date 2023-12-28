using System.Data;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }

        public bool EhPar(int n)
        {
            return n % 2 == 0;
        }
    }
}