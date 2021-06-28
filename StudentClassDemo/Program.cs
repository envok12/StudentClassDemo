using System;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student molly = new Student();
            molly.Name = "Molly the Cat";
            Console.WriteLine(molly.Name);

            Student bella = new Student();
            bella.Name = "Bella Yamaki";
            Console.WriteLine(bella.Name);
            //molly.idNumber = 42;
            //Console.WriteLine(molly.idNumber);
            */

            /*Student.DoStuff();

            Student joe = new Student();
            joe.SetName("Joe Shmoe");

            string joesName = joe.GetName();
            Console.WriteLine("Joe's name is {0}", joe.GetName());

            Student jane = new Student();
            jane.SetName("Jane");
            Console.WriteLine("Jane's name is {0}", jane.GetName());

            jane.SetScore1(100);
            jane.SetScore2(50);
            Console.WriteLine("Jane's average score is {0}", jane.GetAverageScore());

            jane.SetScore2(90);
            Console.WriteLine("Jane's new average score is {0}", jane.GetAverageScore());

            Console.WriteLine("Jane's high score is {0}", jane.GetHighScore());

            jane.SetScore2(110);
            Console.WriteLine("Jane's new high score is {0}", jane.GetHighScore());
            */

            Student molly = new Student("Molly Cat", 1234); //1.2 Constructors Demo

            Console.WriteLine("molly's Id Number: {0}", molly.GetIdNumber());
            Console.WriteLine("molly's Name: {0}", molly.GetName());

            Student bella = new Student("Bella");

            Console.WriteLine("bella’s Id Number: {0}", bella.GetIdNumber());
            Console.WriteLine("bella’s Name: {0}", bella.GetName());

            Student kitKat = new Student("KitKat");

            Console.WriteLine("kitKat’s Id Number: {0}", kitKat.GetIdNumber());
            Console.WriteLine("kitKat’s Name: {0}", kitKat.GetName());


        }
    }
}
