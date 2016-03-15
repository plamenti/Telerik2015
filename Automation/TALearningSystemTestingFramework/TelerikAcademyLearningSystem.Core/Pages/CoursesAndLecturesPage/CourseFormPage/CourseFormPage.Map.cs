namespace TelerikAcademyLearningSystem.Core.Pages.CoursesAndLecturesPage.CourseFormPage
{
    using System;
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class CourseFormPage
    {
        internal HtmlSpan Title
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("tagname=span", "class=k-window-title");
            }
        }

        internal HtmlInputText NameBg
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("NameBg");
            }
        }

        internal HtmlInputText NameEn
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("NameEn");
            }
        }

        internal HtmlInputText UrlName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("UrlName");
            }
        }

        internal HtmlContainerControl Description
        {
            get
            {
                Browser textFrame = this.Browser.Frames[0];
                HtmlContainerControl description = textFrame.Find.AllByTagName<HtmlContainerControl>("body").FirstOrDefault();
                return description;
            }
        }

        internal HtmlInputText Color
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("DesignColor");
            }
        }

       internal HtmlInputText Order
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlInputText>("//*[@id='Order']/preceding-sibling::input");
            }
        }

        internal HtmlContainerControl NameBgValidationMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("NameBg_validationMessage");
            }
        }

        internal HtmlDiv NameEnValidationMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("NameEn_validationMessage");
            }
        }

        internal HtmlDiv UrlNameValidationMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("UrlName_validationMessage");
            }
        }

        internal HtmlDiv DescriptionValidationMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("Description_validationMessage");
            }
        }

        internal HtmlDiv OrderValidationMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("Order_validationMessage");
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
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-cancel");
            }
        }
    }
}
