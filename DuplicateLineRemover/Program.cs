using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace DuplicateLineRemover
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFile = args[0];

            var destinationPath = Path.GetFileNameWithoutExtension(sourceFile) + "_output" + Path.GetExtension(sourceFile);

            var previousLines = new HashSet<string>();

            File.WriteAllLines(destinationPath, File.ReadLines(sourceFile)
                                                    .Where(line => previousLines.Add(line)));
        }
    }
}