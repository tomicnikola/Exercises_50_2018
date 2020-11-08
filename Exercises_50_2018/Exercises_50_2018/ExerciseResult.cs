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

        public int GetSetID { get; set; }
        public string GetSetStudentName { get; set; }
        public string GetSetStudentIndex { get; set; }
        public int GetSetPoints { get; set; }

        public ExerciseResult (int id, string studentName, string studentIndex, int points)
        {
            this.id = id;
            this.studentName = studentName;
            this.studentIndex = studentIndex;
            this.points = points;
        }
    }
}
