namespace TelerikAcademyLearningSystem.Tests.KidsAcademy.Registration
{
    using Core.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;
    using TelerikAcademyLearningSystem.Core.Pages.KidsAcademyRegistrationPage;

    [TestClass]
    public class TestRegistration : BaseTest
    {
        public override void TestInit()
        {
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyRegisteredUserWithEveryFieldFilled()
        {
            KidsAcademyRegistrationFacade facade = new KidsAcademyRegistrationFacade();
            Kid kid = new Kid("Kide31", "123456", "123456", "Пенчо", "Стораро", "kide31@kide.com", "03/11/1999", "0880000000", "123", "Четвърти", "София", "ASSSSS", "Пенка", "Стораро", "parent03@parent.com", "0880000000");
            facade.Register(kid);
            facade.VerifyRegisteredUser();
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyDuplicateUsernameRegistration()
        {
            KidsAcademyRegistrationPage.Instance.NavigateToNewAccountRegistration();
            Kid kid = new Kid("Kide25", "123456", "123456", "Пенчо", "Стораро", "kide40@kide.com", "03/11/1999", "0880000000", "123", "Четвърти", "София", "ASSSSS", "Пенка", "Стораро", "parent03@parent.com", "0880000000");
            KidsAcademyRegistrationPage.Instance.FillForm(kid);
            KidsAcademyRegistrationPage.Instance.VerifyDuplicateUsernameError();
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyDuplicateEmailRegistration()
        {
            KidsAcademyRegistrationPage.Instance.NavigateToNewAccountRegistration();
            Kid kid = new Kid("Kide40", "123456", "123456", "Пенчо", "Стораро", "kide25@kide.com", "03/11/1999", "0880000000", "123", "Четвърти", "София", "ASSSSS", "Пенка", "Стораро", "parent03@parent.com", "0880000000");
            KidsAcademyRegistrationPage.Instance.FillForm(kid);
            KidsAcademyRegistrationPage.Instance.VerifyDuplicateEmailError();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyUsernameNotFilledrrorMassage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyUsernameNotFilledErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyPasswordNotFilledErrorMassage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyPasswordIsNotFilledErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyReEntreyPasswordNotFilledErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyPasswordReEntryIsNotFilledErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyEmailNotFilledErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyEmailNotFilledErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyFistNameInBulgarianNotFilledErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyFirstNameIsNotFilledErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyLastNameInBulgarianNotFilledErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyLastNameIsNotFilledErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyBirthDayNotFilledErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyBirthDayIsNotSelectedErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyGenderNotSelcetedErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyGenderNotSelectedErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyGradeNotSelcetedErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyGradeNotSelectedErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyParentFirstNameNotFilledErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyParentFirstNameNotFilledErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyParentLastNameNotFilledErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyParentLastNameNotFilledErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyParentEmailNotFilledErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyParentEmailNotFilledErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyParentPhoneNotFilledErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyParentPhoneNotFilledErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyTermsAndConditionsNotCheckedErrorMessage()
        {
            KidsAcademyRegistrationPage.Instance.SubmitEmptyForm();
            KidsAcademyRegistrationPage.Instance.VerifyTermsAndConditionsNotCheckedErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidUsernameErrorMessage()
        {
            Kid kid = new Kid();
            kid.Username = "БеднаЛисица";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidUsernameErrorMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyDifferentPasswordsErrorMessage()
        {
            Kid kid = new Kid();
            kid.Password = "XXX123";
            kid.PasswordAgain = "SanoBezRasizan";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyDifferentPasswordsError();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidEmailErrorMessage()
        {
            Kid kid = new Kid();
            kid.Email = "БеднаЛисица";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidEmailMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidFirstNameErrorMessage()
        {
            Kid kid = new Kid();
            kid.FirstNameInBulgarian = "Plo6tad tanqnmyn";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidFirstNameMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidLastNameErrorMessage()
        {       
            Kid kid = new Kid();
            kid.LastNameInBulgarian = "Plo6tad tanqnmyn";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidLastNameMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidBirthDayErrorMessage()
        {
            Kid kid = new Kid();
            kid.BirthDate = "Plo6tad tanqnmyn";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidBirthDayMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidPhoneErrorMessage()
        {
            Kid kid = new Kid();
            kid.MobilePhone = "Plo6tad tanqnmyn";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidPhoneMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidSchoolErrorMessage()
        {
            Kid kid = new Kid();
            kid.School = ")()SFT&(G59asd9;;";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidSchoolMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidParentFirstNameErrorMessage()
        {
            Kid kid = new Kid();
            kid.ParentFirstName = "Rambo Silek";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidParentFirstNameMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidParentLastNameErrorMessage()
        {
            Kid kid = new Kid();
            kid.ParentLastName = "Rambo Silek";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidParentLastNameMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidParentEmailErrorMessage()
        {
            Kid kid = new Kid();
            kid.ParentEmail = "Rambo Silek";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidParentEmailMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyInvalidParentPhoneErrorMessage()
        {
            Kid kid = new Kid();
            kid.ParentPhone = "Rambo Silek";
            KidsAcademyRegistrationPage.Instance.Registration(kid);
            KidsAcademyRegistrationPage.Instance.VerifyInvalidParentPhoneMessage();
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyMoreInfoPage()
        {
            KidsAcademyRegistrationPage.Instance.NavigateToNewAccountRegistration();
            KidsAcademyRegistrationPage.Instance.VerifyMoreinfoPage();
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Blagoy),
        TestCategory(Category.KidsAcademyRegistration)]
        public void VerifyTermsAndConditionsLink()
        {
            KidsAcademyRegistrationPage.Instance.NavigateToNewAccountRegistration();
            KidsAcademyRegistrationPage.Instance.VerifyTermsAndConditionsLink();
        }
    }
}
