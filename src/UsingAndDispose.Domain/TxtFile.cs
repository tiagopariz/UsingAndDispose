using System;

namespace UsingAndDispose.Domain
{
    public class TxtFile : IDisposable
    {
        public TxtFile(string name, string folder)
        {
            Name = name;
            Folder = folder;
            FullPath = Folder + "/" + Name;
        }

        public string Name { get; }
        public string Folder { get; }
        public string FullPath { get; }

        public void Close()
        {
            Console.WriteLine("Dispose object...");
        }

        public void Dispose()
        {
            Close();
        }
    }
}