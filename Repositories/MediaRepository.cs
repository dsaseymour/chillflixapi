using System;
namespace Repositories
{
    public class MediaRepository:RepositoryBase<Media>,IMediaRepository
    {
        public MediaRepository(Chillflixapicontext repositoryContextoodf):base(Chillflixapicontext repositoryContext)
        {
        }
    }
}
