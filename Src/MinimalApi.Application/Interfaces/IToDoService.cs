using MinimalApi.Domain.Dto;
using MinimalApi.Domain.Models;

namespace MinimalApi.Application.Interfaces
{
    public interface IToDoService
    {
        Task<List<ToDo>> GetItems();
        Task<ToDo?> GetItem(Guid id);
        Task<ToDo> Add(ToDoInputDto todo);
    }
}