namespace ConsoleApp5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var somName = "Евгения";
            Console.WriteLine(somName);


            string name = null;
            GetName(ref name);

            Console.WriteLine(name);

            Console.ReadKey();
        }
        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }
    }
}