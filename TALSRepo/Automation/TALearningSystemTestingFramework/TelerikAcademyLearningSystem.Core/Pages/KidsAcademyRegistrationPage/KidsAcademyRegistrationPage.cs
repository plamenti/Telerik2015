namespace TelerikAcademyLearningSystem.Core.Pages.KidsAcademyRegistrationPage
{
    using System;
    using System.Reflection;

    using Base;
    using Constants;
    using Model;

    public partial class KidsAcademyRegistrationPage : BasePage<KidsAcademyRegistrationPage>
    {
        public void NavigateToExistingAccountRegistration()
        {
            this.Browser.NavigateTo(UrlLink.KidsAcademyRegistrationWithExistingAcc);
        }

        public void NavigateToNewAccountRegistration()
        {
            this.Browser.NavigateTo(UrlLink.KidsAcademyRegistrationWithNewAcc);
        }

        public void FillForm(Kid kid)
        {
            this.Username.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.Username);
            this.Browser.RefreshDomTree();
            this.Password.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.Password);
            this.Browser.RefreshDomTree();
            this.PasswordAgain.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.PasswordAgain);
            this.Browser.RefreshDomTree();
            this.Email.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.Email);
            this.Browser.RefreshDomTree();
            this.BulgarianFirstName.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.FirstNameInBulgarian);
            this.Browser.RefreshDomTree();
            this.BulgarianLastName.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.LastNameInBulgarian);
            this.Browser.RefreshDomTree();
            this.BirthDay.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.BirthDate);
            this.Browser.RefreshDomTree();
            this.Male.MouseClick();
            this.Phone.ScrollToVisible();
            this.Phone.MouseClick();
            this.Browser.RefreshDomTree();
            this.Browser.Desktop.KeyBoard.TypeText(kid.MobilePhone);
            this.SchoolName.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.School);
            this.Browser.RefreshDomTree();
            this.GradeSelect.MouseClick();
            this.Browser.RefreshDomTree();
            this.Browser.WaitUntilReady();
            var grade = this.Grade(kid.Grade);
            grade.MouseClick();
            this.CitySelect.MouseClick();
            this.Browser.RefreshDomTree();
            this.Browser.WaitUntilReady();
            var city = this.City(kid.City);
            city.MouseClick();
            this.About.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.AdditionalInfo);
            this.Browser.RefreshDomTree();
            this.ParentFirstName.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.ParentFirstName);
            this.Browser.RefreshDomTree();
            this.ParentLastName.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.ParentLastName);
            this.Browser.RefreshDomTree();
            this.ParentEmail.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.ParentEmail);
            this.Browser.RefreshDomTree();
            this.ParentPhone.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(kid.ParentPhone);
            this.Browser.RefreshDomTree();
            this.AgreeToTermsAndConditions.MouseClick();
            this.SubmitButton.MouseClick();
        }

        public void SubmitEmptyForm()
        {
            this.NavigateToNewAccountRegistration();
            this.SubmitButton.ScrollToVisible();
            this.SubmitButton.MouseClick();
            this.Browser.RefreshDomTree();
        }

        public void FillRegistrationForm(Kid kid)
        {
            Type t = kid.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (PropertyInfo property in props)
            {
                if (property.GetValue(kid) != null)
                {
                    if (property.Name == "Username")
                    {
                        this.Username.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.Username);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "Password")
                    {
                        this.Password.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.Password);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "PasswordAgain")
                    {
                        this.PasswordAgain.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.PasswordAgain);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "Email")
                    {
                        this.Email.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.Email);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "FirstNameInBulgarian")
                    {
                        this.BulgarianFirstName.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.FirstNameInBulgarian);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "LastNameInBulgarian")
                    {
                        this.BulgarianLastName.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.LastNameInBulgarian);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "BirthDate")
                    {
                        this.BirthDay.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.BirthDate);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "MobilePhone")
                    {
                        this.Phone.ScrollToVisible();
                        this.Phone.MouseClick();
                        this.Browser.RefreshDomTree();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.MobilePhone);
                    }

                    if (property.Name == "School")
                    {
                        this.SchoolName.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.School);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "Grade")
                    {
                        this.GradeSelect.MouseClick();
                        this.Browser.RefreshDomTree();
                        this.Browser.WaitUntilReady();
                        var grade = this.Grade(kid.Grade);
                        grade.MouseClick();
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "City")
                    {
                        this.CitySelect.MouseClick();
                        this.Browser.RefreshDomTree();
                        this.Browser.WaitUntilReady();
                        var city = this.City(kid.City);
                        city.MouseClick();
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "AdditionalInfo")
                    {
                        this.About.ScrollToVisible();
                        this.About.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.AdditionalInfo);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "ParentFirstName")
                    {
                        this.ParentFirstName.ScrollToVisible();
                        this.ParentFirstName.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.ParentFirstName);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "ParentLastName")
                    {
                        this.ParentLastName.ScrollToVisible();
                        this.ParentLastName.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.ParentLastName);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "ParentEmail")
                    {
                        this.ParentEmail.ScrollToVisible();
                        this.ParentEmail.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.ParentEmail);
                        this.Browser.RefreshDomTree();
                    }

                    if (property.Name == "ParentPhone")
                    {
                        this.ParentPhone.ScrollToVisible();
                        this.ParentPhone.MouseClick();
                        this.Browser.Desktop.KeyBoard.TypeText(kid.ParentPhone);
                        this.Browser.RefreshDomTree();
                    }
                }
            }
        }

        public void Registration(Kid kid)
        {
            this.NavigateToNewAccountRegistration();
            this.FillRegistrationForm(kid);
            this.DivContainer.ScrollToVisible();
            this.DivContainer.MouseClick();
            this.Browser.RefreshDomTree();
        }

        public void VerifyUsernameNotFilledErrorMessage()
        {
            this.AssertUsernameNotFilledErrorMessage();
        }

        public void VerifyPasswordIsNotFilledErrorMessage()
        {
            this.AssertPasswordNotFilledErrorMessage();
        }

        public void VerifyPasswordReEntryIsNotFilledErrorMessage()
        {
            this.AssertPasswordReEntryNotFilledErrorMessage();
        }

        public void VerifyEmailNotFilledErrorMessage()
        {
            this.AssertEmailNotFilledMessage();
        }

        public void VerifyFirstNameIsNotFilledErrorMessage()
        {
            this.AssertFirstnameInBulgarianIsNotFilledMessage();
        }

        public void VerifyLastNameIsNotFilledErrorMessage()
        {
            this.AssertLastNameNotFilledErrorMessage();
        }

        public void VerifyBirthDayIsNotSelectedErrorMessage()
        {
            this.AssertBirthDayNotSelectedErrorMessage();
        }

        public void VerifyGenderNotSelectedErrorMessage()
        {
            this.AssertGenderNotSelectedErrorMessage();
        }

        public void VerifyGradeNotSelectedErrorMessage()
        {
            this.AssertGradeNotSelectedErrorMessage();
        }

        public void VerifyParentFirstNameNotFilledErrorMessage()
        {
            this.AssertParentFirstNameNotFilledErrorMessage();
        }

        public void VerifyParentLastNameNotFilledErrorMessage()
        {
            this.AssertParentLastNameNotFilledErrorMessage();
        }

        public void VerifyParentEmailNotFilledErrorMessage()
        {
            this.AssertParentEmailNotFilledErrorMessage();
        }

        public void VerifyParentPhoneNotFilledErrorMessage()
        {
            this.AssertParentPhoneNotFilledErrorMessage();
        }

        public void VerifyTermsAndConditionsNotCheckedErrorMessage()
        {
            this.AssertTermsAndConditionsNotCheckedErrorMessage();
        }

        public void VerifyInvalidUsernameErrorMessage()
        {
            this.AssertUsernameInvalidErrorMessage();
        }

        public void VerifyInvalidEmailMessage()
        {
            this.AssertEmailErrorMessage();
        }

        public void VerifyInvalidFirstNameMessage()
        {
            this.AssertFirstNameErrorMessage();
        }

        public void VerifyInvalidLastNameMessage()
        {
            this.AssertLastNameErrorMessage();
        }

        public void VerifyInvalidBirthDayMessage()
        {
            this.BirthDay.ScrollToVisible();
            this.AssertBirthDayInvalidMessage();
        }

        public void VerifyInvalidPhoneMessage()
        {
            this.AssertPhoneErrorMessage();
        }

        public void VerifyInvalidSchoolMessage()
        {
            this.SchoolName.ScrollToVisible();
            this.AssertSchoolNameErrorMessage();
        }

        public void VerifyInvalidParentFirstNameMessage()
        {
            this.ParentFirstName.ScrollToVisible();
            this.AssertParentFirstNameErrorMessage();
        }

        public void VerifyInvalidParentLastNameMessage()
        {
            this.ParentLastName.ScrollToVisible();
            this.AssertParentLastNameErrorMessage();
        }

        public void VerifyInvalidParentEmailMessage()
        {
            this.ParentEmail.ScrollToVisible();
            this.AssertParentEmailErrorMessage();
        }

        public void VerifyInvalidParentPhoneMessage()
        {
            this.ParentEmail.ScrollToVisible();
            this.AssertParentPhoneErrorMessage();
        }

        public void VerifyDifferentPasswordsError()
        {
            this.Password.ScrollToVisible();
            this.AssertPassworDIfferenceErrorMessage();
        }

        public void VerifyDuplicateUsernameError()
        {
            this.Username.ScrollToVisible();
            this.AssertDuplicateUsernameErrorMessage();
        }

        public void VerifyDuplicateEmailError()
        {
            this.Email.ScrollToVisible();
            this.AssertDuplicateEmailErrorMessage();
        }

        public void VerifyTermsAndConditionsLink()
        {
            this.TermsAndConditionsLink.ScrollToVisible();
            this.AssertTermsAndCondtionsPage();
        }

        public void VerifyMoreinfoPage()
        {
            this.MoreInfo.ScrollToVisible();
            this.AssertMoreInfoPage();
        }
    }
}
