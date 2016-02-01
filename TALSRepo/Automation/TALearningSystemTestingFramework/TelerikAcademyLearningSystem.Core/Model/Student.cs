namespace TelerikAcademyLearningSystem.Core.Model
{
    public class Student
    {
        public Student(string userName, string course)
        {
            this.UserName = userName;
            this.Course = course;
        }

        public Student(string userName, string course, bool isLiveParticipant, bool canDoPracticalExam, bool canDoTestExam, string accommodation)
            : this(userName, course)
        {
            this.IsLiveParticipant = isLiveParticipant;
            this.CanDoPracticalExam = canDoPracticalExam;
            this.CanDoTestExam = canDoTestExam;
            this.Accommodation = accommodation;
        }

        public Student(string userName, string course, bool isLiveParticipant, bool canDoPracticalExam, bool canDoTestExam, string accommodation, string coursePoints, string courseResult)
            : this(userName, course, isLiveParticipant, canDoPracticalExam, canDoTestExam, accommodation)
        {
            this.CoursePoints = coursePoints;
            this.CourseResult = courseResult;
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Course { get; set; }

        public string CoursePoints { get; set; }

        public string CourseResult { get; set; }

        public bool IsLiveParticipant { get; set; }

        public bool IsDeletedFromCourse { get; set; }

        public bool CanDoPracticalExam { get; set; }

        public bool CanDoTestExam { get; set; }

        public string Accommodation { get; set; }

        public int Id { get; set; }
    }
}