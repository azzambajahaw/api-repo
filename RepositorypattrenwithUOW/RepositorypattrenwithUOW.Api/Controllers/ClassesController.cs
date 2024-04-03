using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositorypattrenwithUOW.Core;
using RepositorypattrenwithUOW.Core.Interfaces;
using RepositorypattrenwithUOW.Core.Models;

namespace RepositorypattrenwithUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        //private readonly IBaseRepository<Classe> _classeRepository;
        //public ClassesController(IBaseRepository<Classe> classeRepository)
        //{
        //    _classeRepository = classeRepository;
        //}
        private readonly IUnitOfWork _unitOfWork;
        public ClassesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public IActionResult GetAll(/*int id*/)
        {
            try
            {
                //ApiResponse apiResponse = new ApiResponse();
                apiResponse.Data = _unitOfWork.Classes.GetById(1);
                apiResponse.Erorrs = null;
                apiResponse.StatusCode = "200";
                return Ok(apiResponse); 

            }
            catch(Exception ex)
            { 
                ApiResponse apiResponse = new ApiResponse();
                apiResponse.Data = null;
                apiResponse.Erorrs = ex;
                apiResponse.StatusCode = "502";
                return Ok(apiResponse); 

            }

            //return Ok(_unitOfWork.Classes.GetById(1));
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetByIdAsync(/*int id*/)
        { 
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.Data =  await _unitOfWork.Classes.GetByIdAsync(1);
            apiResponse.Erorrs = null;
            apiResponse.StatusCode = "200";
            return Ok(apiResponse);

            //var classe = await _unitOfWork.Classes.GetByIdAsync(1);
            //return Ok(classe);
        }

        [HttpGet("All")]
        public IActionResult GetALl()
        {
            var classe = _unitOfWork.Classes.GetAll();
            return Ok(classe);
        }

        [HttpGet("Byname")]
        public IActionResult GetByName(/*string name*/)
        {
            var classe = _unitOfWork.Classes.Find(c => c.name == "oneA");
            //if asve is needed
            //_unitOfWork.Complate();
            return Ok(classe);
        }
        [HttpPost]
        public IActionResult ADD(/*Classe classe*/)
        {
            try
            {
                ApiResponse apiResponse = new ApiResponse();
                apiResponse.Data = "done";
                apiResponse.Erorrs = null;
                apiResponse.StatusCode = "200";
                return Ok(apiResponse); 
            }
            catch (Exception ex)    
            {
                ApiResponse apiResponse = new ApiResponse();
                apiResponse.Data = null;
                apiResponse.Erorrs = ex;
                apiResponse.StatusCode = "502";
                return Ok(apiResponse); 

            }


        }



    }
}
