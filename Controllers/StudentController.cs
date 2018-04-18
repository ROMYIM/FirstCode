using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstCode.Models;
using FirstCode.DbContexts;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using FirstCode.Constants;

namespace FirstCode.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly FirstCodeContext _context;

        private readonly ILogger<StudentController> _logger;

        public StudentController(FirstCodeContext context, ILogger<StudentController> logger) 
        {
            this._context = context;
            this._logger = logger;
        }

        [HttpPost("login")]
        public IActionResult Login(Student student)
        {
            ResponseResult result = new ResponseResult(ResultCode.ResponseFailCode);
            if (ModelState.IsValid)
            {
                Student studentTemp = _context.Student.Find(student.Id);
                if (studentTemp != null)
                {
                    if (studentTemp.Password == student.Password)
                    {
                        result.SetResult(ResultType.SUCCESS);
                    }
                    else
                    {
                        result.SetResult(ResultType.FAIL);
                    }
                }
                else
                {
                    result.SetResult(ResultType.FAIL).Info = ErrorMessage.EmptyUser;
                }
                return new JsonResult(result);
            }
            return BadRequest(ModelState);
        }
    }
}