using System.ComponentModel.DataAnnotations;
namespace HansensTodo.Models
{
    public class Todo
    {
        [Key] public int Id { get; set; }
        public string ?UserEmailId { get; set; }
        public string ?TodoTitle { get; set; }
        public int StackSize { get; set; }
        public int Price { get; set; }
    }
}
