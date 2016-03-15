namespace TelerikAcademyLearningSystem.Core.Pages.LicensesPage
{
    using System.IO;
    using ArtOfTest.Common.UnitTesting;
    using TelerikAcademyLearningSystem.Core.Model;
    using TelerikAcademyLearningSystem.Utilities;

    public static class LicensesPageAsserter
    {
        public static void AssertFileExist(string fileName)
        {
            var path = PathGenerator.GeneratePathToDownloadedFilesFolder() + fileName;

            bool fileExists = File.Exists(path);

            Assert.IsTrue(fileExists, "The file " + fileName + " does not exist");
        }

        public static void AssertLicenseExist(this LicensesPage page, License license)
        {
            bool isAdded = page.ContainsLicense(license);
            Assert.IsTrue(isAdded, "License is not added");
        }

        public static void AssertLicenseNotExist(this LicensesPage page, License license)
        {
            bool isAdded = page.ContainsLicense(license);
            Assert.IsFalse(isAdded, "License is added");
        }
    }
}
