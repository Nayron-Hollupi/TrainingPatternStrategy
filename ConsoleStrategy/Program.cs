using System;

namespace ConsoleStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\t\t\t>>>>>>>Training Designer Pattern<<<<<<<");
            CompressionContext ctx = new CompressionContext(new CompressionZip());

            Console.Write("\n\t\t\t\t\tEnter the name of the file to be compressed: ");
            var fileName = Console.ReadLine();

            Console.WriteLine("\n\t\t\t\t\tWhat type of compression you want to use.");
            Console.WriteLine("\n\t\t\t\t\t1- Zip(Pattern)  \n\t\t\t\t\t2-Rar  \n\t\t\t\t\t3 -Gzip\n");
            Console.Write("\n\t\t\t\t\toption: ");
            var option = Convert.ToInt32(Console.ReadLine());

            if(option == 2) 
            {
                ctx.DefineStrategy(new CompressionRar());
            }else if (option == 3)
            {
                ctx.DefineStrategy(new CompressionGzip());
            }

            ctx.CreateFileCompress(fileName);


            Console.Read();

        }
    }
}
