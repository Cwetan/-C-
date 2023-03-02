using Microsoft.AspNetCore.Mvc;
using Project.bl.Interfaces;
using Project.bl.Services;
using Project.Models.Data;

namespace project_1._1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly IAutorServices _autorService;
        public AutorController(IAutorServices autorService)
        {
            _autorService = autorService;
        }
        [HttpGet("GetAll")]

        public IEnumerable<Autor> GetAll()
        {
        return _autorService.GetAll();
        }
    }
}