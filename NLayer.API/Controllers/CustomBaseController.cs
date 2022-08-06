using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction] //endpoint olmadığını belirtiyoruz. swagger endpoint olarak algılamayacak.
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode==204)
            
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            else
            {
                return new ObjectResult(response)
                {
                    StatusCode = response.StatusCode
                };
            }
        }
    }
}
