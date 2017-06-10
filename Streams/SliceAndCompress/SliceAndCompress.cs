using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SliceAndCompress
{
    class SliceAndCompress
    {
        static void Main(string[] args)
        {
            string original = "../../originalsong.mp3";
            string outputDir = "../..";
            int parts = 3;

            SliceAndZip(original, outputDir, parts);

            var files = new List<string>()
            {
                "part0.gz",
                "part1.gz",
                "part2.gz"
            };

            UnzipAndAssemble(files, outputDir);
        }

        public static void SliceAndZip(string sourceFile, string destinationDirectory, int parts)
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
                    using (FileStream outputStream = new FileStream(String.Format($"{destinationDirectory}/part{i}.gz"), FileMode.CreateNew))
                    {
                        using (var compressionFile = new GZipStream(outputStream, CompressionMode.Compress, false))
                        {
                            byte[] writeBuffer = new byte[partSize];
                            inputStream.Read(writeBuffer, 0, writeBuffer.Length);
                            compressionFile.Write(writeBuffer, 0, writeBuffer.Length);
                        }
                    }
                }
            }
        }

        public static void UnzipAndAssemble(List<string> files, string destinationDirectory)
        {
            using (var result = new FileStream(destinationDirectory + "//result." + "gz", FileMode.Create))
            {
                foreach (var file in files)
                {
                    using (var currentZip = new FileStream(destinationDirectory + "//" + file, FileMode.Open))
                    {
                        using (var currentDecompress = new GZipStream(currentZip, CompressionMode.Decompress, false))
                        {
                            var buffer = new byte[1024];
                            var countBytes = currentDecompress.Read(buffer, 0, buffer.Length);

                            while (countBytes != 0)
                            {
                                result.Write(buffer, 0, countBytes);
                                countBytes = currentDecompress.Read(buffer, 0, buffer.Length);
                            }
                        }
                    }
                }
            }
        }
    }
}
