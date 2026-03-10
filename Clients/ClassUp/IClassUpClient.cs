using Call_External_Service.Clients.ClassUp.Contract;
using Call_External_Service.Clients.ClassUp.Contract.Filter;
using Refit;

namespace Call_External_Service.Clients.ClassUp
{
    public interface IClassUpClient
    {
        [Get("/api/Courses/GetAllCourses")] // refit make an servic code
        Task<PaginatedListDTO<AllCoursesDTO>> GetCourses();
        [Get("/api/Courses/{id}")]
        Task<CourseDetailsDTO> GetCourseById(int id);

        [Get("/api/Categorise")]
        Task<object> GetCategorise([Query] FilterOptions filter);

        [Post("/api/Account/login")]
        Task<object>  Login([Body] LoginDTO loginDTO);
    }
}
