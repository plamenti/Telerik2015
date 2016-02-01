namespace TelerikAcademyLearningSystem.Core.Factories
{
    using System;
    using TelerikAcademyLearningSystem.Core.Constants;

    public class ColumnIndexFacory
    {
        public int CreateIndex(string by)
        {
            switch (by)
            {
                case GroupsColumnNames.CourseName:
                    return 2;

                case GroupsColumnNames.GroupName:
                    return 3;

                case GroupsColumnNames.DayOfWeek:
                    return 4;

                case GroupsColumnNames.Start:
                    return 5;

                case GroupsColumnNames.LectureNumber:
                    return 6;

                case GroupsColumnNames.Hall:
                    return 7;

                case GroupsColumnNames.EnrollAfter:
                    return 8;

                case GroupsColumnNames.FreePlaces:
                    return 10;

                default:
                    throw new ArgumentOutOfRangeException("No such column title");
            }
        }
    }
}