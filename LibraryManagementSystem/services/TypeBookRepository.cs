using LibraryManagementSystem.Context;
using LibraryManagementSystem.dto;
using LibraryManagementSystem.models.Entity;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.services
{
    public class TypeBookRepository : ITypeBookRepository
    {
        private readonly LibraryManagementSystemDbContext _context;

        public TypeBookRepository(LibraryManagementSystemDbContext context)
        {
            _context = context;
        }
        //CREATE
        public async Task<TypeBookDTO> Create(CreateTypeBook createTypeBook)
        {
            DateTime currentDate = DateTime.Now;
            var createData = new TypeBook()
            {
                Type_ID = createTypeBook.Type_ID,
                Type = createTypeBook.Type,
                Date_created = currentDate,
                Date_updated = currentDate,
            };
            _context.TypeBook.Add(createData);
            await _context.SaveChangesAsync();
            var data = new TypeBookDTO()
            {
                Type_ID = createTypeBook.Type_ID,
                Type = createTypeBook.Type,
                Date_created = currentDate,
                Date_updated = currentDate,
            };
            return data;
        }
        //UPDATE
        public async Task Update(PutTypeBook putTypeBook)
        {
            DateTime currentDate = DateTime.Now;
            var createData = new TypeBook()
            {
                Type_ID = putTypeBook.Type_ID,
                Type = putTypeBook.Type,
                Date_updated = currentDate,
            };
            _context.Entry(createData).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        //DELETE
        public async Task Delete(int Type_ID)
        {
            var typebookToDelete = await _context.TypeBook.FindAsync(Type_ID);
            _context.TypeBook.Remove(typebookToDelete);
            await _context.SaveChangesAsync();
        }
    }
}

