using Shared.Models;

namespace KseniiaIllustrator.Services
{
    public class ProjectsDataService : IProjectsDataService
    {
        public List<ProjectPreview> GetAllProjectPreviews()
        {
            return new List<ProjectPreview>() {
                new ProjectPreview { Id = new Guid("38d4d731-343f-47ee-9522-fc6a80aa7719"), Thumbnail = "./images/project1.jpg" },
                new ProjectPreview { Id = new Guid("13f7a3d8-d6ee-4b1b-867a-04f8b52c2b23"), Thumbnail = "./images/project2.jpg" },
                new ProjectPreview { Id = new Guid("3c92a917-5c09-48ed-8b2a-010134d04a04"), Thumbnail = "./images/project3.jpg" },
                new ProjectPreview { Id = new Guid("38d4d731-343f-47ee-9522-fc6a80aa7719"), Thumbnail = "./images/project4.gif" },
                new ProjectPreview { Id = new Guid("13f7a3d8-d6ee-4b1b-867a-04f8b52c2b23"), Thumbnail = "./images/project5.jpg" },
                new ProjectPreview { Id = new Guid("3c92a917-5c09-48ed-8b2a-010134d04a04"), Thumbnail = "./images/project6.gif" },
                new ProjectPreview { Id = new Guid("38d4d731-343f-47ee-9522-fc6a80aa7719"), Thumbnail = "./images/project1.jpg" },
                new ProjectPreview { Id = new Guid("13f7a3d8-d6ee-4b1b-867a-04f8b52c2b23"), Thumbnail = "./images/project2.jpg" }
            };
        }
    }
}
