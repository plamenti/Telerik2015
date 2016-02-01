namespace TelerikAcademyLearningSystem.Core.Pages.StudentsInCoursesPage.StudentsInCoursesFormPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    internal partial class StudentsInCoursesFormPage
    {
        internal HtmlSpan Title
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("tagname=span", "class=k-window-title");
            }
        }

        internal HtmlInputText UserName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("Username");
            }
        }

        internal HtmlSpan CourseSelector
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("xpat=//*[@id='UserInCourseId']/following-sibling::div[4]/span[1]/span/span[1]", "class=k-input");
            }
        }

        internal HtmlSelect CourseInstance
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSelect>("CourseInstanceId");
            }
        }

        internal HtmlInputText CoursePoints
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("Result");
            }
        }

        internal HtmlControl CourseResult
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlControl>("//*[@id='UserInCourseId']/div[4]/span[1]/span/span[1]");
            }
        }

        internal HtmlInputCheckBox LiveParticipant
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputCheckBox>("IsLiveParticipant");
            }
        }

        internal HtmlInputCheckBox PracticalExam
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputCheckBox>("CanDoPracticalExam");
            }
        }

        internal HtmlInputCheckBox TestExam
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputCheckBox>("CanDoTestExam");
            }
        }

        internal HtmlControl AccommodationSelector
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlControl>("//*[@id='UserInCourseId']/following-sibling::div[13]/span[1]/span/span[1]");
            }
        }

        internal HtmlDiv UserNameValidationMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("Username_validationMessage");
            }
        }

        internal HtmlDiv CourseInstanceValidationMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("CourseInstanceId_validationMessage");
            }
        }

        internal HtmlDiv UrlValidationMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("CourseInstanceId_validationMessage");
            }
        }

        internal HtmlAnchor UpdateButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        internal HtmlAnchor CancelButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-k-button k-button-icontext k-grid-cancel");
            }
        }

        internal HtmlSpan AllCourses
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("tagname=span", "class=k-input", "innerText=Всички курсове");
            }
        }

        internal HtmlDiv AllCoursesListDivContainer
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=CourseInstanceId-list"), 3000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("CourseInstanceId-list");
            }
        }

        internal HtmlUnorderedList AllCoursesListBoxUl
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=CourseInstanceId_listbox"), 3000, false);
                return this.AllCoursesListDivContainer.Find.ById<HtmlUnorderedList>("CourseInstanceId_listbox");
            }
        }

        internal HtmlSpan Accommodation
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("tagname=span", "class=k-input", "innerText=Не е задено");
            }
        }

        internal HtmlDiv AccommodationListDivContainer
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=Accommodation-list"), 3000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("Accommodation-list");
            }
        }

        internal HtmlUnorderedList AccommodationListBoxUl
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=Accommodation_listbox"), 3000, false);
                return this.AccommodationListDivContainer.Find.ById<HtmlUnorderedList>("Accommodation_listbox");
            }
        }

        internal HtmlListItem Course(string courseName)
        {
            return this.AllCoursesListBoxUl.Find.ByExpression<HtmlListItem>("innerText=" + courseName);
        }

        internal HtmlListItem AccommodationOption(string option)
        {
            return this.AccommodationListBoxUl.Find.ByExpression<HtmlListItem>("innerText=" + option);
        }
    }
}