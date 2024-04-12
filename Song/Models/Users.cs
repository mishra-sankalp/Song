using System.ComponentModel.DataAnnotations;

namespace Song.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }       
        public string? gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime dob { get; set; }
    }
}
