namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Categories
{
    using System.Collections.Generic;
    using Core.Constants;
    using Core.Facades;
    using Core.Model;
    using Core.Pages.CategoryPages;
    using Excel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using Utilities;

    [TestClass]
    public class CategoryTest : BaseTest
    {
        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyAddEditFormCreateCategory()
        {
            CategoryFacade facade = new CategoryFacade();
            Categories category = new Categories("Category", "20");
            
            facade.AddCategory(category);
            
            facade.AssertCategoryExist(category);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyAddFormNameErrorMessages()
        {
            CategoryFacade facade = new CategoryFacade();
            var path = PathGenerator.AbsoluteRelativeCombine(Paths.DataBindLocation + "CategoryFormName.xlsx");

            foreach (var sheet in Workbook.Worksheets(path))
            {
                foreach (var row in sheet.Rows)
                {
                    Categories category = new Categories(row.Cells);

                    facade.AddCategory(category);

                    facade.AssertNameErrorMessage(category);
                }
            }
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyAddFormOrderErrorMessages()
        {
            CategoryFacade facade = new CategoryFacade();
            var path = PathGenerator.AbsoluteRelativeCombine(Paths.DataBindLocation + "CategoryFormOrder.xlsx");

            foreach (var sheet in Workbook.Worksheets(path))
            {
                foreach (var row in sheet.Rows)
                {
                    Categories category = new Categories(row.Cells);

                    facade.AddCategory(category);

                    facade.AssertOrderErrorMessage(category);
                }
            }
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyEditFormCreateCategory()
        {
            CategoryFacade facade = new CategoryFacade();
            Categories category = new Categories("Category", "20");
            Categories editCategory = new Categories("EditCat", "10");

            facade.AddCategory(category);
            facade.EditCategory(category, editCategory);

            facade.AssertCategoryExist(editCategory);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyEditFormNameErrorMessagesDataBind()
        {
            CategoryFacade facade = new CategoryFacade();
            Categories category = new Categories("Category", "20");
            var path = PathGenerator.AbsoluteRelativeCombine(Paths.DataBindLocation + "CategoryFormName.xlsx");

            facade.AddCategory(category);
            foreach (var sheet in Workbook.Worksheets(path))
            {
                foreach (var row in sheet.Rows)
                {
                    Categories editCategory = new Categories(row.Cells);

                    facade.EditCategory(category, editCategory);

                    facade.AssertNameErrorMessage(editCategory);
                }
            }
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyEditFormOrderErrorMessagesDataBind()
        {
            CategoryFacade facade = new CategoryFacade();
            Categories category = new Categories("Category", "20");
            var path = PathGenerator.AbsoluteRelativeCombine(Paths.DataBindLocation + "CategoryFormOrder.xlsx");

            facade.AddCategory(category);
            foreach (var sheet in Workbook.Worksheets(path))
            {
                foreach (var row in sheet.Rows)
                {
                    Categories editCategory = new Categories(row.Cells);

                    facade.EditCategory(category, editCategory);

                    facade.AssertOrderErrorMessage(editCategory);
                }
            }
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyDownloadExcelFile()
        {
            string fileName = "CategoryExportGrid.xlsx";

            CategoryPage.Instance.ExportFile(fileName);

            CategoryPage.Instance.AssertFileExist(fileName);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyDownloadPdfFile()
        {
            string fileName = "CategoryExportGrid.pdf";

            CategoryPage.Instance.ExportFile(fileName);

            CategoryPage.Instance.AssertFileExist(fileName);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyGridSort()
        {
            CategoryFacade facade = new CategoryFacade();

            facade.SortGrid();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyNestedCategoriesAreCreated()
        {
            CategoryFacade facade = new CategoryFacade();
            Categories category = new Categories("Category", "15");
            var listOfNestedCategories = new List<Categories>()
            {
                new Categories("NestedOne", "2"),
                new Categories("NestedTwo", "4"),
                new Categories("NestedThree", "3")
            };

            facade.AddCategory(category);
            facade.AddNestedCategory(category, listOfNestedCategories);
            facade.GoToHierarchyPage(category, listOfNestedCategories);

            facade.AssertCategoryHierachy(category, listOfNestedCategories);
        }
    }
}