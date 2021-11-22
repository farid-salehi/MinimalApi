using MinimalApi.Application.Interfaces;
using MinimalApi.Domain.Dto;
using MinimalApi.Domain.Infrastructure.Interfaces;
using MinimalApi.Domain.Models;


namespace MinimalApi.Application.Implementations
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;
        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }
        
        public async Task<List<ToDo>> GetItems()
        {
           return await _toDoRepository.GetItems();
        }

        public async Task<ToDo> Add(ToDoInputDto todo)
        {
            if (todo == null)
            {
                throw new ArgumentException("todo can not be null");
            }
            var item = new ToDo(todo.Name) { Description = todo.Description };
            await _toDoRepository.Add(item);
            return item;
        }
        
        public async Task<ToDo?> GetItem(Guid id)
        {
           return await _toDoRepository.GetItem(id);
        }
    }
}