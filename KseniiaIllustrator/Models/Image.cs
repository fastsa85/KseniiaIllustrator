namespace KseniiaIllustrator.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public bool IsThumbnail { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
    }
}
