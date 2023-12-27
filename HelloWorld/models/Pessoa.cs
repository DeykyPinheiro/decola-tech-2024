using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloWorld.models
{
    public class Pessoa
    {
        public int Idade { get; set; }

        public string Nome { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"meu nome é: {Nome} tenho {Idade} anos");
        }
    }
}