using convert;
using System.Reflection.PortableExecutable;

namespace main
{
    internal class main
    {
        static void Main()
        {
            Files New_file = new Files();
            Console.WriteLine("Укажите путь: ");
            string pth = Console.ReadLine();
            New_file.path(pth);
        }
    }
}