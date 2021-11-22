using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // displays the characters from file in the terminal....
            string text;
            FileStream fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                text = reader.ReadToEnd();
            }
            Console.WriteLine("File Contains:"+ text);

            // deletes the file if it exists
            if (File.Exists("test1.txt"))
            {
                File.Delete("test1.txt");
                Console.WriteLine("File deleted");
            }

            //Copies file test.txt to test1.txt....
            File.Copy("test.txt", "test1.txt");
            Console.WriteLine("File Copied");


        }
        


    }
}
