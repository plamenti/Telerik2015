namespace TelerikAcademyLearningSystem.Core.Factories
{
    using System;
    using System.Collections;
    using TelerikAcademyLearningSystem.Core.Constants;
    using TelerikAcademyLearningSystem.Utilities.SortingHelpers;

    public class SortingHelperFactory
    {
        public IComparer CreateSortingHelper(string helper)
        {
            switch (helper)
            {
                case SortingHelpersNames.DatesAndTimes:
                    return new SortingDatesAndTimesHelper();

                case SortingHelpersNames.DaysOfWeek:
                    return new SortingDaysOfWeekHelper();

                case SortingHelpersNames.FreePlaces:
                    return new SortingFreePlacesHelper();

                case SortingHelpersNames.Halls:
                    return new SortingHallsHelper();

                case SortingHelpersNames.Names:
                    return new SortingNamesHelper();

                case SortingHelpersNames.Lectures:
                    return new SortingLecturesHelper();

                case SortingHelpersNames.Times:
                    return new SortingTimesHelper();

                default:
                    throw new ArgumentOutOfRangeException("No such helper");
            }
        }
    }
}