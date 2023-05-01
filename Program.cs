using TCPClient;

internal class Program
{
    private static void Main(string[] args)
    {
        Client client = new Client();
        
        client.handlerAsync();

        Console.WriteLine("Hello, World!");
    }
}
