using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EED.DAL.Models
{
   public class TypeAricles
    {
        [Key]
        public string ID { get; set; }
        public ICollection<Article> articles { get; set; }
        public string NameType { get; set; }
        public string Type { get; set; }
    }
}
