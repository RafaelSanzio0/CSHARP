public class Program
{
    static readonly Queue<string> pedagio = new();

    public static void Main(string[] args)
    {
        {
            Enqueue("van");
            Enqueue("onibus");
            Enqueue("carro");

            ShowElementsQueue();

            Dequeue();
            Dequeue();
            Dequeue();
            Dequeue();

            ShowElementsQueue();
        }
    }

    private static void ShowElementsQueue()
    {
        Console.WriteLine("ELEMENTOS NA FILA:");
        foreach (var v in pedagio)
        {
            Console.WriteLine(v);
        }
    }

    private static void DesenfileirarVerificandOProximoElemento()
    {
        if (pedagio.Peek() == "guincho")
        {
            Console.WriteLine("guincho está fazendo o pagamento.");
        }
    }

    private static void Dequeue()
    {
        if (pedagio.Any())
        {
            Console.WriteLine($"Saiu na fila: {pedagio.Dequeue()}");
        }
    }

    private static void Enqueue(string veiculo)
    {
        Console.WriteLine($"Entrou na fila: {veiculo}");
        pedagio.Enqueue(veiculo);
    }
}