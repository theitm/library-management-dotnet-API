using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementSystem.models;
using LibraryManagementSystem.dto;
using System.Security.Policy;
using LibraryManagementSystem.services;
using LibraryManagementSystem.models.Entity;

namespace LibraryManagementSystem.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class searchUserController : ControllerBase
    {
        private readonly IUserRepository SearchUserRepository;
        public searchUserController(IUserRepository SearchUserRepository)
        {
            this.SearchUserRepository = SearchUserRepository;
        }

        [HttpGet("search")]
        public async Task<IQueryable<User>> GetSearchUsers(string Name)
        {
            return await SearchUserRepository.GetSearchUser(Name);
        }
    }
}
