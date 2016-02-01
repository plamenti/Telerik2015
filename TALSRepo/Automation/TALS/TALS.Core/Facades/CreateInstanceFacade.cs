namespace TALS.TestingFramework.Core.Facades
{
    using TALS.TestingFramework.Core.Pages.InstancePage;

    public class CreateInstanceFacade
    {
        private InstancePage page;

        public CreateInstanceFacade()
        {
            this.page = new InstancePage();
        }

        public void VerifyFormOpen()
        {
            this.page.CreateNewInstance();
            this.page.Asserter.DoAssert();
        }
    }
}