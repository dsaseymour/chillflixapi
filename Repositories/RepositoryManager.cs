using System;
using Contracts;
using Entities;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryManager:IRepositoryManager
    {

        private ChillflixapiContext _repositoryContext;
        private ILikeRepository _likeRepository;
        private IMatchRepository _matchRepository;
        private IMediaRepository _mediaRepository;
        private IPhotoRepository _photoRespository;
        private IUserRepository _userRepository;
        private IAuthRepository _authRepository;
        private IPostRepository _postRepository;
        private IProfileRepository _profileRepository;

        public RepositoryManager(ChillflixapiContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ILikeRepository Like
        {
            get
            {
                if (_likeRepository == null)
                    _likeRepository = new LikeRepository(_repositoryContext);

                    return _likeRepository;
            }
        }


        public void SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
