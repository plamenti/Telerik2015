namespace TelerikAcademyLearningSystem.Utilities.SortingHelpers
{
    using System;
    using System.Collections;

    public class SortingFreePlacesHelper : IComparer
    {
        public int Compare(object first, object second)
        {
            int firstFreePlaces = int.Parse(this.ExtractFreePlaces((string)first));
            int secondFreePlaces = int.Parse(this.ExtractFreePlaces((string)second));

            return firstFreePlaces.CompareTo(secondFreePlaces);
        }

        private string ExtractFreePlaces(string places)
        {
            // 10 от 10
            char separator = ' ';

            var splittedPlaces = places.Split(new char[] { separator }, StringSplitOptions.RemoveEmptyEntries);

            return splittedPlaces[0];
        }
    }
}