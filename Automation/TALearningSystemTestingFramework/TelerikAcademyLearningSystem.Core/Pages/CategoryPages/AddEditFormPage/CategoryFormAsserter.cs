namespace TelerikAcademyLearningSystem.Core.Pages.CategoryPages.AddEditFormPage
{
    using ArtOfTest.Common.UnitTesting;
    using Constants;
    using Model;

    public static class CategoryFormAsserter
    {
        public static void AssertNameErrorMessage(this CategoryFormPage page, Categories category)
        {
            Assert.IsTrue(page.NameErrorMessage.IsEnabled);

            if (category.Name.Length >= 50)
            {
                Assert.AreEqual(page.NameErrorMessage.InnerText, CategoryForm.LongNameErrorMessage, string.Format("Invalid error message for long string in name"));
            }
            else if (category.Name.Length == 0)
            {
                Assert.AreEqual(page.NameErrorMessage.InnerText, CategoryForm.EmptyNameErrorMessage, string.Format("Invalid error message for empty string in name"));
            }
            else
            {
                Assert.AreEqual(page.NameErrorMessage.InnerText, CategoryForm.NameWithoutWords, string.Format("Invalid error message for no words string in name"));
            }
        }

        public static void AssertOrderErrorMessage(this CategoryFormPage page, Categories category)
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
            else if (category.Order == string.Empty)
            {
                Assert.AreEqual(page.OrderErrorMessage.InnerText, CategoryForm.EmptyOrderErrorMessage, string.Format("Invalid error message for empty string in name"));
            }
            else
            {
                Assert.IsFalse(page.Order.Text == null);
            }
        }
    }
}
