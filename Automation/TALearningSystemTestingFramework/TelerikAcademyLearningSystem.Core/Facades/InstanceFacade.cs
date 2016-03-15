namespace TelerikAcademyLearningSystem.Core.Facades
{
    using Model;
    using Pages.AdministrationPage;
    using Pages.InstancePages;
    using Pages.InstancePages.AddEditFormPage;
    using Pages.NavigationPage;

    public class InstanceFacade
    {
        public void ManualNavigate()
        {
            NavigationPage.Instance.GoToAdminPage();
            AdministrationPage.Instance.ClickInstanceLink();
        }

        public void GoBackToAdminPage()
        {
            InstancePage.Instance.Navigate();
            InstancePage.Instance.GoBackToAdmin();
        }

        public void AssertInstancePageIsOpen()
        {
            InstancePage.Instance.AssertTitle();
            InstancePage.Instance.AssertHeader();
        }

        public void AddInstance(Instance newInstance)
        {
            InstancePage.Instance.Navigate();
            if (InstancePage.Instance.CheckInstanceExist(newInstance))
            {
                InstancePage.Instance.DeleteInstance(newInstance);
            }

            InstancePage.Instance.OpenAddForm();
            InstanceFormPage.Instance.FillForm(newInstance);
            InstanceFormPage.Instance.UpdateForm();
        }

        public void EditCategory(Instance instance, Instance editInstance)
        {
            InstancePage.Instance.OpenEditForm(instance);
            InstanceFormPage.Instance.FillForm(editInstance);
            InstanceFormPage.Instance.UpdateForm();
        }

        public void AssertCategoryExist(Instance category)
        {
            InstancePage.Instance.AssertInstanceExist(category);
        }

        public void AssertNameErrorMessage(Instance category)
        {
            this.AssertNameErrorMessage(category);
        }

        public void AssertOrderErrorMessage(Instance category)
        {
            this.AssertOrderErrorMessage(category);
        }
        
        public void SortGrid()
        {
            InstancePage.Instance.Navigate();
            InstancePage.Instance.GridPage.SortGridByStringAndNumber();
        }
    }
}
