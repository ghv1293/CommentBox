using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommentBox.Models
{
    public class User
    {
        [Key]
        public string name { get; set; }

    }
}