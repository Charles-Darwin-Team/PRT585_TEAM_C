namespace FullStack.API.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid Email{ get; set; }

        public Guid Phone { get; set; }
        public Guid Salary { get; set; }
        public Guid Department { get; set; }

    }
}
