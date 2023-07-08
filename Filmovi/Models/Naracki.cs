using System.ComponentModel.DataAnnotations;

namespace Filmovi.Models
{
    public class Naracki
    {
        [Key]
        public int Id { get; set; }
        public int BiletiId { get; set; }
        public virtual Bileti OdKosna { get; set; }
    }
}
