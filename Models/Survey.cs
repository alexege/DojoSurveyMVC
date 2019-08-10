namespace DojoSurvey.Models
{
    public class Survey
    {
        public string Name {get; set;}
        public string Location { get; set; }
        public string Language { get; set; }
        public string Comment { get; set; }
    
        public Survey()
        {

        }

        public Survey(string Name, string Location, string Language, string Comment)
        {
            this.Name = Name;
            this.Location = Location;
            this.Language = Language;
            this.Comment = Comment;
        }
    }
}