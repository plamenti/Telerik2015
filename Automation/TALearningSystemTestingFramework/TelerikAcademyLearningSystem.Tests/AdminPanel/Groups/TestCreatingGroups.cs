namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Groups
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;
    using TelerikAcademyLearningSystem.Core.Factories;
    using TelerikAcademyLearningSystem.Core.Model;

    [TestClass]
    public class TestCreatingGroups : BaseTest
    {
        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifyCreateNewGroup()
        {
            GroupsFacade groupsFacade = new GroupsFacade();
            GroupsFactory factory = new GroupsFactory();
            Group group = factory.CreateGroup();

            groupsFacade.CreateNewGroup(group);

            groupsFacade.AssertGroupIsCreated(group);
        }
    }
}