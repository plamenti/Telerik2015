namespace TelerikAcademyLearningSystem.Utilities.SortingHelpers
{
    using System;
    using System.Collections;

    public class SortingTimesHelper : IComparer
    {
        public int Compare(object first, object second)
        {
            DateTime firstTime = Convert.ToDateTime((string)first);
            DateTime secondTime = Convert.ToDateTime((string)second);
            return DateTime.Compare(firstTime, secondTime);
        }
    }
}