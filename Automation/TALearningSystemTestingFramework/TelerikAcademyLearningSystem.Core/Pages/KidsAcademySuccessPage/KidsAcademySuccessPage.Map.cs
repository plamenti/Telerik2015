namespace TelerikAcademyLearningSystem.Core.Pages.KidsAcademySuccessPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class KidsAcademySuccessPage
    {
        public HtmlInputSubmit ChooseExam
        { 
            get 
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputSubmit>("value=Запиши се за изпит");
            } 
        }

        public HtmlDiv InportantMessageInfoDiv
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByAttributes<HtmlDiv>("class=importantMessageInfo");
            }
        }
    }
}
