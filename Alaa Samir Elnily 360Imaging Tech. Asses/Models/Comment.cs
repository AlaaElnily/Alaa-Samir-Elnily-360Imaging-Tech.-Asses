using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Alaa_Samir_Elnily_360Imaging_Tech._Asses.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
    }
}
