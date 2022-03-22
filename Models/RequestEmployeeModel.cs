namespace xxXXXxxx
{
    public class RequestEmployeeModel
    {
         public RequestEmployeeModel()
        {
            substring = null;
            limit = 1;
            guidList = null;
        }
        public string? substring { get; set; }
        public int? limit { get; set; }
        public Guid[]? guidList { get; set; }
        
    }
}
