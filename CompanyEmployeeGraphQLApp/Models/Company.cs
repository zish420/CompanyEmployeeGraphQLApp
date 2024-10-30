﻿namespace CompanyEmployeeGraphQLApp.Models
{
    public class Company
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
