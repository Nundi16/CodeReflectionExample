using CodeReflectionExample.Interfaces;

namespace CodeReflectionExample.Animals
{
    internal class Giraffe : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void SayHello()
        {
            Console.WriteLine($"Hi I'm the Giraffe");
        }
    }
}
