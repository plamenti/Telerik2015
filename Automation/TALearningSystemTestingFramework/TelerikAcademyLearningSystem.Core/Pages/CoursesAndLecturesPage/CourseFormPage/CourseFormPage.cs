namespace TelerikAcademyLearningSystem.Core.Pages.CoursesAndLecturesPage.CourseFormPage
{
    using System.Windows.Forms;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using Base;
    using Model;

    public partial class CourseFormPage : BasePage<CourseFormPage>
    {
        public override void Navigate()
        {
            CoursesAndLecturesPage.Instance.OpenCourseForm();
            this.Browser.RefreshDomTree();
        }

        public void ClearInput(string inputText, HtmlControl field)
        {
            field.MouseClick();

            for (int i = 0; i <= inputText.Length + 5; i++)
            {
                this.Browser.Desktop.KeyBoard.KeyPress(Keys.Back);
            }
        }

        public void EditInput(string inputText, HtmlControl field, string newText)
        {
            this.ClearInput(inputText, field);

            Manager.Current.ActiveBrowser.Desktop.KeyBoard.TypeText(newText);
        }

        internal void EditForm(Course course)
        {
            this.NameBg.ScrollToVisible();
            this.ClearInput(this.NameBg.Text, this.NameBg);
            this.Browser.Desktop.KeyBoard.TypeText(course.NameBg);
            //// this.NameEn.ScrollToVisible();
            this.NameEn.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(course.NameEn);
            ////this.UrlName.ScrollToVisible();
            this.UrlName.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(course.UrlName);
            this.Description.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(course.Description);
            ///this.Color.ScrollToVisible();
            this.Color.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(course.Color);
            ////this.Order.ScrollToVisible();
            this.Order.MouseClick(MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);
            this.CleanInput(this.Order.Text);
            this.Browser.Desktop.KeyBoard.TypeText(course.Order.ToString());
            this.Browser.Desktop.KeyBoard.KeyPress(Keys.Enter);
        }

        internal void FillForm(Course course)
        {
            this.NameBg.ScrollToVisible();
            this.NameBg.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(course.NameBg);
            //// this.NameEn.ScrollToVisible();
            this.NameEn.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(course.NameEn);
            ////this.UrlName.ScrollToVisible();
            this.UrlName.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(course.UrlName);
            this.Description.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(course.Description);
            ///this.Color.ScrollToVisible();
            this.Color.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(course.Color);
            ////this.Order.ScrollToVisible();
            this.Order.MouseClick(MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);
            this.CleanInput(this.Order.Text);
            this.Browser.Desktop.KeyBoard.TypeText(course.Order.ToString());
            this.Browser.Desktop.KeyBoard.KeyPress(Keys.Enter);
        }

        internal void UpdateForm()
        {
            this.UpdateButton.Click();
            CoursesAndLecturesPage.Instance.Browser.RefreshDomTree(); //// ?
        }

        internal void CancelForm()
        {
            this.CancelButton.Click();
            CoursesAndLecturesPage.Instance.Browser.RefreshDomTree();
        }
    }
}
