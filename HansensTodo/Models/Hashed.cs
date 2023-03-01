using System.ComponentModel.DataAnnotations;

namespace HansensTodo.Models
{
    public class Hashed
    {
        [Key] public string HashId { get; set; }
        public string ?UserEmailId { get; set; }
        public string ?HashedData { get; set; } 
    }
}
