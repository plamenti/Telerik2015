namespace TALS.TestingFramework.Core.Pages.CourseFormPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class CourseFormPage
    {
        public HtmlInputText NameBg
        {
            get
            {
                return this.Find.ById<HtmlInputText>("NameBg");
            }
        }

        public HtmlInputText NameEn
        {
            get
            {
                return this.Find.ById<HtmlInputText>("NameEn");
            }
        }

        public HtmlInputText UrlName
        {
            get
            {
                return this.Find.ById<HtmlInputText>("UrlName");
            }
        }
        // public  Description

        public HtmlInputText Color
        {
            get
            {
                return this.Find.ById<HtmlInputText>("DesignColor");
            }
        }

        public HtmlInputText Order
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Order");
            }
        }

        public HtmlDiv NameBgValidationMessageFor
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Order");
            }
        }

        public HtmlDiv DescriptionValidationMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Description_validationMessage");
            }
        }

        public HtmlDiv OrderValidatinMessage
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Order_validationMessage");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        public HtmlAnchor CanleButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=k-k-button k-button-icontext k-grid-cancel");
            }
        }

    }
}
