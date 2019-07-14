using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommentBox.Models
{
    public class Comment
    {
        [Key]
        public string Textbox { get; set; }
        public DateTime Timestamp { get; set; }

    }
}