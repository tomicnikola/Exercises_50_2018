using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises_50_2018
{
    class ExerciseResult
    {
        private int id;
        private string studentName;
        private string studentIndex;
        private int points;

        public int GetSetID 
        { 
            get { return id; }
            set { id = value; }
        }
        public string GetSetStudentName 
        { 
            get { return studentName; }
            set { studentName = value; }
        }
        public string GetSetStudentIndex 
        {
            get { return studentIndex; }
            set { studentIndex = value; }
        }
        public int GetSetPoints 
        {
            get { return points; }
            set { points = value; }
        }

        public ExerciseResult() { }
        public ExerciseResult (int id, string studentName, string studentIndex, int points)
        {
            this.id = id;
            this.studentName = studentName;
            this.studentIndex = studentIndex;
            this.points = points;
        }

        public override string ToString()
        {
            return "ID: " + id + " StudentName: " + studentName + " StudentIndex: " + studentIndex + " Points: " + points;
        }
    }
}
