using SearchNavigator.Models.DTO;

namespace SearchNavigator.Models
{
    public class AdminIndexModel
    {
        public IEnumerable<LeaseShortInfoDTO>? leases { get; set; }
    }
}
