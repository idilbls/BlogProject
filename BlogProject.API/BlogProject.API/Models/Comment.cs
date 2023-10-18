using System.ComponentModel.DataAnnotations.Schema;

namespace BlogProject.API.Models
{
    [Table("Comment")]
    public class Comment : BaseEntity<int>
    {
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
