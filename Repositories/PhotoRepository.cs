using System;
namespace Repositories
{
    public class PhotoRepository:RepositoryBase<PhotoRepository>,IPhotoRepository
    {
        public PhotoRepository(Chilloos):base(repositoryContext)
        {
        }
    }
}
qq