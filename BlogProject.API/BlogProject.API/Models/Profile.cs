using System.ComponentModel.DataAnnotations.Schema;

namespace BlogProject.API.Models
{
    [Table("Profile")]
    public class Profile : BaseEntity<int>
    {
        public string Name { get; set; }
        public string PhotoBase64 { get; set; }
        public DateTime BirthDate { get; set; }
        public string Info { get; set; }
        public string Email { get; set; }
    }
}
