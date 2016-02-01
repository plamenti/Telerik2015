namespace ConsoleApplication1
{
    using System;
    using TelerikAcademyLearningSystem.Core.Pages.CategoryPages;

    public class Facade
    {
        public void OpenForm()
        {
            CategoryPage.Instance.Navigate();
            CategoryPage.Instance.AssertHeader();
            CategoryPage.Instance.AssertTitle();

            Console.WriteLine("Done!");
        }
    }
}
