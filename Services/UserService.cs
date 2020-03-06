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

        public async Task<IEnumerable<UserDto>> GetUserCollection(IEnumerable<int> ids)
        {
            
            var userEntities = _repositorymanager.User.GetByIdsAsync(ids, trackChanges: false);
            if(ids.Count() != userEntities.Count()) 
            {
            _logger.LogError("Some ids are not valid in a collection"); 
            return null;
            } 

            var usersToReturn = _mapper.Map<IEnumerable<UserDto>>(userEntities);
            return usersToReturn;
        }
        #endregion 


        public async Task<UserDto> CreateUser(UserForCreationDto user)
        {
            var userEntity = _mapper.Map<User>(user);
            _repositorymanager.User.CreateUser(userEntity);
            await _repositorymanager.SaveAsync();
            var userToReturn = _mapper.Map<UserDto>(userEntity);
            return  userToReturn;
        }



        public async Task DeleteUser(int id)
        {
            var user = await _repositorymanager.User.GetUserAsync(id, trackChanges: false);
            if(user == null)
            {
                _logger.LogInfo($"Company with id: {id} doesn't exist in the database.");
                return;
            }
            _repositorymanager.User.DeleteUser(user);
            await _repositorymanager.SaveAsync();
        }

        #region updateusers-service definition  
        //PUT update
        //returning user entity to calling function in controller just so it can check == null and send status if not found
        public async Task<User> UpdateUser( int id, UserForUpdateDto employee)
        {
            var userEntity = await _repositorymanager.User.GetUserAsync(id, trackChanges: true);
            if(userEntity == null)
            {
                return null;
            }
            await _repositorymanager.SaveAsync();
            return userEntity;
        }

        //PATCH update
        public async Task PartialUpdateUser(int userId, JsonPatchDocument<UserForUpdateDto> patchDoc)
        {
             var userEntity = await _repositorymanager.User.GetUserAsync(userId, trackChanges: false);
            if (userEntity == null)
            {
                _logger.LogInfo($"User with id: {userId} doesn't exist in the database.");
            }

            var userToPatch = _mapper.Map<UserForUpdateDto>(userEntity);

            patchDoc.ApplyTo(userToPatch, ModelState);

            //TryValidateModel(userToPatch);

         //   if(!ModelState.IsValid)
           // {
             //   _logger.LogError("Invalid model state for the patch document");
              //  return UnprocessableEntity(ModelState);
           // }

            _mapper.Map(userToPatch, userEntity);

            await _repositorymanager.SaveAsync();
        }
        #endregion
    }
}
