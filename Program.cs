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
            while ((inputLine = tr.ReadLine()) != null)
            { 
                //And write the contents to the screen
                Console.WriteLine(inputLine); 
            }
        }
    }
}
