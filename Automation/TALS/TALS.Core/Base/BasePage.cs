namespace TALS.TestingFramework.Core.Base
{
    using ArtOfTest.WebAii.TestTemplates;

    public abstract class BasePage : BaseTest
    {
        public BasePage()
        {
            this.Initialize(true);
        }

        public IAsserter Asserter { get; set; }

        public virtual void Navigate()
        {
        }
    }
}