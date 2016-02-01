namespace TALearningSystemTestingFramework.Core.Base
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikAcademyLearningSystem.Core.Model;
    using TelerikAcademyLearningSystem.Core.Pages.LoginPage;

    [TestClass]
    public class BaseTest
    {
        public Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

        [TestInitialize]
        public void CoreTestInit()
        {
            this.InitializeBrowser();
            this.TestInit();
        }

        [TestCleanup]
        public void CleanUp()
        {
            this.DisposeBrowser();
            this.TestCleanUp();
        }

        public virtual void TestInit()
        {
            AdminUser adminUser = new AdminUser()
            {
                Username = "GiantTestUser",
                Password = "123456"
            };

            LoginPage loginPage = new LoginPage();
            loginPage.Login(adminUser);
        }

        protected virtual void TestCleanUp()
        {
        }

        private void DisposeBrowser()
        {
            foreach (var currentBrowser in Manager.Current.Browsers)
            {
                currentBrowser.Close();
            }

            Manager.Current.Dispose();
        }

        private void InitializeBrowser()
        {
            Settings mySettings = new Settings
            {
                Web =
                {
                    ////DefaultBrowser = BrowserType.Chrome,
                    DefaultBrowser = BrowserType.InternetExplorer,
                    ////DefaultBrowser = BrowserType.FireFox,
                    RecycleBrowser = true,
                },
                AnnotateExecution = true,
                CreateLogFile = true,
                ExecutionDelay = 100
            };

            Manager manager = new Manager(mySettings);
            manager.Start();
            Manager.Current.LaunchNewBrowser();
            Manager.Current.ActiveBrowser.Window.Maximize();
            ////manager.DialogMonitor.AddDialog(new ConfirmDialog(Manager.Current.ActiveBrowser, DialogButton.OK));
            ////manager.DialogMonitor.Start();
            Manager.Current.ActiveBrowser.ClearCache(BrowserCacheType.Cookies);
        }
    }
}