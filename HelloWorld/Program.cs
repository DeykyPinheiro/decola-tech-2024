// See https://aka.ms/new-console-template for more information


// using helloWorld.models;

// Console.WriteLine("Hello, World!");
// Console.WriteLine("isso é um teste");
// Console.WriteLine("como criar um projeto console: dotnet new console");
// Console.WriteLine("como rodar? dotnet run na pasta do arquivo");


// Pessoa p = new Pessoa();
// p.Nome = "Deyky";
// p.Idade = 27;

// p.Apresentar();

string apresentar = "APRESENTACAO DESSE TESTE";

int quantidade = 1;

double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentar);
Console.WriteLine("quantidade: " + quantidade);
Console.WriteLine("altura: " + altura);
Console.WriteLine("altura com tratamento: " + altura.ToString("0.00"));
Console.WriteLine("preco: " + preco);
Console.WriteLine("condicao: " + condicao);


DateTime atual = DateTime.Now;
Console.WriteLine(atual);

atual = DateTime.Now.AddDays(5);
Console.WriteLine(atual);


Console.WriteLine(atual.ToString("dd/MM/yyy"));

Console.WriteLine(atual.ToString("dd/MM/yyy HH:mm"));
