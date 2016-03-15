namespace TelerikAcademyLearningSystem.Utilities.SortingHelpers
{
    using System;
    using System.Collections;

    public class SortingHallsHelper : IComparer
    {
        private string[] halls = new string[] { "Light", "Ultimate", "Enterprise" };

        public int Compare(object first, object second)
        {
            string firstAsString = (string)first;
            string secondAsString = (string)second;

            if (Array.IndexOf(this.halls, firstAsString) > Array.IndexOf(this.halls, secondAsString))
            {
                return 1;
            }

            if (Array.IndexOf(this.halls, firstAsString) < Array.IndexOf(this.halls, secondAsString))
            {
                return -1;
            }

            return 0;
        }
    }
}