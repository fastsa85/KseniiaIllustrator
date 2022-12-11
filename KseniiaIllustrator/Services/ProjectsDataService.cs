using KseniiaIllustrator.Data;
using KseniiaIllustrator.Models;

namespace KseniiaIllustrator.Services
{
    public class ProjectsDataService : IProjectsRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public ProjectsDataService(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<ProjectPreview> GetAllProjectPreviews() =>
            _appDbContext.Projects.Select(p => new ProjectPreview
            {
                Id = p.Id,
                Title = p.Title,
                PreviewDescription = p.PreviewDescription,
                Thumbnail = _appDbContext.Images.Where(i => i.ProjectId == p.Id && i.IsThumbnail).FirstOrDefault().FileName
            }).ToList();
    }
}
