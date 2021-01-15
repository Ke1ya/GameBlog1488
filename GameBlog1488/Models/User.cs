using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameBlog1488.Models
{
    public class User
    {
        [Key]
        [DisplayName("Id")]
        public int Id { set; get; }

        [DisplayName("Ник")]
        [Required]
        public string Nick { set; get; }

        [DisplayName("Email")]
        [Required]
        public string Email { set; get; }

        [DisplayName("Пароль")]
        [Required]
        public string Password { set; get; }
    }
}