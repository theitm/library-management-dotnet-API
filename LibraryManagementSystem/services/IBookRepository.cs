using LibraryManagementSystem.dto;
using LibraryManagementSystem.models;
using Microsoft.AspNetCore.Mvc;
//using static LibraryManagementSystem.models.Users;

namespace LibraryManagementSystem.services
{
    public interface IBookRepository


    {
        Task<List<books>> Get();

        //Task<List<Books>> Get();
        //Task<Books> GetById(int id);

        //Task<IEnumerable<books>> Get();
        //Task<books> GetById(int id);
        Task<Books> CreateBook(Books books);
        Task<object> EditBook(int id, PutBooks books);
        Task Delete(int id);
        Task<IQueryable<books>> GetSearchBook(string title, string author);


        //Task Update(PutBooks PutBooks);
        //Task Delete(int id);

    }

}



