namespace TelerikAcademyLearningSystem.Core.Facades
{
    using System.Collections.Generic;
    using Model;
    using Pages.AdministrationPage;
    using Pages.CategoryPages;
    using Pages.CategoryPages.AddEditFormPage;
    using Pages.CategoryPages.HierachyCategoryPages;
    using Pages.NavigationPage;

    public class CategoryFacade
    {
        public void ManualNavigate()
        {
            NavigationPage.Instance.GoToAdminPage();
            AdministrationPage.Instance.ClickCategoryLink();
        }

        public void GoBackToAdminPage()
        {
            CategoryPage.Instance.Navigate();
            CategoryPage.Instance.GoBackToAdmin();
        }

        public void AddCategory(Categories category)
        {
            CategoryPage.Instance.Navigate();
            if (CategoryPage.Instance.CheckCategoryExist(category))
            {
                CategoryPage.Instance.DeleteCategory(category);
            }

            CategoryPage.Instance.OpenAddForm();
            CategoryFormPage.Instance.FillForm(category);
            CategoryFormPage.Instance.UpdateForm();
        }

        public void AddNestedCategory(Categories category, List<Categories> listOfNestedCategories)
        {
            CategoryPage.Instance.OpenNestedCategories(category);
            foreach (var nestedCategory in listOfNestedCategories)
            {
                CategoryPage.Instance.OpenNestedAddForm();
                CategoryFormPage.Instance.FillForm(nestedCategory);
                CategoryFormPage.Instance.UpdateForm();
            }
        }

        public void EditCategory(Categories category, Categories editCategory)
        {
            CategoryPage.Instance.OpenEditForm(category);
            CategoryFormPage.Instance.FillForm(editCategory);
            CategoryFormPage.Instance.UpdateForm();
        }

        public void GoToHierarchyPage(Categories category, List<Categories> listOfNestedCategories)
        {
            var gridMainRowsCount = CategoryPage.Instance.GridPage.GridTable.BodyRows.Count - 1;
            HierachyCategoryPages.Instance.Navigate();
            HierachyCategoryPages.Instance.AssertNumberOfMainCategories(gridMainRowsCount);
            HierachyCategoryPages.Instance.AssertMainCategotyIsExpandable(category);
            HierachyCategoryPages.Instance.FindNestedCategories(category, listOfNestedCategories);
        }

        public void AssertCategoryPageIsOpen()
        {
            CategoryPage.Instance.AssertTitle();
            CategoryPage.Instance.AssertHeader();
        }

        public void AssertCategoryExist(Categories category)
        {
            CategoryPage.Instance.AssertCategoryExist(category);
        }

        public void AssertNameErrorMessage(Categories category)
        {
            CategoryFormPage.Instance.AssertNameErrorMessage(category);
        }

        public void AssertOrderErrorMessage(Categories category)
        {
            CategoryFormPage.Instance.AssertOrderErrorMessage(category);
        }
        
        public void AssertCategoryHierachy(Categories category, List<Categories> listOfNestedCategories)
        {
            var listFromSite = HierachyCategoryPages.Instance.NestedListWithCategories;
            HierachyCategoryPages.Instance.AssertNestedCategoriesAreOrderedRight(listOfNestedCategories);
        }

        public void SortGrid()
        {
            CategoryPage.Instance.Navigate();
            CategoryPage.Instance.GridPage.SortGridByStringAndNumber();
        }
    }
}