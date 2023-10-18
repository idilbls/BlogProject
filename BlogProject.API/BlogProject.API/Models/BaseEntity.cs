namespace BlogProject.API.Models
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
