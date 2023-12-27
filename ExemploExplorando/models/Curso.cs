using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ExemploExplorando.models
{
    public class Curso
    {

        public Curso()
        {
            Alunos = new List<Pessoa>();
        }

        // public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            return Alunos.Count();
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }


        public void ListarAlunos()
        {
            foreach (Pessoa p in Alunos)
            {
                Console.WriteLine($"Aluno: {p.Nome}");
            }
        }

    }
}