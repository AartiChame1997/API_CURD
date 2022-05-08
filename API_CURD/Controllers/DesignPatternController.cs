using API_CURD.GenericRepo;
using API_CURD.Infrastrcture;
using API_CURD.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CURD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DesignPatternController : ControllerBase
  {
        //    private readonly IRepo<Project> _project;
        //    private readonly IRepo<Developer> _developer;
        //    public DesignPatternController(IRepo<Project> project,IRepo<Developer> developer)
        //    {
        //        _project = project;
        //        _developer = developer;
        //    }

        //private readonly IRepo<Project> _repo;
        //public DesignPatternController(IRepo<Project> repo)
        // {
        //         _repo = repo;

        // }
        //     [HttpGet]
        //     [Route("Get")]
        //     public IActionResult getdata()
        //     {
        //         try
        //         {
        //             var res = _repo.Getdata();
        //             return Ok(res);
        //         }
        //         catch(Exception)
        //         {
        //             return NotFound();
        //         }
        //     }

        //     [HttpGet]
        //     [Route("GetById")]
        //     public IActionResult GetById(int id)
        //     {
        //         if(id==null)
        //         {
        //             return NotFound();
        //         }
        //         try
        //         {
        //             var res = _repo.GetDataById(id);
        //             return Ok(res);
        //         }
        //         catch (Exception)
        //         {
        //             return NotFound();
        //         }
        //     }
        //     [HttpPost]
        //     [Route("PostData")]
        //     public IActionResult PostData([FromBody] Project project)
        //     {
        //         try
        //         {
        //              _repo.AddData(project);
        //             return Ok();
        //         }
        //         catch (Exception)
        //         {
        //             return NotFound();
        //         }
        //     }

        private readonly IUnitOfWork _unitOfWork;
        public DesignPatternController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("GetAllData")]
        public IActionResult GetProduct()
        {
            try
            {
                var res = _unitOfWork.Products.GetAllProduct();
                if(res!=null)
                {
                    return Ok(res);
                }
                return NotFound();
            }
            catch(Exception)
            {
                return BadRequest();
            }

        }

    }
}
