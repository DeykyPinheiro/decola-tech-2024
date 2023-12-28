using TestePoo.Models;

string nome = Console.ReadLine();
int mana = int.Parse(Console.ReadLine());
int danoBase = int.Parse(Console.ReadLine());
Subclasse personagem = new Subclasse(nome, mana, danoBase);

personagem.CalcularDano();



















// TESTE PERSONAGEM
// string nome = Console.ReadLine();
// string raca = Console.ReadLine();
// string classe = Console.ReadLine();
// Personagem personagem = new Personagem(nome, raca, classe);
// personagem.ExibirStatus();


















// TESTE JOGADOR
// string nome = Console.ReadLine();
// string nacionalidade = Console.ReadLine();
// int idade = int.Parse(Console.ReadLine());
// string posicao = Console.ReadLine();


// Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);
// Console.WriteLine(jogador.Nome);
// Console.WriteLine(jogador.Nacionalidade);
// Console.WriteLine(jogador.Idade);
// Console.WriteLine($"Posição: {jogador.Posicao}");























// TESTE ROBO
// string[] valores = Console.ReadLine().Split();
// int vmin = int.Parse(valores[0]);
// int vmax = int.Parse(valores[1]);;
// string acoes = Console.ReadLine();
// Robo robo = new Robo(vmin, vmax);
// robo.ExecutarAcoes(acoes);
// Console.WriteLine($"{robo.VelocidadeAtual}");
















// TESTE PESSOA
// Console.WriteLine("digite nome: ");
// string nome = Console.ReadLine();
// Console.WriteLine("digite idade: ");
// int idade = int.Parse(Console.ReadLine());
// Pessoa p = new Pessoa(nome, idade);
// p.Apresentar();