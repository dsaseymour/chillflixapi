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

        public IMatchRepository Match
        {
            get
            {
                if (_matchRepository == null)
                    _matchRepository = new MatchRepository(_repositoryContext);

                return _matchRepository;
            }
        }




        public IMediaRepository Media
        {
            get
            {
                if (_mediaRepository == null)
                    _mediaRepository = new MediaRepository(_repositoryContext);

                return _mediaRepository;
            }
        }

        public IPhotoRepository Photo
        {
            get
            {
                if (_photoRespository == null)
                    _photoRespository = new PhotoRepository(_repositoryContext);

                return _photoRespository;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_repositoryContext);

                return _userRepository;
            }
        }

 

        public IAuthRepository Auth
        {
            get
            {
                if (_authRepository == null)
                    _authRepository = new AuthRepository(_repositoryContext);

                return _authRepository;
            }
        }

        public IPostRepository Post
        {
            get
            {
                if (_postRepository == null)
                    _postRepository = new PostRepository(_repositoryContext);

                return _postRepository;
            }
        }

        public IProfileRepository Profile
        {
            get
            {
                if (_profileRepository == null)
                    _profileRepository = new ProfileRepository(_repositoryContext);

                return _profileRepository;
            }
        }



        public void SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
