namespace TelerikAcademyLearningSystem.Core.Pages.CategoryPages
{
    using System.Collections.Generic;
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class CategoryPage
    {
        public string Title
        {
            get
            {
                return this.Browser.PageTitle;
            }
        }

        public HtmlContainerControl Header
        {
            get
            {
                return Find.ByXPath<HtmlContainerControl>("//*[@id='MainContent']/div/h1");
            }
        }

        public HtmlAnchor Add
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=?k-grid-add");
            }
        }

        public IList<HtmlAnchor> NestedAdd
        {
            get
            {
                return Find.AllByExpression<HtmlAnchor>("class=?k-grid-add");
            }
        }

        public HtmlAnchor BackToAdmin
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("href=/Administration/Navigation");
            }
        }

        public HtmlButton ExportExcel
        {
            get
            {
                return Find.ByExpression<HtmlButton>("class=?k-grid-excel");
            }
        }

        public HtmlButton ExportPdf
        {
            get
            {
                return Find.ByExpression<HtmlButton>("class=?k-grid-pdf");
            }
        }

        //public GridPage GridPage
        //{
        //    get
        //    {
        //        return new GridPage();
        //    }
        //}
    }
}
