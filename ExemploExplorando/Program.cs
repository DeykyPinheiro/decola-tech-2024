// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("isso é um teste filho da puta");

using System.Globalization;
using ExemploExplorando.models;

// Pessoa p = new Pessoa("Deyky", -1);

Pessoa p1 = new Pessoa();
p1.Nome = "Deyky";
p1.Idade = 27;
p1.Apresentar();


Pessoa p2 = new Pessoa();
p2.Nome = "Mikael";
p2.Idade = 27;
p2.Apresentar();


Pessoa p3 = new Pessoa("Benjamim", 27);
p3.Apresentar();


Curso curso = new Curso();
curso.AdicionarAluno(p1);
curso.AdicionarAluno(p2);
curso.AdicionarAluno(p3);


Console.WriteLine("\nAlunos no total");
curso.ListarAlunos();


Console.WriteLine("\nAlunos depois de remover um aluno");
curso.RemoverAluno(p1);
curso.ListarAlunos();


int quantidade = curso.ObterQuantidadeAlunosMatriculados();
Console.WriteLine($"\nQuantidade de alunos: {quantidade}");


// valores monetario formatados
decimal valorMonetario = 1342.35M;
Console.WriteLine($"\nvalor {valorMonetario}");

// pega a localizacao do sistem para exibir os valores monetarios
Console.WriteLine($"\nvalor rm brl {valorMonetario:C}");



// mudando a cultura do sistema/ localizacao
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
Console.WriteLine($"\nvalor em usd {valorMonetario:C}");
Console.WriteLine($"\nvalor em usd com 8 casas{valorMonetario:C8}");

// para devolver em uma cultura/ localizacao especifica
Console.WriteLine($"\nespecifico {valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");

// porcentagem
double p = .1920;
Console.WriteLine($"\nporcentagem {p.ToString("P")}");

// personalizaco
double personalizado = 123456;
Console.WriteLine($"\npersonalizado {personalizado.ToString("##-##-##")}");