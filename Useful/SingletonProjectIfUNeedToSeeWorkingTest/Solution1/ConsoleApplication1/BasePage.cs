namespace TelerikAcademyLearningSystem.Core.Base
{
    using System.Windows.Forms;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;
    using System;

    public abstract class BasePage<T> : HtmlElementContainer
        where T : new()
    {
        public BasePage(string url)
            : base(Manager.Current.ActiveBrowser.Find)
        {
            this.url = url;
        }

        public BasePage()
            : base(Manager.Current.ActiveBrowser.Find)
        {
            this.url = null;
        }

        //public const string Categories = @"http://stage.telerikacademy.com/Administration_Courses/CourseInstanceCategories";
        protected readonly string url;
        private static T instance;
        private static readonly object lockObject = new object();
        //private static readonly Lazy<T> lazy = new Lazy<T>(() => new T());

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
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

        public string Url
        {
            get
            {
                return this.url;
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
            this.Browser.NavigateTo(this.url);
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