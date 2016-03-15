namespace TelerikAcademyLearningSystem.Core.Model
{
    public class Group
    {
        public Group()
        {
        }

        public Group(string groupName, string courseName, string weekDay, string startTime, string enrollentStartTime, string trainingRoom, string weekLectureNumber, string peopleLimit)
        {
            this.GroupName = groupName;
            this.CourseName = courseName;
            this.WeekDay = weekDay;
            this.StartTime = startTime;
            this.EnrollmentStartTime = enrollentStartTime;
            this.TrainingRoom = trainingRoom;
            this.WeekLectureNumber = weekLectureNumber;
            this.PeopleLimit = peopleLimit;
        }

        public string GroupName { get; set; }

        public string CourseName { get; set; }

        public string WeekDay { get; set; }

        public string StartTime { get; set; }

        public string EnrollmentStartTime { get; set; }

        public string TrainingRoom { get; set; }

        public string WeekLectureNumber { get; set; }

        public string PeopleLimit { get; set; }
    }
}