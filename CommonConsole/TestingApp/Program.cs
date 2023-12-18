namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            for(int i = 1; i < 10; i++){
                name += '1';
                Console.WriteLine(name.Length);
            }
            Console.WriteLine("Welcome " + name);
        }
    }
}