namespace TelerikAcademyLearningSystem.Core.Model
{
    using System;

    public class Kid
    {
        public Kid()
        {
        }

        public Kid(
            string birthDate,
            string mobilePhone,
            string school,
            string grade,
            string city,
            string additionalInfo,
            string parentFirstName,
            string parentLastName,
            string parentEmail,
            string parentPhone)
        {
            this.BirthDate = birthDate;
            this.MobilePhone = mobilePhone;
            this.School = school;
            this.Grade = grade;
            this.City = city;
            this.AdditionalInfo = additionalInfo;
            this.ParentFirstName = parentFirstName;
            this.ParentLastName = parentLastName;
            this.ParentEmail = parentEmail;
            this.ParentPhone = parentPhone;
        }

        public Kid(
             string firstName,
             string lastName,
             string email,
             string birthDate,
             string mobilePhone,
             string school,
             string grade,
             string city,
             string additionalInfo,
             string parentFirstName,
             string parentLastName,
             string parentEmail,
             string parentPhone)
            : this(
                   birthDate,
                   mobilePhone,
                   school,
                   grade,
                   city,
                   additionalInfo,
                   parentFirstName,
                   parentLastName,
                   parentEmail,
                   parentPhone)
        {
            this.FirstNameInBulgarian = firstName;
            this.LastNameInBulgarian = lastName;
            this.Email = email;
        }

        public Kid(
            string username,
            string password,
            string passwordAgain,
            string firstName,
            string lastName,
            string email,
            string birthDate,
            string mobilePhone,
            string school,
            string grade,
            string city,
            string additionalInfo,
            string parentFirstName,
            string parentLastName,
            string parentEmail,
            string parentPhone)
            : this(
                firstName,
                lastName,
                email,
                birthDate,
                mobilePhone,
                school,
                grade,
                city,
                additionalInfo,
                parentFirstName,
                parentLastName,
                parentEmail,
                parentPhone)
        {
            this.Username = username;
            this.Password = password;
            this.PasswordAgain = passwordAgain;
        }

       //public Kid()
       //{
       //    this.Username = string.Empty;
       //    this.Password = string.Empty;
       //    this.PasswordAgain = string.Empty;
       //    this.FirstNameInBulgarian = string.Empty;
       //    this.LastNameInBulgarian = string.Empty;
       //    this.Email = string.Empty;
       //    this.BirthDate = string.Empty;
       //    this.MobilePhone = string.Empty;
       //    this.MobilePhone = string.Empty;
       //    this.School = string.Empty;
       //    this.Grade = "Пети";
       //    this.City = "София";
       //    this.AdditionalInfo = string.Empty;
       //    this.ParentFirstName = string.Empty;
       //    this.ParentLastName = string.Empty;
       //    this.ParentEmail = string.Empty;
       //    this.ParentPhone = string.Empty;
       //}

        public string Username { get; set; }

        public string Password { get; set; }

        public string PasswordAgain { get; set; }

        public string FirstNameInBulgarian { get; set; }

        public string LastNameInBulgarian { get; set; }

        public string Email { get; set; }

        public string BirthDate { get; set; }

        public string MobilePhone { get; set; }

        public string School { get; set; }

        public string Grade { get; set; }

        public string City { get; set; }

        public string AdditionalInfo { get; set; }

        public string ParentFirstName { get; set; }

        public string ParentLastName { get; set; }

        public string ParentEmail { get; set; }

        public string ParentPhone { get; set; }
    }
}
