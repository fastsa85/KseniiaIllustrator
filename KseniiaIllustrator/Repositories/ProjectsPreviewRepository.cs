using KseniiaIllustrator.Data;
using KseniiaIllustrator.Models;

namespace KseniiaIllustrator.Repositories
{
    public class ProjectsPreviewRepository : IProjectsPreviewRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProjectsPreviewRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ProjectPreview> GetAllProjectPreviews()
        {
           
            foreach (var project in _appDbContext.Projects.ToList())
            {
                yield return new ProjectPreview
                {
                    Id = project.Id,
                    Title = project.Title,
                    ShortDescription = project.ShortDescription,
                    ThumbnailImage = _appDbContext.Images.Where(x => x.Id == project.ThumbnailImageId).FirstOrDefault().FileName
                };
            }

            //return new List<Project>() {
            //    new Project { Id = new Guid("38d4d731-343f-47ee-9522-fc6a80aa7719"), Title = "Wednesday with Goddard", ShortDescription = "Nicolas Ménard", ThumbnailImageId = "./images/project1.jpg" },
            //    new Project { Id = new Guid("13f7a3d8-d6ee-4b1b-867a-04f8b52c2b23"), Title = "Stephen Kelleher", ShortDescription = "Offset", ThumbnailImageId = "./images/project2.jpg" },
            //    new Project { Id = new Guid("3c92a917-5c09-48ed-8b2a-010134d04a04"), Title = "Rigging Academy", ShortDescription = "Lorem ipsur", ThumbnailImageId = "./images/project3.jpg" },
            //    new Project { Id = new Guid("38d4d731-343f-47ee-9522-fc6a80aa7719"), Title = "School of Motion", ShortDescription = "Buck", ThumbnailImageId = "./images/project4.gif" },
            //    new Project { Id = new Guid("13f7a3d8-d6ee-4b1b-867a-04f8b52c2b23"), Title = "First Step", ShortDescription = "Hive", ThumbnailImageId = "./images/project5.jpg" },
            //    new Project { Id = new Guid("3c92a917-5c09-48ed-8b2a-010134d04a04"), Title = "Adventure Time", ShortDescription = "Animation", ThumbnailImageId = "./images/project6.gif" },
            //    new Project { Id = new Guid("38d4d731-343f-47ee-9522-fc6a80aa7719"), Title = "World Basketball Festival", ShortDescription = "Buck", ThumbnailImageId = "./images/project1.jpg" },
            //    new Project { Id = new Guid("13f7a3d8-d6ee-4b1b-867a-04f8b52c2b23"), Title = "I'm Fine Thanks", ShortDescription = "Factory", ThumbnailImageId = "./images/project2.jpg" }
            //};
        }
    }
}
