using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameBlog1488.Models
{
    public class Post
    {
        [Key]
        [DisplayName("IdPost")]
        public int Id { set; get; }

        [ForeignKey("User")]
        [DisplayName("IdUser")]
        [Required]
        public int IdUser { set; get; }
        public User User { set; get; }

        [DisplayName("Заголовок")]
        [Required]
        public string Title { set; get; }

        [DisplayName("Текст")]
        [Required]
        public string TextComment { set; get; }

        [DisplayName("Дата создания")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime CurrentDate { set; get; }

        [ForeignKey("Genre")]
        [DisplayName("№ Жанра")]
        [Required]
        public int IdGenre { set; get; }
        public Genre Genre { set; get; }
    }
}