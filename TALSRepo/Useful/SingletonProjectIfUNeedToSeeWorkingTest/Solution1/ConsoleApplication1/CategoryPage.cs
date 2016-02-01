namespace TelerikAcademyLearningSystem.Core.Pages.CategoryPages
{
    using System;
    using System.IO;
    using System.Threading;
    using ArtOfTest.Common;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using Base;

    public partial class CategoryPage : BasePage<CategoryPage>
    {
        private string url = @"http://stage.telerikacademy.com/Administration_Courses/CourseInstanceCategories";

        public override void Navigate()
        {
            this.Browser.NavigateTo(this.url);
        }

        internal void GoBackToAdmin()
        {
            this.BackToAdmin.ScrollToVisible();
            this.BackToAdmin.MouseClick();
        }

        ////TODO: merge this two methods
        //internal void ExportToExcelDownloadsExcelFile(string fileName)
        //{
        //    this.Navigate();
        //    string saveLocation = PathGenerator.AbsoluteRelativeCombine(Paths.ExportLocation + fileName);
        //    if (File.Exists(saveLocation))
        //    {
        //        File.Delete(saveLocation);
        //    }

        //    Thread.Sleep(5000);
        //    DownloadDialogsHandler dialog = new DownloadDialogsHandler(this.Browser, DialogButton.SAVE, saveLocation, this.Browser.Desktop);
        //    this.Browser.Manager.DialogMonitor.Start();
        //    this.ExportExcel.ScrollToVisible();
        //    this.ExportExcel.Click();
        //    Thread.Sleep(20000);
        //    dialog.WaitUntilHandled(20000);
        //}

        //internal void ExportToPdfDownloadsExcelFile(string fileName)
        //{
        //    this.Navigate();
        //    string saveLocation = PathGenerator.AbsoluteRelativeCombine(Paths.ExportLocation + fileName);
        //    if (File.Exists(saveLocation))
        //    {
        //        File.Delete(saveLocation);
        //    }

        //    DownloadDialogsHandler dialog = new DownloadDialogsHandler(this.Browser, DialogButton.SAVE, saveLocation, this.Browser.Desktop);
        //    this.Browser.Manager.DialogMonitor.Start();
        //    this.ExportPdf.ScrollToVisible();
        //    this.ExportPdf.Click();
        //    Thread.Sleep(20000);
        //    dialog.WaitUntilHandled(20000);
        //}

        //internal void OpenNestedCategories(Categories category)
        //{
        //    this.Browser.RefreshDomTree();
        //    var rowIndex = this.GridPage.FindRow("Категория", category.Name);
        //    var buttonToClick = this.GridPage.HiearachyButton[rowIndex - 1];
        //    buttonToClick.ScrollToVisible();
        //    buttonToClick.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
        //}

        internal void OpenAddForm()
        {
            this.Navigate();
            this.Browser.WaitUntilReady();
            this.Add.ScrollToVisible();
            this.Add.Click(false);
        }

        internal void OpenNestedAddForm()
        {
            this.Browser.RefreshDomTree();
            var adds = this.NestedAdd;
            adds[1].Click(false);
        }

        //internal void OpenEditForm(Categories category)
        //{
        //    var rowForDeleteClick = this.GridPage.FindRow("Категория", category.Name);
        //    var buttonToClick = this.GridPage.EditButton[rowForDeleteClick - 1];
        //    buttonToClick.ScrollToVisible();
        //    buttonToClick.Wait.ForVisible(2000);
        //    buttonToClick.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
        //}

        //internal void DeleteCategory(Categories category)
        //{
        //    this.Browser.Manager.DialogMonitor.AddDialog(new ConfirmDialog(this.Browser, DialogButton.OK));
        //    this.Browser.Manager.DialogMonitor.Start();
        //    var rowForDeleteClick = this.GridPage.FindRow("Категория", category.Name);
        //    var buttonToClick = this.GridPage.DeleteButton[rowForDeleteClick - 1];
        //    buttonToClick.ScrollToVisible();
        //    buttonToClick.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
        //}

        //internal bool CheckCategoryExist(Categories category)
        //{
        //    if (this.GridPage.FindRow("Категория", category.Name) != int.MaxValue)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }
}
