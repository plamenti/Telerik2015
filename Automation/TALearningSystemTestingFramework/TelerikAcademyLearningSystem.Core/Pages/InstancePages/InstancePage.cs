namespace TelerikAcademyLearningSystem.Core.Pages.InstancePages
{
    using ArtOfTest.Common;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using Base;
    using Constants;
    using Model;
    using System.IO;
    using System.Threading;
    using Utilities;

    public partial class InstancePage : BasePage<InstancePage>
    {
        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.Instances);
        }

        public void GoBackToAdmin()
        {
            this.BackToAdmin.ScrollToVisible();
            this.BackToAdmin.MouseClick();
        }

        public void OpenAddForm()
        {
            this.Browser.WaitUntilReady();
            this.Add.ScrollToVisible();
            this.Add.Click(false);
        }

        internal void OpenEditForm(Instance instance)
        {
            var rowForDeleteClick = this.GridPage.FindRow("Име", instance.Name);
            var buttonToClick = this.GridPage.EditButton[rowForDeleteClick - 1];
            buttonToClick.ScrollToVisible();
            buttonToClick.Wait.ForVisible(2000);
            buttonToClick.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
        }

        public void DeleteInstance(Instance instance)
        {
            this.Browser.Manager.DialogMonitor.AddDialog(new ConfirmDialog(this.Browser, DialogButton.OK));
            this.Browser.Manager.DialogMonitor.Start();
            ////Buro
            var rowForDeleteClick = this.GridPage.FindRow("Категория", instance.Name);
            var buttonToClick = this.GridPage.DeleteButton[rowForDeleteClick - 1];
            buttonToClick.ScrollToVisible();
            buttonToClick.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
        }

        public void ExportFile(string fileName)
        {
            this.Navigate();
            string saveLocation = PathGenerator.AbsoluteRelativeCombine(Paths.ExportLocation + fileName);
            if (File.Exists(saveLocation))
            {
                File.Delete(saveLocation);
            }

            Thread.Sleep(5000);
            DownloadDialogsHandler dialog = new DownloadDialogsHandler(this.Browser, DialogButton.SAVE, saveLocation, this.Browser.Desktop);
            this.Browser.Manager.DialogMonitor.Start();
            if (fileName.Contains("xlsx"))
            {
                this.ExportToExcelDownloadsExcelFile(fileName);
            }
            else
            {
                this.ExportToPdfDownloadsExcelFile(fileName);
            }

            Thread.Sleep(20000);
            dialog.WaitUntilHandled(20000);
        }

        public bool CheckInstanceExist(Instance instance)
        {
            ////Buro
            if (this.GridPage.FindRow("Категория", instance.Name) != int.MaxValue)
            {
                return true;
            }

            return false;
        }

        ////TODO: merge this two methods
        private void ExportToExcelDownloadsExcelFile(string fileName)
        {
            this.ExportExcel.ScrollToVisible();
            this.ExportExcel.Click();
        }

        private void ExportToPdfDownloadsExcelFile(string fileName)
        {
            this.ExportPdf.ScrollToVisible();
            this.ExportPdf.Click();
        }
    }
}