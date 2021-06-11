using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Alaa_Samir_Elnily_360Imaging_Tech._Asses.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
