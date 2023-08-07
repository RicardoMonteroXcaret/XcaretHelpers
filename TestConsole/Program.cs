// See https://aka.ms/new-console-template for more information

using Xcaret.ClientHTTP;
using Xcaret.ClientHTTP.ClientHttpWrapper;
using XcaretHelpers;

internal class Program 
{
    private IClientFactory _clientFactory;

    public Program(IClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    private static void Main(string[] args)
    {
        Test test = new();

        test.Hi();

        Console.WriteLine("Hello, World!" + test.Hi());
    }
}