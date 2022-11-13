using Shared.Models;

namespace KseniiaIllustrator.Services
{
    public interface IProjectsDataService
    {
        List<ProjectPreview> GetAllProjectPreviews();
    }
}
