﻿using System;
using System.ComponentModel.DataAnnotations;

namespace KetoBlog.Models
{
    public class Posting
    {
        [Key]
        public int PostingId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime LastModifiedDateTime { get; set; }

        [Required]
        [MinLength(100, ErrorMessage = "Blog Posting must have at least 100 chars in length")]
        public string Content { get; set; }
    }
}
