using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
     /*creates instances of repository classes 
     *registers those repository instances in the dependency injection container
     *allows us to call any class needed
     * repository base class will not savechanges
     * repository manager is responsible for saving changes made by repositories
     * the repository save method is used after modifications are finished for an object
     * the repository manager can be used to fetch and multiple repositories and make multiple modifications
     * while making one save call
     *
     *
     * example usage
     * IRepositoryManager _repository= new RepositoryManager(rContext);
     * _repository.User.Create(user);
     * 
     * */
        ILikeRepository Like { get; }
        IMatchRepository Match { get; }
        IMediaRepository Media { get; }
        IPhotoRepository Photo { get; }
        IUserRepository User { get; }
        IAuthRepository Auth { get; }
        IPostRepository Post { get; }
        IProfileRepository Profile { get; }
        Task SaveAsync();

    }
}
