namespace TelerikAcademyLearningSystem.Utilities.SortingHelpers
{
    using System.Collections;

    public class SortingLecturesHelper : IComparer
    {
        public int Compare(object first, object second)
        {
            int firstAsNumber = int.Parse((string)first);
            int secondAsNumber = int.Parse((string)second);

            return firstAsNumber.CompareTo(secondAsNumber);
        }
    }
}