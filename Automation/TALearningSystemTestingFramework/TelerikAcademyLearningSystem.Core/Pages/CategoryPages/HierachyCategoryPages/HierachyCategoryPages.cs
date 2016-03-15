namespace TelerikAcademyLearningSystem.Core.Pages.CategoryPages.HierachyCategoryPages
{
    using System.Collections.Generic;
    using ArtOfTest.WebAii.Core;
    using Base;
    using Constants;
    using Model;

    public partial class HierachyCategoryPages : BasePage<HierachyCategoryPages>
    {
        private int indexOfMainCategory;

        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.HierarchyCategories);
        }

        public void FindListElementIndex(string categoryName)
        {
            for (int i = 0; i < this.ListWithCategories.ChildNodes.Count; i++)
            {
                if (this.ListWithCategories.ChildNodes[i].InnerText == categoryName)
                {
                    this.indexOfMainCategory = i;
                }
            }
        }

        internal void FindNestedCategories(Categories category, List<Categories> listOfNestedCategories)
        {
            this.FindListElementIndex(category.Name);
            this.Category.ScrollToVisible();
            this.Category.MouseClick(MouseClickType.LeftDoubleClick);
        }
    }
}
