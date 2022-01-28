using System;
using System.IO;
namespace ExerciseFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string sourcePath = @"D:\Documents\curso\file1.txt";
            string targetPath = @"E:\files\file3.txt";


            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                Console.WriteLine(fileInfo.Exists);

                var mess = fileInfo.CopyTo(targetPath);
                Console.WriteLine(mess);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
