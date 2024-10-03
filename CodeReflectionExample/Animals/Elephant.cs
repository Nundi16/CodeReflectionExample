using CodeReflectionExample.Interfaces;

namespace CodeReflectionExample.Animals
{
    internal class Elephant : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void SayHello()
        {
            Console.WriteLine($"Hi I'm the Elephant");
        }
    }
}
