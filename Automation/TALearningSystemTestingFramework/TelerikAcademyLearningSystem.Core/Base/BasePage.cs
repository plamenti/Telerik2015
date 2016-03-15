namespace TelerikAcademyLearningSystem.Core.Base
{
    using System.Windows.Forms;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;

    public abstract class BasePage<T> : HtmlElementContainer
        where T : new()
    {
        protected readonly string UrlBaseField;
        private static readonly object LockObject = new object();
        private static T instance;

        public BasePage()
            : base(Manager.Current.ActiveBrowser.Find)
        {
            this.UrlBaseField = null;
        }

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (LockObject)
                    {
                        if (instance == null)
                        {
                            instance = new T();
                        }
                    }
                }

                return instance;
            }
        }

        public string UrlBase
        {
            get
            {
                return this.UrlBaseField;
            }
        }

        public Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

        public virtual void Navigate()
        {
            this.Browser.NavigateTo(this.UrlBase);
        }

        public virtual void CleanInput(string inputText)
        {
            for (int i = 0; i <= inputText.Length + 5; i++)
            {
                this.Browser.Desktop.KeyBoard.KeyPress(Keys.Back);
            }
        }
    }
}