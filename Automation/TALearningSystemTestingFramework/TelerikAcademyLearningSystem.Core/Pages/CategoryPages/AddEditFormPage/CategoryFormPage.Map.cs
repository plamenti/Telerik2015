namespace TelerikAcademyLearningSystem.Core.Pages.CategoryPages.AddEditFormPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class CategoryFormPage
    {
        public HtmlDiv Form
        {
            get
            {
                var element = Manager.Current.ActiveBrowser.Find.ByExpression<HtmlDiv>("class=~k-window");
                return element;
            }
        }

        public HtmlAnchor Update
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=~k-grid-update");
            }
        }

        public HtmlAnchor Cancel
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=?k-grid-cancel");
            }
        }

        // string or array max lenght 50
        public HtmlInputText Name
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("Name");
            }
        }

        // number
        public HtmlInputNumber Order
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputNumber>("Order");
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
    }
}
