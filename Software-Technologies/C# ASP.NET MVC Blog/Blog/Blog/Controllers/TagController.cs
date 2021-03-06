﻿using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class TagController : Controller
    {
        // GET: Tag
        public ActionResult ListArticlesByTag(int? id)
        {
            if (id == null)
            {
                //validate
            }

            using (var db = new BlogDbContext())
            {
                var articles = db.Tags
                    .Include(t => t.Articles.Select(a => a.Author))
                    .Include(t => t.Articles.Select(a => a.Tags))
                    .FirstOrDefault(t => t.Id == id)
                    .Articles
                    .ToList();

                return View(articles);
            }
        }
    }
}