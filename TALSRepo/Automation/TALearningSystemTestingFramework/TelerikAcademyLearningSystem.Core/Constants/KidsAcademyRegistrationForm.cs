namespace TelerikAcademyLearningSystem.Core.Constants
{
    internal class KidsAcademyRegistrationForm
    {
        internal const string UsernameRequiredMessage = "Потребителското име е задължително";
        internal const string PasswordRequiredMessage = "Паролата е задължителна";
        internal const string ReEnterPasswordRequiredMessage = "Повторното въвеждане на паролата е задължително";
        internal const string EmailRequiredMessage = "Имейлът е задължителен";
        internal const string FirstNameRequiredMassage = "Името е задължително";
        internal const string LastNameRequiredMessage = "Фамилията е задължителна";
        internal const string BirthDayRequiredMessage = "Датата на раждане е задължителна";
        internal const string GenderNotChosenMessage = "Моля, изберете пол";
        internal const string GradeNotChosenMessage = "Избирането на клас е задължително";
        internal const string ParentFirstNameRequiredMessage = "Името на родителя е задължително";
        internal const string ParentLastNameRequiredMessage = "Фамилията на родителя е задължителна";
        internal const string ParentEmailRequiredMessage = "Имейлът на родителя е задължителен";
        internal const string ParentPhoneNumberRequiredMessage = "Мобилният телефон на родителя е задължителен";
        internal const string TermsAndConditionsNotCheckedMessage = "За да се рагистрирате трябва да приемете условията и правилата на академията на Телерик";

        internal const string UsernameInvalidMessage = "Потребителското име може да съдържа само малки и главни латински букви, цифри и знаците точка и долна черта. Потребителското име трябва да започва с буква и да завършва с буква или цифра.";
        internal const string InvalidEmailMassage = "Моля въведете валиден имейл адрес.";
        internal const string InvalidFirstNameMessage = "Невалидно име. Името може да съдържа само букви от българската азбука и знака тире. Минимална дължина - 2 букви.";
        internal const string InvalidLastNameMessage = "Невалидна фамилия. Фамилията може да съдържа само букви от българската азбука и знака тире. Минимална дължина - 2 букви.";
        internal const string InvalidBirthDayMessage = "Въведената стойност не е валидна за полето 'Дата на раждане'.";
        internal const string InvalidPhoneNumberMessage = "Моля въведете валиден мобилен телефон (пример: 0888123456 или +359888123456).";
        internal const string InvalidNameOfSchoolMessage = "Невалидно училище. Името на училището може да съдържа само букви, цифри, интервали и знака тире. Минимална дължина - 2 символа.";

        internal const string DuplicateUsernameMessage = "Потребителското име вече е заето.";
        internal const string DuplicateEmailMessage = "Този емейл адрес вече се използва от друг потребител.";

        internal const string UsernameNotInRangeMessage = "Потребителското име трябва да е между 5 и 32 символа";
        internal const string PasswordShouldBeMoreThanSixCharactersMessage = "Паролата трябва да е повече от 6 символа";
        internal const string PasswordsDontMatchMessage = "Паролите не съвпадат";      
        internal const string EmailOutOfRangeMessage = "Имейлът трябва да е не по-дълъг от 50 символа"; 
        internal const string FirstNameOutOfRangeMessage = "Името трябва да е не по-дълго от 30 и не по-къса от 2 символа.";  
        internal const string LastNameOutOfRangeMessage = "Фамилията трябва да е не по-дълга от 30 и не по-къса от 2 символа.";
        internal const string SchoolNameOutOfRangeMessage = "Училището трябва да е не по-дълго от 100 символа";
        internal const string InvalidCityNameMessage = "Въведената стойност 'sdsfhsfhdfhdf' не е валидна за полето 'Роден град'.";
        internal const string AboutMeSectionOutOfRangeMessage = "Полето 'За мен' трябва да е не по-дълго от 1000 символа";

        internal const string RegistrationSuccessMessage = "Благодарим Ви за кандидатурата за новият сезон в \"Академията на Телерик\".";
        internal const string ChooseExamMessage = "Запиши се за изпит";

        internal const string MoreInfoPageLink = "http://www.telerik-kids.com/sofia/shkola-po-programirane";
    }
}
