namespace TelerikAcademyLearningSystem.Core.Pages.LicensesPage.AddLicensePage
{
    using ArtOfTest.WebAii.Core;
    using TelerikAcademyLearningSystem.Core.Base;
    using TelerikAcademyLearningSystem.Core.Model;

    public partial class AddLicensePage : BasePage<AddLicensePage>
    {
        public override void Navigate()
        {
            LicensesPage.Instance.OpenAddLicenseForm();
        }

        public void FillForm(License license)
        {
            this.LicenseName.ScrollToVisible();
            this.LicenseName.MouseClick();
            this.CleanInput(this.LicenseName.Text);
            this.Browser.Desktop.KeyBoard.TypeText(license.Name);
            this.Header.MouseClick();

            this.LicenseUrl.ScrollToVisible();
            this.LicenseUrl.MouseClick();
            this.CleanInput(this.LicenseUrl.Text);
            this.Browser.Desktop.KeyBoard.TypeText(license.Url);
            this.Header.MouseClick();

            this.LicenseLink.ScrollToVisible();
            this.LicenseLink.MouseClick();
            this.CleanInput(this.LicenseLink.Text);
            this.Browser.Desktop.KeyBoard.TypeText(license.Link);
            this.Header.MouseClick();

            this.UpdateButton.ScrollToVisible();
            this.UpdateButton.MouseClick();
        }

        public void FillFormWithNoData()
        {
            this.Browser.ScrollBy(0, 500);
            this.UpdateButton.ScrollToVisible();
            this.UpdateButton.MouseClick();
        }

        public void CancelFillForm(License license)
        {
            this.LicenseName.ScrollToVisible();
            this.LicenseName.MouseClick();
            this.CleanInput(this.LicenseName.Text);
            this.Browser.Desktop.KeyBoard.TypeText(license.Name);
            this.Header.MouseClick();

            this.LicenseUrl.ScrollToVisible();
            this.LicenseUrl.MouseClick();
            this.CleanInput(this.LicenseUrl.Text);
            this.Browser.Desktop.KeyBoard.TypeText(license.Url);
            this.Header.MouseClick();

            this.LicenseLink.ScrollToVisible();
            this.LicenseLink.MouseClick();
            this.CleanInput(this.LicenseLink.Text);
            this.Browser.Desktop.KeyBoard.TypeText(license.Link);
            this.Header.MouseClick();

            this.CancelButton.ScrollToVisible();
            this.CancelButton.MouseClick();
            Manager.Current.ActiveBrowser.RefreshDomTree();
        }
    }
}
