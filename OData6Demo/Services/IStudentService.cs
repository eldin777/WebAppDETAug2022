using OData6Demo.Models;

namespace OData6Demo.Services
{
    public interface IStudentService
    {
        IQueryable<Student> RetrieveAllStudents();
    }
}
