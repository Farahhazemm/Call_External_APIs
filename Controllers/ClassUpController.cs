using Call_External_Service.Clients.ClassUp;
using Call_External_Service.Clients.ClassUp.Contract;
using Call_External_Service.Clients.ClassUp.Contract.Filter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Call_External_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassUpController(IClassUpClient classUpClient) : ControllerBase
    {
        [HttpGet("Courses")]
        public async Task<IActionResult> GetCourses()
        {
            var courses = await classUpClient.GetCourses();
            return Ok(courses);

        }

        [HttpGet("Course/{id}")]
        public async Task<IActionResult> GetCourseById([FromRoute]int id)
        {
            var course = await classUpClient.GetCourseById(id);
            return Ok(course);

        }

        [HttpGet("Categorises")]
        public async Task<IActionResult> GetCategorises([FromQuery] FilterOptions filter)
        {
            var Categorises = await classUpClient.GetCategorise(filter);
            return Ok(Categorises);

        }

        [HttpPost("Account-login")]
        public async Task<IActionResult> GetToken([FromBody] LoginDTO dTO)
        {
            var Token = await classUpClient.Login(dTO);
            return Ok(Token);

        }
    }
}
