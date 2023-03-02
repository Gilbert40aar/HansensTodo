using System.ComponentModel.DataAnnotations;

namespace HansensTodo.Models
{
    public class Hashed
    {
        [Key] public int HashId { get; set; }
        public string ?UserEmailId { get; set; }
        public string ?HashedData { get; set; } 
        public string ?Dato { get; set; }
    }
}
