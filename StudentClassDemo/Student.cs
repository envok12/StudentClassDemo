using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {
        private string name;
        private int idNumber;
        private double score1;
        private double score2;
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

        public Student()
        {

        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }
            
        public int GetIdNumber()
        {
            return idNumber;
        }

        public void SetIdNumber(int newIdNumber)
        {
            idNumber = newIdNumber;
        }

        public double GetScore1()
        {
            return score1;
        }

        public double GetScore2()
        {
            return score2;
        }

        public void SetScore1(double newScore1)
        {
            score1 = newScore1;
            UpdateAverageScore();
        }

        public void SetScore2(double newScore2)
        {
            score2 = newScore2;
            UpdateAverageScore();
        }

        public double GetAverageScore()
        {
            return averageScore;
        }

        private void UpdateAverageScore()
        {
            averageScore = (score1 + score2) / 2;
        }

        public double GetHighScore()
        {
            if(score1>score2)
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
