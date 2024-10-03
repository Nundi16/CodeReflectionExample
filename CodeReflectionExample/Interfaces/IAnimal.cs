namespace CodeReflectionExample.Interfaces
{
    internal interface IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void SayHello();
    }
}
