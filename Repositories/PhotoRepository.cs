﻿using System;
using Contracts;
using Entities;
using Entities.Models;
namespace Repositories
{
    public class PhotoRepository:RepositoryBase<PhotoRepository>,IPhotoRepository
    {
        public PhotoRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {
        }
    }
}