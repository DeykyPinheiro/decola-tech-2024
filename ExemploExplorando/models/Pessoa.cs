using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Pessoa
    {

        private string _nome;

        private int _idade;

        public Pessoa() { }

        public Pessoa(string nome, int idade)
        {
            this.Idade = idade;
            this.Nome = nome;

        }




        public string Nome
        {

            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("argumento nao pode ser vazio");
                }
                _nome = value;
            }
        }

        public int Idade
        {

            // body expression
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser menor do que 0");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"meu nome é {Nome} tenho {Idade} anos");
        }
    }
}