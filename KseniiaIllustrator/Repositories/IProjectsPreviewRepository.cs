

using KseniiaIllustrator.Models;

namespace KseniiaIllustrator.Repositories
{
    public interface IProjectsPreviewRepository
    {
        IEnumerable<ProjectPreview> GetAllProjectPreviews();
    }
}
