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
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserService(IRepositoryManager repositorymanager,ILoggerManager logger,IMapper mapper)
        {
            _repositorymanager = repositorymanager;
            _mapper = mapper;
            _logger=logger;
        }

        #region getusers-service definition  
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

        public async Task<IEnumerable<UserDto>> GetUserCollection(IEnumerable<Guid> ids)
        {
            var userEntities = _repositorymanager.User.GetByIdsAsync(ids, trackChanges: false);
            if(ids.Count() != userEntities.Count()) 
            {
            _logger.LogError("Some ids are not valid in a collection"); 
            return NotFound();
            } 

            var userToReturn = _mapper.Map<IEnumerable<UserDto>>(userEntities);
        }
        #endregion 


        public async Task<UserDto> CreateUser(User user)
        {
            var userEntity = _mapper.Map<User>(user);
            _repositorymanager.User.CreateUser(userEntity);
            await _repositorymanager.SaveAsync();
            var userToReturn = _mapper.Map<UserDto>(userEntity);
            return  userToReturn;
        }



        public void DeleteUser(int id)
        {
            //Delete(id);

            //var user = HttpContext.Items["user"] as User;

            //_DeleteEmployee(employeeForCompany);

            //            await _repositorymanager.SaveAsync();
            //             return NoContent();

        }

        #region updateusers-service definition  
        public void UpdateUser(int user)
        {
                    await _repositorymanager.SaveAsync();
        }


        public void PartialUpdateUser(int id)
        {


        }
        #endregion
    }
}
