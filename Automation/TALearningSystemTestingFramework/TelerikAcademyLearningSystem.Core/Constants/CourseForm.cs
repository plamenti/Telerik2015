namespace TelerikAcademyLearningSystem.Core.Constants
{
    using TelerikAcademyLearningSystem.Core.Model;

    public class CourseForm
    {
        public const string LongName101symbols = "badNameBecauseItIsTooLongAndDontPassLenghtValidationbadNameBecauseItIsTooLongAndDontPassLenghtValidat";
        public const string ExactName100symbols = "Exact100GoogNameItIsTooLongAndPassLenghtValidationExact100GoogNameItIsTooLongAndPassLenghtValidation";
        public const string ExactName99symbols = "Exact99GoogNameItIsTooLongAndPassLenghtValidationExact100GoogNameItIsTooLongAndPassLenghtValidation";
        public const string LongUrlName51symbols = "badNameBecauseItIsTooLongAndDontPassLenghtValidatio";
        public const string ExactName50symbols = "Exact050GoogNameItIsTooLongAndPassLenghtValidation";
        public const string ExactName49symbols = "Exact49GoogNameItIsTooLongAndPassLenghtValidation";
        public const string OrderGraterMaxValueWithOne = "2147483648";
        public const string OrderMaxValue = "2147483647";
        public const string OrderLessMaxValueWithOne = "2147483646";

        internal const string RequiredNameBgMessage = "Моля попълнете името на курса.";
        internal const string RequiredDescriptionMessage = "Моля попълнете описанието за курса.";
        internal const string RequiredOrderMessage = "The Подредба field is required.";
        internal const string ExistingNameMesage = "Вече съществува курс с такова име!";
        internal const string ExistingUrlNAmeMesage = "Вече съществува курс с такъв Url!";
        internal const string InvalidLengthNameBgMessage = "The field Име (BG) must be a string with a maximum length of 100.";
        internal const string InvalidLengthNameEnMessage = "The field Име (EN) must be a string with a maximum length of 100.";
        internal const string InvalidLengthUrNamelMessage = "The field Url име must be a string with a maximum length of 50.";
        internal const string InvalidUrlNameMessage = "Some Validation Message";
        internal const string InvalidOrderMessage = "Въведената стойност '{0}' не е валидна за полето 'Подредба'.";
    }
}
