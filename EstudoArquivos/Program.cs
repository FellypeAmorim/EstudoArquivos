using System;
using System.IO;

namespace EstudoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string soucePath = @"C:\Users\gigim\Desktop\C#\Temp\file1.txt";
            string targetPath = @"C:\Users\gigim\Desktop\C#\Temp\file2.txt";
            
            try
            {
                FileInfo fileinfo = new FileInfo(soucePath);
                fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(soucePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
