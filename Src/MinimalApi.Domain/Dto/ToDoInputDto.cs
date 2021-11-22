namespace MinimalApi.Domain.Dto
{
    public class ToDoInputDto
    {
        public string Name { get; set; }

        public ToDoInputDto(string name)
        {
            Name = name;
        }

        public string? Description { get; set; }
    }
}
