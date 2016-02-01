namespace TelerikAcademyLearningSystem.Core.Pages.GroupsPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class GroupsPage
    {
        public string Title
        {
            get
            {
                return this.Browser.PageTitle;
            }
        }

        public HtmlAnchor CreateGroupButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add", "href=~CoursesGroups");
            }
        }

        public HtmlAnchor BackToAdminButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=~Administration");
            }
        }

        public HtmlInputText Name
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=Name"), 3000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlSpan CourseName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("tagname=span", "class=k-input", "innerText=~Изберете курс");
            }
        }

        public HtmlDiv CourseInstanceIdListDivContainer
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=CourseInstanceId-list"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("CourseInstanceId-list");
            }
        }

        public HtmlUnorderedList CourseInstanceIdListboxUl
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=CourseInstanceId_listbox"), 30000, false);
                return this.CourseInstanceIdListDivContainer.Find.ById<HtmlUnorderedList>("CourseInstanceId_listbox");
            }
        }

        public HtmlControl WeekDayLabel
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlControl>("TextContent=Ден от седмицата", "tagname=label");
            }
        }

        public HtmlDiv WeekDayIdListDivContainer
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=WeekDayId-list"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("WeekDayId-list");
            }
        }

        public HtmlUnorderedList WeekDayIdListboxUl
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=WeekDayId_listbox"), 30000, false);
                return this.WeekDayIdListDivContainer.Find.ById<HtmlUnorderedList>("WeekDayId_listbox");
            }
        }

        public HtmlInputText StartTime
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("StartTime");
            }
        }

        public HtmlUnorderedList StartTimeIdListboxUl
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=StartTime_timeview"), 3000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlUnorderedList>("StartTime_timeview");
            }
        }

        public HtmlInputText EnrollmentStartTime
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("EnrollmentStartTime");
            }
        }

        public HtmlSpan TrainingRoomName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("tagname=span", "class=k-input", "innerText=Изберете зала");
            }
        }

        public HtmlUnorderedList TrainingRoomIdListboxUl
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=TrainingRoomId_listbox"), 3000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlUnorderedList>("TrainingRoomId_listbox");
            }
        }

        public HtmlInputNumber WeekLectureNumber
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputNumber>("WeekLectureNumber");
            }
        }

        public HtmlInputNumber PeopleLimit
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputNumber>("PeopleLimit");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        public HtmlAnchor CancelButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-cancel");
            }
        }

        public HtmlDiv Grid
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=DataGrid"), 3000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("DataGrid");
            }
        }

        public HtmlTable Table
        {
            get
            {
                return this.Grid.Find.ByExpression<HtmlTable>("tagname=table", "role=treegrid");
            }
        }

        public HtmlInputText CourseFilter
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByName<HtmlInputText>("CourseFilter_input");
            }
        }

        public HtmlSpan Refresh
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("class=k-icon k-i-refresh");
            }
        }

        public HtmlListItem Course(string courseName)
        {
            return this.CourseInstanceIdListboxUl.Find.ByExpression<HtmlListItem>("innerText=" + courseName);
        }

        public HtmlListItem WeekDay(string weekDay)
        {
            return this.WeekDayIdListboxUl.Find.ByExpression<HtmlListItem>("innerText=" + weekDay);
        }

        public HtmlListItem Time(string time)
        {
            return this.StartTimeIdListboxUl.Find.ByExpression<HtmlListItem>("innerText=" + time);
        }

        public HtmlListItem TrainingRoom(string roomName)
        {
            return this.TrainingRoomIdListboxUl.Find.ByExpression<HtmlListItem>("innerText=" + roomName);
        }

        public HtmlSpan DeleteRowButton(int rowIndex)
        {
            return this.Table.BodyRows[rowIndex].Find.ByExpression<HtmlSpan>("class=k-icon k-delete");
        }

        public HtmlAnchor ColumnTitle(string columnTitle)
        {
            return this.Table.Find.ByExpression<HtmlAnchor>("textContent=" + columnTitle);
        }
    }
}