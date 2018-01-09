using System;
using UsingAndDispose.Domain;

namespace UsingAndDispose.Prompt
{
    internal class Program
    {
        private static void Main()
        {
            var name = "Test";
            var folder = "C:/Temp";

            using (var file = new TxtFile(name, folder))
            {
                Console.WriteLine(file.FullPath);
            }

            Console.ReadKey();
        }
    }
}