using System;
using System.Collections.Generic;
using System.IO;

namespace ExploringMars
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];
            List<string> inputData = new List<string>();

            try
            {
                using (StreamReader file = File.OpenText(path))
                {
                    while (!file.EndOfStream)
                    {
                        string fileLine = file.ReadLine();
                        inputData.Add(fileLine);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error reading file. " + e.Message);
            }

            if (inputData.Count > 0)
            {
                
            }



        }
    }
}
