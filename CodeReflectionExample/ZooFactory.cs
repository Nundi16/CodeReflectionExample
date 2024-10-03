using CodeReflectionExample.Attributes;
using CodeReflectionExample.Interfaces;
using System.Reflection;

namespace CodeReflectionExample
{
    internal class ZooFactory
    {
        private List<IAnimal> animals;
        public ZooFactory()
        {
            animals = new List<IAnimal>();
            BuildZoo();
        }
        public void BuildZoo()
        {
            var animalTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IAnimal).IsAssignableFrom(t)
                            && t.IsClass
                            && t.IsAbstract == false);

            foreach (var animalType in animalTypes)
            {
                animals.Add((IAnimal)Activator.CreateInstance(animalType)!);
            }
        }

        public void MakeAnimalSpeak()
        {

            foreach (var animal in animals)
            {
                if (Attribute.IsDefined(animal.GetType(), typeof(Mute)) == false)
                {
                    animal.SayHello();
                }
                else
                {
                    Console.WriteLine($"I'm a {animal.GetType().Name}");
                }
            }
        }
    }
}
