using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class IOManager
    {
        public static void TraverseDirectory(string path)
        {
            OutputWriter.WriteEmptyLine();
            int initialIndentation = path.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(path);

            while (subFolders.Count != 0)
            {
                string currentPath = subFolders.Dequeue();
                int indentation = currentPath.Split('\\').Length - initialIndentation;

                OutputWriter.WriteMessageOnNewLine(String.Format("{0}{1}", new string('-', indentation), currentPath));

                foreach (string directoryPath in DirectoryInfo.GetDirectories(currentPath))
                {
                    subFolders.Enqueue(directoryPath);
                }

            }
        }
    }
}
