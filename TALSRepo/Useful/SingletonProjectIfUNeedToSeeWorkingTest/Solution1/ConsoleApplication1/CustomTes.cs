namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Categories
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.Base;
    using ConsoleApplication1;

    [TestClass]
    public class CategoryTest : BaseTest
    {
        [TestMethod]
        public void VerifyAddEditFormCreateCategory()
        {
            Facade facade = new Facade();
            facade.OpenForm();
            ////Categories category = new Categories("Category", "20", CategoriesAsserterType.Exist);

            //facade.AddCategory(category);

            //facade.VerifyAddEditSucsessOrErrorMessageDisplayed(category);
        }
    }
}