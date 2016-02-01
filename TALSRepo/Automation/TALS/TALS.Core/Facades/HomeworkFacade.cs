using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TALS.TestingFramework.Core.Pages.HomeworkPage;

namespace TALS.TestingFramework.Core.Facades
{
    public class HomeworkFacade
    {
        private HomeworkPage homeworkPage;

        public HomeworkFacade()
        {
            this.homeworkPage = new HomeworkPage();
        }

        public void VerifyHomeworkPage()
        {
            this.homeworkPage.Navigate();
            this.homeworkPage.Asserter.DoAssert();
        }
    }
}
