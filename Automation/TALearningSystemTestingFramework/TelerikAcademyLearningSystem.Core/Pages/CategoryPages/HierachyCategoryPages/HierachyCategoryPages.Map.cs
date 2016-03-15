namespace TelerikAcademyLearningSystem.Core.Pages.CategoryPages.HierachyCategoryPages
{
    using System;
    using System.Collections.Generic;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using Model;

    public partial class HierachyCategoryPages
    {
        public HtmlUnorderedList ListWithCategories
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlUnorderedList>("class=k-group k-treeview-lines");
            }
        }

        public HtmlUnorderedList NestedListWithCategories
        {
            get
            {
                var xpath = "//*[@id='treeview']/ul/li[" + (this.indexOfMainCategory + 1) + "]/ul";
                this.Browser.WaitForElement(new HtmlFindExpression("XPath=" + xpath), 10000, false);
                var element = Manager.Current.ActiveBrowser.Find.ByXPath<HtmlUnorderedList>(xpath);
                return element;
            }
        }

        public HtmlSpan Category
        {
            get
            {
                var xpath = "//div[@id=\"treeview\"]/ul/li[" + (this.indexOfMainCategory + 1) + "]/div/span[2]";
                this.Browser.WaitForElement(new HtmlFindExpression("XPath=" + xpath), 10000, false);
                var element = Manager.Current.ActiveBrowser.Find.ByXPath<HtmlSpan>(xpath);
                return element;
            }
        }
    }
}
