using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryTraversal
{
    class DirectoryTraversal
    {
        private static SortedDictionary<long, string> filesSizes = new SortedDictionary<long, string>();
        private static Dictionary<string, int> fileExtensions = new Dictionary<string, int>();

        static void Main()
        {
            string inputDir = Console.ReadLine();

            DirectoryInfo dir = new DirectoryInfo(inputDir);

            WalkDirectoryTree(dir);
        }

        static void WalkDirectoryTree(System.IO.DirectoryInfo root, bool walkSubDirs = false)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    if (!filesSizes.ContainsValue(fi.Name) && !filesSizes.ContainsKey(fi.Length))
                    {
                        filesSizes.Add(fi.Length, fi.Name);
                    }
                    if (!fileExtensions.ContainsKey(fi.Extension))
                    {
                        fileExtensions.Add(fi.Extension, 1);
                    }
                    else
                    {
                        fileExtensions[fi.Extension]++;
                    }
                }

            }
            if (walkSubDirs == true)
            {
                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    WalkDirectoryTree(dirInfo, walkSubDirs);
                }
            }

            fileExtensions = fileExtensions
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);


            string resultpath = "../../result.txt";
            using (var outputStream = new StreamWriter(resultpath))
            {
                foreach (var extension in fileExtensions.Keys)
                {
                    outputStream.WriteLine(extension);
                    foreach (var fileName in filesSizes.Values.Where(x => x.EndsWith(extension)).Reverse().ToList())
                    {
                        string size = (filesSizes.Keys.Where(x => filesSizes[x] == fileName).First() / 1000.0).ToString("F3");
                        outputStream.WriteLine($"--{fileName} - {size}kb");
                    }
                }
            }
            
        }

    }
}
