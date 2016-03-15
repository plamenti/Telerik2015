namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Instances
{
    using Core.Facades;
    using Core.Model;
    using Excel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using Core.Constants;
    using Utilities;
    using Core.Pages.InstancePages;

    [TestClass]
    public class AddEditInstanceTests : BaseTest
    {
        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyAddInstanceWithAllValidData()
        {
            InstanceFacade facade = new InstanceFacade();

            facade.AddInstance(this.GetInstance());

            Assert.IsTrue(true);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyAddFormNameErrorMessages()
        {
            InstanceFacade facade = new InstanceFacade();
            var path = PathGenerator.AbsoluteRelativeCombine(Paths.DataBindLocation + "InstaceFormName.xlsx");

            foreach (var sheet in Workbook.Worksheets(path))
            {
                foreach (var row in sheet.Rows)
                {
                    Instance instance = new Instance(row.Cells);

                    facade.AddInstance(instance);

                    facade.AssertNameErrorMessage(instance);
                }
            }
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyAddFormDescriptionErrorMessages()
        {
            InstanceFacade facade = new InstanceFacade();
            var path = PathGenerator.AbsoluteRelativeCombine(Paths.DataBindLocation + "CategoryFormOrder.xlsx");

            foreach (var sheet in Workbook.Worksheets(path))
            {
                foreach (var row in sheet.Rows)
                {
                    Instance category = new Instance(row.Cells);

                    facade.AddInstance(category);

                    facade.AssertOrderErrorMessage(category);
                }
            }
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyEditFormCreateCategory()
        {
            InstanceFacade facade = new InstanceFacade();
            Instance instance = this.GetInstance();
            Instance editInstance = this.GetEditInstance();

            facade.AddInstance(instance);
            facade.EditCategory(instance, editInstance);

            facade.AssertCategoryExist(editInstance);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyEditFormNameErrorMessagesDataBind()
        {
            InstanceFacade facade = new InstanceFacade();
            Instance instance = this.GetInstance();
            var path = PathGenerator.AbsoluteRelativeCombine(Paths.DataBindLocation + "CategoryFormName.xlsx");

            facade.AddInstance(instance);
            foreach (var sheet in Workbook.Worksheets(path))
            {
                foreach (var row in sheet.Rows)
                {
                    Instance editInstance = new Instance(row.Cells);

                    facade.EditCategory(instance, editInstance);

                    facade.AssertNameErrorMessage(editInstance);
                }
            }
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyEditFormOrderErrorMessagesDataBind()
        {
            InstanceFacade facade = new InstanceFacade();
            Instance instance = this.GetInstance();
            var path = PathGenerator.AbsoluteRelativeCombine(Paths.DataBindLocation + "CategoryFormName.xlsx");

            facade.AddInstance(instance);
            foreach (var sheet in Workbook.Worksheets(path))
            {
                foreach (var row in sheet.Rows)
                {
                    Instance editInstance = new Instance(row.Cells);

                    facade.EditCategory(instance, editInstance);

                    facade.AssertOrderErrorMessage(editInstance);
                }
            }
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyDownloadExcelFile()
        {
            string fileName = "CategoryExportGrid.xlsx";

            InstancePage.Instance.ExportFile(fileName);

            InstancePage.Instance.AssertFileExist(fileName);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyDownloadPdfFile()
        {
            string fileName = "CategoryExportGrid.pdf";

            InstancePage.Instance.ExportFile(fileName);

            InstancePage.Instance.AssertFileExist(fileName);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyGridSort()
        {
            InstanceFacade facade = new InstanceFacade();

            facade.SortGrid();
        }

        private Instance GetInstance()
        {
            return new Instance(
                "Instace",
                "Description ",
                "Структури от данни и алгоритми",
                "MIT",
                "Програмиране",
                "999");
        }

        private Instance GetEditInstance()
        {
            return new Instance(
                "Instace",
                "Description ",
                "Структури от данни и алгоритми",
                "MIT",
                "Програмиране",
                "999");
        }
    }
}
