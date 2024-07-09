using System.ComponentModel.DataAnnotations;

namespace Protofolio_Website.Db_Set
{
    public class Message
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Key]
        public string Email { get; set; }

        [Required]
        [Length(3,25)]
        public string Subject { get; set; }

        [Required]
        [Length(10,50)]
        public string message { get; set; }
    }
}
