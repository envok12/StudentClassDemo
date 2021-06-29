using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {
        private string name;
        private int idNumber;
        private int score1;
        private int score2;
        private double averageScore;

        public static void DoStuff()
        {
            Student molly = new Student();
            molly.idNumber = 42;
            molly.name = "Molly Eguchi";
            Console.WriteLine("Molly: {0}", molly.name);
            Console.WriteLine("Molly: {0}", molly.idNumber);

            Student someStudent = new Student();
            Console.WriteLine("someStudent: {0}", someStudent.name);
            Console.WriteLine("someStudent: {0}", someStudent.idNumber);


        }

        public Student() : this("Unknown", -1) //2.1 
        {
            
        }

        public Student(int newIdNumber) : this("Unknown", newIdNumber)// ConstructorsDemo
        {
            //name = "Unknown";
            //idNumber = newIdNumber;
        }

        public Student(string newName) : this(newName, -1)
        {
            //name = newName;
            //idNumber = -1;
        }

        public Student(string newName, int newIdNumber)
        {
            name = newName;
            idNumber = newIdNumber;
        }
       

        public string Name
        {
            get;
            set;
        }

        public string IdNumber
        {
            get;
            set;
        }

        public int Score1
        {
            get 
            { return score1; 
            }
            set 
            { 
                score1 = value;
                UpdateAverageScore();
            }
        }

        public int Score2
        {
            get
            {
                return score2;
            }
            set
            {
                score2 = value;
                UpdateAverageScore();
            }
        }
        public double AverageScore
        {
            get;
            private set;
        }
       

        public double GetAverageScore()
        {
            return averageScore;
        }

        private void UpdateAverageScore()
        {
            averageScore = (score1 + score2) / 2;
        }

       public double HighScore
        {
            get
            {
                if (score1 > score2)
                {
                    return score1;
                }
                else
                {
                    return score2;
                }
            }
        }
        
    }

    
}
