using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
            {
                public Book(string name)
                {
                    grades = new List<double>();
                    this.name = name;
                }

                public void AddGrade(double grade)
                {
                    grades.Add(grade);
                }

        public void ShowStatistics()
                {
                     
                    var result = 0.0;
                    var highGrade = double.MinValue;
                    var lowGrade = double.MaxValue;
         
                    foreach(var number in grades)
                    {
                        highGrade = Math.Max(number, highGrade);
                        lowGrade = Math.Min(number, highGrade);
                        result += number;
                    }
         
                    var averageGrade = result / grades.Count;
                  
                    Console.WriteLine ($"Highest of grades is {highGrade} ");
                    Console.WriteLine ($"Lowest of grades is {lowGrade} ");
                    Console.WriteLine ($"Average of grades is {averageGrade} ");
                }
                private List<double> grades;
                private string name;
            }
}