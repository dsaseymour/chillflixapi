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
                //GetAll(trackChanges: false);
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(usersFromDb);
            return usersDto;
        }


        public async Task<UserDto> GetUser(int id)
        {
            var userFromDb = await _repositorymanager.User.GetUserAsync(id);
            var userDto= _mapper.Map<UserDto>(userFromDb);
            return userDto;
        }


        public void DeleteUser(int id)
        {
            //Delete(id);

            //var user = HttpContext.Items["user"] as User;

            //_DeleteEmployee(employeeForCompany);

            //            await _repositorymanager.SaveAsync();
            //             return NoContent();

        }

        public void UpdateUser(User user)
        {


            //            await _repositorymanager.SaveAsync();
            //             return NoContent();
        }

    }
}
