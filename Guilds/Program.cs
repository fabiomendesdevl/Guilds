namespace Guilds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); 
            var id = Guid.NewGuid();
            Console.WriteLine(id);

            id.ToString();
            id = new Guid();
            Console.WriteLine(id);
        }
    }
}