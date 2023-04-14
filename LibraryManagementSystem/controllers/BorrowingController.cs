using LibraryManagementSystem.dto;
using LibraryManagementSystem.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.controllers
{



    [ApiController]
    [Route("[controller]")]
    public class BorrowingController : ControllerBase
    {
        private readonly IBorrowingRepository _borrowingRepository;

        public BorrowingController(IBorrowingRepository borrowingRepository)
        {
            this._borrowingRepository = borrowingRepository;

        }



        [HttpPost]
        public async Task<ActionResult> PostUser([FromBody] BorrowingDTO createBorrowing)
        {
            var newBorrowing = await _borrowingRepository.Create(createBorrowing);
            return Ok(newBorrowing);
        }
    }
}
