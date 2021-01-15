using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameBlog1488.Models
{
    public class Genre
    {
        [Key]
        [DisplayName("IdGenre")]
        public int IdGenre { set; get; }

        [DisplayName("Жанр")]
        [Required]
        public String NameGenre { set; get; }
    }
}