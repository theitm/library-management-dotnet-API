using LibraryManagementSystem.dto;
using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
//using static LibraryManagementSystem.models.Users;

namespace LibraryManagementSystem.services
{
    public interface IBookRepository


    {
        Task<List<books>> Get();

        
        Task<Books> CreateBook(Books books);
        Task<object> EditBook(int id, PutBooks books);
        Task Delete(int id);
        Task<IQueryable<books>> GetSearchBook(string title, string author);


        

    }

}



