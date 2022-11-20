namespace KseniiaIllustrator.Models
{
    public class Project
    {
        public Guid Id { get; set; }       
        public Guid ThumbnailImageId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
    }
}
