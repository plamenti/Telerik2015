namespace TelerikAcademyLearningSystem.Core.Pages.InstancePages
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using AddEditFormPage;
    using Model;
    using Constants;

    public static class AddEditInstancePageAsserter
    {
        //TODO
        public static void AssertNameErrorMessage(this InstanceFormPage page, Instance instance)
        {
            Assert.IsTrue(page.NameErrorMessage.IsEnabled);

            if (instance.Name.Length >= 50)
            {
                Assert.AreEqual(page.NameErrorMessage.InnerText, CategoryForm.LongNameErrorMessage, string.Format("Invalid error message for long string in name"));
            }
            else if (instance.Name.Length == 0)
            {
                Assert.AreEqual(page.NameErrorMessage.InnerText, CategoryForm.EmptyNameErrorMessage, string.Format("Invalid error message for empty string in name"));
            }
            else
            {
                Assert.AreEqual(page.NameErrorMessage.InnerText, CategoryForm.NameWithoutWords, string.Format("Invalid error message for no words string in name"));
            }
        }

        public static void AssertOrderErrorMessage(this InstanceFormPage page, Categories category)
        {
            Assert.IsTrue(page.OrderErrorMessage.IsEnabled);

            if (category.Order.Length > 10)
            {
                Assert.AreEqual(page.OrderErrorMessage.InnerText, CategoryForm.BigNumberErrorMessage, string.Format("Invalid error message for long string in name"));
            }
            else if (category.Order.Contains("."))
            {
                Assert.AreEqual(page.OrderErrorMessage.InnerText, CategoryForm.FloatNumberErrorMessage, string.Format("Invalid error message for no words string in name"));
            }
            else
            {
                Assert.AreEqual(page.OrderErrorMessage.InnerText, CategoryForm.EmptyOrderErrorMessage, string.Format("Invalid error message for empty string in name"));
            }
        }
    }
}
