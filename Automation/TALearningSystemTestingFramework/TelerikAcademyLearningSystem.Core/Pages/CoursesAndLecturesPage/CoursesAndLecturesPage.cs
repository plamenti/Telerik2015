namespace TelerikAcademyLearningSystem.Core.Pages.CoursesAndLecturesPage
{
    using System.Threading;
    using ArtOfTest.Common;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using Base;
    using Constants;
    using Model;

    public partial class CoursesAndLecturesPage : BasePage<CoursesAndLecturesPage>
    {
        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.CoursesAndLectures);
            this.Browser.RefreshDomTree();
        }

        public void OpenCourseForm()
        {
            this.CreateCourseButton.Click();
            this.PopUp.Wait.ForExists(1000);
            this.Browser.RefreshDomTree();
        }

        public void OpenEditForm(Course course)
        {
            Thread.Sleep(2000);
            Manager.Current.ActiveBrowser.RefreshDomTree();
            int index = this.GridPage.FindRow("Име (BG)", course.NameBg);
            var newRow = this.GridPage.GridTable.Rows[index];
            var editButton = this.GridPage.GridTable.Rows[index - 1].Cells[9];
            editButton.ScrollToVisible();
            Thread.Sleep(1000);
            editButton.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
            this.Browser.RefreshDomTree();
        }

        public void DeleteCourseIfExisting(Course newCourse)
        {
            Thread.Sleep(2000);
            if (this.GridPage.FindRow("Име (BG)", newCourse.NameBg) != int.MaxValue)
            {
                this.DeleteCourse(newCourse, "Име (BG)", newCourse.NameBg);
                Thread.Sleep(2000);
                Manager.Current.ActiveBrowser.Refresh();
            }

            if (this.GridPage.FindRow("Име (EN)", newCourse.NameEn) != int.MaxValue)
            {
                this.DeleteCourse(newCourse, "Име (EN)", newCourse.NameEn);
                Thread.Sleep(2000);
                this.Browser.Refresh();
            }

            if (this.GridPage.FindRow("Url име", newCourse.UrlName) != int.MaxValue)
            {
                this.DeleteCourse(newCourse, "Url име", newCourse.UrlName);
                Thread.Sleep(2000);
                this.Browser.Refresh();
            }
        }

        public void DeleteCourse(Course course, string colName, string colValue)
        {
            this.Browser.Manager.DialogMonitor.AddDialog(new ConfirmDialog(this.Browser, DialogButton.OK));
            this.Browser.Manager.DialogMonitor.Start();
            var rowForDeleteIndex = this.GridPage.FindRow(colName, colValue);
            var buttonToClick = this.GridPage.DeleteButton[rowForDeleteIndex - 1];
            buttonToClick.ScrollToVisible();
            buttonToClick.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
            this.Browser.RefreshDomTree();
        }

        public void GoBackToAdminPage()
        {
            this.Navigate();
            this.BackToAdminButton.Click();
        }
    }
}
