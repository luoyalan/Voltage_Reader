using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voltage_Reader
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pathToResult = @"C:\Users\Yalan\source\repos\Voltage Reader\result.txt";
            VoltageReader(pathToResult);
            Console.ReadKey();
        }

        static void VoltageReader(string path)
        {
            int counter = 0;
            string lineReadFromFile;
            string stringToSearch = "Voltage";
            // Read the file and display the next line under the line which contains "Voltage".  
            using (StreamReader file = new System.IO.StreamReader(path))
            {
                var lines = new List<string>();

                while ((lineReadFromFile = file.ReadLine()) != null)
                {
                    lines.Add(lineReadFromFile);
                }
                for (int i = 0; i < lines.Count; i++)
                {
                    string line = lines[i];
                    string nextLine = i+1 <= lines.Count - 1 ? lines[i + 1] : "";

                    if (line.Contains(stringToSearch))
                    {
                        Console.WriteLine(nextLine);
                    }

                    counter++;
                }

            }
        }
    }
}
