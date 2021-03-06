﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KisiselBlog.Models
{
    [Table("Comments")]
    public class Comments
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }
        [StringLength(400), Required]
        public string Content { get; set; }
        [StringLength(32), Required]
        public string UserName { get; set; }
        [StringLength(32), Required]
        public string UserSurname { get; set; }
        [StringLength(64), Required]
        public string UserEmail { get; set; }
        public string UserPhoto { get; set; }
        public DateTime AddedDate { get; set; }

        public int ArticleID { get; set; }
        public virtual Articles article { get; set; }

        public virtual ICollection<SubComment> subComments { get; set; }

    }
}