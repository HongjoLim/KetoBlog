using System;
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

        public string Content { get; set; }
    }
}
