using System;
using Repositories;
using Contracts;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Services;

namespace Services
{
    public class UserService
    {
        private readonly IRepositoryManager _repository;

        public UserService(IRepositoryManager repository)
        {
            _repository = repository;

        }

        public async Task<IQueryable> GetAllUsers()
        {
            var users = await _repository.Company.GetAllCompaniesAsync(trackChanges: false);

            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);

            return await Ok(usersDto);
        }


    }
}
