using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositorypattrenwithUOW.Core.Interfaces;
using RepositorypattrenwithUOW.Core;
using RepositorypattrenwithUOW.Core.Models;

namespace RepositorypattrenwithUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelsController : ControllerBase
    {
        //private readonly IBaseRepository<Level> _levelRepository;
        //public LevelsController(IBaseRepository<Level> levelRepository)
        //{
        //    _levelRepository = levelRepository;
        //}
        
        private readonly IUnitOfWork _unitOfWork;
        public LevelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    return Ok(_levelRepository.GetById(1));
        //}
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_unitOfWork.Levels.GetById(1));
        }
    }
}
