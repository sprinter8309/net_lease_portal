namespace SearchNavigator.Data.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string PassportNumber { get; set; }
        public bool? IsDelete { get; set; }
    }
}
