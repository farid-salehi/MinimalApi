using MinimalApi.Domain.Models;

namespace MinimalApi.Domain.Infrastructure.Interfaces
{
    public interface IToDoRepository
    {
        Task Add(ToDo todo);
        Task<List<ToDo>> GetItems();
        Task<ToDo?> GetItem(Guid id);
    }
}