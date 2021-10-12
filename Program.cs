using System;
//Want to open a file so
using System.IO;

namespace SwitchesAndUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Text Reader
            TextReader tr = new StreamReader("D:/CourseNotes/GetStarted.csv");
            //SOmething to read it to
            string inputLine;
            inputLine = tr.ReadLine();
            string[] outputs = {"error", " is a type of penguin!",
                " is a CD"," is a game!", " is unknown!"
            };         
            while ((inputLine = tr.ReadLine()) != null)
            {
                string[] parts = inputLine.Split(',');
                int p0 = Int16.Parse(parts[0]);
                Console.WriteLine(parts[1] + outputs[p0]);
            }
        }
    }
}
