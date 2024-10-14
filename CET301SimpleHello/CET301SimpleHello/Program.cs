namespace CET301SimpleHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person person = new Person();
            person.Name = "Test";
            Person person2 = new Person();
            person2.Name = "B";
            person2 = person;
            person.Name = "Ahmet";
            Console.WriteLine(person.Name);
        }
    }
}
