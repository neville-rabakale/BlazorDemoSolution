using BlazorDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Models
{
    public class DataService
    {
        private readonly BlazorDemoContext context;

        public DataService(BlazorDemoContext context)
        {
            this.context = context;
        }

        public async Task AddPersonAsync(DisplayPersonModel model)
        {
            await context.People.AddAsync(new Person
            {
                FirstName= model.FirstName,
                LastName= model.LastName,
                Email= model.Email,
            });
            await context.SaveChangesAsync();
        }

        public async Task<Person[]> GetAllPeopleAsync()
        {
            return await context.People.ToArrayAsync();
        }
    }
}
