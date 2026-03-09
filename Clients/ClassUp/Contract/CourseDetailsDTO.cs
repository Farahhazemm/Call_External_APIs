namespace Call_External_Service.Clients.ClassUp.Contract
{
    public class CourseDetailsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Level { get; set; } = null!;
        public decimal Price { get; set; }
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string? PreviewVideoUrl { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedAt { get; set; }

        #region Instructor Info

        public string InstructorId { get; set; }
        #endregion

        #region  Category Info
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        #endregion

        #region  Statistics

        public int TotalSections { get; set; }
        public int TotalEnrollments { get; set; }
        public int TotalReviews { get; set; }
        public double AverageRating { get; set; }
        #endregion
    }
}
