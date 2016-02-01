namespace TelerikAcademyLearningSystem.Core.Pages.LicensesPage
{
    using System.IO;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using Base;
    using Constants;
    using TelerikAcademyLearningSystem.Core.Model;
    using Utilities;

    public partial class LicensesPage : BasePage<LicensesPage>
    {
        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.Licenses);
        }

        public void ExportToExcelButtonDownloadsExcelFile(string fileName)
        {
            this.Navigate();
            string saveLocation = PathGenerator.GeneratePathToDownloadedFilesFolder() + fileName;

            if (File.Exists(saveLocation))
            {
                File.Delete(saveLocation);
            }

            this.ExportToExcellButton.Wait.ForVisible();
            this.ExportToExcellButton.Download(false, DownloadOption.Save, saveLocation, 50000);
        }

        public void ExportToPdfButtonDownloadsPdfFile(string fileName)
        {
            this.Navigate();
            string saveLocation = PathGenerator.GeneratePathToDownloadedFilesFolder() + fileName;

            if (File.Exists(saveLocation))
            {
                File.Delete(saveLocation);
            }

            this.ExportToPdfButton.Wait.ForVisible();
            this.ExportToPdfButton.Download(false, DownloadOption.Save, saveLocation, 40000);
        }

        public bool ContainsLicense(License license)
        {
            int indexOfLicenseInTable = this.FindLicenseIndexInTable(license);
            if (indexOfLicenseInTable > -1)
            {
                return true;
            }

            return false;
        }

        public void OpenAddLicenseForm()
        {
            this.Navigate();
            this.AddLicenseButton.Wait.ForExists(1000);
            this.AddLicenseButton.ScrollToVisible();
            this.AddLicenseButton.MouseClick();
            this.PopUp.Wait.ForExists(1000);
            this.Browser.RefreshDomTree();
        }

        public void DeleteLicense(License license)
        {
            this.Browser.Manager.DialogMonitor.AddDialog(new ConfirmDialog(this.Browser.Manager.ActiveBrowser, DialogButton.OK));
            this.Browser.Manager.DialogMonitor.Start();
            int indexOfHomeworkInTable = this.FindLicenseIndexInTable(license);
            this.DeleteRowButton(indexOfHomeworkInTable).Click();
        }

        private int FindLicenseIndexInTable(License license)
        {
            this.Browser.RefreshDomTree();
            int licenseIndex = -1;

            this.GridPage.GridTable.ScrollToVisible();
            var bodyRowsCount = this.GridPage.GridTable.BodyRows.Count;

            for (int i = 0; i < bodyRowsCount; i++)
            {
                if (this.TableDataCell(i)[1].InnerText == license.Name &&
                    this.TableDataCell(i)[2].InnerText == license.Url &&
                    this.TableDataCell(i)[3].InnerText == license.Link)
                {
                    licenseIndex = i;
                    break;
                }
            }

            return licenseIndex;
        }
    }
}
