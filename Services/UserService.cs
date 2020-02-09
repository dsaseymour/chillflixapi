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

        public IQueryable<UserDto> GetAllUsers()
        {
            var users = _repositorymanager.User.GetAllUsers(trackChanges: false);
                
                //GetAll(trackChanges: false);

            var usersDto = _mapper.Map<IQueryable<UserDto>>(users);

            return usersDto;
        }

        public UserDto GetUser(int id)
        {

        }

        public void DeleteUser(int id)
        {
            //Delete(id);

            //var user = HttpContext.Items["user"] as User;

            //_DeleteEmployee(employeeForCompany);
           // await _repository.SaveAsync();


        }

        public void UpdateUser(User user)
        {


        }


    }
}
