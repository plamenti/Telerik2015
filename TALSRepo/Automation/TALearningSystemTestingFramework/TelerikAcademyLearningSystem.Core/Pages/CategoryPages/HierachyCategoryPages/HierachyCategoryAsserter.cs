namespace TelerikAcademyLearningSystem.Core.Pages.CategoryPages.HierachyCategoryPages
{
    using System.Collections.Generic;
    using System.Linq;
    using ArtOfTest.Common.UnitTesting;
    using Model;

    public static class HierachyCategoryAsserter
    {
        internal static void AssertNumberOfMainCategories(this HierachyCategoryPages page, int gridMainRowsCount)
        {
            Assert.IsTrue(page.ListWithCategories.ChildNodes.Count == gridMainRowsCount);
        }

        internal static void AssertMainCategotyIsExpandable(this HierachyCategoryPages page, Categories category)
        {
            for (int i = 0; i < page.ListWithCategories.ChildNodes.Count; i++)
            {
                if (page.ListWithCategories.ChildNodes[i].InnerText == category.Name)
                {
                    Assert.IsTrue(page.ListWithCategories.ChildNodes[i].ChildNodes[0].Children.Count == 2);
                }
            }
        }

        internal static void AssertNestedCategoriesAreOrderedRight(this HierachyCategoryPages page, List<Categories> listOfNestedCategories)
        {
            listOfNestedCategories = listOfNestedCategories.OrderBy(x => x.Order).ToList();
            for (int i = 0; i < listOfNestedCategories.Count; i++)
            {
                Assert.AreEqual(listOfNestedCategories[i].Name, page.NestedListWithCategories.ChildNodes[i].InnerText);
            }
        }
    }
}
