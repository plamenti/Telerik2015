namespace TelerikAcademyLearningSystem.Core.Pages.InstancePages.AddEditFormPage
{
    using System;
    using System.Threading;
    using ArtOfTest.Common;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using Base;
    using Constants;
    using Model;

    public partial class InstanceFormPage : BasePage<InstanceFormPage>
    {
        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.Instances);
            InstancePage.Instance.Add.Click();
        }

        public void FillForm(Instance instance)
        {
            this.Browser.RefreshDomTree();
            this.Form.Wait.ForExists();

            this.NameLabel.Click();
            this.CleanInput(this.Name.Text);
            this.Browser.Desktop.KeyBoard.TypeText(instance.Name);

            this.CourseInput.MouseClick(MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);
            this.CleanInput(this.CourseInput.Text);
            this.Browser.Desktop.KeyBoard.TypeText(instance.Course);
            
            this.Description.MouseClick(MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);
            this.CleanInput(this.Description.InnerText);
            this.Browser.Desktop.KeyBoard.TypeText(instance.Description);

            this.DropDownSelectOption(this.LicenceLabel, this.LicenceList, instance.Licence);
            this.LicenceLabel.MouseClick(MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);
            int optionIndex = this.FindOption(this.LicenceList, instance.Licence);
            this.LicenceOption(optionIndex).MouseClick(MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);

            optionIndex = this.FindOption(this.CategoriesList, instance.Categiry);
            this.CategoriesOption(optionIndex).ScrollToVisible();
            this.CategoriesOption(optionIndex).MouseClick();

            this.DropDownSelectOption(this.CopyLecturesDropDownLabel, this.CopyLecturesList, instance.CopyLectures);
            Thread.Sleep(22222);
            this.CopyLecturesDropDownLabel.MouseClick();
            optionIndex = this.FindOption(this.CopyLecturesList, instance.CopyLectures);
            this.CopyLecturesOption(optionIndex).MouseClick();
        }

        public void UpdateForm()
        {
            this.Browser.WaitUntilReady();
            this.Browser.RefreshDomTree();
            this.Update.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
        }

        private int FindOption(HtmlUnorderedList list, string searchedItem)
        {
            for (int i = 0; i < list.ChildNodes.Count; i++)
            {
                if (list.ChildNodes[i].InnerText == searchedItem)
                {
                    return i;
                }
            }

            throw new ArgumentException("There is no {0} in any list in form");
        }

        private void DropDownSelectOption(HtmlControl label, HtmlUnorderedList list, string value)
        {
            label.ScrollToVisible();
            label.MouseClick();
            int optionIndex = this.FindOption(list, value);
            this.LicenceOption(optionIndex).MouseClick(MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);
        }
    }
}