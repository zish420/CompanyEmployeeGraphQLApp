using CompanyEmployeeGraphQLApp.Data;
using CompanyEmployeeGraphQLApp.Models;

namespace CompanyEmployeeGraphQLApp.GraphQL
{
    public class Mutation
    {
        public async Task<Company> AddCompanyAsync(Company company, [Service] AppDbContext context)
        {
            try
            {
            context.Companies.Add(company);
            await context.SaveChangesAsync();
            return company;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding company: {ex.Message}");
                throw new GraphQLException($"An error occurred: {ex.Message}");
            }
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee, [Service] AppDbContext context)
        {
            context.Employees.Add(employee);
            await context.SaveChangesAsync();
            return employee;
        }
    }
}
