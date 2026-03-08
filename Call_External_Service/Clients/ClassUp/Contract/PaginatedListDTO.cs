namespace Call_External_Service.Clients.ClassUp.Contract
{
    public class PaginatedListDTO<T>
    {
        public List<T> Items { get; set; } = new();
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
    }
}
