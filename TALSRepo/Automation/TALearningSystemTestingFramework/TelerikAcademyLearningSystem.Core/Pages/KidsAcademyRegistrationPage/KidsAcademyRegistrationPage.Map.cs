namespace TelerikAcademyLearningSystem.Core.Pages.KidsAcademyRegistrationPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class KidsAcademyRegistrationPage
    {
        public string CurrentTitle
        {
            get
            {
                return Browser.PageTitle;
            }
        }

        public string CurrentUrl
        {
            get
            {
                return Browser.Url;
            }
        }

        public HtmlDiv DivContainer
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByAttributes<HtmlDiv>("class=container");
            }
        }

        public HtmlInputControl Username
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("Username");
            }
        }

        public HtmlInputPassword Password
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputPassword>("Password");
            }
        }

        public HtmlInputPassword PasswordAgain
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputPassword>("PasswordAgain");
            }
        }

        public HtmlSpan SchoolSeason
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("textContent=Изберете сезон на школа");
            }
        }

        public HtmlInputControl BulgarianFirstName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("FirstName");
            }
        }

        public HtmlInputControl BulgarianLastName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("LastName");
            }
        }

        public HtmlInputControl Email
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("Email");
            }
        }

        public HtmlInputControl BirthDay
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("BirthDay");
            }
        }

        public HtmlInputRadioButton Male
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputRadioButton>("Male");
            }
        }

        public HtmlInputRadioButton Female
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputRadioButton>("Female");
            }
        }

        public HtmlInputControl Phone
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("Phone");
            }
        }

        public HtmlInputControl SchoolName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("SchoolName");
            }
        }

        public HtmlSpan SelectClass
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("textContent=Изберете клас");
            }
        }

        public HtmlTextArea About
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlTextArea>("About");
            }
        }

        public HtmlAnchor ProfileSettings
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("href=/Users/Profile/Settings");
            }
        }

        public HtmlInputControl ParentFirstName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("ParentFirstName");
            }
        }

        public HtmlInputControl ParentLastName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("ParentLastName");
            }
        }

        public HtmlInputControl ParentEmail
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("ParentEmail");
            }
        }

        public HtmlInputControl ParentPhone
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("ParentPhone");
            }
        }

        public HtmlInputControl SubmitButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputControl>("value=Регистрация");
            }
        }

        public HtmlDiv SuccessMessage
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("importantMessageInfo");
            }
        }

        public HtmlSpan UsernameError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("Username-error");
            }
        }

        public HtmlSpan PasswordError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("Password-error");
            }
        }

        public HtmlSpan PasswordAgainError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("PasswordAgain-error");
            }
        }

        public HtmlSpan FirstNameError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("FirstName-error");
            }
        }

        public HtmlSpan LastNameError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("LastName-error");
            }
        }

        public HtmlSpan EmailError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("Email-error");
            }
        }

        public HtmlSpan InvalidBirthDayError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByAttributes<HtmlSpan>("data-valmsg-for=BirthDay");
            }
        }

        public HtmlSpan PhoneError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("Phone-error");
            }
        }

        public HtmlSpan SchoolNameError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("SchoolName-error");
            }
        }

        public HtmlSpan ParentFirstNameError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("ParentFirstName-error");
            }
        }

        public HtmlSpan ParentLastNameError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("ParentLastName-error");
            }
        }

        public HtmlSpan ParentEmailError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("ParentEmail-error");
            }
        }

        public HtmlSpan ParentPhoneError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("ParentPhone-error");
            }
        }

        public HtmlSpan GenderNotSelectedError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("IsMale-error");
            }
        }

        public HtmlSpan SchoolNotSelecetedError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("data-valmsg-for='KidsSchoolSeasonId'");
            }
        }

        public HtmlSpan BirthDayNotSelecetedError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("data-valmsg-for='BirthDay'");
            }
        }

        public HtmlSpan GradeNotSelecetedError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("data-valmsg-for='ClassId'");
            }
        }

        public HtmlAnchor MoreInfo
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("title=Повече информация");
            }
        }

        public HtmlDiv GradeDivContainer
        {
            get
            {
                Browser.WaitForElement(new HtmlFindExpression("id=ClassId-list"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("ClassId-list");
            }
        }

        public HtmlUnorderedList ClassIdList
        {
            get
            {
                Browser.WaitForElement(new HtmlFindExpression("id=ClassId_listbox"), 30000, false);
                return this.GradeDivContainer.Find.ById<HtmlUnorderedList>("ClassId_listbox");
            }
        }

        public HtmlSpan GradeSelect
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("textContent=Изберете клас");
            }
        }

        public HtmlSpan CitySelect
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("aria-controls=CityId_listbox");
            }
        }

        public HtmlDiv CityDivContainer
        {
            get
            {
                Browser.WaitForElement(new HtmlFindExpression("id=CityId-list"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("CityId-list");
            }
        }

        public HtmlUnorderedList CityList
        {
            get
            {
                Browser.WaitForElement(new HtmlFindExpression("id=CityId_listbox"), 30000, false);
                return this.CityDivContainer.Find.ById<HtmlUnorderedList>("CityId_listbox");
            }
        }

        public HtmlSpan DuplicateUsernameAndEmaliError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByAttributes<HtmlSpan>("class=field-validation-error");
            }
        }

        public HtmlInputCheckBox AgreeToTermsAndConditions
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputCheckBox>("TermsAndConditions");
            }
        }

        public HtmlSpan TermsAndConditionsError
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("data-valmsg-for=TermsAndConditions");
            }
        }

        public HtmlAnchor TermsAndConditionsLink
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("textContent=Свалете правилата и условията");
            }
        }

        public HtmlListItem Grade(string gradeName)
        {
            return this.ClassIdList.Find.ByExpression<HtmlListItem>("innerText=" + gradeName);
        }

        public HtmlListItem City(string cityName)
        {
            return this.CityList.Find.ByExpression<HtmlListItem>("innerText=" + cityName);
        }
    }
}
