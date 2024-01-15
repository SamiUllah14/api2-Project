using System.ComponentModel.DataAnnotations;

namespace api2.Model
{
    public class Comments
    {

        [Key]
        public int Id { get; set; } = 1;

        public string Description { get; set; }
    }
}
