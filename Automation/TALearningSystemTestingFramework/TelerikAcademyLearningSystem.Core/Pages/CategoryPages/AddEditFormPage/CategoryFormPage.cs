namespace TelerikAcademyLearningSystem.Core.Pages.CategoryPages.AddEditFormPage
{
    using ArtOfTest.Common;
    using ArtOfTest.WebAii.Core;
    using Base;
    using Constants;
    using Model;

    public partial class CategoryFormPage : BasePage<CategoryFormPage>
    {
        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.Categories);
            CategoryPage.Instance.Add.MouseClick();
        }

        public void FillForm(Categories category)
        {
            this.Browser.RefreshDomTree();
            this.Form.Wait.ForExists();
            this.Name.MouseClick();
            this.CleanInput(this.Name.Text);
            this.Browser.Desktop.KeyBoard.TypeText(category.Name);
            this.Order.MouseClick(MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);
            this.CleanInput(this.Order.Text);
            this.Browser.Desktop.KeyBoard.TypeText(category.Order.ToString());
        }

        internal void UpdateForm()
        {
            this.Browser.WaitUntilReady();
            this.Browser.RefreshDomTree();
            this.Update.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
        }
    }
}