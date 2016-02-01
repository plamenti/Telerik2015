namespace TALS.TestingFramework.Core.Pages.InstancePage
{
    using ArtOfTest.Common.UnitTesting;
    using TALS.TestingFramework.Core.Base;

    public class InstancePageAsserter : IAsserter
    {
        private InstancePage page;

        public InstancePageAsserter(InstancePage page)
        {
            this.page = page;
        }

        public void DoAssert()
        {
            this.IsDivVissible();
        }

        private void IsDivVissible()
        {
            Assert.IsTrue(this.page.PopUp.IsVisible());
        }
    }
}