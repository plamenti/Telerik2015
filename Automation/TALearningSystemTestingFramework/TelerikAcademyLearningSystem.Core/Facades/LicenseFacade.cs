namespace TelerikAcademyLearningSystem.Core.Facades
{
    using TelerikAcademyLearningSystem.Core.Constants;
    using TelerikAcademyLearningSystem.Core.Model;
    using TelerikAcademyLearningSystem.Core.Pages.LicensesPage;
    using TelerikAcademyLearningSystem.Core.Pages.LicensesPage.AddLicensePage;

    public class LicenseFacade
    {
        public void OpenHomeworkPage()
        {
            LicensesPage.Instance.Navigate();
        }

        public void ExportFile(string fileName)
        {
            if (fileName.Contains(".xls"))
            {
                LicensesPage.Instance.ExportToExcelButtonDownloadsExcelFile(fileName);
            }
            else
            {
                LicensesPage.Instance.ExportToPdfButtonDownloadsPdfFile(fileName);
            }
        }

        public void CreateLicense(License license)
        {
            LicensesPage.Instance.Navigate();
            if (LicensesPage.Instance.ContainsLicense(license))
            {
                LicensesPage.Instance.DeleteLicense(license);
            }

            AddLicensePage.Instance.Navigate();
            AddLicensePage.Instance.FillForm(license);
        }

        public void CreateLicenseWithNoData()
        {
            AddLicensePage.Instance.Navigate();
            AddLicensePage.Instance.FillFormWithNoData();
        }

        public void ValidateAllErrorMessages()
        {
            AddLicensePage.Instance.LicenseNameValidationMessageIsVisible(AddLicenseConstants.LicenceNameErrorMessageBlank);
            AddLicensePage.Instance.LicenseUrlValidationMessageIsVisible(AddLicenseConstants.LicenceUrlErrorMessageBlank);
            AddLicensePage.Instance.LicenseLinkValidationMessageIsVisible(AddLicenseConstants.LicenceLinkErrorMessageBlank);
        }

        public void CancelCreateLicense(License license)
        {
            AddLicensePage.Instance.Navigate();
            AddLicensePage.Instance.CancelFillForm(license);
        }
    }
}
