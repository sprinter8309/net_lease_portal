namespace SearchNavigator.Data.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public Brand? Brand { get; set; }
        public string? Model { get; set; }
        public int IssueYear { get; set; }
        public int EnginePower { get; set; }
        public string? Transmission { get; set; }
        public string? Color { get; set; }
        public string? Number { get; set; }
        public decimal LeaseRate { get; set; }
        public City? City { get; set; }
        public string? PreviewImage { get; set; }
        public bool? IsDelete { get; set; }
    }
}
