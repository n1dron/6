using convert;
using System.Reflection.PortableExecutable;

namespace main
{
    internal class main
    {
        static void Main()
        {
            Console.WriteLine("Укажите путь: ");
            Files New_file = new Files();
            string path = Console.ReadLine();
            New_file.path(path);
        }
    }
}