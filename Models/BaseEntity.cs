
namespace MEalAPI.Models
{
    public abstract class BaseEntity : ICreatedUpdated
    {
        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Updated { get; set; }
    }
}
