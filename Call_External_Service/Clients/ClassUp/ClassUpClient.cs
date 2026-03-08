using Call_External_Service.Clients.ClassUp.Contract;

namespace Call_External_Service.Clients.ClassUp
{
    public class ClassUpClient(IHttpClientFactory httpClientFactory) : IClassUpClient
    {
        public async Task <IEnumerable<AllCoursesDTO>> GetCources()
        {
            var httpclient = httpClientFactory.CreateClient("ClassUp");
            var paginatedCourses = await httpclient.GetFromJsonAsync<PaginatedListDTO<AllCoursesDTO>>("/api/Courses/GetAllCourses");
            var courses = paginatedCourses.Items;
            return courses ?? [];

        }
    }
}
