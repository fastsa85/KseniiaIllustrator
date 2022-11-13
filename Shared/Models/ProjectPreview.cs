using System;

namespace Shared.Models
{
    public class ProjectPreview
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string PreviewDescription { get; set; }
        public string Thumbnail { get; set; }
    }
}
