namespace TelerikAcademyLearningSystem.Core.Pages.KidsAcademyRegistrationPage
{
    using Constants;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class KidsAcademyRegistrationPageAsserter
    {
        internal static void AssertTitleForNewAccountRegistration(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(PageTitle.KidsAcademyRegistrationWithNewAcc, page.CurrentTitle, string.Format("Page title should be: {0}", PageTitle.KidsAcademyRegistrationWithNewAcc));
        }

        internal static void AsserttUrlForNewAccountRegistration(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(UrlLink.KidsAcademyRegistrationWithNewAcc, page.CurrentUrl, "Different Url");
        }

        internal static void AssertTitleForExistingAccountRegistration(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(PageTitle.KidsAcademyRegistrationWithExistingAcc, page.CurrentTitle, string.Format("Page title should be: {0}", PageTitle.KidsAcademyRegistrationWithExistingAcc));
        }

        internal static void AsserttUrlForExistingAccountRegistration(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(UrlLink.KidsAcademyRegistrationWithExistingAcc, page.CurrentUrl, "Different Url");
        }

        internal static void AssertUsernameInvalidErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.UsernameInvalidMessage, page.UsernameError.InnerText);
        }

        internal static void AssertUsernameNotFilledErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.UsernameError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.UsernameRequiredMessage, page.UsernameError.InnerText);
        }

        internal static void AssertPasswordNotFilledErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.PasswordError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.ReEnterPasswordRequiredMessage, page.PasswordAgainError.InnerText);
        }

        internal static void AssertPasswordReEntryNotFilledErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.PasswordAgainError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.ReEnterPasswordRequiredMessage, page.PasswordAgainError.InnerText);
        }

        internal static void AssertPassworDIfferenceErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.PasswordsDontMatchMessage, page.PasswordAgainError.InnerText);
        }

        internal static void AssertFirstNameInBulgarianIsFilled(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.BulgarianFirstName.Value != null);
        }

        internal static void AssertFirstnameInBulgarianIsNotFilledMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.FirstNameRequiredMassage, page.FirstNameError.InnerText);
        }

        internal static void AssertFirstNameErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.FirstNameError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.InvalidFirstNameMessage, page.FirstNameError.InnerText);
        }

        internal static void AssertLastNameInBulgarianIsFilled(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.BulgarianLastName.Value != null);
        }

        internal static void AssertLastNameErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.LastNameError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.InvalidLastNameMessage, page.LastNameError.InnerText);
        }

        internal static void AssertLastNameNotFilledErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.LastNameRequiredMessage, page.LastNameError.InnerText);
        }

        internal static void AssertEmailFilled(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.Email.Value != null);
        }

        internal static void AssertEmailNotFilledMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.EmailRequiredMessage, page.EmailError.InnerText);
        }

        internal static void AssertEmailErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.EmailError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.InvalidEmailMassage, page.EmailError.InnerText);
        }

        internal static void AssertBirthDayNotSelectedErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.BirthDayRequiredMessage, page.BirthDayNotSelecetedError.InnerText);
        }

        internal static void AssertBirthDayInvalidMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.InvalidBirthDayMessage, page.InvalidBirthDayError.InnerText);
        }

        internal static void AssertGenderNotSelectedErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.GenderNotChosenMessage, page.GenderNotSelectedError.InnerText);
        }

        internal static void AssertPhoneErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.PhoneError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.InvalidPhoneNumberMessage, page.PhoneError.InnerText);
        }

        internal static void AssertSchoolNameErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.SchoolNameError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.InvalidNameOfSchoolMessage, page.SchoolNameError.InnerText);
        }

        internal static void AssertGradeNotSelectedErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.GradeNotSelecetedError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.GradeNotChosenMessage, page.GradeNotSelecetedError.InnerText);
        }

        internal static void AssertParentFirstNameErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.InvalidFirstNameMessage, page.ParentFirstNameError.InnerText);
        }

        internal static void AssertParentFirstNameNotFilledErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.ParentFirstNameRequiredMessage, page.ParentFirstNameError.InnerText);
        }

        internal static void AssertParentLastNameErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.ParentLastNameError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.InvalidLastNameMessage, page.ParentLastNameError.InnerText);
        }

        internal static void AssertParentLastNameNotFilledErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.ParentLastNameRequiredMessage, page.ParentLastNameError.InnerText);
        }

        internal static void AssertParentEmailErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.ParentEmailError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.InvalidEmailMassage, page.ParentEmailError.InnerText);
        }

        internal static void AssertParentEmailNotFilledErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.ParentEmailError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.ParentEmailRequiredMessage, page.ParentEmailError.InnerText);
        }

        internal static void AssertParentPhoneErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.ParentPhoneError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.InvalidPhoneNumberMessage, page.ParentPhoneError.InnerText);
        }

        internal static void AssertParentPhoneNotFilledErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.ParentPhoneError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.ParentPhoneNumberRequiredMessage, page.ParentPhoneError.InnerText);
        }

        internal static void AssertInfoLink(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.MoreInfo.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.MoreInfoPageLink, page.MoreInfo.HRef);
        }

        internal static void AssertRegistrationIsSuccessful(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.SuccessMessage.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.RegistrationSuccessMessage, page.SuccessMessage.InnerText);
        }

        internal static void AssertTermsAndConditionsNotCheckedErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.IsTrue(page.TermsAndConditionsError.IsVisible());
            Assert.AreEqual(KidsAcademyRegistrationForm.TermsAndConditionsNotCheckedMessage, page.TermsAndConditionsError.InnerText);
        }

        internal static void AssertDuplicateUsernameErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.DuplicateUsernameMessage, page.DuplicateUsernameAndEmaliError.InnerText);
        }

        internal static void AssertDuplicateEmailErrorMessage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.DuplicateEmailMessage, page.DuplicateUsernameAndEmaliError.InnerText);
        }

        internal static void AssertMoreInfoPage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(UrlLink.KidsAcademyInfo, page.MoreInfo.HRef);
        }

        internal static void AssertTermsAndCondtionsPage(this KidsAcademyRegistrationPage page)
        {
            Assert.AreEqual(UrlLink.KidsAcademyTermsAndConditions, page.TermsAndConditionsLink.HRef);
        }
    }
}
