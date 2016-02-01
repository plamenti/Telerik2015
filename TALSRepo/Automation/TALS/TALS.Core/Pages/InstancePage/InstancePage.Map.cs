namespace TALS.TestingFramework.Core.Pages.InstancePage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class InstancePage
    {
        public HtmlAnchor CreateInstanceButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add");
            }
        }

        public HtmlInputText SearchInstance
        {
            get
            {
                return Find.ById<HtmlInputText>("CourseInstanceToFilter");
            }
        }

        public HtmlDiv PopUp
        {
            get
            {
                return Find.ByExpression<HtmlDiv>("class=k-edit-form-container");
            }
        }
    }
}