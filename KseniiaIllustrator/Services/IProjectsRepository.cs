using KseniiaIllustrator.Models;

namespace KseniiaIllustrator.Services
{
    public interface IProjectsRepository
    {
        List<ProjectPreview> GetAllProjectPreviews();
    }
}
