using Pschool.Models;

namespace Pschool.Data.Services
{

    public interface IParentsService
    {
        Task<IEnumerable<Parent>> GetAll();
        Task Add(Parent parent);
    }
}