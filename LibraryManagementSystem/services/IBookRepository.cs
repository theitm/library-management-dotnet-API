using LibraryManagementSystem.models.Entity;
using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.dto;


namespace LibraryManagementSystem.services
{
    public interface IBookRepository


    {
        Task<List<Book>> Get();


        Task<BookDTO> CreateBook(BookDTO books);
        Task<object> EditBook(int id, PutBook books);
        Task Delete(int id);
        Task<IQueryable<Book>> GetSearchBook(string Title, string Author);




    }

}



