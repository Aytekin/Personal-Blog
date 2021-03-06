﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KisiselBlog.Models
{
    [Table("Users")]
    public class Users
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] //primary key and autoincrement 
        public int UserID { get; set; }
        [StringLength(15), Required]
        public string Name { get; set; }
        [StringLength(15), Required]
        public string Surname { get; set; }
        [StringLength(15), Required]
        public string NickName { get; set; }
        [StringLength(64), Required]
        public string Email { get; set; }
        [StringLength(45),Required]
        public string Password { get; set; }
        [StringLength(64)]
        public string PPPath {get; set;}
        [StringLength(64)]
        public string CommentPPPath {get; set;}
        [StringLength(256)]
        public string AboutUser { get; set; }
        public bool authorRequest { get; set; }
        public string UserTwitterAdress { get; set; }
        public string UserGithubAdress { get; set; }
        public string UserBitbucketAdress { get; set; }
        public string UserlinkedinAdress { get; set; }

        public Guid ControlCode { get; set; }
        public bool ControlCodeStatus { get; set; }

        public virtual ICollection<Dates> dates { get; set; }
        public int RoleID { get; set; }
        public virtual Roles roles { get; set; }

        public virtual ICollection<Articles> articles { get; set; }
    
      

    }
}