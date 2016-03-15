namespace TALS.TestingFramework.Core.Pages.LicensePage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALS.TestingFramework.Core.Base;

    public class LicensePageAsserter : IAsserter
    {
        private const string PageTitle = "Лицензи за курсове - Телерик Академия - Студентска система";
        private const string ExcellLicenseButtonNotVisibleMessage = @"Button ""Сваляне на Excel"" is not viisible";
        private const string PdfLicenseButtonNotVisibleMessage = @"Button ""Сваляне на PDF"" is not viisible";
        private const string AddLicenseNotVisibleMessage = @"Button ""Добавяне"" is not viisible";
        private const string BackToAdminNotVisibleMessage = @"Button ""Към администрацията"" is not viisible";

        private LicensePage licensePage;

        public LicensePageAsserter(LicensePage licensePage)
        {
            this.licensePage = licensePage;
        }

        public void DoAssert()
        {
            this.AssertTitle();
            this.ExportToExcellBtnIsVisible();
            this.ExportToPdfBtnIsVisible();
            this.AddLicenseBtnIsVisible();
            this.BackToAdminBtnIsVisible();
            this.AddNewLicenseIsSuccessful();
        }

        private void AssertTitle()
        {
            Assert.AreEqual(PageTitle, licensePage.Title, string.Format("The correct page title is: {0}", PageTitle));
        }

        private void ExportToExcellBtnIsVisible()
        {
            Assert.IsTrue(this.licensePage.ExportToExcellButton.IsVisible(), ExcellLicenseButtonNotVisibleMessage);
        }

        private void ExportToPdfBtnIsVisible()
        {
            Assert.IsTrue(this.licensePage.ExportToPdfButton.IsVisible(), PdfLicenseButtonNotVisibleMessage);
        }

        private void AddLicenseBtnIsVisible()
        {
            Assert.IsTrue(this.licensePage.AddLicenseButton.IsVisible(), AddLicenseNotVisibleMessage);
        }

        private void BackToAdminBtnIsVisible()
        {
            Assert.IsTrue(this.licensePage.BackToAdministrationButton.IsVisible(), BackToAdminNotVisibleMessage);
        }

        private void AddNewLicenseIsSuccessful()
        {
            this.licensePage.AddLicenseButton.Click();
            this.licensePage.PopUpTitle.Wait.ForExists(2000);
            this.licensePage.LicenseName.Text = "AutoLicenseName";
            this.licensePage.LicenseUrl.Text = "AutoLicenseUrl";
            this.licensePage.LicenseLink.Text = "www.autoLicense.com";
            this.licensePage.UpdateButton.Click();
            this.licensePage.LicenseGrid.Wait.ForExists(2000);
            
           // Assert.IsTrue(this.licensePage.GridCell)
        }
    }
}
