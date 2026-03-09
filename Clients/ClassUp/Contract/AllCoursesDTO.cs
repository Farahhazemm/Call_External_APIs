namespace Call_External_Service.Clients.ClassUp.Contract
{
    public class AllCoursesDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }
        public string Level { get; set; } = null!;
        public string Language { get; set; } = null!;
        public bool IsActive { get; set; }
        public string InstructorId { get; set; } = null!;
        public string ThumbnailUrl { get; set; } = null!;
        public int CategoryId { get; set; }
    }
}
