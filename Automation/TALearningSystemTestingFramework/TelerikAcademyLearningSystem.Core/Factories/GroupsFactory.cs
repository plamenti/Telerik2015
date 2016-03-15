namespace TelerikAcademyLearningSystem.Core.Factories
{
    using TelerikAcademyLearningSystem.Core.Constants;
    using TelerikAcademyLearningSystem.Core.Model;

    public class GroupsFactory
    {
        public Group CreateGroup()
        {
            return new Group(GroupProperties.GroupName, GroupProperties.CourseName, GroupProperties.WeekDay, GroupProperties.StartTime, GroupProperties.EnrollmentStartTime, GroupProperties.TrainingRoom, GroupProperties.WeekLectureNumber, GroupProperties.PeopleLimit);
        }
    }
}