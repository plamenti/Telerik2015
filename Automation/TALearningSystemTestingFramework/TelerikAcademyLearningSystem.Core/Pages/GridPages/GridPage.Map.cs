namespace TelerikAcademyLearningSystem.Core.Pages.GridPages
{
    using System.Collections.Generic;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class GridPage
    {
        public HtmlDiv Grid
        {
            get
            {
                return Find.ByExpression<HtmlDiv>("class=kendo-style-default");
            }
        }

        public HtmlDiv FilterHeader
        {
            get
            {
                return Find.ByExpression<HtmlDiv>("class=k-grouping-header");
            }
        }

        public HtmlTable GridTable
        {
            get
            {
                this.Browser.RefreshDomTree();
                this.Browser.WaitForElement(new HtmlFindExpression("role=~grid", "tagname=table"), 30000, false);
                return Find.ByExpression<HtmlTable>("role=~grid", "tagname=table");
            }
        }

        public HtmlDiv Footer
        {
            get
            {
                return Find.ByExpression<HtmlDiv>("class=k-pager-wrap k-grid-pager k-widget k-floatwrap");
            }
        }

        public HtmlAnchor Id
        {
            get
            {
                return Find.ByContent<HtmlAnchor>("№");
            }
        }

        /// <summary>
        /// Work only when u look in needed table row
        /// </summary>
        public IList<HtmlAnchor> EditButton
        {
            get
            {
                return Find.AllByExpression<HtmlAnchor>("class=~k-grid-edit");
            }
        }
        
        public IList<HtmlAnchor> DeleteButton
        {
            get
            {
                return Find.AllByExpression<HtmlAnchor>("class=~k-grid-delete");
            }
        }

        public IList<HtmlTableCell> HiearachyButton
        {
            get
            {
                return Find.AllByExpression<HtmlTableCell>("class=k-hierarchy-cell");
            }
        }

        ////public HtmlAnchor Add
        ////{
        ////    get
        ////    {
        ////        return Find.ByExpression<HtmlAnchor>("class=?k-grid-add");
        ////    }
        ////}
    }
}
