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


            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An Error Ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
