using MinimalApi.Infrastructure.Implementations;
using System.Threading.Tasks;
using Xunit;

namespace MinimalApi.Test
{
    public class TodoRepositoryTest
    {
        private readonly ToDoRepository _sut;
        public TodoRepositoryTest()
        {
            _sut = new ToDoRepository();   
        }

        [Fact]
        public async Task GetItem__WithInvalidId__ShouldReturnsNull()
        {
            var result = await _sut.GetItem(System.Guid.NewGuid());
            Assert.Null(result);
              
        }

        [Fact]
        public async Task GetItems__Always__ShouldRetursNotnNull()
        {
            var result = await _sut.GetItems();
            Assert.NotNull(result);

        }

        [Fact]
        public async Task GetItems__AfterAdding__ShouldReturnsNotEmptyList()
        {
            await _sut.Add(new Domain.Models.ToDo("test"));
            var result = await _sut.GetItems();
            Assert.True(result.Count > 0);

        }
    }
}
