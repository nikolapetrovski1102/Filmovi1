using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Filmovi.Models
{
    public class Bileti
    {
        [Key]
        public int Id { get; set; }
        public string ImeFilm { get; set; }
        public string Avtor { get; set; }
        public string Zanr { get; set; }
        public int BrBileti { get; set; }
        [BindProperty, DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        /*[NotMapped]
        public List<string> GenreList { get; set; }*/

    }
}
