using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KetoBlog.Models
{
    public class Comment
    {
        [Key]
        public int PostingId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime LastModifiedDateTime { get; set; }

        public string Content { get; set; }
    }
}
