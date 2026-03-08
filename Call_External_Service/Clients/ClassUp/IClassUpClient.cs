using Call_External_Service.Clients.ClassUp.Contract;

namespace Call_External_Service.Clients.ClassUp
{
    public interface IClassUpClient
    {
        Task<IEnumerable<AllCoursesDTO>> GetCources();
    }
}
