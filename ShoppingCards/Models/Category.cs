﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCard.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        public string Name { get; set; }

        [DisplayName("DisplayOrder")]
        public int DisplayOrder { get; set; }
        public DateTime createdate { get; set; }=DateTime.Now;
    }
}
