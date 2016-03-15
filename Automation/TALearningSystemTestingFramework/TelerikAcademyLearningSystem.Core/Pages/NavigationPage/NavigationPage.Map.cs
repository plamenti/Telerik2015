namespace TelerikAcademyLearningSystem.Core.Pages.NavigationPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class NavigationPage
    {
        public HtmlUnorderedList Navigation
        {
            get
            {
                return Find.ById<HtmlUnorderedList>("Menu");
            }
        }

        public HtmlAnchor AdminButton
        {
            get
            {
                return Find.ByXPath<HtmlAnchor>(@"//*[@id='Menu']/li[8]/a");
            }
        }
    }
}
