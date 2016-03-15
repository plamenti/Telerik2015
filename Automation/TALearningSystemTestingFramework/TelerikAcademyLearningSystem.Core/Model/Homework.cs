namespace TelerikAcademyLearningSystem.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Homework
    {
        public Homework(string courseName, string userName, bool forEvaluation)
        {
            this.CourseName = courseName;
            this.UserName = userName;
            this.ForEvaluation = forEvaluation;
        }

        public Homework(string courseName, string lectureName, string userName, bool forEvaluation)
            : this(courseName, userName, forEvaluation)
        {
            this.LectureName = lectureName;
        }

        public Homework(string courseName, string lectureName, string userName, string mark, bool forEvaluation)
            : this(courseName, userName, forEvaluation)
        {
            this.LectureName = lectureName;
            this.Mark = mark;
        }

        public string CourseName { get; set; }

        public string LectureName { get; set; }

        public string UserName { get; set; }

        public string Mark { get; set; }

        public bool ForEvaluation { get; set; }
    }
}
