namespace TelerikAcademyLearningSystem.Core.Pages.GroupsPage
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using Base;
    using TelerikAcademyLearningSystem.Core.Constants;
    using TelerikAcademyLearningSystem.Core.Model;

    public partial class GroupsPage : BasePage<GroupsPage>
    {
        private bool isSortedProperly;

        public GroupsPage()
        {
            this.IsSortedProperly = true;
        }

        public bool IsSortedProperly
        {
            get
            {
                return this.isSortedProperly;
            }

            set
            {
                this.isSortedProperly = value;
            }
        }

        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.GroupsPage);
        }

        public void CreateNewGroup(Group group)
        {
            this.CreateGroupButton.Click();

            this.Name.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(group.GroupName);

            this.CourseName.MouseClick();
            var course = this.Course(group.CourseName);
            course.MouseClick();

            this.WeekDayLabel.MouseClick();
            var weekDay = this.WeekDay(group.WeekDay);
            weekDay.MouseClick();

            this.StartTime.MouseClick();
            var startTime = this.Time(group.StartTime);
            startTime.MouseClick();

            this.EnrollmentStartTime.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(group.EnrollmentStartTime);

            this.TrainingRoomName.MouseClick();
            var trainingRoom = this.TrainingRoom(group.TrainingRoom);
            trainingRoom.MouseClick();

            this.WeekLectureNumber.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(group.WeekLectureNumber);

            this.PeopleLimit.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(group.PeopleLimit);

            this.UpdateButton.Click();
        }

        public bool ContainsGroup(Group group)
        {
            int indexOfGroupInTable = this.FindGroupInTable(group);
            if (indexOfGroupInTable > -1)
            {
                return true;
            }

            return false;
        }

        public void DeleteGroup(Group group)
        {
            this.Browser.Manager.DialogMonitor.AddDialog(new ConfirmDialog(this.Browser.Manager.ActiveBrowser, DialogButton.OK));
            this.Browser.Manager.DialogMonitor.Start();
            int indexOfGroupInTable = this.FindGroupInTable(group);
            this.DeleteRowButton(indexOfGroupInTable).Click();
        }

        public void FilterCourses(string courseName)
        {
            this.CourseFilter.ScrollToVisible();
            this.CourseFilter.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(courseName);
            this.Refresh.MouseClick();
        }

        public bool AreCoursesDifferent()
        {
            var bodyRowsCount = this.Table.BodyRows.Count;
            for (int i = 1; i < bodyRowsCount; i++)
            {
                var firstCell = this.Table.BodyRows[i - 1].Cells[2].TextContent;
                var secondCell = this.Table.BodyRows[i].Cells[2].TextContent;
                if (firstCell != secondCell)
                {
                    return true;
                }
            }

            return false;
        }

        public void SortGroups(string sortBy)
        {
            this.ColumnTitle(sortBy).ScrollToVisible();
            this.ColumnTitle(sortBy).MouseClick();
            this.Browser.WaitForAjax(3000);
            this.Browser.RefreshDomTree();
        }

        public string[] ExtractColumnValues(int columnIndex)
        {
            List<string> cells = new List<string>();

            var bodyRowsCount = this.Table.BodyRows.Count;
            for (int i = 0; i < bodyRowsCount; i++)
            {
                cells.Add(this.Table.BodyRows[i].Cells[columnIndex].InnerText);
            }

            return cells.ToArray();
        }

        public string[] SortColumn(IComparer comparer, int columnIndex)
        {
            string[] cells = this.ExtractColumnValues(columnIndex);
            Array.Sort(cells, comparer);

            return cells;
        }

        public bool AreColumnsEqual(string[] actual, string[] expected)
        {
            if (actual.Length != expected.Length)
            {
                return false;
            }

            for (int i = 0; i < actual.Length; i++)
            {
                if (actual[i] != expected[i])
                {
                    return false;
                }
            }

            return true;
        }

        private int FindGroupInTable(Group group)
        {
            int groupIndex = -1;
            this.Table.ScrollToVisible();
            var bodyRowsCount = this.Table.BodyRows.Count;

            for (int i = 0; i < bodyRowsCount; i++)
            {
                if (this.Table.BodyRows[i].InnerText.Contains(group.GroupName) &&
                    this.Table.BodyRows[i].InnerText.Contains(group.CourseName) &&
                    this.Table.BodyRows[i].InnerText.Contains(group.WeekDay) &&
                    this.Table.BodyRows[i].InnerText.Contains(group.TrainingRoom))
                {
                    groupIndex = i;
                    break;
                }
            }

            return groupIndex;
        }
    }
}