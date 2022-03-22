namespace xxXXXxxx
{
    public record EmployeeDto
    {
        public Guid Id { get; set; }
        public string? LastName { get; set; }
        public string? FirsName { get; set; }
        public string? MiddleName { get; set; }       
        public string? Title { get; set; }
        public string? OrgName { get; set; }
        public string? EmpMotherOrgName { get; set; }
    }
}
