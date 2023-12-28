
// #1
// // TODO: Declare as variáveis para guardar as informações de nome, email e senha:
// string registroEmail;
// string registroNome;
// string registroSenha;

// // Obtém o email e nome do usuário a partir da entrada do console
// registroEmail = Console.ReadLine();
// registroNome = Console.ReadLine();
// registroSenha = Console.ReadLine();


// // TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
// Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");


// #2
// // TODO: Crie as variáveis titulo, descricao e dataVencimento para guardar as informações das tarefas:
// string titulo;
// string descricao;
// string dataVencimento;

// // Obtém o titulo e a descricao a partir da entrada do console  
// titulo = Console.ReadLine();
// descricao = Console.ReadLine();

// // TODO: Crie uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres.
// if (descricao.Length <= 50)
// {

//     // Caso a descricao esteja dentro do limite é solicitado a entrada pelo console:
//     dataVencimento = Console.ReadLine();
//     // DateTime.TryParseExact(input, "MM/yy", null, System.Globalization.DateTimeStyles.None, out dataVencimento)
//     // dataVencimento = DateTime.ParseExact(input, "MM/yy", null);
//     Console.WriteLine($"{descricao} ate {dataVencimento}");
// }
// else
// {
//     Console.WriteLine("Descricao ultrapassa limite de caracteres.");
// }
// // TODO: Imprima a descricao e a data de vencimento como nos exemplos da tabela:   


// #3
// // Solicita ao usuário os limites inferiores e superiores
// int limiteInferior = int.Parse(Console.ReadLine());
// int limiteSuperior = int.Parse(Console.ReadLine());

// // Variável para acumular a soma dos números pares
// int somaPares = 0;

// // TODO: Crie um Loop para percorrer os números no intervalo
// // Lembre-se: O limiteSuperior deve ser menor ou igual a i;
// for (int i = limiteInferior; i <= limiteSuperior; i++)
// {
//     if (i % 2 == 0)
//     {
//         somaPares = somaPares + i++;
//     }
// }

// // TODO: Implemente o if para verificar se o número é par:


// // TODO: Crie o acumulador para a soma dos números pares:

// // Exibe o resultado
// Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");


// #4
// static void Main()
// {
//     // Pergunta ao usuário quantos jogos deseja adicionar:
//     int quantidadeJogos = int.Parse(Console.ReadLine());

//     // TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
//     string[] nomesJogos = new string[quantidadeJogos];


//     // TODO: Crei um Loop para adicionar jogos conforme a quantidade especificada:
//     for (int i = 0; i < nomesJogos.Length; i++)
//     {
//         AdicionarJogo(i, nomesJogos);
//     }


//     //TODO: Chame a função AdicionarJogo para obter o nome do jogo e armazená-lo no array:


//     // Exibe o resumo da adição de jogos
//     ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
// }

// static void AdicionarJogo(int indice, string[] nomes)
// {
//     // Entrada do nome do jogo
//     nomes[indice] = Console.ReadLine();
// }

// static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
// {
//     string listaJogos = string.Join(", ", nomes);
//     Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {listaJogos} ao catalogo.");
// }

// #5
static void Main()
{
    // Solicita o nome do usuário, quilômetros percorridos por dia, 
    // Horas de uso de eletrônicos por dia e o número de refeições com carne:
    Console.WriteLine("digite o nome");
    string nome = Console.ReadLine();
    double quilometrosPorDia = double.Parse(Console.ReadLine());
    int horasDeEletronicos = int.Parse(Console.ReadLine());
    int refeicoesComCarne = int.Parse(Console.ReadLine());

    // Chama o método para calcular a pegada de carbono
    double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

    // TODO: Exiba o resultado para o usuário:
    Console.WriteLine($"{nome}, sua pegada de carbono e de {pegadaDeCarbono} toneladas de CO2 por ano.");

    // Aguarda a entrada do usuário antes de encerrar o programa:
    Console.ReadLine();
}

static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
{
    //  transporte (quilômetros diários × 365 × 0.2), 
    // eletrônicos (horas diárias × 0.1) 
    //  consumo de carne (refeições com carne por dia × 0.5)

    double transporte = quilometrosPorDia * 365 * 0.2;
    double horasDiarias = horasDeEletronicos * 0.1;
    double consumCarne = refeicoesComCarne * 0.5;

    return transporte + horasDiarias + consumCarne;
}

// TODO: Crie um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos: