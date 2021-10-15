using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KetoBlog.Models
{
    public class Like
    {
        [Key]
        public int LikeId { get; set; }

        public int PostingId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}
