using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EED.DAL.Models
{
    public   class Article

    {
        [Key]
        public string IDArticles { get; set; }
        [StringLength(20,MinimumLength =5,ErrorMessage ="it nhat 5 ky tu")]
        public string title { get; set; }
        public TypeAricles TypeAricles { get; set; }
        public string content { get; set; }
    }
}
