namespace TelerikAcademyLearningSystem.Utilities.SortingHelpers
{
    using System;
    using System.Collections;

    public class SortingDatesAndTimesHelper : IComparer
    {
        public int Compare(object first, object second)
        {
            string firstDateAndTimeAsString = this.ExtractDateAndTime((string)first);
            string secondDateAndTimeAsString = this.ExtractDateAndTime((string)second);

            DateTime firstDataAndTime = Convert.ToDateTime(firstDateAndTimeAsString);
            DateTime secondDateAndTime = Convert.ToDateTime(secondDateAndTimeAsString);

            return DateTime.Compare(firstDataAndTime, secondDateAndTime);
        }

        private string ExtractDateAndTime(string rawDateAndTime)
        {
            // 00:00 часа на 29/01/2016
            string separator = " часа на ";

            var splittedDateAndTime = rawDateAndTime.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);

            return splittedDateAndTime[1] + " " + splittedDateAndTime[0];
        }
    }
}