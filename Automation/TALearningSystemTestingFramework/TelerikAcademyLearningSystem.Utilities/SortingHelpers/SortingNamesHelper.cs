namespace TelerikAcademyLearningSystem.Utilities.SortingHelpers
{
    using System.Collections;

    public class SortingNamesHelper : IComparer
    {
        public int Compare(object first, object second)
        {
            return string.Compare((string)first, (string)second);
        }
    }
}