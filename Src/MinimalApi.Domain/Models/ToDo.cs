namespace MinimalApi.Domain.Models
{
    public class ToDo
    {
        public ToDo(string name)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;

        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}