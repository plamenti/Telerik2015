namespace TelerikAcademyLearningSystem.Core.Pages.GridPages
{
    using ArtOfTest.Common.UnitTesting;

    public static class GridPageAsserter
    {
        internal static void AssertSortedAscending(int result)
        {
            Assert.IsTrue(result <= 0);
        }

        internal static void AssertSorteddescending(int result)
        {
            Assert.IsTrue(result >= 0);
        }
    }
}
