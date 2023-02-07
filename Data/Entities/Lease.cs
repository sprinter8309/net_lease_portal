using System.Drawing;
using System.Reflection;

namespace SearchNavigator.Data.Entities
{
    public class Lease
    {
        // * Потом этот класс разбивается на машины и пользователей при EF Core
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int CarId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
