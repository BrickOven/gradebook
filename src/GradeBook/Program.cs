using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Brian's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(97.2);
            book.AddGrade(57.2);
            
            book.ShowStatistics();
        }
    }
}
