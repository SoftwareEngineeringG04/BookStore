﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1773BookStore.Models.Data
{
    public class BookType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }

    }
}