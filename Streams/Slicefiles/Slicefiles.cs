using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slicefiles
{
    class Slicefiles
    {
        static void Main(string[] args)
        {
            string original = "../../originalsong.mp3";
            string outputDir = "../..";
            int parts = 3;

            Slice(original, outputDir, parts);

            var files = new List<string>()
            {
                "part0.mp3",
                "part1.mp3",
                "part2.mp3"
            };

            Assemble(files, outputDir);
        }

        public static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream inputStream = new FileStream(sourceFile, FileMode.Open))
            {
                long fileSize = 0;
                var buffer = new byte[1024];
                var countBytes = inputStream.Read(buffer, 0, buffer.Length);

                while (countBytes != 0)
                {
                    fileSize += countBytes;
                    countBytes = inputStream.Read(buffer, 0, buffer.Length);
                }

                inputStream.Seek(0, SeekOrigin.Begin);
                var partSize = fileSize / parts;


                for (int i = 0; i < parts; i++)
                {
                    using (FileStream outputStream = new FileStream(String.Format($"{destinationDirectory}/part{i}.mp3"), FileMode.CreateNew))
                    {
                        byte[] writeBuffer = new byte[partSize];
                        inputStream.Read(writeBuffer, 0, writeBuffer.Length);
                        outputStream.Write(writeBuffer, 0, writeBuffer.Length);
                    }
                }
            }
        }

        public static void Assemble(List<string> files, string destinationDirectory)
        {
            var extension = files[0].Split('.')[1];

            using (var result = new FileStream(destinationDirectory + "//result." + extension, FileMode.Create))
            {
                foreach (var file in files)
                {
                    using (var currentFile = new FileStream(destinationDirectory + "//" + file, FileMode.Open))
                    {
                        var buffer = new byte[1024];
                        var countBytes = currentFile.Read(buffer, 0, buffer.Length);

                        while (countBytes != 0)
                        {
                            result.Write(buffer, 0, countBytes);
                            countBytes = currentFile.Read(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
    }
}
