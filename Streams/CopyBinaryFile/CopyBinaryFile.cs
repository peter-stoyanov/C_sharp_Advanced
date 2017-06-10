using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string original = "../../chowder.png";
            string copy = "../../copyOfChowder.png";

            using (FileStream inputStream = new FileStream(original, FileMode.Open))
            {
                using (FileStream outputStream = new FileStream(copy, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = inputStream.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        outputStream.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
