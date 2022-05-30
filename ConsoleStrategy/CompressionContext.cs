using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStrategy
{
    public class CompressionContext
    {
        private ICompression _icompress;

        public CompressionContext(ICompression icompress)
        {
            _icompress = icompress;
        }

        public void DefineStrategy(ICompression icompress)
        {
            _icompress = icompress;
        }

        public void CreateFileCompress(string fileName)
        {
            _icompress.FileCompress(fileName);
        }



    }
}
