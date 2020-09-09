using System;
using System.IO;
using System.Net.Http.Headers;

namespace EstudoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gigim\Desktop\C#\Temp\file1.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error Occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }


        }
    }
}
