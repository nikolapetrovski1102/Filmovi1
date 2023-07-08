using System.ComponentModel.DataAnnotations;

namespace Filmovi.Models
{
    public class Kosna
    {
        [Key]
        public int Id { get; set; }
        public int BiletId { get; set; }
        public virtual Bileti Bileti { get; set; }
    }
}