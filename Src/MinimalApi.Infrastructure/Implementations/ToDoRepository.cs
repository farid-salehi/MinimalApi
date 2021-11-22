using MinimalApi.Domain.Infrastructure.Interfaces;
using MinimalApi.Domain.Models;


namespace MinimalApi.Infrastructure.Implementations
{
    public class ToDoRepository : IToDoRepository
    {
        private  static SynchronizedCollection<ToDo> todoCollection 
            = new SynchronizedCollection<ToDo>(); 

        public async Task Add(ToDo todo)
        {
            todoCollection.Add(todo);
        }

        public async Task<List<ToDo>> GetItems()
        {
            return todoCollection.ToList();
        }

        public async Task<ToDo?> GetItem(Guid id)
        {
            return todoCollection.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}