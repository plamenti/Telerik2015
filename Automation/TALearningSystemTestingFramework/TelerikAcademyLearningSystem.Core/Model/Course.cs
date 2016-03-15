namespace TelerikAcademyLearningSystem.Core.Model
{
    public class Course
    {
        public Course()
        {
        }

        public Course(string nameBg, string nameEn, string urlName, string description, string color, string order)
            : base()
        {
            this.NameBg = nameBg;
            this.NameEn = nameEn;
            this.UrlName = urlName;
            this.Description = description;
            this.Color = color;
            this.Order = order;
        }

        public string Description { get; set; }

        public string NameBg { get; set; }

        public string NameEn { get; set; }

        public string UrlName { get; set; }

        public string Color { get; set; }

        public string Order { get; set; }

        public int Id { get; set; }
    }
}
