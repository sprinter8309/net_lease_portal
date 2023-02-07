namespace SearchNavigator.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PreviewImage { get; set; }
        public List<Car> Cars { get; set; }
        public bool? IsDelete { get; set; }
    }
}
