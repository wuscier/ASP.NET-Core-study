using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> e386c088684990027c234fafd34d9f652b4a037c
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
<<<<<<< HEAD
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
=======

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
>>>>>>> e386c088684990027c234fafd34d9f652b4a037c
        public decimal Price { get; set; }
    }
}
