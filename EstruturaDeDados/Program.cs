// FILA

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

// remove sempre o primeiro
Console.WriteLine($"removendo o elemento {fila.Dequeue()}");

foreach (int item in fila)
{
    Console.WriteLine(item);
}

// PILHA
Stack<int> pilha = new Stack<int>();


pilha.Push(1);
pilha.Push(2);
pilha.Push(3);


foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"removendo o elemento do topo {pilha.Pop()}");

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

// DICIONARIO
Dictionary<string, string> dicionario = new Dictionary<string, string>();
dicionario.Add("sp", "sao paulo");
dicionario.Add("mg", "minas gerais");

foreach (KeyValuePair<string, string> item in dicionario)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}


dicionario.Remove("mg");
Console.WriteLine("\nremovi mg");

foreach (KeyValuePair<string, string> item in dicionario)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
