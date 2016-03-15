namespace TelerikAcademyLearningSystem.Core.Model
{
    using Excel;
    using System.Collections.Generic;

    public class Instance
    {
        public Instance(string name, string desc, string course, string licence, string category, string copyLectures)
        {
            this.Name = name;
            this.Description = desc;
            this.Course = course;
            this.Licence = licence;
            this.Categiry = category;
            this.CopyLectures = copyLectures;
        }

        public Instance(IList<Cell> excelRoww)
        {
            if (excelRoww[0] == null)
            {
                this.Name = string.Empty;
            }
            else
            {
                this.Name = excelRoww[0].Text;
            }

            if (excelRoww[1] == null)
            {
                this.Description = string.Empty;
            }
            else
            {
                this.Description = excelRoww[1].Text;
            }
        }

        public int Id { get; set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Course { get; private set; }

        public string CopyLectures { get; private set; }

        public string Categiry { get; private set; }

        public string Licence { get; private set; }
    }
}
