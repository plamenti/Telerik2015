using TALS.TestingFramework.Core.Pages.LicensePage;
namespace TALS.TestingFramework.Core.Facades
{

    public class LicenseFacade
    {
        private LicensePage licensePage;

        public LicenseFacade()
        {
            this.licensePage = new LicensePage();
        }

        public void VerifyLicensePage()
        {
            this.licensePage.Navigate();
            this.licensePage.Asserter.DoAssert();
         //   this.licensePage.AddNewLicense();
        }
    }
}
