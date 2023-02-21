using System;
using System.Collections.Generic;
using System.Text;

namespace _22022023
{
    internal class Student
    {
        public string FullName;
        public string Group;
        public List<Exam> Exams = new List<Exam>();

        public override string ToString()
        {
            return FullName + " - " + Group;
        }

        public List<Exam> GetExamsByPointRange(byte minPoint, byte maxPoint)
        {
            List<Exam> wantedExams = new List<Exam>();

            foreach (var item in Exams)
            {
                if (item.Point >= minPoint && item.Point <= maxPoint)
                    wantedExams.Add(item);
            }
            return wantedExams;
        }

        public List<Exam> GetExamsByDateRange(DateTime StartDate, DateTime FinishDate)
        {
            List<Exam> wantedExams = new List<Exam>();

            foreach (var item in Exams)
            {
                if (item.StartAt >= StartDate && item.FinishAt <= FinishDate)
                    wantedExams.Add(item);
            }
            return wantedExams;
        }

        public double GetAvgPoint()
        {
            double sum = 0;
            foreach (var item in Exams)
            {
                sum += item.Point;
            }

            return sum / Exams.Count;
        }

        public double GetTotalExamMinutes()
        {
            double totalMinutes = 0;
            foreach (var item in Exams)
            {
                var diff = item.FinishAt - item.StartAt;
                totalMinutes += diff.TotalMinutes;
            }
            return totalMinutes;
        }
    }
}
