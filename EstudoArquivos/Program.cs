using System;
using System.IO;
using System.Net.Http.Headers;
using System.Xml;

namespace EstudoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\gigim\Desktop\C#\Temp\file1.txt";
            string targetPath = @"C:\Users\gigim\Desktop\C#\Temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error Has Occurred");
                Console.WriteLine(e.Message);   
            }

        }
    }
}
