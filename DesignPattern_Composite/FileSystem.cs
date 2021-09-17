using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Composite
{
    interface FileSystem
    {
        public int GetSize();
        public void Remove();
    }

    class CustomFile : FileSystem
    {
        private string name;
        private int size;

        public CustomFile(string _name, int _size)
        {
            name = _name;
            size = _size;
        }

        public int GetSize()
        {
            Console.WriteLine(name + "파일 크기: " + size);
            return size;
        }

        public void Remove()
        {
            Console.WriteLine(name + " 파일 삭제");
        }
    }

    class CustomFolder : FileSystem
    {
        private string name;
        private List<FileSystem> includeds = new List<FileSystem>();

        public CustomFolder(string _name)
        {
            name = _name;
        }

        public void Add(FileSystem fileSystem)
        {
            includeds.Add(fileSystem);
        }

        public int GetSize()
        {
            int total = 0;

            foreach (var included in includeds)
            {
                total += included.GetSize();
            }

            Console.WriteLine(name + "폴더 크기: " + total);
            Console.WriteLine("------");
            return total;
        }

        public void Remove()
        {
            foreach (var included in includeds)
            {
                included.Remove();
            }

            Console.WriteLine(name + " 폴더 삭제");
            Console.WriteLine("----------");
        }
    }
}
