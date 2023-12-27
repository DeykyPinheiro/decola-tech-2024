
// string[] linhas = File.ReadAllLines("Arquivos/ArquivoTexto.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }

// como tratar com exception
// try
// {
//     string[] linhas2 = File.ReadAllLines("Arquivos/Arquivo.Texto.txt");
//     foreach (string linha in linhas2)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"erro excessao generica {ex.Message}");
// }


// especilizacao 
// try
// {
//     // int a = 1;
//     string[] linhas3 = File.ReadAllLines("Arquivos/Arquivo.Texto.txt");
//     foreach (string linha in linhas3)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"arquivo nao encontrado {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"erro excessao generica {ex.Message}");
// }

// finally
// try
// {
//     string[] linhas4 = File.ReadAllLines("Arquivos/Arquivo.Texto.txt");
//     foreach (string linha in linhas4)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"arquivo nao encontrado {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"erro excessao generica {ex.Message}");
// }
// finally{
//     Console.WriteLine($"fim da excecucao do programas");
// }


// new ExemploExcecao.Metodo1();

using LeituraArquivo;

ExemploExcecao exemplo = new ExemploExcecao();
exemplo.Metodo1();