namespace TelerikAcademyLearningSystem.Utilities.SortingHelpers
{
    using System;
    using System.Collections;

    public class SortingDaysOfWeekHelper : IComparer
    {
        private string[] daysOfWeekBg = new string[] { "понеделник", "вторник", "сряда", "четвъртък", "петък", "събота", "неделя" };

        public int Compare(object first, object second)
        {
            string firstAsString = (string)first;
            string secondAsString = (string)second;

            if (Array.IndexOf(this.daysOfWeekBg, firstAsString) > Array.IndexOf(this.daysOfWeekBg, secondAsString))
            {
                return 1;
            }

            if (Array.IndexOf(this.daysOfWeekBg, firstAsString) < Array.IndexOf(this.daysOfWeekBg, secondAsString))
            {
                return -1;
            }

            return 0;
        }
    }
}