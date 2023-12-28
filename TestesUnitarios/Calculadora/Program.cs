/*
como criar um projeto com teste
criar a pasta projeto
cria a pasta projetoTest
cria uma solution usando o solution c#
aponta a solucao para os dois projetos
aponta o teste para o projeto
para executar o teste é só executar "dotnet test" dentro d projeto de teste
*/

using System.Data;
using Calculadora.Services;

CalculadoraImp calculadora = new CalculadoraImp();
int a = 1;
int b = 2;
int r = calculadora.Soma(a, b);

Console.WriteLine($"soma de {a} + {b} = {r}");
