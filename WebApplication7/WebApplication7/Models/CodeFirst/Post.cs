﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models.CodeFirst;

namespace WebApplication7.Models
{
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [AllowHtml]
        public string Body { get; set; }
        public string MediaURL { get; set; }
        public string Slug { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}