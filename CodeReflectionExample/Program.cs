

using CodeReflectionExample;

internal class Program
{
    private static void Main(string[] args)
    {
        var zoo = new ZooFactory();
        zoo.MakeAnimalSpeak();
        Console.ReadKey();
    }
}