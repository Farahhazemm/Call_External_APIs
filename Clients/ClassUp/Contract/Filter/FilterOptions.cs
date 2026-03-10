namespace Call_External_Service.Clients.ClassUp.Contract.Filter
{
    public class FilterOptions
    {
        #region Filtering
        public string? FilterBy { get; set; }
        public string? FilterValue { get; set; } 
        #endregion

        #region Sorting
        public string? SortBy { get; set; }
        public string SortOrder { get; set; } = "asc";
        #endregion

        #region Pagination
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        #endregion

    }
}
