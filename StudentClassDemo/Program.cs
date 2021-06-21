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

            Student.DoStuff();

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

        }
    }
}
