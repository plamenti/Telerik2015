namespace TelerikAcademyLearningSystem.Core.Model
{
    using System.Collections.Generic;
    using Excel;

    public class Categories
    {
        public Categories(string name, string order)
        {
            this.Name = name;
            this.Order = order;
        }
        
        public Categories(IList<Cell> excelRoww)
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
                this.Order = string.Empty;
            }
            else
            {
                this.Order = excelRoww[1].Text;
            }
        }

        public string Name { get; set; }

        public string Order { get; set; }

        public int Id { get; set; }
    }
}
