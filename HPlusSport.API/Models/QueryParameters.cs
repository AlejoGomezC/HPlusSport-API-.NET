namespace HPlusSport.API.Models
{
    public class QueryParameters
    {

        const int _maxSize = 100;

        public int Page { get; set; }

        public int PageSize { get; set; }
    }
}
