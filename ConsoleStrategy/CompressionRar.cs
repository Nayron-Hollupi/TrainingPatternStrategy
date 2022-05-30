using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategy
{
    public class CompressionRar : ICompression
    {
        public void FileCompress(string fileName)
        {
            Console.WriteLine($"\n\t\t\t\t\tThe file '{fileName}' compacted to with sucess to Rar ");
        }

    }
}
