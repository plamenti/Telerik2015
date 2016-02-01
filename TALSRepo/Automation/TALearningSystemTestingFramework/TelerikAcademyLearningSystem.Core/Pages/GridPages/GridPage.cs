namespace TelerikAcademyLearningSystem.Core.Pages.GridPages
{
    using Base;

    public partial class GridPage : BasePage<GridPage>
    {
        public int FindRow(string columnName, string value)
        {
            var allRows = this.GridTable.AllRows;
            int searchedColumn = this.FindColumnIndex(columnName);
            for (int i = 0; i < allRows.Count; i++)
            {
                if (allRows[i].Cells[searchedColumn].InnerText == value)
                {
                    return i;
                }
            }

            return int.MaxValue;
        }

        public void SortGridByStringAndNumber()
        {
            var headers = this.GridTable.HeadRows[0].Cells;
            for (int i = 0; i < headers.Count; i++)
            {
                var b = i;
                var a = headers[i].InnerText;
                if (headers[i].InnerText == string.Empty || headers[i].InnerText == "Column SettingsЦвят")
                {
                    continue;
                }

                this.Footer.ScrollToVisible();
                headers[i].Click();
                var grid = this.GridTable.Rows;
                var element = this.GridTable.Rows[0].Cells[i].InnerText;
                int reminder;
                for (int j = 1; j < grid.Count; j++)
                {
                    var newElement = this.GridTable.Rows[j].Cells[i].InnerText;
                    if (int.TryParse(element, out reminder))
                    {
                        int intElement = int.Parse(element);
                        int intNewElement = int.Parse(newElement);
                        GridPageAsserter.AssertSortedAscending(intElement.CompareTo(intNewElement));
                    }
                    else
                    {
                        GridPageAsserter.AssertSortedAscending(element.CompareTo(newElement));
                    }

                    element = newElement;
                }

                headers[i].Click();
                grid = this.GridTable.Rows;
                element = this.GridTable.Rows[0].Cells[i].InnerText;
                for (int j = 1; j < grid.Count; j++)
                {
                    var newElement = this.GridTable.Rows[j].Cells[i].InnerText;
                    if (int.TryParse(element, out reminder))
                    {
                        int intElement = int.Parse(element);
                        int intNewElement = int.Parse(newElement);
                        GridPageAsserter.AssertSorteddescending(intElement.CompareTo(intNewElement));
                    }
                    else
                    {
                        GridPageAsserter.AssertSorteddescending(element.CompareTo(newElement));
                    }

                    element = newElement;
                }
            }
        }

        private int FindColumnIndex(string name)
        {
            var headerRow = this.GridTable.HeadRows[0];
            for (int i = 0; i < headerRow.Cells.Count; i++)
            {
                if (headerRow.Cells[i].InnerText.Contains(name))
                {
                    return i;
                }
            }

            throw new System.Exception("There is no column with this name");
        }
    }
}