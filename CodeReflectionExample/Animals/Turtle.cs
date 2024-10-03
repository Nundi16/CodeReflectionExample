using CodeReflectionExample.Attributes;
using CodeReflectionExample.Interfaces;

namespace CodeReflectionExample.Animals
{
    [Mute]
    internal class Turtle : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Hi My name is Raffaello");
        }
    }
}
