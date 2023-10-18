using System.ComponentModel.DataAnnotations.Schema;

namespace BlogProject.API.Models
{
    [Table("Article")]
    public class Article : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
