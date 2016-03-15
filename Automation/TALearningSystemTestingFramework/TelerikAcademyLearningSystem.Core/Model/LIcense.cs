namespace TelerikAcademyLearningSystem.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class License
    {
        public License(string name, string url, string link)
        {
            this.Name = name;
            this.Url = url;
            this.Link = link;
        }

        public string Name { get; set; }

        public string Url { get; set; }

        public string Link { get; set; }
    }
}
