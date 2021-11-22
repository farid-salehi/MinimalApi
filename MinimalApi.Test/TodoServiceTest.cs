using MinimalApi.Application.Implementations;
using MinimalApi.Domain.Infrastructure.Interfaces;
using Moq;
using System;
using Xunit;

namespace MinimalApi.Test
{
    public class TodoServiceTest
    {
        [Fact]
        public void AddItem__WithNullInput__ShouldThrowException()
        {
            var mock = new Mock<IToDoRepository>();
            ToDoService sut = new ToDoService(mock.Object);
            _ = Assert.ThrowsAsync<ArgumentException>(() => sut.Add(null));
        }
    }
}