using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
   public class Gradebook
    {


        public Gradebook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            stats.HighestGrade = 0;

            float sum = 0;
            foreach(float grade in grades)
            {
                
                {
                    stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                    stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                }

               sum += grade;

            }
            stats.AverageGrade = sum / grades.Count;
            return stats;

        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades;

        public GradeStatistics GradeStatistics { get; private set; }
    }
}
