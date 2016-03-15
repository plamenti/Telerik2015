namespace TelerikAcademyLearningSystem.Core.Pages.InstancePages.AddEditFormPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class InstanceFormPage
    {
        public HtmlDiv Form
        {
            get
            {
                return Find.ByExpression<HtmlDiv>("class=k-widget k-window");
            }
        }

        public HtmlSpan Title
        {
            get
            {
                return Find.ByExpression<HtmlSpan>("class=k-window-title");
            }
        }

        public HtmlContainerControl CourseLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Курс", "tagname=label");
            }
        }

        public HtmlContainerControl NameLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Име", "tagname=label");
            }
        }

        public HtmlContainerControl DescLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Описание", "tagname=label");
            }
        }

        public HtmlContainerControl LicenceLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Лиценз за курса", "tagname=label");
            }
        }

        public HtmlContainerControl CategoryLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Категория", "tagname=label");
            }
        }

        public HtmlContainerControl CopyLecturesDropDownLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Копиране на лекции", "tagname=label");
            }
        }

        public HtmlContainerControl CopyMaterialsLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Копиране на материали към лекции", "tagname=label");
            }
        }

        public HtmlContainerControl SharedCourseLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Споделен курс", "tagname=label");
            }
        }

        public HtmlContainerControl StartLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Начало", "tagname=label");
            }
        }

        public HtmlContainerControl EndLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Край", "tagname=label");
            }
        }

        public HtmlContainerControl ActivityLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Активен", "tagname=label");
            }
        }

        public HtmlContainerControl VisibilityLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Публичен", "tagname=label");
            }
        }

        public HtmlContainerControl LecturesCountLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Брой лекции", "tagname=label");
            }
        }

        public HtmlContainerControl FinalTimeForSignLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Срок за записване", "tagname=label");
            }
        }

        public HtmlContainerControl ClassLimilLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Лимит присъствено", "tagname=label");
            }
        }

        public HtmlContainerControl OnlineLimitLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Лимит онлайн", "tagname=label");
            }
        }

        public HtmlContainerControl KidsPlusLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Сборен курс (за Кидс Академия)", "tagname=label");
            }
        }

        public HtmlContainerControl KidsSeasonLabel
        {
            get
            {
                return Find.ByExpression<HtmlContainerControl>("TextContent=Сезон на Кидс Академя", "tagname=label");
            }
        }

        public HtmlInputText CourseInput
        {
            get
            {
                var element = Find.ByExpression<HtmlInputText>("name=CourseId_input");
                return element;
            }
        }

        public HtmlSpan CourseDropdownButton
        {
            get
            {
                return Find.ByExpression<HtmlSpan>("aria-controls=\"CourseId_listbox\"");
            }
        }

        public HtmlUnorderedList CourseList
        {
            get
            {
                return Find.ById<HtmlUnorderedList>("CourseId_listbox");
            }
        }

        public HtmlInputText Name
        {
            get
            {
                return Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlContainerControl Description
        {
            get
            {
                Browser textFrame = this.Browser.Frames[0];
                HtmlContainerControl description = textFrame.Find.AllByTagName<HtmlContainerControl>("body").FirstOrDefault();
                return description;
            }
        }

        public HtmlUnorderedList LicenceList
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=CourseLicenseId_listbox"), 3000, false);
                return Find.ById<HtmlUnorderedList>("CourseLicenseId_listbox");
            }
        }

        public HtmlUnorderedList CategoriesList
        {
            get
            {
                ////*[@id="CourseInstanceCategory"]/ul
                return Find.ByXPath<HtmlUnorderedList>("//*[@id='CourseInstanceCategory']/ul");
            }
        }

        public HtmlUnorderedList CopyLecturesList
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=LecturesCopyCourseInstanceId_listbox"), 3000, false);
                return Find.ById<HtmlUnorderedList>("LecturesCopyCourseInstanceId_listbox");
            }
        }

        public HtmlInputCheckBox CopyLectureCheckBox
        {
            get
            {
                //*[@id="lectures-copy-container"]/div[4]/input[2]
                return Find.ByXPath<HtmlInputCheckBox>("//*[@id='lectures-copy-container']/div[4]/input[2]");
            }
        }

        public HtmlUnorderedList SharedCourseList
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=SharesResourcesWithCourseInstanceId_listbox"), 3000, false);
                return Find.ById<HtmlUnorderedList>("SharesResourcesWithCourseInstanceId_listbox");
            }
        }

        public HtmlInputText StartInput
        {
            get
            {
                return Find.ById<HtmlInputText>("StartDate");
            }
        }

        public HtmlInputText EndInput
        {
            get
            {
                return Find.ById<HtmlInputText>("EndDate");
            }
        }

        public HtmlInputCheckBox ActivityCheckBox
        {
            get
            {
                return Find.ByXPath<HtmlInputCheckBox>("//input[@id='IsActive']/following-sibling::input");
            }
        }

        public HtmlInputCheckBox VisibilityCheckBox
        {
            get
            {
                return Find.ByXPath<HtmlInputCheckBox>("//input[@id='IsPublic']/following-sibling::input");
            }
        }

        public HtmlInputText LecturesCountInput
        {
            get
            {
                return Find.ById<HtmlInputText>("LecturesPerWeek");
            }
        }

        public HtmlInputText TimeForSignInbox
        {
            get
            {
                return Find.ById<HtmlInputText>("LecturesPerWeek");
            }
        }

        public HtmlInputText ClassLimitInbox
        {
            get
            {
                return Find.ById<HtmlInputText>("LiveStudentsLimit");
            }
        }

        public HtmlInputText OnlineLimitInbox
        {
            get
            {
                return Find.ById<HtmlInputText>("OnlineStudentsLimit");
            }
        }

        public HtmlInputCheckBox KidsPlusCourseCheckBox
        {
            get
            {
                return Find.ByXPath<HtmlInputCheckBox>("//input[@id='FilterableLectureResources']/following-sibling::input");
            }
        }

        public HtmlUnorderedList KidsSeasonList
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=KidsSchoolSeasonId_listbox"), 3000, false);
                return Find.ById<HtmlUnorderedList>("KidsSchoolSeasonId_listbox");
            }
        }

        public HtmlAnchor Update
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=?k-grid-update");
            }
        }

        public HtmlAnchor Cancel
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=?k-grid-cancel");
            }
        }
        public HtmlDiv NameErrorMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("Name_validationMessage");
            }
        }

        public HtmlDiv OrderErrorMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("Order_validationMessage");
            }
        }

        public HtmlListItem CourseOption(int index)
        {
            ////*[@id="CourseId_listbox"]/li[4]
            var xpath = "//*[@id='CourseId_listbox']/li[" + (index + 1) + "]";
            this.Browser.WaitForElement(new HtmlFindExpression("XPath=" + xpath), 3000, false);
            return Find.ByXPath<HtmlListItem>(xpath);
        }

        public HtmlListItem LicenceOption(int index)
        {
            ////*[@id="CourseLicenseId_listbox"]/li[6]
            var xpath = "//*[@id='CourseLicenseId_listbox']/li[" + (index + 1) + "]";
            this.Browser.WaitForElement(new HtmlFindExpression("XPath=" + xpath), 3000, false);
            return Find.ByXPath<HtmlListItem>(xpath);
        }
        
        public HtmlSpan CategoriesOption(int index)
        {
            ////*[@id="CourseInstanceCategory"]/ul/li[3]/div/span
            var xpath = "//*[@id='CourseInstanceCategory']/ul/li[" + (index + 1) + "]/div/span";
            this.Browser.WaitForElement(new HtmlFindExpression("XPath=" + xpath), 3000, false);
            return Find.ByXPath<HtmlSpan>(xpath);
        }

        public HtmlListItem CopyLecturesOption(int index)
        {
            ////*[@id="LecturesCopyCourseInstanceId_listbox"]/li[5]
            var xpath = "//*[@id='LecturesCopyCourseInstanceId_listbox']/li[" + (index + 1) + "]";
            this.Browser.WaitForElement(new HtmlFindExpression("XPath=" + xpath), 3000, false);
            return Find.ByXPath<HtmlListItem>(xpath);
        }

        public HtmlListItem SharedCourseOption(int index)
        {
            ////*[@id="SharesResourcesWithCourseInstanceId_listbox"]/li[6]
            var xpath = "//*[@id='SharesResourcesWithCourseInstanceId_listbox']/li[" + (index + 1) + "]";
            this.Browser.WaitForElement(new HtmlFindExpression("XPath=" + xpath), 3000, false);
            return Find.ByXPath<HtmlListItem>(xpath);
        }

        public HtmlListItem KidsSeasonOption(int index)
        {
            ////*[@id="KidsSchoolSeasonId_listbox"]/li[3]
            var xpath = "//*[@id='KidsSchoolSeasonId_listbox']/li[" + (index + 1) + "]";
            this.Browser.WaitForElement(new HtmlFindExpression("XPath=" + xpath), 3000, false);
            return Find.ByXPath<HtmlListItem>(xpath);
        }
    }
}
