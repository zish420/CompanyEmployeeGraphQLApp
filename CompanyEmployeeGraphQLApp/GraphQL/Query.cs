using CompanyEmployeeGraphQLApp.Data;
using CompanyEmployeeGraphQLApp.Models;

namespace CompanyEmployeeGraphQLApp.GraphQL
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Company> GetCompanies([Service] AppDbContext context) => context.Companies;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Employee> GetEmployees([Service] AppDbContext context) => context.Employees;
    }
}
