using LibraryManagementSystem.models.Entity;
using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.dto;

namespace LibraryManagementSystem.services
{
    public interface IUserRepository

    {
        Task<IQueryable<User>> GetSearchUser(string Name);
    }
}