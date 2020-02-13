using System;
using Repositories;
using Contracts;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Services;

namespace Services
{
    public class UserService
    {
        private readonly IRepositoryManager _repositorymanager;
        private readonly IMapper _mapper;

        public UserService(IRepositoryManager repositorymanager,IMapper mapper)
        {
            _repositorymanager = repositorymanager;
            _mapper = mapper;
        }



        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            var usersFromDb = await _repositorymanager.User.GetAllUsersAsync(trackChanges: false);
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(usersFromDb);
            return usersDto;
        }


        public async Task<UserDto> GetUserAsync(int id)
        {
            var userFromDb = await _repositorymanager.User.GetUserAsync(id,trackChanges: false);
            var userDto= _mapper.Map<UserDto>(userFromDb);
            return userDto;
        }


        public void CreateUser(User user)
        {
            if (user == null)
            {

            }


        }



        public void DeleteUser(int id)
        {
            //Delete(id);

            //var user = HttpContext.Items["user"] as User;

            //_DeleteEmployee(employeeForCompany);

            //            await _repositorymanager.SaveAsync();
            //             return NoContent();

        }

        public void UpdateUser(int user)
        {


            //            await _repositorymanager.SaveAsync();
            //             return NoContent();
        }


        public void PartialUpdateUser(int id)
        {


        }
    }
}
