using Call_External_Service.Clients.ClassUp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Call_External_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassUpController(IClassUpClient classUpClient) : ControllerBase
    {
        [HttpGet("Courses")]
        public async Task<IActionResult> GetCources()
        {
            var courses = await classUpClient.GetCources();
            return Ok(courses);

        }
    }
}
